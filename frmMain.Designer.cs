namespace ScreenTextRecorder
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelH = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.labelW = new System.Windows.Forms.Label();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.listBoxArea = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxSaveToFile = new System.Windows.Forms.CheckBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.labelInterval = new System.Windows.Forms.Label();
            this.comboBoxIntervalUnits = new System.Windows.Forms.ComboBox();
            this.groupBoxPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 169);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 31);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(96, 169);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 31);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(61, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(208, 23);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(45, 20);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(76, 23);
            this.textBoxX.TabIndex = 7;
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(38, 68);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 15);
            this.labelX.TabIndex = 8;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(154, 68);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 15);
            this.labelY.TabIndex = 10;
            this.labelY.Text = "Y:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(177, 64);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(76, 23);
            this.textBoxY.TabIndex = 9;
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(154, 126);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(19, 15);
            this.labelH.TabIndex = 15;
            this.labelH.Text = "H:";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(177, 122);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.ReadOnly = true;
            this.textBoxH.Size = new System.Drawing.Size(76, 23);
            this.textBoxH.TabIndex = 14;
            this.textBoxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Location = new System.Drawing.Point(38, 126);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(21, 15);
            this.labelW.TabIndex = 13;
            this.labelW.Text = "W:";
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(61, 122);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.ReadOnly = true;
            this.textBoxW.Size = new System.Drawing.Size(76, 23);
            this.textBoxW.TabIndex = 12;
            this.textBoxW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.textBoxX);
            this.groupBoxPosition.Location = new System.Drawing.Point(16, 44);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(253, 53);
            this.groupBoxPosition.TabIndex = 16;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Position";
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Location = new System.Drawing.Point(16, 103);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(253, 53);
            this.groupBoxSize.TabIndex = 17;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // listBoxArea
            // 
            this.listBoxArea.FormattingEnabled = true;
            this.listBoxArea.ItemHeight = 15;
            this.listBoxArea.Location = new System.Drawing.Point(289, 20);
            this.listBoxArea.Name = "listBoxArea";
            this.listBoxArea.Size = new System.Drawing.Size(254, 424);
            this.listBoxArea.TabIndex = 18;
            this.listBoxArea.SelectedIndexChanged += new System.EventHandler(this.listBoxArea_SelectedIndexChanged);
            this.listBoxArea.Enter += new System.EventHandler(this.listBoxArea_Enter);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(16, 441);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(61, 33);
            this.buttonStart.TabIndex = 19;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(83, 441);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(61, 33);
            this.buttonStop.TabIndex = 20;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 206);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 69);
            this.textBox1.TabIndex = 22;
            // 
            // checkBoxSaveToFile
            // 
            this.checkBoxSaveToFile.AutoSize = true;
            this.checkBoxSaveToFile.Location = new System.Drawing.Point(158, 449);
            this.checkBoxSaveToFile.Name = "checkBoxSaveToFile";
            this.checkBoxSaveToFile.Size = new System.Drawing.Size(86, 19);
            this.checkBoxSaveToFile.TabIndex = 23;
            this.checkBoxSaveToFile.Text = "Save To File";
            this.checkBoxSaveToFile.UseVisualStyleBackColor = true;
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(96, 407);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(98, 23);
            this.numericUpDownInterval.TabIndex = 24;
            this.numericUpDownInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownInterval.ThousandsSeparator = true;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(17, 409);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(78, 15);
            this.labelInterval.TabIndex = 25;
            this.labelInterval.Text = "Record every:";
            // 
            // comboBoxIntervalUnits
            // 
            this.comboBoxIntervalUnits.FormattingEnabled = true;
            this.comboBoxIntervalUnits.Items.AddRange(new object[] {
            "ms",
            "s",
            "m"});
            this.comboBoxIntervalUnits.Location = new System.Drawing.Point(200, 407);
            this.comboBoxIntervalUnits.Name = "comboBoxIntervalUnits";
            this.comboBoxIntervalUnits.Size = new System.Drawing.Size(53, 23);
            this.comboBoxIntervalUnits.TabIndex = 26;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 489);
            this.Controls.Add(this.comboBoxIntervalUnits);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.checkBoxSaveToFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxArea);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxPosition);
            this.Controls.Add(this.groupBoxSize);
            this.Name = "frmMain";
            this.Text = "Screen Text Recorder";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.groupBoxPosition.ResumeLayout(false);
            this.groupBoxPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Button buttonAdd;
        private Button buttonDelete;
        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxX;
        private Label labelX;
        private Label labelY;
        private TextBox textBoxY;
        private Label labelH;
        private TextBox textBoxH;
        private Label labelW;
        private TextBox textBoxW;
        private GroupBox groupBoxPosition;
        private GroupBox groupBoxSize;
        private ListBox listBoxArea;
        private Button buttonStart;
        private Button buttonStop;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private CheckBox checkBoxSaveToFile;
        private SaveFileDialog saveFileDialog;
        private NumericUpDown numericUpDownInterval;
        private Label labelInterval;
        private ComboBox comboBoxIntervalUnits;
    }
}