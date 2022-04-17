using Tesseract;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ScreenTextRecorder
{
    public partial class frmMain : Form
    {
        bool _started = false;
        bool _processing = false;
        bool _savingToFile = false;
        string _filePath = string.Empty;

        System.Threading.Timer? _timer = null;
        public BindingList<Area> _areaList;
        public Area? SelectedArea { get; set; }
        public FrameControl Selection { get; set; }
        public FrameControl? TestFrame { get; set; }
        public frmArea FormArea { get; set; }
        public frmMain()
        {
            InitializeComponent();
            this.TopMost = true;
            _areaList = new BindingList<Area>(RestoreAreaListFromFile(Environment.CurrentDirectory + @"/Areas.xml"));
            listBoxArea.DataSource = _areaList;
            EnableControls();
            FormArea = new frmArea();
            FormArea.ParentRef = this;
            Selection = FormArea.Selection;            
        }

        private string ExtractTextFromImage(Image image)
        {
            if (image == null)
                return String.Empty;
            string result = String.Empty;
            using (TesseractEngine engine = new TesseractEngine(Environment.CurrentDirectory + @"/TesseractTrainedData", "eng", EngineMode.Default))
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                result = engine.Process(Pix.LoadFromMemory(ms.ToArray())).GetText();
            }
            return result;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
                textBoxName.Text = "New Area";

            var size = new Size(100, 50);
            var location = new Point(Screen.GetBounds(this).Width / 2 - 50, Screen.GetBounds(this).Height / 2 - 25);
            Area area = new Area(textBoxName.Text, size, location);
            SelectedArea = area;
            if (Selection != null && SelectedArea != null)
            {
                Selection.Size = size;
                Selection.Location = location;
            }
            _areaList.Add(area);
            listBoxArea.SelectedItem = area;
            FormArea.Show();
        }
        public void ModifyArea()
        {
            if (SelectedArea != null)
            {
                SelectedArea.Name = textBoxName.Text;

                if (Selection != null)
                {
                    SelectedArea.Size = Selection.Size;
                    SelectedArea.Position = Selection.Location;
                    UpdateAreaData(SelectedArea);
                }
                else
                {
                    SelectedArea.Size = new Size(Int32.Parse(textBoxW.Text), Int32.Parse(textBoxH.Text));
                    SelectedArea.Position = new Point(Int32.Parse(textBoxX.Text), Int32.Parse(textBoxY.Text));
                }
            }
            _areaList.ResetBindings();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxArea.SelectedIndex;
            if (SelectedArea != null)
            {
                _areaList.Remove(SelectedArea);
            }
            if (_areaList.Count > 0 && selectedIndex >= 0)
                listBoxArea.SelectedIndex = selectedIndex - 1;
            if (_areaList.Count == 0 && FormArea != null)
                FormArea.Hide();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_areaList.Count == 0) 
                return;

            int interval =  Convert.ToInt32(numericUpDownInterval.Value);
            switch (comboBoxIntervalUnits.Text)
            {
                case "s":
                    interval *= 1000;
                    break;
                case "m":
                    interval *= 60000;
                    break;
                default:
                    break;
            }

            if (interval < 500)
            {
                interval = 500;
                numericUpDownInterval.Value = interval;
                comboBoxIntervalUnits.Text = comboBoxIntervalUnits.Items[0].ToString();
            }

            FormArea?.Hide();
            if (checkBoxSaveToFile.Checked)
            {
                _savingToFile = true;
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.Filter = "csv files (*.csv)|*.csv";
                saveFileDialog.Title = "Save data to...";
                saveFileDialog.ShowDialog();
                _filePath = saveFileDialog.FileName;
                if (!string.IsNullOrEmpty(_filePath))
                {
                    var line = "sep=\t\r\n";
                    line += string.Join('\t', _areaList.Select(area => area.Name).ToArray()) + "\r\n";
                    File.AppendAllText(_filePath, line);
                }
                else
                {
                    _savingToFile = false;
                }
            }
            _timer = new System.Threading.Timer(new TimerCallback(TimerTick), null, 0, interval);
            _started = true;
            EnableControls();


        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (_timer != null)
                _timer.Dispose();
            _started = false;
            EnableControls();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void listBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxArea.SelectedItem != null)
            {
                SelectedArea = _areaList[listBoxArea.SelectedIndex];

                if (!_started) 
                    FormArea?.Show();

                UpdateAreaData(SelectedArea);
                if (Selection != null)
                {
                    var size = SelectedArea.Size;
                    var location = SelectedArea.Position;
                    Selection.Location = location;
                    Selection.Size = size;
                }
            }
            else
            {
                ClearAreaData();
                FormArea?.Hide();
            }
        }
        private void UpdateAreaData(Area area)
        {
            if (area != null)
            {
                textBoxName.Text = area.Name;
                textBoxW.Text = area.Size.Width.ToString();
                textBoxH.Text = area.Size.Height.ToString();
                textBoxX.Text = area.Position.X.ToString();
                textBoxY.Text = area.Position.Y.ToString();
                pictureBoxLastAreaImage.Image = area.Image;
                textBoxLastReadData.Text = area.LastReadData;
            }
        }
        private void ClearAreaData()
        {
            SelectedArea = null;
            textBoxName.Text = String.Empty;
            textBoxW.Text = String.Empty;
            textBoxH.Text = String.Empty;
            textBoxX.Text = String.Empty;
            textBoxY.Text = String.Empty;
        }
        private void ReadAreaData(BindingList<Area> list)
        {
            foreach (var area in list)
            {
                Bitmap bm = new Bitmap(area.Size.Width, area.Size.Height);
                Graphics g = Graphics.FromImage(bm);
                g.CopyFromScreen(area.Position.X, area.Position.Y, 0, 0, bm.Size);
                area.Image = bm;
                area.LastReadData = ExtractTextFromImage(bm).Trim();
            }
        }
        void TimerTick (object? state)
        {
            _processing = true;
            ReadAreaData(_areaList);
            

            if (_savingToFile && !string.IsNullOrEmpty(_filePath))
            {
                var line = string.Join('\t', _areaList.Select(area => area.LastReadData).ToArray()) + "\r\n";
                File.AppendAllText(_filePath,line);
            }
            _processing = false;

            Invoke((MethodInvoker)delegate {
                if (SelectedArea != null)
                    UpdateAreaData(SelectedArea);
                _areaList.ResetBindings();
                EnableControls();
            });
        }
        private void listBoxArea_Enter(object sender, EventArgs e)
        {
            if (SelectedArea != null && FormArea != null && !_started)
                FormArea.Show();
        }
        private void EnableControls()
        {
            buttonStart.Enabled = !_started && !_processing;
            buttonStop.Enabled = _started && !_processing;
            buttonAdd.Enabled = !_started && !_processing;
            buttonDelete.Enabled = !_started && !_processing;
            comboBoxIntervalUnits.Enabled = !_started && !_processing;
            numericUpDownInterval.Enabled = !_started && !_processing;
            textBoxName.Enabled = !_started && !_processing;
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ModifyArea();
            }
        }
        private void SaveAreaListToFile(List<Area> areas, string path)
        {
            Area[] arr = areas.ToArray();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Area[]));
            using (TextWriter writer = new StreamWriter(path))
            {
                xmlSerializer.Serialize(writer, arr);
            }

        }
        private List<Area> RestoreAreaListFromFile(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Area[]));

            Area[]? arr;
            if (File.Exists(path))
            {
                using (Stream reader = new FileStream(path, FileMode.Open))
                {
                    arr = (Area[]?)xmlSerializer.Deserialize(reader);
                }

                if (arr != null)
                {
                    return arr.ToList();
                }
            }
            return new List<Area>();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAreaListToFile(_areaList.ToList(), Environment.CurrentDirectory + @"/Areas.xml");
        }
    }
}