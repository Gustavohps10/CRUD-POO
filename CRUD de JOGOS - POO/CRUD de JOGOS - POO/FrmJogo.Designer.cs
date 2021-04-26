
namespace CRUD_de_JOGOS___POO
{
    partial class FrmJogo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvJogo = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDesenvolvedor = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblDataLancamento = new System.Windows.Forms.Label();
            this.lblDesenvolvedor = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dtpDataLancamento = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(474, 10);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(101, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvJogo
            // 
            this.dgvJogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogo.Location = new System.Drawing.Point(22, 198);
            this.dgvJogo.Name = "dgvJogo";
            this.dgvJogo.Size = new System.Drawing.Size(553, 188);
            this.dgvJogo.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtDesenvolvedor
            // 
            this.txtDesenvolvedor.Location = new System.Drawing.Point(119, 126);
            this.txtDesenvolvedor.Name = "txtDesenvolvedor";
            this.txtDesenvolvedor.Size = new System.Drawing.Size(232, 20);
            this.txtDesenvolvedor.TabIndex = 5;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(119, 162);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(232, 20);
            this.txtGenero.TabIndex = 6;
            // 
            // lblDataLancamento
            // 
            this.lblDataLancamento.AutoSize = true;
            this.lblDataLancamento.Location = new System.Drawing.Point(21, 98);
            this.lblDataLancamento.Name = "lblDataLancamento";
            this.lblDataLancamento.Size = new System.Drawing.Size(92, 13);
            this.lblDataLancamento.TabIndex = 7;
            this.lblDataLancamento.Text = "Data Lançamento";
            // 
            // lblDesenvolvedor
            // 
            this.lblDesenvolvedor.AutoSize = true;
            this.lblDesenvolvedor.Location = new System.Drawing.Point(21, 133);
            this.lblDesenvolvedor.Name = "lblDesenvolvedor";
            this.lblDesenvolvedor.Size = new System.Drawing.Size(79, 13);
            this.lblDesenvolvedor.TabIndex = 8;
            this.lblDesenvolvedor.Text = "Desenvolvedor";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(21, 169);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 9;
            this.lblGenero.Text = "Gênero";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(474, 80);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(101, 23);
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(474, 46);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(101, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(276, 9);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 12;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "ID";
            // 
            // dtpDataLancamento
            // 
            this.dtpDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLancamento.Location = new System.Drawing.Point(119, 92);
            this.dtpDataLancamento.Name = "dtpDataLancamento";
            this.dtpDataLancamento.Size = new System.Drawing.Size(232, 20);
            this.dtpDataLancamento.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(474, 160);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 23);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 408);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dtpDataLancamento);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblDesenvolvedor);
            this.Controls.Add(this.lblDataLancamento);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtDesenvolvedor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvJogo);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Jogo";
            this.Load += new System.EventHandler(this.FrmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvJogo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDesenvolvedor;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblDataLancamento;
        private System.Windows.Forms.Label lblDesenvolvedor;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DateTimePicker dtpDataLancamento;
        private System.Windows.Forms.Button btnSair;
    }
}

