namespace EDDClient_
{
    partial class Envio
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
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btnsendM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(12, 12);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_message.Size = new System.Drawing.Size(437, 315);
            this.txt_message.TabIndex = 0;
            // 
            // btnsendM
            // 
            this.btnsendM.Location = new System.Drawing.Point(103, 334);
            this.btnsendM.Name = "btnsendM";
            this.btnsendM.Size = new System.Drawing.Size(239, 33);
            this.btnsendM.TabIndex = 1;
            this.btnsendM.Text = "Enviar";
            this.btnsendM.UseVisualStyleBackColor = true;
            // 
            // Envio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 379);
            this.Controls.Add(this.btnsendM);
            this.Controls.Add(this.txt_message);
            this.Name = "Envio";
            this.Text = "Envio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btnsendM;
    }
}