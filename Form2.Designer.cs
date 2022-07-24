namespace WindowsForms__Task1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.catchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catchBtn
            // 
            this.catchBtn.Location = new System.Drawing.Point(410, 418);
            this.catchBtn.Name = "catchBtn";
            this.catchBtn.Size = new System.Drawing.Size(120, 72);
            this.catchBtn.TabIndex = 0;
            this.catchBtn.Text = "button1";
            this.catchBtn.UseVisualStyleBackColor = true;
            this.catchBtn.Click += new System.EventHandler(this.button1_Click);
            this.catchBtn.MouseHover += new System.EventHandler(this.catchBtn_MouseHover);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 543);
            this.Controls.Add(this.catchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button catchBtn;
    }
}