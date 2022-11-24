
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevaCartuchera));
            this.numCapacidadCartuchera = new System.Windows.Forms.NumericUpDown();
            this.lblNombreCartuchera = new System.Windows.Forms.Label();
            this.lblCapacidadCartuchera = new System.Windows.Forms.Label();
            this.tbxNombreCartuchera = new System.Windows.Forms.TextBox();
            this.dgdCartucheras = new System.Windows.Forms.DataGridView();
            this.gbxNuevaCartuchera = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrarCartuchera = new System.Windows.Forms.Button();
            this.btnEditarUtiles = new System.Windows.Forms.Button();
            this.btnVerLogs = new System.Windows.Forms.Button();
            this.dgdUtilesDisponibles = new System.Windows.Forms.DataGridView();
            this.rbtVerSacapuntas = new System.Windows.Forms.RadioButton();
            this.rbtVerLapices = new System.Windows.Forms.RadioButton();
            this.rbtVerGomas = new System.Windows.Forms.RadioButton();
            this.gbxUtilesDisponibles = new System.Windows.Forms.GroupBox();
            this.btnAgregarUtil = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadCartuchera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCartucheras)).BeginInit();
            this.gbxNuevaCartuchera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUtilesDisponibles)).BeginInit();
            this.gbxUtilesDisponibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // numCapacidadCartuchera
            // 
            this.numCapacidadCartuchera.Location = new System.Drawing.Point(97, 59);
            this.numCapacidadCartuchera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCapacidadCartuchera.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numCapacidadCartuchera.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidadCartuchera.Name = "numCapacidadCartuchera";
            this.numCapacidadCartuchera.Size = new System.Drawing.Size(114, 26);
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
            this.lblNombreCartuchera.Location = new System.Drawing.Point(7, 23);
            this.lblNombreCartuchera.Name = "lblNombreCartuchera";
            this.lblNombreCartuchera.Size = new System.Drawing.Size(61, 18);
            this.lblNombreCartuchera.TabIndex = 1;
            this.lblNombreCartuchera.Text = "Nombre";
            // 
            // lblCapacidadCartuchera
            // 
            this.lblCapacidadCartuchera.AutoSize = true;
            this.lblCapacidadCartuchera.Location = new System.Drawing.Point(6, 59);
            this.lblCapacidadCartuchera.Name = "lblCapacidadCartuchera";
            this.lblCapacidadCartuchera.Size = new System.Drawing.Size(76, 18);
            this.lblCapacidadCartuchera.TabIndex = 2;
            this.lblCapacidadCartuchera.Text = "Capacidad";
            // 
            // tbxNombreCartuchera
            // 
            this.tbxNombreCartuchera.Location = new System.Drawing.Point(97, 20);
            this.tbxNombreCartuchera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxNombreCartuchera.Name = "tbxNombreCartuchera";
            this.tbxNombreCartuchera.Size = new System.Drawing.Size(114, 26);
            this.tbxNombreCartuchera.TabIndex = 3;
            // 
            // dgdCartucheras
            // 
            this.dgdCartucheras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdCartucheras.BackgroundColor = System.Drawing.Color.Pink;
            this.dgdCartucheras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdCartucheras.GridColor = System.Drawing.Color.Pink;
            this.dgdCartucheras.Location = new System.Drawing.Point(14, 14);
            this.dgdCartucheras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgdCartucheras.Name = "dgdCartucheras";
            this.dgdCartucheras.RowTemplate.Height = 25;
            this.dgdCartucheras.Size = new System.Drawing.Size(359, 281);
            this.dgdCartucheras.TabIndex = 4;
            // 
            // gbxNuevaCartuchera
            // 
            this.gbxNuevaCartuchera.Controls.Add(this.btnCrear);
            this.gbxNuevaCartuchera.Controls.Add(this.tbxNombreCartuchera);
            this.gbxNuevaCartuchera.Controls.Add(this.numCapacidadCartuchera);
            this.gbxNuevaCartuchera.Controls.Add(this.lblCapacidadCartuchera);
            this.gbxNuevaCartuchera.Controls.Add(this.lblNombreCartuchera);
            this.gbxNuevaCartuchera.Location = new System.Drawing.Point(379, 14);
            this.gbxNuevaCartuchera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxNuevaCartuchera.Name = "gbxNuevaCartuchera";
            this.gbxNuevaCartuchera.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxNuevaCartuchera.Size = new System.Drawing.Size(222, 149);
            this.gbxNuevaCartuchera.TabIndex = 5;
            this.gbxNuevaCartuchera.TabStop = false;
            this.gbxNuevaCartuchera.Text = "Nueva cartuchera";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Wheat;
            this.btnCrear.Location = new System.Drawing.Point(7, 93);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(204, 45);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrarCartuchera
            // 
            this.btnMostrarCartuchera.BackColor = System.Drawing.Color.Wheat;
            this.btnMostrarCartuchera.Location = new System.Drawing.Point(379, 183);
            this.btnMostrarCartuchera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMostrarCartuchera.Name = "btnMostrarCartuchera";
            this.btnMostrarCartuchera.Size = new System.Drawing.Size(222, 52);
            this.btnMostrarCartuchera.TabIndex = 5;
            this.btnMostrarCartuchera.Text = "Mostrar cartuchera";
            this.btnMostrarCartuchera.UseVisualStyleBackColor = false;
            this.btnMostrarCartuchera.Click += new System.EventHandler(this.btnMostrarCartuchera_Click);
            // 
            // btnEditarUtiles
            // 
            this.btnEditarUtiles.BackColor = System.Drawing.Color.Wheat;
            this.btnEditarUtiles.Location = new System.Drawing.Point(511, 495);
            this.btnEditarUtiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarUtiles.Name = "btnEditarUtiles";
            this.btnEditarUtiles.Size = new System.Drawing.Size(99, 63);
            this.btnEditarUtiles.TabIndex = 7;
            this.btnEditarUtiles.Text = "Editar utiles";
            this.btnEditarUtiles.UseVisualStyleBackColor = false;
            this.btnEditarUtiles.Click += new System.EventHandler(this.btnAgregarUtiles_Click);
            // 
            // btnVerLogs
            // 
            this.btnVerLogs.BackColor = System.Drawing.Color.Wheat;
            this.btnVerLogs.Location = new System.Drawing.Point(379, 243);
            this.btnVerLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerLogs.Name = "btnVerLogs";
            this.btnVerLogs.Size = new System.Drawing.Size(222, 52);
            this.btnVerLogs.TabIndex = 8;
            this.btnVerLogs.Text = "Ver logs";
            this.btnVerLogs.UseVisualStyleBackColor = false;
            this.btnVerLogs.Click += new System.EventHandler(this.btnVerLogs_Click);
            // 
            // dgdUtilesDisponibles
            // 
            this.dgdUtilesDisponibles.BackgroundColor = System.Drawing.Color.Pink;
            this.dgdUtilesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdUtilesDisponibles.GridColor = System.Drawing.Color.Pink;
            this.dgdUtilesDisponibles.Location = new System.Drawing.Point(12, 371);
            this.dgdUtilesDisponibles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgdUtilesDisponibles.Name = "dgdUtilesDisponibles";
            this.dgdUtilesDisponibles.RowTemplate.Height = 25;
            this.dgdUtilesDisponibles.Size = new System.Drawing.Size(493, 187);
            this.dgdUtilesDisponibles.TabIndex = 9;
            // 
            // rbtVerSacapuntas
            // 
            this.rbtVerSacapuntas.AutoSize = true;
            this.rbtVerSacapuntas.Location = new System.Drawing.Point(208, 24);
            this.rbtVerSacapuntas.Name = "rbtVerSacapuntas";
            this.rbtVerSacapuntas.Size = new System.Drawing.Size(124, 22);
            this.rbtVerSacapuntas.TabIndex = 11;
            this.rbtVerSacapuntas.TabStop = true;
            this.rbtVerSacapuntas.Text = "Ver sacapuntas";
            this.rbtVerSacapuntas.UseVisualStyleBackColor = true;
            this.rbtVerSacapuntas.CheckedChanged += new System.EventHandler(this.rbtVerSacapuntas_CheckedChanged_1);
            // 
            // rbtVerLapices
            // 
            this.rbtVerLapices.AutoSize = true;
            this.rbtVerLapices.Location = new System.Drawing.Point(6, 24);
            this.rbtVerLapices.Name = "rbtVerLapices";
            this.rbtVerLapices.Size = new System.Drawing.Size(96, 22);
            this.rbtVerLapices.TabIndex = 12;
            this.rbtVerLapices.TabStop = true;
            this.rbtVerLapices.Text = "Ver lápices";
            this.rbtVerLapices.UseVisualStyleBackColor = true;
            this.rbtVerLapices.CheckedChanged += new System.EventHandler(this.rbtVerLapices_CheckedChanged);
            // 
            // rbtVerGomas
            // 
            this.rbtVerGomas.AutoSize = true;
            this.rbtVerGomas.Location = new System.Drawing.Point(108, 24);
            this.rbtVerGomas.Name = "rbtVerGomas";
            this.rbtVerGomas.Size = new System.Drawing.Size(94, 22);
            this.rbtVerGomas.TabIndex = 13;
            this.rbtVerGomas.TabStop = true;
            this.rbtVerGomas.Text = "Ver gomas";
            this.rbtVerGomas.UseVisualStyleBackColor = true;
            this.rbtVerGomas.CheckedChanged += new System.EventHandler(this.rbtVerGomas_CheckedChanged_1);
            // 
            // gbxUtilesDisponibles
            // 
            this.gbxUtilesDisponibles.Controls.Add(this.rbtVerGomas);
            this.gbxUtilesDisponibles.Controls.Add(this.rbtVerSacapuntas);
            this.gbxUtilesDisponibles.Controls.Add(this.rbtVerLapices);
            this.gbxUtilesDisponibles.Location = new System.Drawing.Point(16, 312);
            this.gbxUtilesDisponibles.Name = "gbxUtilesDisponibles";
            this.gbxUtilesDisponibles.Size = new System.Drawing.Size(338, 52);
            this.gbxUtilesDisponibles.TabIndex = 14;
            this.gbxUtilesDisponibles.TabStop = false;
            this.gbxUtilesDisponibles.Text = "Útiles disponibles para agregar en cartuchera";
            // 
            // btnAgregarUtil
            // 
            this.btnAgregarUtil.BackColor = System.Drawing.Color.Wheat;
            this.btnAgregarUtil.Location = new System.Drawing.Point(511, 371);
            this.btnAgregarUtil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarUtil.Name = "btnAgregarUtil";
            this.btnAgregarUtil.Size = new System.Drawing.Size(100, 63);
            this.btnAgregarUtil.TabIndex = 15;
            this.btnAgregarUtil.Text = "Agregar en cartuchera";
            this.btnAgregarUtil.UseVisualStyleBackColor = false;
            this.btnAgregarUtil.Click += new System.EventHandler(this.btnAgregarUtil_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Thistle;
            this.richTextBox1.Location = new System.Drawing.Point(619, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(159, 544);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // FormNuevaCartuchera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(790, 569);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnAgregarUtil);
            this.Controls.Add(this.gbxUtilesDisponibles);
            this.Controls.Add(this.dgdUtilesDisponibles);
            this.Controls.Add(this.btnVerLogs);
            this.Controls.Add(this.btnEditarUtiles);
            this.Controls.Add(this.btnMostrarCartuchera);
            this.Controls.Add(this.gbxNuevaCartuchera);
            this.Controls.Add(this.dgdCartucheras);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNuevaCartuchera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estefania Gomez Peverini - 2C";
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadCartuchera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCartucheras)).EndInit();
            this.gbxNuevaCartuchera.ResumeLayout(false);
            this.gbxNuevaCartuchera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUtilesDisponibles)).EndInit();
            this.gbxUtilesDisponibles.ResumeLayout(false);
            this.gbxUtilesDisponibles.PerformLayout();
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
        private System.Windows.Forms.Button btnEditarUtiles;
        private System.Windows.Forms.Button btnVerLogs;
        private System.Windows.Forms.DataGridView dgdUtilesDisponibles;
        private System.Windows.Forms.RadioButton rbtVerSacapuntas;
        private System.Windows.Forms.RadioButton rbtVerLapices;
        private System.Windows.Forms.RadioButton rbtVerGomas;
        private System.Windows.Forms.GroupBox gbxUtilesDisponibles;
        private System.Windows.Forms.Button btnAgregarUtil;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}