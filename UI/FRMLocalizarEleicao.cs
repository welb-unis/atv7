using BLL;
using DAL;
using MODELO;
using System;
using System.Data;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class FRMLocalizarEleicao : Form
    {
        public MODELOEleicao modeleleicao;
        public FRMLocalizarEleicao()
        {
            InitializeComponent();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLEleicao blleleicao = new BLLEleicao(cx);
            DataTable tabela = blleleicao.Localizar(TXTBusca.Text);
            DGVDados.DataSource = tabela;

        }

        private void DGVDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modeleleicao = new MODELOEleicao();

            this.modeleleicao.IdUrna = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modeleleicao.IdEmpresa = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString());
            DateTime data = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString());
            this.modeleleicao.DataInicioEleicao = data;
            this.modeleleicao.DataFimEleicao = data;
            this.modeleleicao.Descricao = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.modeleleicao.NomeUrna = DGVDados.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.modeleleicao.Voto = DGVDados.Rows[e.RowIndex].Cells[5].Value.ToString();

            this.Close();


        }

        private void FRMLocalizar_Load(object sender, EventArgs e)
        {

        }


    }
}
