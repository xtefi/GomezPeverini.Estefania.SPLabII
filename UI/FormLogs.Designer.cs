
namespace UI
{
    partial class FormLogs
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
            this.rtbxLogs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbxLogs
            // 
            this.rtbxLogs.Location = new System.Drawing.Point(12, 12);
            this.rtbxLogs.Name = "rtbxLogs";
            this.rtbxLogs.Size = new System.Drawing.Size(468, 230);
            this.rtbxLogs.TabIndex = 0;
            this.rtbxLogs.Text = "";
            // 
            // FormLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 318);
            this.Controls.Add(this.rtbxLogs);
            this.Name = "FormLogs";
            this.Text = "FormLogs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxLogs;
    }
}