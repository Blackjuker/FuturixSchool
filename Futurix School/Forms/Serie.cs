using Futurix_School_Prim_En.DAO;
using Futurix_School_Prim_En.Entite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futurix_School_Prim_En.Forms
{
    public partial class Serie : Form
    {
       private int idU;
        public Serie(int id)
        {
            InitializeComponent();
            this.idU = id;
        }

        private void Serie_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSetSerieList.serie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
       //     this.serieTableAdapter.Fill(this.open_schoolDataSetSerieList.serie);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ESerie serie = new ESerie();

            serie.idUser = idU;
            serie.designation = txtSerie.TextName.Trim();

            DB.createSerie(serie);


            // TODO: cette ligne de code charge les données dans la table 'open_schoolDataSetSerieList.serie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        //    this.serieTableAdapter.Fill(this.open_schoolDataSetSerieList.serie);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
