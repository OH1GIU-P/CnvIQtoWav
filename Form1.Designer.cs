namespace CnvIQtoWav
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOutfile = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "IQ files|*.iq";
            this.openFileDialog1.InitialDirectory = "c:\\temp\\iq";
            this.openFileDialog1.Title = "IQ file";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open and convert IQ file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Infile";
            // 
            // labelInfile
            // 
            this.labelInfile.AutoSize = true;
            this.labelInfile.Location = new System.Drawing.Point(56, 64);
            this.labelInfile.Name = "labelInfile";
            this.labelInfile.Size = new System.Drawing.Size(35, 13);
            this.labelInfile.TabIndex = 2;
            this.labelInfile.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Outfile";
            // 
            // labelOutfile
            // 
            this.labelOutfile.AutoSize = true;
            this.labelOutfile.Location = new System.Drawing.Point(56, 87);
            this.labelOutfile.Name = "labelOutfile";
            this.labelOutfile.Size = new System.Drawing.Size(35, 13);
            this.labelOutfile.TabIndex = 4;
            this.labelOutfile.Text = "label3";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 116);
            this.labelError.MaximumSize = new System.Drawing.Size(590, 69);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(35, 13);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 209);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelOutfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelInfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "HackRF IQ to SDR# wav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOutfile;
        private System.Windows.Forms.Label labelError;
    }
}

