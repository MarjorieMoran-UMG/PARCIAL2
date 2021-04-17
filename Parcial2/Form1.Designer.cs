
namespace Parcial2
{
    partial class Form1
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
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.listBoxArchivo = new System.Windows.Forms.ListBox();
            this.textBoxResultados = new System.Windows.Forms.TextBox();
            this.buttonPromedioPorParcial = new System.Windows.Forms.Button();
            this.buttonPromedioPorSeccion = new System.Windows.Forms.Button();
            this.buttonPromedioGeneralSeccion = new System.Windows.Forms.Button();
            this.buttonNotaMayorEnGeneral = new System.Windows.Forms.Button();
            this.buttonNombreAlumnosySeccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonCargarArchivo.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarArchivo.ForeColor = System.Drawing.Color.White;
            this.buttonCargarArchivo.Location = new System.Drawing.Point(13, 13);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(138, 73);
            this.buttonCargarArchivo.TabIndex = 0;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = false;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // listBoxArchivo
            // 
            this.listBoxArchivo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxArchivo.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxArchivo.FormattingEnabled = true;
            this.listBoxArchivo.ItemHeight = 15;
            this.listBoxArchivo.Location = new System.Drawing.Point(577, 15);
            this.listBoxArchivo.Name = "listBoxArchivo";
            this.listBoxArchivo.Size = new System.Drawing.Size(347, 454);
            this.listBoxArchivo.TabIndex = 1;
            // 
            // textBoxResultados
            // 
            this.textBoxResultados.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxResultados.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultados.Location = new System.Drawing.Point(175, 13);
            this.textBoxResultados.Multiline = true;
            this.textBoxResultados.Name = "textBoxResultados";
            this.textBoxResultados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultados.Size = new System.Drawing.Size(394, 459);
            this.textBoxResultados.TabIndex = 2;
            // 
            // buttonPromedioPorParcial
            // 
            this.buttonPromedioPorParcial.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonPromedioPorParcial.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromedioPorParcial.ForeColor = System.Drawing.Color.White;
            this.buttonPromedioPorParcial.Location = new System.Drawing.Point(13, 92);
            this.buttonPromedioPorParcial.Name = "buttonPromedioPorParcial";
            this.buttonPromedioPorParcial.Size = new System.Drawing.Size(138, 73);
            this.buttonPromedioPorParcial.TabIndex = 3;
            this.buttonPromedioPorParcial.Text = "Promedio por Parcial";
            this.buttonPromedioPorParcial.UseVisualStyleBackColor = false;
            this.buttonPromedioPorParcial.Click += new System.EventHandler(this.buttonPromedioPorParcial_Click);
            // 
            // buttonPromedioPorSeccion
            // 
            this.buttonPromedioPorSeccion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonPromedioPorSeccion.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromedioPorSeccion.ForeColor = System.Drawing.Color.White;
            this.buttonPromedioPorSeccion.Location = new System.Drawing.Point(13, 171);
            this.buttonPromedioPorSeccion.Name = "buttonPromedioPorSeccion";
            this.buttonPromedioPorSeccion.Size = new System.Drawing.Size(136, 72);
            this.buttonPromedioPorSeccion.TabIndex = 5;
            this.buttonPromedioPorSeccion.Text = "Promedio de cada Parcial por Seccion";
            this.buttonPromedioPorSeccion.UseVisualStyleBackColor = false;
            this.buttonPromedioPorSeccion.Click += new System.EventHandler(this.buttonPromedioPorSeccion_Click);
            // 
            // buttonPromedioGeneralSeccion
            // 
            this.buttonPromedioGeneralSeccion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonPromedioGeneralSeccion.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromedioGeneralSeccion.ForeColor = System.Drawing.Color.White;
            this.buttonPromedioGeneralSeccion.Location = new System.Drawing.Point(13, 249);
            this.buttonPromedioGeneralSeccion.Name = "buttonPromedioGeneralSeccion";
            this.buttonPromedioGeneralSeccion.Size = new System.Drawing.Size(136, 72);
            this.buttonPromedioGeneralSeccion.TabIndex = 6;
            this.buttonPromedioGeneralSeccion.Text = "Promedio General de la Seccion";
            this.buttonPromedioGeneralSeccion.UseVisualStyleBackColor = false;
            this.buttonPromedioGeneralSeccion.Click += new System.EventHandler(this.buttonPromedioGeneralSeccion_Click);
            // 
            // buttonNotaMayorEnGeneral
            // 
            this.buttonNotaMayorEnGeneral.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonNotaMayorEnGeneral.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotaMayorEnGeneral.ForeColor = System.Drawing.Color.White;
            this.buttonNotaMayorEnGeneral.Location = new System.Drawing.Point(13, 327);
            this.buttonNotaMayorEnGeneral.Name = "buttonNotaMayorEnGeneral";
            this.buttonNotaMayorEnGeneral.Size = new System.Drawing.Size(136, 72);
            this.buttonNotaMayorEnGeneral.TabIndex = 7;
            this.buttonNotaMayorEnGeneral.Text = "Nota Mayor en General";
            this.buttonNotaMayorEnGeneral.UseVisualStyleBackColor = false;
            this.buttonNotaMayorEnGeneral.Click += new System.EventHandler(this.buttonNotaMayorEnGeneral_Click);
            // 
            // buttonNombreAlumnosySeccion
            // 
            this.buttonNombreAlumnosySeccion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonNombreAlumnosySeccion.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNombreAlumnosySeccion.ForeColor = System.Drawing.Color.White;
            this.buttonNombreAlumnosySeccion.Location = new System.Drawing.Point(15, 405);
            this.buttonNombreAlumnosySeccion.Name = "buttonNombreAlumnosySeccion";
            this.buttonNombreAlumnosySeccion.Size = new System.Drawing.Size(136, 72);
            this.buttonNombreAlumnosySeccion.TabIndex = 8;
            this.buttonNombreAlumnosySeccion.Text = "Nombre de Alumnos y Seccion";
            this.buttonNombreAlumnosySeccion.UseVisualStyleBackColor = false;
            this.buttonNombreAlumnosySeccion.Click += new System.EventHandler(this.buttonNombreAlumnosySeccion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(934, 492);
            this.Controls.Add(this.buttonNombreAlumnosySeccion);
            this.Controls.Add(this.buttonNotaMayorEnGeneral);
            this.Controls.Add(this.buttonPromedioGeneralSeccion);
            this.Controls.Add(this.buttonPromedioPorSeccion);
            this.Controls.Add(this.buttonPromedioPorParcial);
            this.Controls.Add(this.textBoxResultados);
            this.Controls.Add(this.listBoxArchivo);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.ListBox listBoxArchivo;
        private System.Windows.Forms.TextBox textBoxResultados;
        private System.Windows.Forms.Button buttonPromedioPorParcial;
        private System.Windows.Forms.Button buttonPromedioPorSeccion;
        private System.Windows.Forms.Button buttonPromedioGeneralSeccion;
        private System.Windows.Forms.Button buttonNotaMayorEnGeneral;
        private System.Windows.Forms.Button buttonNombreAlumnosySeccion;
    }
}

