
namespace TP2SebastianBarthe
{
    partial class Form1
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
            this.dgvCamaras = new System.Windows.Forms.DataGridView();
            this.pbxCamaras = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamaras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCamaras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCamaras
            // 
            this.dgvCamaras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamaras.Location = new System.Drawing.Point(12, 12);
            this.dgvCamaras.Name = "dgvCamaras";
            this.dgvCamaras.Size = new System.Drawing.Size(515, 246);
            this.dgvCamaras.TabIndex = 0;
            this.dgvCamaras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCamaras_CellContentClick);
            this.dgvCamaras.SelectionChanged += new System.EventHandler(this.dgvCamaras_SelectionChanged);
            // 
            // pbxCamaras
            // 
            this.pbxCamaras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCamaras.Location = new System.Drawing.Point(533, 12);
            this.pbxCamaras.Name = "pbxCamaras";
            this.pbxCamaras.Size = new System.Drawing.Size(273, 246);
            this.pbxCamaras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCamaras.TabIndex = 1;
            this.pbxCamaras.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(12, 264);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 30);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 387);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxCamaras);
            this.Controls.Add(this.dgvCamaras);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamaras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCamaras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCamaras;
        private System.Windows.Forms.PictureBox pbxCamaras;
        private System.Windows.Forms.Button btnAgregar;
    }
}

