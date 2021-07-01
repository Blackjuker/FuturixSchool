using Futurix_School_Prim_En.DAO;
using NumberToWordConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;

using System.IO;

namespace Futurix_School_Prim_En.Forms
{
    public partial class EtatJournalier : Form
    {
        int idUser = 0;
        public EtatJournalier(int v)
        {
            this.idUser = v;
            InitializeComponent();

           
            lblCaissier.Text =DB.getNomAdmin(idUser);

        }

        private void lblDateJour_ValueChanged(object sender, EventArgs e)
        {
            gridAffiche.DataSource = DB.gridVersementJournalier(idUser, lblDateJour.Value.ToShortDateString());

            compteurSomme(gridAffiche);
        }


        private void compteurSomme(DataGridView dataGrid)
        {
            string compteur = null;
            int count = 0;

            if (dataGrid.Rows.Count > 0)
            {
                for(int counter = 0; counter < dataGrid.Rows.Count-1; counter++)
                {
                    count += Convert.ToInt32(dataGrid.Rows[counter].Cells[1].Value.ToString());
                }
            }

            lblVersement.Text = count.ToString()+" FCFA";
            //en anglais conversion en lettre
            //   montantEnLettre.Text =NumberToWord.Convert("56");

            montantEnLettre.Text = count.ToWord(NumberExtension.LiteralNumberFormat.Normal) +" francs CFA";
        }

      

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EtatJournalier_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            sendSMS();
        }

        public void sendSMS()
        {
            String result;
            string apiKey = "KTTmVqpD6H8-EsagYxU4gnGKsckiaiO0adHz3F2ltq";
            string numbers = "698771576"; // in a comma seperated list
            string message = "Bienvenue a la messagerie les Cocotiers. Ce message est un test envoyer par le logiciel Futurix School des cocotiers. Veuillez confirmez reception au 695627379";
            string sender = "Cocotiers";

            String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + sender;
            //refer to parameters to complete correct url string

            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            objRequest.Method = "POST";
            objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            objRequest.ContentType = "application/x-www-form-urlencoded";
            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(url);
            }
            catch (Exception e)
            {
                //  return e.Message;
                MessageBox.Show(null, "the error is " + e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                // Close and clean up the StreamReader
                sr.Close();
            }
            // return result;
            MessageBox.Show(null, result, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
