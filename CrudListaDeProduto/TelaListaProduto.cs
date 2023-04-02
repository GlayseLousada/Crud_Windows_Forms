namespace CrudListaDeProduto
{
    public partial class TelaDeListaDeProduto : Form
    {
        public TelaDeListaDeProduto()
        {
            InitializeComponent();
        }

        private void AoClicarNoBotaoSair(object sender, EventArgs e)
        {
            Close();
        }

        private void AoClicarNoBotaoRemover(object sender, EventArgs e)
        {

        }

        private void AoClicarNoBotaoAtualizar(object sender, EventArgs e)
        {

        }

        private void AoClicarNoBotaoCadastrar(object sender, EventArgs e)
        {
            TelaDeCadastroDeProduto telaDeCadastroDeProduto = new TelaDeCadastroDeProduto(dataGridView1);
            telaDeCadastroDeProduto.Show();
        }
    }
}