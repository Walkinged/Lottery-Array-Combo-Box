namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fillBTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 303);
            this.listBox1.TabIndex = 0;
            // 
            // fillBTN
            // 
            this.fillBTN.Location = new System.Drawing.Point(51, 357);
            this.fillBTN.Name = "fillBTN";
            this.fillBTN.Size = new System.Drawing.Size(151, 23);
            this.fillBTN.TabIndex = 1;
            this.fillBTN.Text = "Fill List";
            this.fillBTN.UseVisualStyleBackColor = true;
            this.fillBTN.Click += new System.EventHandler(this.fillBTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(382, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBTN
            // 
            this.comboBTN.Location = new System.Drawing.Point(382, 93);
            this.comboBTN.Name = "comboBTN";
            this.comboBTN.Size = new System.Drawing.Size(141, 31);
            this.comboBTN.TabIndex = 3;
            this.comboBTN.Text = "Fill Combo Box";
            this.comboBTN.UseVisualStyleBackColor = true;
            this.comboBTN.Click += new System.EventHandler(this.comboBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 398);
            this.Controls.Add(this.comboBTN);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fillBTN);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button fillBTN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button comboBTN;
    }
}

