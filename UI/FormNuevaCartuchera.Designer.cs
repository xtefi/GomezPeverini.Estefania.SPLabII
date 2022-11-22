
namespace UI
{
    partial class FormNuevaCartuchera
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
            this.numCapacidadCartuchera = new System.Windows.Forms.NumericUpDown();
            this.lblNombreCartuchera = new System.Windows.Forms.Label();
            this.lblCapacidadCartuchera = new System.Windows.Forms.Label();
            this.tbxNombreCartuchera = new System.Windows.Forms.TextBox();
            this.dgdCartucheras = new System.Windows.Forms.DataGridView();
            this.gbxNuevaCartuchera = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrarCartuchera = new System.Windows.Forms.Button();
            this.btnEditarCartuchera = new System.Windows.Forms.Button();
            this.btnAgregarUtiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadCartuchera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCartucheras)).BeginInit();
            this.gbxNuevaCartuchera.SuspendLayout();
            this.SuspendLayout();
            // 
            // numCapacidadCartuchera
            // 
            this.numCapacidadCartuchera.Location = new System.Drawing.Point(100, 78);
            this.numCapacidadCartuchera.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numCapacidadCartuchera.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidadCartuchera.Name = "numCapacidadCartuchera";
            this.numCapacidadCartuchera.Size = new System.Drawing.Size(120, 23);
            this.numCapacidadCartuchera.TabIndex = 0;
            this.numCapacidadCartuchera.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNombreCartuchera
            // 
            this.lblNombreCartuchera.AutoSize = true;
            this.lblNombreCartuchera.Location = new System.Drawing.Point(6, 25);
            this.lblNombreCartuchera.Name = "lblNombreCartuchera";
            this.lblNombreCartuchera.Size = new System.Drawing.Size(51, 15);
            this.lblNombreCartuchera.TabIndex = 1;
            this.lblNombreCartuchera.Text = "Nombre";
            // 
            // lblCapacidadCartuchera
            // 
            this.lblCapacidadCartuchera.AutoSize = true;
            this.lblCapacidadCartuchera.Location = new System.Drawing.Point(6, 64);
            this.lblCapacidadCartuchera.Name = "lblCapacidadCartuchera";
            this.lblCapacidadCartuchera.Size = new System.Drawing.Size(63, 15);
            this.lblCapacidadCartuchera.TabIndex = 2;
            this.lblCapacidadCartuchera.Text = "Capacidad";
            // 
            // tbxNombreCartuchera
            // 
            this.tbxNombreCartuchera.Location = new System.Drawing.Point(100, 22);
            this.tbxNombreCartuchera.Name = "tbxNombreCartuchera";
            this.tbxNombreCartuchera.Size = new System.Drawing.Size(100, 23);
            this.tbxNombreCartuchera.TabIndex = 3;
            // 
            // dgdCartucheras
            // 
            this.dgdCartucheras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdCartucheras.Location = new System.Drawing.Point(12, 12);
            this.dgdCartucheras.Name = "dgdCartucheras";
            this.dgdCartucheras.RowTemplate.Height = 25;
            this.dgdCartucheras.Size = new System.Drawing.Size(517, 174);
            this.dgdCartucheras.TabIndex = 4;
            // 
            // gbxNuevaCartuchera
            // 
            this.gbxNuevaCartuchera.Controls.Add(this.btnCrear);
            this.gbxNuevaCartuchera.Controls.Add(this.tbxNombreCartuchera);
            this.gbxNuevaCartuchera.Controls.Add(this.numCapacidadCartuchera);
            this.gbxNuevaCartuchera.Controls.Add(this.lblCapacidadCartuchera);
            this.gbxNuevaCartuchera.Controls.Add(this.lblNombreCartuchera);
            this.gbxNuevaCartuchera.Location = new System.Drawing.Point(12, 213);
            this.gbxNuevaCartuchera.Name = "gbxNuevaCartuchera";
            this.gbxNuevaCartuchera.Size = new System.Drawing.Size(237, 169);
            this.gbxNuevaCartuchera.TabIndex = 5;
            this.gbxNuevaCartuchera.TabStop = false;
            this.gbxNuevaCartuchera.Text = "Nueva cartuchera";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(22, 126);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(151, 37);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrarCartuchera
            // 
            this.btnMostrarCartuchera.Location = new System.Drawing.Point(274, 196);
            this.btnMostrarCartuchera.Name = "btnMostrarCartuchera";
            this.btnMostrarCartuchera.Size = new System.Drawing.Size(129, 62);
            this.btnMostrarCartuchera.TabIndex = 5;
            this.btnMostrarCartuchera.Text = "Mostrar cartuchera";
            this.btnMostrarCartuchera.UseVisualStyleBackColor = true;
            this.btnMostrarCartuchera.Click += new System.EventHandler(this.btnMostrarCartuchera_Click);
            // 
            // btnEditarCartuchera
            // 
            this.btnEditarCartuchera.Location = new System.Drawing.Point(274, 277);
            this.btnEditarCartuchera.Name = "btnEditarCartuchera";
            this.btnEditarCartuchera.Size = new System.Drawing.Size(129, 62);
            this.btnEditarCartuchera.TabIndex = 6;
            this.btnEditarCartuchera.Text = "Editar cartuchera";
            this.btnEditarCartuchera.UseVisualStyleBackColor = true;
            this.btnEditarCartuchera.Click += new System.EventHandler(this.btnEditarCartuchera_Click);
            // 
            // btnAgregarUtiles
            // 
            this.btnAgregarUtiles.Location = new System.Drawing.Point(274, 345);
            this.btnAgregarUtiles.Name = "btnAgregarUtiles";
            this.btnAgregarUtiles.Size = new System.Drawing.Size(129, 46);
            this.btnAgregarUtiles.TabIndex = 7;
            this.btnAgregarUtiles.Text = "Agregar Utiles";
            this.btnAgregarUtiles.UseVisualStyleBackColor = true;
            this.btnAgregarUtiles.Click += new System.EventHandler(this.btnAgregarUtiles_Click);
            // 
            // FormNuevaCartuchera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 403);
            this.Controls.Add(this.btnAgregarUtiles);
            this.Controls.Add(this.btnEditarCartuchera);
            this.Controls.Add(this.btnMostrarCartuchera);
            this.Controls.Add(this.gbxNuevaCartuchera);
            this.Controls.Add(this.dgdCartucheras);
            this.Name = "FormNuevaCartuchera";
            this.Text = "FormNuevaCartuchera";
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadCartuchera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCartucheras)).EndInit();
            this.gbxNuevaCartuchera.ResumeLayout(false);
            this.gbxNuevaCartuchera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numCapacidadCartuchera;
        private System.Windows.Forms.Label lblNombreCartuchera;
        private System.Windows.Forms.Label lblCapacidadCartuchera;
        private System.Windows.Forms.TextBox tbxNombreCartuchera;
        private System.Windows.Forms.DataGridView dgdCartucheras;
        private System.Windows.Forms.GroupBox gbxNuevaCartuchera;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnMostrarCartuchera;
        private System.Windows.Forms.Button btnEditarCartuchera;
        private System.Windows.Forms.Button btnAgregarUtiles;
    }
}