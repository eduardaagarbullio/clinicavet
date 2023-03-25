using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicaVet
{
    public partial class Detalhes : Form
    {
        public string nome { get; set; }
        public string DataNasc { get; set; }
        public string raca { get; set; }
        public string dataCons { get; set; }
        public string vet { get; set; }
        public string problema { get; set; }
        public string diag { get; set; }
        public string dono { get; set; }
        public string tel { get; set; }
        public string end { get; set; }

        public Detalhes()
        {
            InitializeComponent();
        }

        private void Detalhes_Load(object sender, EventArgs e)
        {
            txtNome.Text = nome;
            txtDono.Text = dono;
            txtDiag.Text = diag;
            txtDataNasc.Text = DataNasc;
            txtDataConsulta.Text = dataCons;
            txtEndereco.Text = end;
            txtNumTel.Text = tel;
            txtProblema.Text = problema;
            txtVet.Text = vet;
            txtRaca.Text = raca;

        }
    }
}
