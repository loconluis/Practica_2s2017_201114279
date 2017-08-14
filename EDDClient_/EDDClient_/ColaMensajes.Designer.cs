namespace EDDClient_
{
    partial class ColaMensajes
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
            this.lblengthop = new System.Windows.Forms.Label();
            this.btnop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_console = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblengthop
            // 
            this.lblengthop.AutoSize = true;
            this.lblengthop.Location = new System.Drawing.Point(231, 30);
            this.lblengthop.Name = "lblengthop";
            this.lblengthop.Size = new System.Drawing.Size(153, 13);
            this.lblengthop.TabIndex = 0;
            this.lblengthop.Text = "NUMERO DE OPERACIONES";
            // 
            // btnop
            // 
            this.btnop.Location = new System.Drawing.Point(264, 58);
            this.btnop.Name = "btnop";
            this.btnop.Size = new System.Drawing.Size(75, 23);
            this.btnop.TabIndex = 1;
            this.btnop.Text = "Operar";
            this.btnop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_console);
            this.groupBox2.Location = new System.Drawing.Point(234, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 296);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consola de Ejecucion";
            // 
            // txt_console
            // 
            this.txt_console.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_console.ForeColor = System.Drawing.Color.Lime;
            this.txt_console.Location = new System.Drawing.Point(7, 20);
            this.txt_console.Multiline = true;
            this.txt_console.Name = "txt_console";
            this.txt_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_console.Size = new System.Drawing.Size(339, 270);
            this.txt_console.TabIndex = 0;
            // 
            // ColaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnop);
            this.Controls.Add(this.lblengthop);
            this.Name = "ColaMensajes";
            this.Text = "Cola de Mensajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblengthop;
        private System.Windows.Forms.Button btnop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_console;
    }
}