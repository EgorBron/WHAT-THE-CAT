namespace WHAT_THE_CAT {
    partial class WtcForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WtcForm));
            this.targetApiTextBox = new System.Windows.Forms.TextBox();
            this.apiEndpointLabel = new System.Windows.Forms.Label();
            this.contentTypesLabel = new System.Windows.Forms.Label();
            this.rawImgRadioButton = new System.Windows.Forms.RadioButton();
            this.linkToImgRadioButton = new System.Windows.Forms.RadioButton();
            this.jsonImgRadioButton = new System.Windows.Forms.RadioButton();
            this.jsonArrayImgRadioButton = new System.Windows.Forms.RadioButton();
            this.jsonPathInput = new System.Windows.Forms.TextBox();
            this.jsonPathLabel = new System.Windows.Forms.Label();
            this.buildButton = new System.Windows.Forms.Button();
            this.limitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.limitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // targetApiTextBox
            // 
            this.targetApiTextBox.Location = new System.Drawing.Point(12, 28);
            this.targetApiTextBox.Name = "targetApiTextBox";
            this.targetApiTextBox.Size = new System.Drawing.Size(215, 20);
            this.targetApiTextBox.TabIndex = 0;
            this.targetApiTextBox.Tag = "";
            this.targetApiTextBox.Text = "https://aws.random.cat/meow";
            // 
            // apiEndpointLabel
            // 
            this.apiEndpointLabel.AutoSize = true;
            this.apiEndpointLabel.Location = new System.Drawing.Point(12, 9);
            this.apiEndpointLabel.Name = "apiEndpointLabel";
            this.apiEndpointLabel.Size = new System.Drawing.Size(103, 13);
            this.apiEndpointLabel.TabIndex = 1;
            this.apiEndpointLabel.Text = "Link to API endpoint";
            // 
            // contentTypesLabel
            // 
            this.contentTypesLabel.AutoSize = true;
            this.contentTypesLabel.Location = new System.Drawing.Point(12, 51);
            this.contentTypesLabel.Name = "contentTypesLabel";
            this.contentTypesLabel.Size = new System.Drawing.Size(70, 13);
            this.contentTypesLabel.TabIndex = 2;
            this.contentTypesLabel.Text = "Content type:";
            // 
            // rawImgRadioButton
            // 
            this.rawImgRadioButton.AutoSize = true;
            this.rawImgRadioButton.Location = new System.Drawing.Point(15, 67);
            this.rawImgRadioButton.Name = "rawImgRadioButton";
            this.rawImgRadioButton.Size = new System.Drawing.Size(78, 17);
            this.rawImgRadioButton.TabIndex = 3;
            this.rawImgRadioButton.TabStop = true;
            this.rawImgRadioButton.Text = "Raw image";
            this.rawImgRadioButton.UseVisualStyleBackColor = true;
            // 
            // linkToImgRadioButton
            // 
            this.linkToImgRadioButton.AutoSize = true;
            this.linkToImgRadioButton.Location = new System.Drawing.Point(15, 90);
            this.linkToImgRadioButton.Name = "linkToImgRadioButton";
            this.linkToImgRadioButton.Size = new System.Drawing.Size(139, 17);
            this.linkToImgRadioButton.TabIndex = 3;
            this.linkToImgRadioButton.TabStop = true;
            this.linkToImgRadioButton.Text = "Link to image (plain text)";
            this.linkToImgRadioButton.UseVisualStyleBackColor = true;
            // 
            // jsonImgRadioButton
            // 
            this.jsonImgRadioButton.AutoSize = true;
            this.jsonImgRadioButton.Location = new System.Drawing.Point(15, 113);
            this.jsonImgRadioButton.Name = "jsonImgRadioButton";
            this.jsonImgRadioButton.Size = new System.Drawing.Size(79, 17);
            this.jsonImgRadioButton.TabIndex = 3;
            this.jsonImgRadioButton.TabStop = true;
            this.jsonImgRadioButton.Text = "JSON entry";
            this.jsonImgRadioButton.UseVisualStyleBackColor = true;
            // 
            // jsonArrayImgRadioButton
            // 
            this.jsonArrayImgRadioButton.AutoSize = true;
            this.jsonArrayImgRadioButton.Location = new System.Drawing.Point(15, 136);
            this.jsonArrayImgRadioButton.Name = "jsonArrayImgRadioButton";
            this.jsonArrayImgRadioButton.Size = new System.Drawing.Size(111, 17);
            this.jsonArrayImgRadioButton.TabIndex = 3;
            this.jsonArrayImgRadioButton.TabStop = true;
            this.jsonArrayImgRadioButton.Text = "JSON entry (array)";
            this.jsonArrayImgRadioButton.UseVisualStyleBackColor = true;
            // 
            // jsonPathInput
            // 
            this.jsonPathInput.Location = new System.Drawing.Point(11, 217);
            this.jsonPathInput.Name = "jsonPathInput";
            this.jsonPathInput.Size = new System.Drawing.Size(215, 20);
            this.jsonPathInput.TabIndex = 4;
            this.jsonPathInput.TextChanged += new System.EventHandler(this.jsonPathInput_TextChanged);
            // 
            // jsonPathLabel
            // 
            this.jsonPathLabel.AutoSize = true;
            this.jsonPathLabel.Location = new System.Drawing.Point(11, 201);
            this.jsonPathLabel.Name = "jsonPathLabel";
            this.jsonPathLabel.Size = new System.Drawing.Size(203, 13);
            this.jsonPathLabel.TabIndex = 5;
            this.jsonPathLabel.Text = "JSON path (separate keys by semicolons)";
            this.jsonPathLabel.Click += new System.EventHandler(this.jsonPathLabel_Click);
            // 
            // buildButton
            // 
            this.buildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildButton.Location = new System.Drawing.Point(8, 243);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(215, 47);
            this.buildButton.TabIndex = 6;
            this.buildButton.Text = "BUILD";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // limitNumericUpDown
            // 
            this.limitNumericUpDown.Location = new System.Drawing.Point(12, 178);
            this.limitNumericUpDown.Name = "limitNumericUpDown";
            this.limitNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.limitNumericUpDown.TabIndex = 7;
            // 
            // limitLabel
            // 
            this.limitLabel.AutoSize = true;
            this.limitLabel.Location = new System.Drawing.Point(15, 160);
            this.limitLabel.Name = "limitLabel";
            this.limitLabel.Size = new System.Drawing.Size(175, 13);
            this.limitLabel.TabIndex = 8;
            this.limitLabel.Text = "Limit (0 is infinite, negatives inverts):";
            // 
            // WtcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 302);
            this.Controls.Add(this.limitLabel);
            this.Controls.Add(this.limitNumericUpDown);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.jsonPathLabel);
            this.Controls.Add(this.jsonPathInput);
            this.Controls.Add(this.jsonArrayImgRadioButton);
            this.Controls.Add(this.jsonImgRadioButton);
            this.Controls.Add(this.linkToImgRadioButton);
            this.Controls.Add(this.rawImgRadioButton);
            this.Controls.Add(this.contentTypesLabel);
            this.Controls.Add(this.apiEndpointLabel);
            this.Controls.Add(this.targetApiTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WtcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WHAT THE CAT?!";
            ((System.ComponentModel.ISupportInitialize)(this.limitNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox targetApiTextBox;
        private System.Windows.Forms.Label apiEndpointLabel;
        private System.Windows.Forms.Label contentTypesLabel;
        private System.Windows.Forms.RadioButton rawImgRadioButton;
        private System.Windows.Forms.RadioButton linkToImgRadioButton;
        private System.Windows.Forms.RadioButton jsonImgRadioButton;
        private System.Windows.Forms.RadioButton jsonArrayImgRadioButton;
        private System.Windows.Forms.TextBox jsonPathInput;
        private System.Windows.Forms.Label jsonPathLabel;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.NumericUpDown limitNumericUpDown;
        private System.Windows.Forms.Label limitLabel;
    }
}

