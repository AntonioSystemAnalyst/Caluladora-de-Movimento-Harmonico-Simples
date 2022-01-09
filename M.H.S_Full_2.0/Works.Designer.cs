namespace M.H.S_Full_2._0
{
    partial class Works
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Works));
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            this.SuspendLayout();
            // 
            // PB1
            // 
            this.PB1.Image = global::M.H.S_Full_2._0.Properties.Resources.MHS_Big1;
            this.PB1.Location = new System.Drawing.Point(0, 0);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(1000, 636);
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            // 
            // PB2
            // 
            this.PB2.BackgroundImage = global::M.H.S_Full_2._0.Properties.Resources.MHS_Big2;
            this.PB2.Location = new System.Drawing.Point(0, 0);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(1000, 636);
            this.PB2.TabIndex = 1;
            this.PB2.TabStop = false;
            this.PB2.Click += new System.EventHandler(this.PB2_Click);
            // 
            // Works
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 635);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Works";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Works";
            this.Load += new System.EventHandler(this.Works_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PB1;
        public System.Windows.Forms.PictureBox PB2;
    }
}