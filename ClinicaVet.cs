using Microsoft.VisualBasic.ApplicationServices;

namespace clinicaVet
{
    public partial class ClinicaVet : Form
    {
        private animal b;
        public ClinicaVet()
        {
            InitializeComponent();
            b = new animal();
            gerarcolunas();
        }
        public void gerarcolunas()
        {
            ltvTodos.Columns.Add("Nome", 200).TextAlign = HorizontalAlignment.Center;
            ltvTodos.Columns.Add("Raça", 200).TextAlign = HorizontalAlignment.Center;
            ltvTodos.Columns.Add("Data de nascimento", 0).TextAlign = HorizontalAlignment.Center;
            ltvTodos.Columns.Add("Data última consulta", 250).TextAlign = HorizontalAlignment.Center;
            ltvTodos.Columns.Add("Veterinário", 0).TextAlign = HorizontalAlignment.Center;
            ltvTodos.Columns.Add("Enfermidade", 0).TextAlign = HorizontalAlignment.Center;
            ltvTodos.Columns.Add("Diagnóstico", 200).TextAlign = HorizontalAlignment.Center;
            ltvTodos.Columns.Add("Dono", 200).TextAlign = HorizontalAlignment.Center;
            ltvTodos.Columns.Add("Telefone", 0).TextAlign = HorizontalAlignment.Center;
            ltvTodos.Columns.Add("Endereço", 0).TextAlign = HorizontalAlignment.Center;
            ltvTodos.View = View.Details;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ltvTodos_DoubleClick(object sender, EventArgs e)
        {

            if (ltvTodos.SelectedItems.Count > 0 && ltvTodos.SelectedItems.Count < 2)
            {

                ListViewItem item = ltvTodos.SelectedItems[0];
                Detalhes detalhesform = new Detalhes();
                detalhesform.nome = item.SubItems[0].Text;
                detalhesform.raca = item.SubItems[1].Text;
                detalhesform.DataNasc = item.SubItems[2].Text;
                detalhesform.dataCons = item.SubItems[3].Text;
                detalhesform.vet = item.SubItems[4].Text;
                detalhesform.problema = item.SubItems[5].Text;
                detalhesform.diag = item.SubItems[6].Text;
                detalhesform.dono = item.SubItems[7].Text;
                detalhesform.tel = item.SubItems[8].Text;
                detalhesform.end = item.SubItems[9].Text;
                detalhesform.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            b.DataNasc = dtpNasc.Value.ToString("dd/MM/yyyy");
            b.dataCons = dtpCons.Value.ToString("dd/MM/yyyy");
            b.tel = txtNumTel.Text;
            b.end = txtEndereco.Text;
            b.vet = txtVet.Text;
            b.raca = txtRaca.Text;
            b.dono = txtDono.Text;
            b.diag = txtDiag.Text;
            b.nome = txtNome.Text;
            b.problema = txtProblema.Text;

            ltvTodos.Items.Add(new ListViewItem(new string[] {
                b.nome, b.raca, b.DataNasc, b.dataCons, b.vet, b.problema, b.diag, b.dono, b.tel, b.end }));
            txtDiag.Text = "";
            txtDono.Text = "";
            txtNumTel.Text = "";
            txtEndereco.Text = "";
            txtVet.Text = "";
            txtRaca.Text = "";
            txtDono.Text = "";
            txtDiag.Text = "";
            txtNome.Text = "";   
            txtProblema.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}