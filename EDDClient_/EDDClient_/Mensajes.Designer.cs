namespace EDDClient_
{
    partial class Mensajes
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
            this.btnAnswers = new System.Windows.Forms.Button();
            this.btnQmess = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnswers
            // 
            this.btnAnswers.Location = new System.Drawing.Point(99, 125);
            this.btnAnswers.Name = "btnAnswers";
            this.btnAnswers.Size = new System.Drawing.Size(244, 35);
            this.btnAnswers.TabIndex = 5;
            this.btnAnswers.Text = "Ver Respuestas de Mensajes";
            this.btnAnswers.UseVisualStyleBackColor = true;
            this.btnAnswers.Click += new System.EventHandler(this.btnAnswers_Click);
            // 
            // btnQmess
            // 
            this.btnQmess.Location = new System.Drawing.Point(99, 84);
            this.btnQmess.Name = "btnQmess";
            this.btnQmess.Size = new System.Drawing.Size(244, 35);
            this.btnQmess.TabIndex = 4;
            this.btnQmess.Text = "Ver Cola de Mensajes";
            this.btnQmess.UseVisualStyleBackColor = true;
            this.btnQmess.Click += new System.EventHandler(this.btnQmess_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(99, 43);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(244, 35);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "Enviar Mensajes";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // Mensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 203);
            this.Controls.Add(this.btnAnswers);
            this.Controls.Add(this.btnQmess);
            this.Controls.Add(this.btnsend);
            this.Name = "Mensajes";
            this.Text = "Mensajes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnswers;
        private System.Windows.Forms.Button btnQmess;
        private System.Windows.Forms.Button btnsend;
    }
}