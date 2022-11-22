
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblContiene = new System.Windows.Forms.Label();
            this.dgdUtilesDisponibles = new System.Windows.Forms.DataGridView();
            this.rbtGomas = new System.Windows.Forms.RadioButton();
            this.rbtSacapuntas = new System.Windows.Forms.RadioButton();
            this.rbtLapices = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminaUtil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUtilesDisponibles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(651, 140);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblContiene
            // 
            this.lblContiene.AutoSize = true;
            this.lblContiene.Location = new System.Drawing.Point(14, 11);
            this.lblContiene.Name = "lblContiene";
            this.lblContiene.Size = new System.Drawing.Size(158, 18);
            this.lblContiene.TabIndex = 3;
            this.lblContiene.Text = "Utiles en la cartuchera:";
            // 
            // dgdUtilesDisponibles
            // 
            this.dgdUtilesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdUtilesDisponibles.Location = new System.Drawing.Point(14, 304);
            this.dgdUtilesDisponibles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgdUtilesDisponibles.Name = "dgdUtilesDisponibles";
            this.dgdUtilesDisponibles.RowTemplate.Height = 25;
            this.dgdUtilesDisponibles.Size = new System.Drawing.Size(651, 180);
            this.dgdUtilesDisponibles.TabIndex = 6;
            // 
            // rbtGomas
            // 
            this.rbtGomas.AutoSize = true;
            this.rbtGomas.Location = new System.Drawing.Point(282, 26);
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
            this.rbtSacapuntas.Location = new System.Drawing.Point(151, 26);
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
            this.groupBox1.Location = new System.Drawing.Point(14, 220);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(397, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escoja útil para cargar:";
            // 
            // btnEliminaUtil
            // 
            this.btnEliminaUtil.Location = new System.Drawing.Point(635, 491);
            this.btnEliminaUtil.Name = "btnEliminaUtil";
            this.btnEliminaUtil.Size = new System.Drawing.Size(108, 53);
            this.btnEliminaUtil.TabIndex = 11;
            this.btnEliminaUtil.Text = "Eliminar util seleccionado";
            this.btnEliminaUtil.UseVisualStyleBackColor = true;
            this.btnEliminaUtil.Click += new System.EventHandler(this.btnEliminaUtil_Click);
            // 
            // FormUtiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 549);
            this.Controls.Add(this.btnEliminaUtil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgdUtilesDisponibles);
            this.Controls.Add(this.lblContiene);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUtiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUtiles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUtilesDisponibles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblContiene;
        private System.Windows.Forms.DataGridView dgdUtilesDisponibles;
        private System.Windows.Forms.RadioButton rbtGomas;
        private System.Windows.Forms.RadioButton rbtSacapuntas;
        private System.Windows.Forms.RadioButton rbtLapices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminaUtil;
    }
}