using StealthRecord;
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

namespace StealthRecord {
    public partial class Main_From : Form {
        //KeyboardHook k_hook;
        public Main_From() {
            InitializeComponent();
            //k_hook = new KeyboardHook();
            //k_hook.KeyDownEvent += k_hook_KeyDownEvent;
            //k_hook.Start();
        }

        //void k_hook_KeyDownEvent(object sender, KeyEventArgs e) {
        //    Output("key:" + e.Alt + "\r\n");
        //    Output("key:" + e.KeyData + "\r\n");
        //}

        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);

        private List<Point> plist = new List<Point>();

        private void Main_Form_Load(object sender, EventArgs e) { }

        private void btn_start_Click(object sender, EventArgs e) {
            if (Tim_Watch.Enabled) {
                btn_exec.Enabled = true;
                txt.Clear();
                btn_start.Text = "Start";
                Tim_Watch.Stop();
            } else {
                btn_exec.Enabled = false;
                txt.Clear();
                plist.Clear();
                btn_start.Text = "Stop";
                Tim_Watch.Start();
                Tim_Exec.Stop();
            }
        }

        private void Tim_Watch_Tick(object sender, EventArgs e) {
            var CurrentPoint = Control.MousePosition;
            if (CurrentPoint.Equals(LastMousePosition)) {
                return;
            }
            plist.Add(CurrentPoint);
            Text = plist.Count + "";
            Output(CurrentPoint.ToString());
            LastMousePosition = CurrentPoint;
        }

        public void Output(string param) {
            txt.AppendText(param);
        }

        int count = 1;

        private void Tim_Exec_Tick(object sender, EventArgs e) {
            count++;
            try {
                if (count >= plist.Count) {
                    Tim_Exec.Stop();
                    Text = "OK";
                    count = 1;
                    plist.Clear();
                    return;
                }
                Output("{" + plist[count].X + "," + plist[count].Y + "}");
                SetCursorPos(plist[count].X, plist[count].Y);
            } catch (Exception ex) {
                Output("exception:" + ex);
                Tim_Exec.Stop();
            }
        }

        public Point LastMousePosition { get; set; }

        private void btn_exec_Click(object sender, EventArgs e) {
            Tim_Exec.Start();
        }
    }
}
