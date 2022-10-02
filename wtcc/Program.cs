using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wtcc {
    public class Form2 : Form {
        public Form2() {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(1, 1);
            WindowState = FormWindowState.Minimized;
            for (int imagesShowed = 0; Program.limit == 0 || imagesShowed != Program.limit; imagesShowed++) {
                Thread.Sleep(1);
                var f = new Form1() { apiLink = Program.apiLink, respType = Program.respType, jsonPath = Program.jsonPath };
                f.Show();
            }
        }
    }
    public static class Program {
        public static string apiLink = "https://aws.random.cat/meow";
        public static int respType = 2;
        public static int limit = 0;
        public static string jsonPath = "file";
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
