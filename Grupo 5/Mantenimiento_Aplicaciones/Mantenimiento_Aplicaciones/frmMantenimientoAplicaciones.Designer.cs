
namespace Mantenimiento_Aplicaciones
{
    partial class frmMantenimientoAplicaciones
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
            this.labelIdaplicacion = new System.Windows.Forms.Label();
            this.labelNombreaplicacion = new System.Windows.Forms.Label();
            this.labelEstadoaplicacion = new System.Windows.Forms.Label();
            this.pnlEstadoAplicacion = new System.Windows.Forms.Panel();
            this.btnInhabilitado = new System.Windows.Forms.RadioButton();
            this.btnHabilitado = new System.Windows.Forms.RadioButton();
            this.txtNombreaplicacion = new System.Windows.Forms.TextBox();
            this.txtIdaplicacion = new System.Windows.Forms.TextBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.pnlEstadoAplicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIdaplicacion
            // 
            this.labelIdaplicacion.AutoSize = true;
            this.labelIdaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelIdaplicacion.Location = new System.Drawing.Point(33, 102);
            this.labelIdaplicacion.Name = "labelIdaplicacion";
            this.labelIdaplicacion.Size = new System.Drawing.Size(73, 13);
            this.labelIdaplicacion.TabIndex = 0;
            this.labelIdaplicacion.Text = "ID Aplicación:";
            // 
            // labelNombreaplicacion
            // 
            this.labelNombreaplicacion.AutoSize = true;
            this.labelNombreaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreaplicacion.Location = new System.Drawing.Point(33, 140);
            this.labelNombreaplicacion.Name = "labelNombreaplicacion";
            this.labelNombreaplicacion.Size = new System.Drawing.Size(99, 13);
            this.labelNombreaplicacion.TabIndex = 1;
            this.labelNombreaplicacion.Text = "Nombre Aplicación:";
            // 
            // labelEstadoaplicacion
            // 
            this.labelEstadoaplicacion.AutoSize = true;
            this.labelEstadoaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelEstadoaplicacion.Location = new System.Drawing.Point(61, 0);
            this.labelEstadoaplicacion.Name = "labelEstadoaplicacion";
            this.labelEstadoaplicacion.Size = new System.Drawing.Size(92, 13);
            this.labelEstadoaplicacion.TabIndex = 2;
            this.labelEstadoaplicacion.Text = "Estado Aplicación";
            // 
            // pnlEstadoAplicacion
            // 
            this.pnlEstadoAplicacion.BackColor = System.Drawing.Color.Transparent;
            this.pnlEstadoAplicacion.Controls.Add(this.btnInhabilitado);
            this.pnlEstadoAplicacion.Controls.Add(this.labelEstadoaplicacion);
            this.pnlEstadoAplicacion.Controls.Add(this.btnHabilitado);
            this.pnlEstadoAplicacion.Location = new System.Drawing.Point(138, 189);
            this.pnlEstadoAplicacion.Name = "pnlEstadoAplicacion";
            this.pnlEstadoAplicacion.Size = new System.Drawing.Size(212, 78);
            this.pnlEstadoAplicacion.TabIndex = 3;
            // 
            // btnInhabilitado
            // 
            this.btnInhabilitado.AutoSize = true;
            this.btnInhabilitado.Location = new System.Drawing.Point(121, 40);
            this.btnInhabilitado.Name = "btnInhabilitado";
            this.btnInhabilitado.Size = new System.Drawing.Size(79, 17);
            this.btnInhabilitado.TabIndex = 1;
            this.btnInhabilitado.TabStop = true;
            this.btnInhabilitado.Text = "Inhabilitado";
            this.btnInhabilitado.UseVisualStyleBackColor = true;
            // 
            // btnHabilitado
            // 
            this.btnHabilitado.AutoSize = true;
            this.btnHabilitado.Location = new System.Drawing.Point(13, 40);
            this.btnHabilitado.Name = "btnHabilitado";
            this.btnHabilitado.Size = new System.Drawing.Size(72, 17);
            this.btnHabilitado.TabIndex = 0;
            this.btnHabilitado.TabStop = true;
            this.btnHabilitado.Text = "Habilitado";
            this.btnHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtNombreaplicacion
            // 
            this.txtNombreaplicacion.Location = new System.Drawing.Point(138, 140);
            this.txtNombreaplicacion.Name = "txtNombreaplicacion";
            this.txtNombreaplicacion.Size = new System.Drawing.Size(212, 20);
            this.txtNombreaplicacion.TabIndex = 4;
            // 
            // txtIdaplicacion
            // 
            this.txtIdaplicacion.Location = new System.Drawing.Point(138, 95);
            this.txtIdaplicacion.Name = "txtIdaplicacion";
            this.txtIdaplicacion.Size = new System.Drawing.Size(212, 20);
            this.txtIdaplicacion.TabIndex = 5;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(411, 95);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 6;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // frmMantenimientoAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mantenimiento_Aplicaciones.Properties.Resources.Fondo_Forms;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.txtIdaplicacion);
            this.Controls.Add(this.txtNombreaplicacion);
            this.Controls.Add(this.pnlEstadoAplicacion);
            this.Controls.Add(this.labelNombreaplicacion);
            this.Controls.Add(this.labelIdaplicacion);
            this.Name = "frmMantenimientoAplicaciones";
            this.Text = "Mantenimiento Aplicaciones";
            this.pnlEstadoAplicacion.ResumeLayout(false);
            this.pnlEstadoAplicacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label labelIdaplicacion;
		private System.Windows.Forms.Label labelNombreaplicacion;
		private System.Windows.Forms.Label labelEstadoaplicacion;
		private System.Windows.Forms.Panel pnlEstadoAplicacion;
		private System.Windows.Forms.RadioButton btnInhabilitado;
		private System.Windows.Forms.RadioButton btnHabilitado;
		private System.Windows.Forms.TextBox txtNombreaplicacion;
		private System.Windows.Forms.TextBox txtIdaplicacion;
        private System.Windows.Forms.Button btnPrueba;
    }
}