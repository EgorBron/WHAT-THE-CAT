using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace WHAT_THE_CAT {
    public struct Data {
        public string apiLink;
        public int respType;
        public int limit;
        public string jsonPath;
    }
    public partial class WtcForm : Form {
        public WtcForm() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            jsonImgRadioButton.Checked = true;
            jsonPathInput.Text = "file";
        }

        private void buildButton_Click(object sender, EventArgs e) {
            var d = new Data();
            d.apiLink = targetApiTextBox.Text;
            d.respType = rawImgRadioButton.Checked ? 0 :
                (
                    linkToImgRadioButton.Checked ? 1 : 
                        (
                            jsonImgRadioButton.Checked ? 2 : 
                                (
                                jsonArrayImgBeforesRadioButton.Checked ? 3 :
                                    (jsonArrayImgAftersRadioButton.Checked ? 4 : 5)
                                )
                        )
                );
            if (limitNumericUpDown.Value < 0) limitNumericUpDown.Value = -limitNumericUpDown.Value;
            d.limit = (int)limitNumericUpDown.Value;
            d.jsonPath = d.respType == 2 || d.respType == 3 || d.respType == 4 ? jsonPathInput.Text : "";
            Console.WriteLine($"api: {d.apiLink}; resp type: {d.respType}; limit: {d.limit}; json: {d.jsonPath}");

            using (var module = AssemblyDefinition.ReadAssembly(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace(Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location), "wtcc.exe"),
                new ReaderParameters { ReadWrite = true })) {
                var t = module.MainModule.Types.Single(ct => ct.Name == "Program");
                var ctor = t.Methods.Single(m => m.IsConstructor);
                Console.WriteLine(ctor);
                var il = ctor.Body.GetILProcessor();

                var inst = il.Body.Instructions.First();
                while (inst != null) {
                    Console.WriteLine($"Checking {inst}");/* || {((FieldReference)inst.Operand).Name}");*/
                    if (inst.OpCode == OpCodes.Stsfld) {
                        Console.WriteLine("Statisfies");
                        if (((FieldReference)inst.Operand).Name == "apiLink") {
                            il.Replace(inst.Previous, il.Create(OpCodes.Ldstr, d.apiLink));
                            Console.WriteLine("Found apiLink");
                        } else if (((FieldReference)inst.Operand).Name == "respType") {
                            il.Replace(inst.Previous, il.Create(OpCodes.Ldc_I4, d.respType));
                            Console.WriteLine("Found respType");
                        } else if (((FieldReference)inst.Operand).Name == "jsonPath") {
                            il.Replace(inst.Previous, il.Create(OpCodes.Ldstr, d.jsonPath));
                            Console.WriteLine("Found jsonPath");
                        } else if (((FieldReference)inst.Operand).Name == "limit") {
                            il.Replace(inst.Previous, il.Create(OpCodes.Ldc_I4, d.limit));
                            Console.WriteLine("Found jsonPath");
                        }
                    }
                    inst = inst.Next;
                }
                //TypeDefinition[] types = module.Types.ToArray();
                //foreach (var type in types) {
                //    if (type.Name == "Program") {
                //        type.Fields.First(f => f.Name == "apiLink" && f.IsStatic).Constant = d.apiLink;
                //        type.Fields.First(f => f.Name == "respType" && f.IsStatic).Constant = d.respType;
                //        type.Fields.First(f => f.Name == "jsonPath" && f.IsStatic).Constant = d.jsonPath;
                //    }
                //}

                var wrd = new SaveFileDialog();
                wrd.Filter = ".NET Executable Assembly (*.exe)|*.exe";
                wrd.DefaultExt = "exe";
                wrd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (wrd.ShowDialog() == DialogResult.OK) {
                    var stream = wrd.OpenFile();
                    module.Write(stream);
                    stream.Close();
                    wrd.Dispose();
                    stream.Dispose();
                }
            }
        }

        private void jsonPathInput_TextChanged(object sender, EventArgs e) {

        }

        private void jsonPathLabel_Click(object sender, EventArgs e) {

        }
    }
}
