namespace BonvinoApp.CapaPresentacion.Forms
{
    partial class ListadoVinos
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
            this.dtgVinos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVinos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVinos
            // 
            this.dtgVinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVinos.Location = new System.Drawing.Point(13, 13);
            this.dtgVinos.Name = "dtgVinos";
            this.dtgVinos.Size = new System.Drawing.Size(591, 313);
            this.dtgVinos.TabIndex = 0;
            // 
            // ListadoVinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 340);
            this.Controls.Add(this.dtgVinos);
            this.Name = "ListadoVinos";
            this.Text = "ListadoVinos";
            this.Load += new System.EventHandler(this.ListadoVinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVinos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVinos;
    }
}