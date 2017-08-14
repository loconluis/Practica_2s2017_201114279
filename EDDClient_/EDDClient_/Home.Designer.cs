namespace EDDClient_
{
    partial class frm_home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btndashboard = new System.Windows.Forms.Button();
            this.btnmessages = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndashboard
            // 
            this.btndashboard.Location = new System.Drawing.Point(101, 43);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(244, 35);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "Ver Dashboard";
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnmessages
            // 
            this.btnmessages.Location = new System.Drawing.Point(101, 84);
            this.btnmessages.Name = "btnmessages";
            this.btnmessages.Size = new System.Drawing.Size(244, 35);
            this.btnmessages.TabIndex = 1;
            this.btnmessages.Text = "Administrar Mensajes";
            this.btnmessages.UseVisualStyleBackColor = true;
            this.btnmessages.Click += new System.EventHandler(this.btnmessages_Click);
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(101, 125);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(244, 35);
            this.btnreports.TabIndex = 2;
            this.btnreports.Text = "Ver Reportes";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 203);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.btnmessages);
            this.Controls.Add(this.btndashboard);
            this.Name = "frm_home";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnmessages;
        private System.Windows.Forms.Button btnreports;
    }
}

