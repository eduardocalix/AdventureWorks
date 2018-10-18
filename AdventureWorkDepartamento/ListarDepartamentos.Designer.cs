namespace AdventureWorkDepartamento
{
    partial class frmListarDepartamentos
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
            this.gvDepartamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDepartamentos
            // 
            this.gvDepartamentos.AllowUserToAddRows = false;
            this.gvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDepartamentos.Location = new System.Drawing.Point(12, 12);
            this.gvDepartamentos.Name = "gvDepartamentos";
            this.gvDepartamentos.Size = new System.Drawing.Size(443, 296);
            this.gvDepartamentos.TabIndex = 1;
            // 
            // frmListarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 330);
            this.Controls.Add(this.gvDepartamentos);
            this.Name = "frmListarDepartamentos";
            this.Text = "ListarDepartamentos";
            this.Load += new System.EventHandler(this.frmListarDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDepartamentos;
    }
}