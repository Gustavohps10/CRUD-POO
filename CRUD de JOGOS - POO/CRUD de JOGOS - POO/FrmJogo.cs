using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_de_JOGOS___POO
{
    public partial class FrmJogo : Form
    {
        public FrmJogo()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string data = dtpDataLancamento.Value.ToString("yyyy-MM-dd");
            Jogo jogo = new Jogo();
            jogo.Inserir(txtNome.Text, data, txtDesenvolvedor.Text, txtGenero.Text);
            MessageBox.Show("Jogo Inserido com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Jogo> jogos = jogo.ListaJogos();
            dgvJogo.DataSource = jogos;
            txtNome.Text = string.Empty;
            txtDesenvolvedor.Text = string.Empty;
            txtGenero.Text = string.Empty;
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            List<Jogo> jogos = jogo.ListaJogos();
            dgvJogo.DataSource = jogos;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Jogo jogo = new Jogo();
            jogo.Localiza(id);
            txtNome.Text = jogo.nome;
            txtDesenvolvedor.Text = jogo.desenvolvedor;
            txtGenero.Text = jogo.genero;
            dtpDataLancamento.Value = Convert.ToDateTime(jogo.data_lancamento);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            string data = dtpDataLancamento.Value.ToString("yyyy-MM-dd");
            Jogo jogo = new Jogo();
            jogo.Atualizar(id, txtNome.Text, data, txtDesenvolvedor.Text, txtGenero.Text);
            MessageBox.Show("Jogo Atualizado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Jogo> jogos = jogo.ListaJogos();
            dgvJogo.DataSource = jogos;
            txtNome.Text = string.Empty;
            txtDesenvolvedor.Text = string.Empty;
            txtGenero.Text = string.Empty;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            string data = dtpDataLancamento.Value.ToString("yyyy-MM-dd");
            Jogo jogo = new Jogo();
            jogo.Deletar(id);
            MessageBox.Show("Jogo Excluido com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Jogo> jogos = jogo.ListaJogos();
            dgvJogo.DataSource = jogos;
            txtNome.Text = string.Empty;
            txtDesenvolvedor.Text = string.Empty;
            txtGenero.Text = string.Empty;
        }
    }
}