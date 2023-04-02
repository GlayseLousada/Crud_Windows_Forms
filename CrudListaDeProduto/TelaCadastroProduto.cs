using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudListaDeProduto
{
    public partial class TelaDeCadastroDeProduto : Form
    {
        private static int _Id = 1;

        private readonly static BindingList<Produto> _listaProdutos = new BindingList<Produto>();
        private DataGridView _dataGrid;

        public TelaDeCadastroDeProduto(DataGridView dataGridView)
        {
            InitializeComponent();
            _dataGrid = dataGridView;
        }

        private void AoClicarNoBotaoSair(object sender, EventArgs e)
        {
            Close();
        }

        private void AoClicarNoBotaoSalvar(object sender, EventArgs e)
        {

            Produto produto = new Produto();
            produto.Id = _Id;
            produto.Nome = campoTextoNome.Text;
            produto.Marca = campoTextoMarca.Text;
            produto.DataDeVencimento = dataDeVencimento.Value;
            produto.Preço = decimal.Parse(campoDeTextoPreço.Text);

            _listaProdutos.Add(produto);

            

            Close();

            _dataGrid.DataSource = _listaProdutos;
            _Id++;
        }

        private void AoInformarPreco_KeyPess(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula");
            }

        }
    }
}
