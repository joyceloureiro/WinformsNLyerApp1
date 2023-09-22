using Database.Repositorios;
using Negocio.Entidades;
using Negocio.Validators;

namespace WindowsForms.telas.Cargos
{
    public partial class CargoView : Form
    {
        
        public CargoView()
        {
            InitializeComponent();
        }


        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
        }

        private void txtSalvar_Click(object sender, EventArgs e)

        {
            var nome = txtCargo.Text;
            var status = chkStatus.Checked;

            var novoCargo = new Cargo(nome, status);

            var erros = Validacoes.ValidarDataAnotattion(novoCargo);

            foreach (var erro in erros)
            {
                MessageBox.Show(erro.ErrorMessage);
                return;
            }


            var cargoRepository = new CargoRepository();
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

            if (gvCargos.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resultado = cargoRepository.Deletar(int.Parse(row.Cells[1].Value.ToString()));
                };
                return;
            }

            if (e.RowIndex >= 0)
            {
                groupBoxCargo.Show();

                txtCargo.Text = row.Cells[1].Value.ToString();
                //id = row.Cells[3].Value;
                chkStatus.Checked = Convert.ToBoolean(row.Cells[2].Value.ToString());
            }
           // if (gvCargos.Columns[e.ColumnIndex].Name == "Delete")
        }

        private void btnRegarregar_Click(object sender, EventArgs e)
        {


            var nome = txtCargo.Text;
            var status = chkStatus.Checked;

            var novoCargo = new Cargo(nome, status);
            var cargoRepository = new CargoRepository();


            var resultado = cargoRepository.Atualizar(novoCargo);



        }
    }
}
