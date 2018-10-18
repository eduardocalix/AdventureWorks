namespace AdventureWorkDepartamento
{
    partial class frmActualizar
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbActualizar = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(99, 277);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 55);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbActualizar
            // 
            this.gbActualizar.Controls.Add(this.btnBuscar);
            this.gbActualizar.Controls.Add(this.txtId);
            this.gbActualizar.Controls.Add(this.lblcodigo);
            this.gbActualizar.Controls.Add(this.lblEstado);
            this.gbActualizar.Controls.Add(this.dtpFechaModificacion);
            this.gbActualizar.Controls.Add(this.lblFechaModificacion);
            this.gbActualizar.Controls.Add(this.txtGrupo);
            this.gbActualizar.Controls.Add(this.label2);
            this.gbActualizar.Controls.Add(this.txtNombre);
            this.gbActualizar.Controls.Add(this.label1);
            this.gbActualizar.Location = new System.Drawing.Point(12, 22);
            this.gbActualizar.Name = "gbActualizar";
            this.gbActualizar.Size = new System.Drawing.Size(492, 237);
            this.gbActualizar.TabIndex = 1;
            this.gbActualizar.TabStop = false;
            this.gbActualizar.Text = "Formulario para Actualizar";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEstado.Location = new System.Drawing.Point(47, 178);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 18);
            this.lblEstado.TabIndex = 18;
            // 
            // dtpFechaModificacion
            // 
            this.dtpFechaModificacion.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaModificacion.Location = new System.Drawing.Point(220, 146);
            this.dtpFechaModificacion.Name = "dtpFechaModificacion";
            this.dtpFechaModificacion.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaModificacion.TabIndex = 17;
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificacion.Location = new System.Drawing.Point(25, 146);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(189, 20);
            this.lblFechaModificacion.TabIndex = 16;
            this.lblFechaModificacion.Text = "Fecha de modificación";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.Location = new System.Drawing.Point(193, 108);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(167, 22);
            this.txtGrupo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre del grupo";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(220, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 22);
            this.txtNombre.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre departamento";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(26, 32);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(142, 20);
            this.lblcodigo.TabIndex = 19;
            this.lblcodigo.Text = "Id departamento";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(193, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(167, 22);
            this.txtId.TabIndex = 20;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(246, 277);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 55);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(404, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 29);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 346);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbActualizar);
            this.Controls.Add(this.btnActualizar);
            this.Name = "frmActualizar";
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.frmActualizar_Load);
            this.gbActualizar.ResumeLayout(false);
            this.gbActualizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox gbActualizar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaModificacion;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
    }
}