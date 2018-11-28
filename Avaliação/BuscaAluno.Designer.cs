namespace insert_csharp
{
    partial class BuscaAluno
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbIDAluno = new System.Windows.Forms.ComboBox();
            this.lblIDAluno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbIDAluno);
            this.groupBox3.Controls.Add(this.lblIDAluno);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox3.ForeColor = System.Drawing.Color.Turquoise;
            this.groupBox3.Location = new System.Drawing.Point(12, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 144);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Excluir Aluno";
            // 
            // cbIDAluno
            // 
            this.cbIDAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbIDAluno.FormattingEnabled = true;
            this.cbIDAluno.Location = new System.Drawing.Point(41, 30);
            this.cbIDAluno.Name = "cbIDAluno";
            this.cbIDAluno.Size = new System.Drawing.Size(155, 25);
            this.cbIDAluno.TabIndex = 11;
            this.cbIDAluno.SelectedValueChanged += new System.EventHandler(this.cbIDAluno_SelectedValueChanged);
            // 
            // lblIDAluno
            // 
            this.lblIDAluno.AutoSize = true;
            this.lblIDAluno.BackColor = System.Drawing.SystemColors.Control;
            this.lblIDAluno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAluno.Location = new System.Drawing.Point(141, 76);
            this.lblIDAluno.Name = "lblIDAluno";
            this.lblIDAluno.Size = new System.Drawing.Size(260, 17);
            this.lblIDAluno.TabIndex = 10;
            this.lblIDAluno.Text = "Atenção esta ação não pode ser desfeita.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Location = new System.Drawing.Point(12, 109);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(524, 29);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtBuscarAluno);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvAluno);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.Turquoise;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 241);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(470, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarAluno.Location = new System.Drawing.Point(125, 29);
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.Size = new System.Drawing.Size(339, 25);
            this.txtBuscarAluno.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome do Aluno:";
            // 
            // dgvAluno
            // 
            this.dgvAluno.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(8, 62);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(528, 173);
            this.dgvAluno.TabIndex = 0;
            // 
            // BuscaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuscaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Aluno";
            this.Load += new System.EventHandler(this.BuscaAluno_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Label lblIDAluno;
        private System.Windows.Forms.ComboBox cbIDAluno;
    }
}