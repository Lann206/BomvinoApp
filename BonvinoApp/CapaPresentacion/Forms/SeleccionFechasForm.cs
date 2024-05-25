using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonvinoApp.CapaPresentacion.Forms
{
    partial class SeleccionFechasForm : Form
    {
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;

        public SeleccionFechasForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(30, 30);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDesde.TabIndex = 0;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(30, 60);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHasta.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(90, 100);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // SeleccionFechasForm
            // 
            this.ClientSize = new System.Drawing.Size(260, 150);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.ResumeLayout(false);
        }

        public DateTime FechaDesde
        {
            get { return dateTimePickerDesde.Value; }
        }

        public DateTime FechaHasta
        {
            get { return dateTimePickerHasta.Value; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Cuando el usuario hace clic en "Aceptar", cierra el formulario
            this.DialogResult = DialogResult.OK;
        }
    }
}
