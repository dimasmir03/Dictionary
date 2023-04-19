namespace Dictionary
{
    partial class Dictionary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iInput = new System.Windows.Forms.TextBox();
            this.iOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.langs1 = new System.Windows.Forms.ComboBox();
            this.langs2 = new System.Windows.Forms.ComboBox();
            this.bTranslate = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // iInput
            // 
            this.iInput.Location = new System.Drawing.Point(11, 36);
            this.iInput.Margin = new System.Windows.Forms.Padding(2);
            this.iInput.Name = "iInput";
            this.iInput.Size = new System.Drawing.Size(92, 20);
            this.iInput.TabIndex = 0;
            // 
            // iOutput
            // 
            this.iOutput.Location = new System.Drawing.Point(240, 37);
            this.iOutput.Margin = new System.Windows.Forms.Padding(2);
            this.iOutput.Name = "iOutput";
            this.iOutput.ReadOnly = true;
            this.iOutput.Size = new System.Drawing.Size(92, 20);
            this.iOutput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(136, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "↔";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // langs1
            // 
            this.langs1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langs1.FormattingEnabled = true;
            this.langs1.Location = new System.Drawing.Point(11, 11);
            this.langs1.Margin = new System.Windows.Forms.Padding(2);
            this.langs1.Name = "langs1";
            this.langs1.Size = new System.Drawing.Size(92, 21);
            this.langs1.TabIndex = 7;
            // 
            // langs2
            // 
            this.langs2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langs2.FormattingEnabled = true;
            this.langs2.Location = new System.Drawing.Point(240, 11);
            this.langs2.Margin = new System.Windows.Forms.Padding(2);
            this.langs2.Name = "langs2";
            this.langs2.Size = new System.Drawing.Size(92, 21);
            this.langs2.TabIndex = 9;
            // 
            // bTranslate
            // 
            this.bTranslate.Location = new System.Drawing.Point(136, 37);
            this.bTranslate.Margin = new System.Windows.Forms.Padding(2);
            this.bTranslate.Name = "bTranslate";
            this.bTranslate.Size = new System.Drawing.Size(74, 19);
            this.bTranslate.TabIndex = 10;
            this.bTranslate.Text = "Перевести";
            this.bTranslate.UseVisualStyleBackColor = true;
            this.bTranslate.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Добавить перевод";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bTranslate);
            this.Controls.Add(this.langs2);
            this.Controls.Add(this.langs1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iOutput);
            this.Controls.Add(this.iInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dictionary";
            this.Text = "AddWords";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dictionary_FormClosing);
            this.Load += new System.EventHandler(this.Dictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iInput;
        private System.Windows.Forms.TextBox iOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox langs1;
        private System.Windows.Forms.ComboBox langs2;
        private System.Windows.Forms.Button bTranslate;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}