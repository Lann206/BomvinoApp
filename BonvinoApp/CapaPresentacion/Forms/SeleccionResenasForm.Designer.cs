namespace BonvinoApp.CapaPresentacion.Forms
{
    partial class SeleccionResenasForm
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
            this.rbResenasNormales = new System.Windows.Forms.RadioButton();
            this.rbResenasSommelier = new System.Windows.Forms.RadioButton();
            this.rbResenasAmigos = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbResenasNormales
            // 
            this.rbResenasNormales.AutoSize = true;
            this.rbResenasNormales.Location = new System.Drawing.Point(34, 34);
            this.rbResenasNormales.Name = "rbResenasNormales";
            this.rbResenasNormales.Size = new System.Drawing.Size(119, 17);
            this.rbResenasNormales.TabIndex = 0;
            this.rbResenasNormales.TabStop = true;
            this.rbResenasNormales.Text = "Reseñas normales";
            this.rbResenasNormales.UseVisualStyleBackColor = true;
            // 
            // rbResenasSommelier
            // 
            this.rbResenasSommelier.AutoSize = true;
            this.rbResenasSommelier.Location = new System.Drawing.Point(34, 70);
            this.rbResenasSommelier.Name = "rbResenasSommelier";
            this.rbResenasSommelier.Size = new System.Drawing.Size(123, 17);
            this.rbResenasSommelier.TabIndex = 1;
            this.rbResenasSommelier.TabStop = true;
            this.rbResenasSommelier.Text = "Reseñas sommelier";
            this.rbResenasSommelier.UseVisualStyleBackColor = true;
            // 
            // rbResenasAmigos
            // 
            this.rbResenasAmigos.AutoSize = true;
            this.rbResenasAmigos.Location = new System.Drawing.Point(34, 106);
            this.rbResenasAmigos.Name = "rbResenasAmigos";
            this.rbResenasAmigos.Size = new System.Drawing.Size(113, 17);
            this.rbResenasAmigos.TabIndex = 2;
            this.rbResenasAmigos.TabStop = true;
            this.rbResenasAmigos.Text = "Reseñas amigos";
            this.rbResenasAmigos.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(34, 155);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(123, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // SeleccionResenasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 204);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rbResenasAmigos);
            this.Controls.Add(this.rbResenasSommelier);
            this.Controls.Add(this.rbResenasNormales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionResenasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selección de Reseñas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbResenasNormales;
        private System.Windows.Forms.RadioButton rbResenasSommelier;
        private System.Windows.Forms.RadioButton rbResenasAmigos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}