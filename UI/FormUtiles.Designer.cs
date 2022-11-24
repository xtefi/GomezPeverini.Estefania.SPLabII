
namespace UI
{
    partial class FormUtiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtiles));
            this.dgdUtilesDisponibles = new System.Windows.Forms.DataGridView();
            this.rbtGomas = new System.Windows.Forms.RadioButton();
            this.rbtSacapuntas = new System.Windows.Forms.RadioButton();
            this.rbtLapices = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminaUtil = new System.Windows.Forms.Button();
            this.btnNuevoUtil = new System.Windows.Forms.Button();
            this.gbxUtiles = new System.Windows.Forms.GroupBox();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbxGoma = new System.Windows.Forms.GroupBox();
            this.tbxFormaGoma = new System.Windows.Forms.TextBox();
            this.lblForma = new System.Windows.Forms.Label();
            this.gbxLapiz = new System.Windows.Forms.GroupBox();
            this.tbxTamanoLapiz = new System.Windows.Forms.TextBox();
            this.tbxColorLapiz = new System.Windows.Forms.TextBox();
            this.lblTamanoLapiz = new System.Windows.Forms.Label();
            this.lblColorLapiz = new System.Windows.Forms.Label();
            this.gbxSacapuntas = new System.Windows.Forms.GroupBox();
            this.chbxDeposito = new System.Windows.Forms.CheckBox();
            this.lblConDeposito = new System.Windows.Forms.Label();
            this.tbxMaterialSacapuntas = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.tbxFormaSacapuntas = new System.Windows.Forms.TextBox();
            this.lblFormaSacapuntas = new System.Windows.Forms.Label();
            this.btnEditarUtilSeleccionado = new System.Windows.Forms.Button();
            this.btnConfirmaModificacion = new System.Windows.Forms.Button();
            this.btnSerializaXml = new System.Windows.Forms.Button();
            this.btnDeserealizaXml = new System.Windows.Forms.Button();
            this.btnSerializaJson = new System.Windows.Forms.Button();
            this.btnDeseralizaJson = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUtilesDisponibles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxUtiles.SuspendLayout();
            this.gbxGoma.SuspendLayout();
            this.gbxLapiz.SuspendLayout();
            this.gbxSacapuntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdUtilesDisponibles
            // 
            this.dgdUtilesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdUtilesDisponibles.BackgroundColor = System.Drawing.Color.Pink;
            this.dgdUtilesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdUtilesDisponibles.GridColor = System.Drawing.Color.Pink;
            this.dgdUtilesDisponibles.Location = new System.Drawing.Point(12, 86);
            this.dgdUtilesDisponibles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgdUtilesDisponibles.Name = "dgdUtilesDisponibles";
            this.dgdUtilesDisponibles.RowTemplate.Height = 25;
            this.dgdUtilesDisponibles.Size = new System.Drawing.Size(647, 199);
            this.dgdUtilesDisponibles.TabIndex = 6;
            // 
            // rbtGomas
            // 
            this.rbtGomas.AutoSize = true;
            this.rbtGomas.Location = new System.Drawing.Point(208, 27);
            this.rbtGomas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtGomas.Name = "rbtGomas";
            this.rbtGomas.Size = new System.Drawing.Size(71, 22);
            this.rbtGomas.TabIndex = 7;
            this.rbtGomas.TabStop = true;
            this.rbtGomas.Text = "Gomas";
            this.rbtGomas.UseVisualStyleBackColor = true;
            this.rbtGomas.CheckedChanged += new System.EventHandler(this.rbtGomas_CheckedChanged);
            // 
            // rbtSacapuntas
            // 
            this.rbtSacapuntas.AutoSize = true;
            this.rbtSacapuntas.Location = new System.Drawing.Point(100, 27);
            this.rbtSacapuntas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtSacapuntas.Name = "rbtSacapuntas";
            this.rbtSacapuntas.Size = new System.Drawing.Size(102, 22);
            this.rbtSacapuntas.TabIndex = 8;
            this.rbtSacapuntas.TabStop = true;
            this.rbtSacapuntas.Text = "Sacapuntas";
            this.rbtSacapuntas.UseVisualStyleBackColor = true;
            this.rbtSacapuntas.CheckedChanged += new System.EventHandler(this.rbtSacapuntas_CheckedChanged);
            // 
            // rbtLapices
            // 
            this.rbtLapices.AutoSize = true;
            this.rbtLapices.Location = new System.Drawing.Point(19, 26);
            this.rbtLapices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtLapices.Name = "rbtLapices";
            this.rbtLapices.Size = new System.Drawing.Size(75, 22);
            this.rbtLapices.TabIndex = 9;
            this.rbtLapices.TabStop = true;
            this.rbtLapices.Text = "Lapices";
            this.rbtLapices.UseVisualStyleBackColor = true;
            this.rbtLapices.CheckedChanged += new System.EventHandler(this.rbtLapices_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtLapices);
            this.groupBox1.Controls.Add(this.rbtGomas);
            this.groupBox1.Controls.Add(this.rbtSacapuntas);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(283, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escoja útil para cargar:";
            // 
            // btnEliminaUtil
            // 
            this.btnEliminaUtil.BackColor = System.Drawing.Color.Wheat;
            this.btnEliminaUtil.Location = new System.Drawing.Point(425, 18);
            this.btnEliminaUtil.Name = "btnEliminaUtil";
            this.btnEliminaUtil.Size = new System.Drawing.Size(108, 60);
            this.btnEliminaUtil.TabIndex = 11;
            this.btnEliminaUtil.Text = "Eliminar util seleccionado";
            this.btnEliminaUtil.UseVisualStyleBackColor = false;
            this.btnEliminaUtil.Click += new System.EventHandler(this.btnEliminaUtil_Click);
            // 
            // btnNuevoUtil
            // 
            this.btnNuevoUtil.BackColor = System.Drawing.Color.Wheat;
            this.btnNuevoUtil.Location = new System.Drawing.Point(301, 18);
            this.btnNuevoUtil.Name = "btnNuevoUtil";
            this.btnNuevoUtil.Size = new System.Drawing.Size(108, 60);
            this.btnNuevoUtil.TabIndex = 12;
            this.btnNuevoUtil.Text = "Agregar nuevo útil";
            this.btnNuevoUtil.UseVisualStyleBackColor = false;
            this.btnNuevoUtil.Click += new System.EventHandler(this.btnNuevoUtil_Click);
            // 
            // gbxUtiles
            // 
            this.gbxUtiles.Controls.Add(this.tbxMarca);
            this.gbxUtiles.Controls.Add(this.tbxPrecio);
            this.gbxUtiles.Controls.Add(this.lblPrecio);
            this.gbxUtiles.Controls.Add(this.lblMarca);
            this.gbxUtiles.Location = new System.Drawing.Point(14, 292);
            this.gbxUtiles.Name = "gbxUtiles";
            this.gbxUtiles.Size = new System.Drawing.Size(182, 96);
            this.gbxUtiles.TabIndex = 13;
            this.gbxUtiles.TabStop = false;
            this.gbxUtiles.Text = "Nuevo util";
            // 
            // tbxMarca
            // 
            this.tbxMarca.Location = new System.Drawing.Point(64, 24);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(100, 26);
            this.tbxMarca.TabIndex = 3;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(64, 56);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(100, 26);
            this.tbxPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 59);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 18);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 27);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 18);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Wheat;
            this.btnConfirmar.Location = new System.Drawing.Point(606, 296);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(142, 49);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar alta";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbxGoma
            // 
            this.gbxGoma.Controls.Add(this.tbxFormaGoma);
            this.gbxGoma.Controls.Add(this.lblForma);
            this.gbxGoma.Location = new System.Drawing.Point(404, 292);
            this.gbxGoma.Name = "gbxGoma";
            this.gbxGoma.Size = new System.Drawing.Size(170, 59);
            this.gbxGoma.TabIndex = 18;
            this.gbxGoma.TabStop = false;
            this.gbxGoma.Text = "Gomas";
            // 
            // tbxFormaGoma
            // 
            this.tbxFormaGoma.Location = new System.Drawing.Point(64, 19);
            this.tbxFormaGoma.Name = "tbxFormaGoma";
            this.tbxFormaGoma.Size = new System.Drawing.Size(100, 26);
            this.tbxFormaGoma.TabIndex = 16;
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Location = new System.Drawing.Point(6, 22);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(54, 18);
            this.lblForma.TabIndex = 15;
            this.lblForma.Text = "Forma:";
            // 
            // gbxLapiz
            // 
            this.gbxLapiz.Controls.Add(this.tbxTamanoLapiz);
            this.gbxLapiz.Controls.Add(this.tbxColorLapiz);
            this.gbxLapiz.Controls.Add(this.lblTamanoLapiz);
            this.gbxLapiz.Controls.Add(this.lblColorLapiz);
            this.gbxLapiz.Location = new System.Drawing.Point(202, 292);
            this.gbxLapiz.Name = "gbxLapiz";
            this.gbxLapiz.Size = new System.Drawing.Size(196, 96);
            this.gbxLapiz.TabIndex = 18;
            this.gbxLapiz.TabStop = false;
            this.gbxLapiz.Text = "Lápices";
            // 
            // tbxTamanoLapiz
            // 
            this.tbxTamanoLapiz.Location = new System.Drawing.Point(76, 53);
            this.tbxTamanoLapiz.Name = "tbxTamanoLapiz";
            this.tbxTamanoLapiz.Size = new System.Drawing.Size(100, 26);
            this.tbxTamanoLapiz.TabIndex = 17;
            // 
            // tbxColorLapiz
            // 
            this.tbxColorLapiz.Location = new System.Drawing.Point(76, 19);
            this.tbxColorLapiz.Name = "tbxColorLapiz";
            this.tbxColorLapiz.Size = new System.Drawing.Size(100, 26);
            this.tbxColorLapiz.TabIndex = 16;
            // 
            // lblTamanoLapiz
            // 
            this.lblTamanoLapiz.AutoSize = true;
            this.lblTamanoLapiz.Location = new System.Drawing.Point(6, 56);
            this.lblTamanoLapiz.Name = "lblTamanoLapiz";
            this.lblTamanoLapiz.Size = new System.Drawing.Size(61, 18);
            this.lblTamanoLapiz.TabIndex = 14;
            this.lblTamanoLapiz.Text = "Tamaño";
            // 
            // lblColorLapiz
            // 
            this.lblColorLapiz.AutoSize = true;
            this.lblColorLapiz.Location = new System.Drawing.Point(6, 22);
            this.lblColorLapiz.Name = "lblColorLapiz";
            this.lblColorLapiz.Size = new System.Drawing.Size(46, 18);
            this.lblColorLapiz.TabIndex = 15;
            this.lblColorLapiz.Text = "Color:";
            // 
            // gbxSacapuntas
            // 
            this.gbxSacapuntas.Controls.Add(this.chbxDeposito);
            this.gbxSacapuntas.Controls.Add(this.lblConDeposito);
            this.gbxSacapuntas.Controls.Add(this.tbxMaterialSacapuntas);
            this.gbxSacapuntas.Controls.Add(this.lblMaterial);
            this.gbxSacapuntas.Controls.Add(this.tbxFormaSacapuntas);
            this.gbxSacapuntas.Controls.Add(this.lblFormaSacapuntas);
            this.gbxSacapuntas.Location = new System.Drawing.Point(202, 292);
            this.gbxSacapuntas.Name = "gbxSacapuntas";
            this.gbxSacapuntas.Size = new System.Drawing.Size(333, 96);
            this.gbxSacapuntas.TabIndex = 19;
            this.gbxSacapuntas.TabStop = false;
            this.gbxSacapuntas.Text = "Sacapuntas";
            // 
            // chbxDeposito
            // 
            this.chbxDeposito.AutoSize = true;
            this.chbxDeposito.Location = new System.Drawing.Point(297, 26);
            this.chbxDeposito.Name = "chbxDeposito";
            this.chbxDeposito.Size = new System.Drawing.Size(15, 14);
            this.chbxDeposito.TabIndex = 21;
            this.chbxDeposito.UseVisualStyleBackColor = true;
            // 
            // lblConDeposito
            // 
            this.lblConDeposito.AutoSize = true;
            this.lblConDeposito.Location = new System.Drawing.Point(193, 23);
            this.lblConDeposito.Name = "lblConDeposito";
            this.lblConDeposito.Size = new System.Drawing.Size(98, 18);
            this.lblConDeposito.TabIndex = 20;
            this.lblConDeposito.Text = "Con Depósito:";
            // 
            // tbxMaterialSacapuntas
            // 
            this.tbxMaterialSacapuntas.Location = new System.Drawing.Point(79, 52);
            this.tbxMaterialSacapuntas.Name = "tbxMaterialSacapuntas";
            this.tbxMaterialSacapuntas.Size = new System.Drawing.Size(100, 26);
            this.tbxMaterialSacapuntas.TabIndex = 19;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(6, 55);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(67, 18);
            this.lblMaterial.TabIndex = 18;
            this.lblMaterial.Text = "Material:";
            // 
            // tbxFormaSacapuntas
            // 
            this.tbxFormaSacapuntas.Location = new System.Drawing.Point(79, 19);
            this.tbxFormaSacapuntas.Name = "tbxFormaSacapuntas";
            this.tbxFormaSacapuntas.Size = new System.Drawing.Size(100, 26);
            this.tbxFormaSacapuntas.TabIndex = 16;
            // 
            // lblFormaSacapuntas
            // 
            this.lblFormaSacapuntas.AutoSize = true;
            this.lblFormaSacapuntas.Location = new System.Drawing.Point(6, 23);
            this.lblFormaSacapuntas.Name = "lblFormaSacapuntas";
            this.lblFormaSacapuntas.Size = new System.Drawing.Size(54, 18);
            this.lblFormaSacapuntas.TabIndex = 15;
            this.lblFormaSacapuntas.Text = "Forma:";
            // 
            // btnEditarUtilSeleccionado
            // 
            this.btnEditarUtilSeleccionado.BackColor = System.Drawing.Color.Wheat;
            this.btnEditarUtilSeleccionado.Location = new System.Drawing.Point(551, 18);
            this.btnEditarUtilSeleccionado.Name = "btnEditarUtilSeleccionado";
            this.btnEditarUtilSeleccionado.Size = new System.Drawing.Size(108, 60);
            this.btnEditarUtilSeleccionado.TabIndex = 20;
            this.btnEditarUtilSeleccionado.Text = "Editar util seleccionado";
            this.btnEditarUtilSeleccionado.UseVisualStyleBackColor = false;
            this.btnEditarUtilSeleccionado.Click += new System.EventHandler(this.btnEditarUtilSeleccionado_Click);
            // 
            // btnConfirmaModificacion
            // 
            this.btnConfirmaModificacion.BackColor = System.Drawing.Color.Wheat;
            this.btnConfirmaModificacion.Location = new System.Drawing.Point(606, 351);
            this.btnConfirmaModificacion.Name = "btnConfirmaModificacion";
            this.btnConfirmaModificacion.Size = new System.Drawing.Size(142, 49);
            this.btnConfirmaModificacion.TabIndex = 21;
            this.btnConfirmaModificacion.Text = "Confirmar modificación";
            this.btnConfirmaModificacion.UseVisualStyleBackColor = false;
            this.btnConfirmaModificacion.Click += new System.EventHandler(this.btnConfirmaModificacion_Click);
            // 
            // btnSerializaXml
            // 
            this.btnSerializaXml.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSerializaXml.Location = new System.Drawing.Point(662, 86);
            this.btnSerializaXml.Name = "btnSerializaXml";
            this.btnSerializaXml.Size = new System.Drawing.Size(94, 45);
            this.btnSerializaXml.TabIndex = 22;
            this.btnSerializaXml.Text = "Serializar lápiz xml";
            this.btnSerializaXml.UseVisualStyleBackColor = false;
            this.btnSerializaXml.Click += new System.EventHandler(this.btnSerializaXml_Click);
            // 
            // btnDeserealizaXml
            // 
            this.btnDeserealizaXml.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDeserealizaXml.Location = new System.Drawing.Point(662, 137);
            this.btnDeserealizaXml.Name = "btnDeserealizaXml";
            this.btnDeserealizaXml.Size = new System.Drawing.Size(94, 45);
            this.btnDeserealizaXml.TabIndex = 23;
            this.btnDeserealizaXml.Text = "Deserializar lápiz xml";
            this.btnDeserealizaXml.UseVisualStyleBackColor = false;
            this.btnDeserealizaXml.Click += new System.EventHandler(this.btnDeserealizaXml_Click);
            // 
            // btnSerializaJson
            // 
            this.btnSerializaJson.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSerializaJson.Location = new System.Drawing.Point(662, 188);
            this.btnSerializaJson.Name = "btnSerializaJson";
            this.btnSerializaJson.Size = new System.Drawing.Size(94, 45);
            this.btnSerializaJson.TabIndex = 24;
            this.btnSerializaJson.Text = "Serializar lápiz json";
            this.btnSerializaJson.UseVisualStyleBackColor = false;
            this.btnSerializaJson.Click += new System.EventHandler(this.btnSerializaJson_Click);
            // 
            // btnDeseralizaJson
            // 
            this.btnDeseralizaJson.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDeseralizaJson.Location = new System.Drawing.Point(662, 239);
            this.btnDeseralizaJson.Name = "btnDeseralizaJson";
            this.btnDeseralizaJson.Size = new System.Drawing.Size(94, 45);
            this.btnDeseralizaJson.TabIndex = 25;
            this.btnDeseralizaJson.Text = "Deserializar lápiz json";
            this.btnDeseralizaJson.UseVisualStyleBackColor = false;
            this.btnDeseralizaJson.Click += new System.EventHandler(this.btnDeseralizaJson_Click);
            // 
            // lblHora
            // 
            this.lblHora.ForeColor = System.Drawing.Color.Aqua;
            this.lblHora.Location = new System.Drawing.Point(665, 18);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(83, 60);
            this.lblHora.TabIndex = 26;
            this.lblHora.Text = " ";
            // 
            // FormUtiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(760, 414);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnDeseralizaJson);
            this.Controls.Add(this.btnSerializaJson);
            this.Controls.Add(this.btnDeserealizaXml);
            this.Controls.Add(this.btnSerializaXml);
            this.Controls.Add(this.btnConfirmaModificacion);
            this.Controls.Add(this.btnEditarUtilSeleccionado);
            this.Controls.Add(this.gbxSacapuntas);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbxLapiz);
            this.Controls.Add(this.gbxGoma);
            this.Controls.Add(this.gbxUtiles);
            this.Controls.Add(this.btnNuevoUtil);
            this.Controls.Add(this.btnEliminaUtil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgdUtilesDisponibles);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormUtiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUtiles";
            ((System.ComponentModel.ISupportInitialize)(this.dgdUtilesDisponibles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxUtiles.ResumeLayout(false);
            this.gbxUtiles.PerformLayout();
            this.gbxGoma.ResumeLayout(false);
            this.gbxGoma.PerformLayout();
            this.gbxLapiz.ResumeLayout(false);
            this.gbxLapiz.PerformLayout();
            this.gbxSacapuntas.ResumeLayout(false);
            this.gbxSacapuntas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgdUtilesDisponibles;
        private System.Windows.Forms.RadioButton rbtGomas;
        private System.Windows.Forms.RadioButton rbtSacapuntas;
        private System.Windows.Forms.RadioButton rbtLapices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminaUtil;
        private System.Windows.Forms.Button btnNuevoUtil;
        private System.Windows.Forms.GroupBox gbxUtiles;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gbxGoma;
        private System.Windows.Forms.TextBox tbxFormaGoma;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.GroupBox gbxLapiz;
        private System.Windows.Forms.TextBox tbxTamanoLapiz;
        private System.Windows.Forms.TextBox tbxColorLapiz;
        private System.Windows.Forms.Label lblTamanoLapiz;
        private System.Windows.Forms.Label lblColorLapiz;
        private System.Windows.Forms.GroupBox gbxSacapuntas;
        private System.Windows.Forms.TextBox tbxMaterialSacapuntas;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.TextBox tbxFormaSacapuntas;
        private System.Windows.Forms.Label lblFormaSacapuntas;
        private System.Windows.Forms.CheckBox chbxDeposito;
        private System.Windows.Forms.Label lblConDeposito;
        private System.Windows.Forms.Button btnEditarUtilSeleccionado;
        private System.Windows.Forms.Button btnConfirmaModificacion;
        private System.Windows.Forms.Button btnSerializaXml;
        private System.Windows.Forms.Button btnDeserealizaXml;
        private System.Windows.Forms.Button btnSerializaJson;
        private System.Windows.Forms.Button btnDeseralizaJson;
        private System.Windows.Forms.Label lblHora;
    }
}