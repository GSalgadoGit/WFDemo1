
namespace WFDemo1
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
            this.Hellobutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hellobutton1
            // 
            this.Hellobutton1.Location = new System.Drawing.Point(311, 49);
            this.Hellobutton1.Name = "Hellobutton1";
            this.Hellobutton1.Size = new System.Drawing.Size(126, 40);
            this.Hellobutton1.TabIndex = 0;
            this.Hellobutton1.Text = "Hello World";
            this.Hellobutton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hellobutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Hellobutton1;
    }
}

