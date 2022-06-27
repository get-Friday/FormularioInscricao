namespace FormularioInscricao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Aqui será o momento de simular a inscrição do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            /*ToDo: Códigos*/

            MessageBox.Show("Olá Mundo !!!");
            MessageBox.Show($"Nome {txtNome.Text}");
            txtIdade.Text = "37";
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCurso.Text = "";
            txtEscolaridade.Text = "";
            txtDataNascimento.Text = "";
            txtIdade.Text = "";
        }
    }
}