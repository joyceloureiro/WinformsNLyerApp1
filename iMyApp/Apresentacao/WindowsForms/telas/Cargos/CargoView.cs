using Database.Repositorios;
using Negocio.Entidades;
using Negocio.Validators;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsForms.telas.Cargos
{
    public partial class CargoView : Form
    {
        int id = -1;

        public CargoView()
        {
            InitializeComponent();
        }


        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
        }

        private void btnSalvar_Click(object sender, EventArgs e)

        {
            var nome = txtCargo.Text;
            var status = chkStatus.Checked;
            Button? button = sender as Button;

            var novoCargo = new Cargo(nome, status);
            var erros = Validacoes.ValidarDataAnotattion(novoCargo);

            foreach (var erro in erros)
            {
                MessageBox.Show(erro.ErrorMessage);
                return;
            }


            var cargoRepository = new CargoRepository();

            switch (button.Text)
            {
                case "Cadastrar":
                    {
                        var resultado = cargoRepository.Inserir(novoCargo);

                        if (resultado)
                        {
                            MessageBox.Show("Cargo Cadastrado com Sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Erro! Verifique e Tente Novamente.");
                        }
                        break;
                    }
                case "Atualizar":
                    {
                        var resultado = cargoRepository.Atualizar(novoCargo, id);
                        if (resultado)
                        {
                            MessageBox.Show("Cargo Atualizado com Sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Erro! Verifique e Tente Novamente.");
                        }
                        break;
                    }
                default:
                    break;
            }
            var resultado = cargoRepository.Inserir(novoCargo);

            if (resultado)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o cargo");
            }

        }

        private void CargoView_Load(object sender, EventArgs e)
        {

            var cargoRepository = new CargoRepository();
            var dataTable = cargoRepository.ObterTodos();
            gvCargos.DataSource = dataTable;

        }

        private void gvCargos_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cargoRepository = new CargoRepository();
            DataGridViewRow row = gvCargos.Rows[e.RowIndex];

            if (gvCargos.Columns[e.ColumnIndex].Name == "Deletar")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resulatdo = cargoRepository.Deletar(Convert.ToInt32(row.Cells[1].Value));
                    MessageBox.Show("Registro deletado com sucesso!");
                };
                return;
            }

            if (e.RowIndex >= 0)
            {
                btnSalvar.Text = "Atualizar";
                groupBoxCargo.Show();
                id = Convert.ToInt32(row.Cells[1].Value);
                txtCargo.Text = row.Cells[2].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(row.Cells[3].Value.ToString());
            }
            // if (gvCargos.Columns[e.ColumnIndex].Name == "Delete")
        }
        private void TabelaCargo()
        {
            var cargoRepository = new CargoRepository();

            var obterTodos = cargoRepository.ObterTodos();

            gvCargos.DataSource = obterTodos;
        }


        private void btnRegarregar_Click(object sender, EventArgs e)
        {
            TabelaCargo();

        }
    }
}
