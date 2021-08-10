
namespace WinFormsAppAsia07Figury
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGraphics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGraphics
            // 
            this.btnGraphics.Location = new System.Drawing.Point(547, 29);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(94, 29);
            this.btnGraphics.TabIndex = 0;
            this.btnGraphics.Text = "graphics button";
            this.btnGraphics.UseVisualStyleBackColor = true;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGraphics);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGraphics;
    }
}

