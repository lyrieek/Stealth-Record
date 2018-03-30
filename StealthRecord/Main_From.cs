using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 隐形记录
{
    public partial class Main_From : Form
    {
        public Main_From()
        {
            InitializeComponent();
        }

        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);

        private List<Point> plist = new List<Point>();

        private void Main_Form_Load(object sender, EventArgs e) { }

        private void Main_Form_KeyDown(object sender, KeyEventArgs e)
        {
            txt.AppendText(e.KeyCode.ToString());
            if (e.Alt)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        break;
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            txt.Clear();
            plist.Clear();
            Text = "Start";
            Tim_Watch.Start();
        }

        private void Tim_Watch_Tick(object sender, EventArgs e)
        {
            plist.Add(Control.MousePosition);
            Text = plist.Count + "";
            txt.AppendText(plist.ToArray()[plist.Count - 1].ToString());
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Tim_Watch.Stop();
            Tim_Exec.Start();
        }

        int count = 1;

        private void Tim_Exec_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == plist.Count)
            {
                Tim_Exec.Stop();
                Text = "OK";
                return;
            } 
            try
            {
                SetCursorPos(plist.ToArray()[count].X, plist.ToArray()[count].Y);
            }
            catch { }
        }
    }
}
