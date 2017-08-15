namespace EDDClient_
{
    partial class Master
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
            this.mshome = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mshome.SuspendLayout();
            this.SuspendLayout();
            // 
            // mshome
            // 
            this.mshome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.mshome.Location = new System.Drawing.Point(0, 0);
            this.mshome.Name = "mshome";
            this.mshome.Size = new System.Drawing.Size(929, 24);
            this.mshome.TabIndex = 1;
            this.mshome.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correrToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // correrToolStripMenuItem
            // 
            this.correrToolStripMenuItem.Name = "correrToolStripMenuItem";
            this.correrToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.correrToolStripMenuItem.Text = "Correr";
            this.correrToolStripMenuItem.Click += new System.EventHandler(this.correrToolStripMenuItem_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 580);
            this.Controls.Add(this.mshome);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mshome;
            this.Name = "Master";
            this.Text = "Blockchain";
            this.mshome.ResumeLayout(false);
            this.mshome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mshome;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correrToolStripMenuItem;
    }
}