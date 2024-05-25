namespace BonvinoApp.CapaPresentacion.Forms
{
    partial class PantallaGenerarRankingVino
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
            this.generarRakingVino = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generarRakingVino
            // 
            this.generarRakingVino.Location = new System.Drawing.Point(250, 106);
            this.generarRakingVino.Name = "generarRakingVino";
            this.generarRakingVino.Size = new System.Drawing.Size(242, 23);
            this.generarRakingVino.TabIndex = 0;
            this.generarRakingVino.Text = "Generar Ranking Vino";
            this.generarRakingVino.UseVisualStyleBackColor = true;
            this.generarRakingVino.Click += new System.EventHandler(this.button1_Click);
            // 
            // PantallaGenerarRankingVino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generarRakingVino);
            this.Name = "PantallaGenerarRankingVino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaGenerarRankingVino";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generarRakingVino;
    }
}