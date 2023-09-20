using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.Db;
using Empresa.Models;


namespace Empresa.UI.Windows
{
    public partial class ProdutoForm1 : Form
    {
        public ProdutoForm1()
        {
            InitializeComponent();
        }

        private void Idlabel1_Click(object sender, EventArgs e)
        {
            var f = new ProdutoIncluir();
                f.ShowDialog();
        }

        private void ExibirGrid()
        {
            listaDataGridView1.Visible = true;
            listaDataGridView1.Dock = DockStyle.Fill;
            fichaPanel3.Visible = false;
            NovoButton.Visible = true;
            alterarButton.Visible = true;
            excluirButton.Visible = true;
            sairButton.Visible = true;
            confirmaralterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            gravarIncluirButton.Visible = false;
            voltarButton.Visible = false;

            var db = new ProdutoDb();
            listaDataGridView1.DataSource = db.Listar();
            listaDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaDataGridView1.ReadOnly = false;
            listaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaDataGridView1.RowHeadersVisible = false;
            listaDataGridView1.EnableHeadersVisualStyles = false;
            listaDataGridView1.Columns["Id"].Width = 50;



        }
        private void ProdutoForm1_Load(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.Id = Convert.ToInt32(IdtextBox1.Text);
            produto.Nome = NometextBox2.Text;

            var db = new ProdutoDb();
            db.Excluir(produto.Id);
            ExibirGrid();
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();

            confirmaralterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            gravarIncluirButton.Visible = true;

            LimpaFicha();
        }

        private void ExibirFicha()
        {
            fichaPanel3.Visible = true;
            fichaPanel3.Dock = DockStyle.Fill;
            listaDataGridView1.Visible = false;
            NovoButton.Visible = false;
            alterarButton.Visible = false;
            excluirButton.Visible = false;
            sairButton.Visible = true;
            confirmaralterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            gravarIncluirButton.Visible = true;
            voltarButton.Visible = true;

            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void gravarIncluirButton_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.Id = Convert.ToInt32(IdtextBox1.Text);
            produto.Nome = NometextBox2.Text;

            var db = new ProdutoDb();
            db.Incluir(produto);
            ExibirGrid();

        }
        private void LimpaFicha()
        {
            IdtextBox1.Clear();
            NometextBox2.Clear();
            IdtextBox1.Focus();

        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)listaDataGridView1.CurrentRow.DataBoundItem;
            IdtextBox1.Text = produto.Id.ToString();
            NometextBox2.Text = produto.Nome.ToString();
            ExibirFicha();

           

            confirmaralterarButton.Visible = true;
            confirmarExcluirButton.Visible = false;
            gravarIncluirButton.Visible = false;

            

        }

        private void confirmaralterarButton_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.Id = Convert.ToInt32(IdtextBox1.Text);
            produto.Nome = NometextBox2.Text;

            var db = new ProdutoDb();
            db.Alterar(produto);
            ExibirGrid();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)listaDataGridView1.CurrentRow.DataBoundItem;
            IdtextBox1.Text = produto.Id.ToString();
            NometextBox2.Text = produto.Nome.ToString();
            ExibirFicha();



            confirmaralterarButton.Visible = false;
            confirmarExcluirButton.Visible = true;
            gravarIncluirButton.Visible = false;
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
