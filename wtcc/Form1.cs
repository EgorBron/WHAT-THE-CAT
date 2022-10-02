using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TinyJson;

namespace wtcc {
    public partial class Form1 : Form {
        public string apiLink;
        public int respType = 0;
        public string jsonPath = "";
        public string Req() {
            var requestT = System.Net.WebRequest.Create(apiLink);
            var responseT = requestT.GetResponse();
            Stream responseStreamT = responseT.GetResponseStream();
            using (var streamReader = new StreamReader(responseStreamT)) {
                return streamReader.ReadToEnd();
            }
        }
        public Form1() {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            InitializeComponent();
            var rnd = new Random();
            Location = new Point(rnd.Next(0, Screen.PrimaryScreen.Bounds.X), rnd.Next(0, Screen.PrimaryScreen.Bounds.Y));
        }

        private void Form1_Activated(object sender, EventArgs e) {
            if (respType == 1) {
                apiLink = Req();
            } else if (respType == 2 || respType == 3) {
                var d = Req().FromJson<Dictionary<string, object>>();
                if (d == null) return;
                foreach (var str in jsonPath.Split(';')) {
                    var dd = d[str];
                    if (dd is Dictionary<string, object> ddd) {
                        d = ddd;
                    } else if (dd is string[] arr) {
                        apiLink = arr[new Random().Next(0, arr.Length)];
                    } else apiLink = dd.ToString();
                }
            }
            var request = System.Net.WebRequest.Create(apiLink);
            var response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            var bmp = new Bitmap(responseStream);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = Size = bmp.Size;
            pictureBox1.Image = bmp;
        }
    }
}
