using Database.Repositorios;
using Negocio.Entidades;

namespace WindowsForms
{
    public partial class FuncionarioView : Form
    {
        public FuncionarioView()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var rg = mtxRg.Text;
            var cpf = mtxCpf.Text;
            var telefone = mtxTelefone.Text;
            var nome = txtNome.Text;
            var endereco = txtEndereco.Text;
            var nacionalidade = txtNacionalidade.Text;
            var cic = txtCic.Text;
            var sexo = cbmSexo.Text;
            var dataDeAdimissao = dtpAdimissao.MaxDate;
            var dataDeNascimento = dtpNascimento.MaxDate;
            var estadoCivil = cbmSexo.Text;

            var funcionarioCadastro = new Funcionario(cpf, nome, endereco, nacionalidade, rg, telefone, cic, sexo, dataDeAdimissao, dataDeNascimento, estadoCivil);
            var funcionarioRepository = new FuncionarioRepository();
            var resultado = funcionarioRepository.Inserir(funcionarioCadastro);


        }


    }
}