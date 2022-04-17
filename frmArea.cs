using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenTextRecorder
{
    public partial class frmArea : Form
    {

        public FrameControl Selection { get; set; }
        public frmMain? ParentRef { get; set; }
        public frmArea()
        {
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            InitializeComponent();
            Selection = new FrameControl();
            Selection.Move += Selection_Move;
            Selection.SizeChanged += Selection_SizeChanged;
            Controls.Add(Selection);
        }
        
        private void UpdateArea()
        {
            if (ParentRef != null)
            {
                ParentRef.ModifyArea();
                if (ParentRef.WindowState != FormWindowState.Minimized)
                    ParentRef.Show();
            }
        }
        private void Selection_SizeChanged(object? sender, EventArgs e)
        {
            UpdateArea();
        }

        private void Selection_Move(object? sender, EventArgs e)
        {
            UpdateArea();
        }

        private void frmArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ParentForm != null)
                ParentForm.Close();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
