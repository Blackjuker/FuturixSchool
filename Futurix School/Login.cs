using Futurix_School_Prim_En.DAO;
using Futurix_School_Prim_En.Entite;
using Futurix_School_Prim_En.Forms;
using Futurix_School_Prim_En.Forms.Forms_Pedagogique;
using Futurix_School_Prim_En.Globals;
using Futurix_School_Prim_En.Main_1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Futurix_School_Prim_En
{
    public partial class Login : Form
    {
        int idChoix = -1;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if(idChoix > -1)
            {
                DB.openConnection();
                EUser user = null;
                user = DB.login(txtUsername.TextName.Trim(), txtPassword.TextName.Trim());

                if (user != null)
                {
                    // Eleve eleve = new Eleve(Convert.ToInt32(user.idAdmin));
                    //Tranche eleve = new Tranche(Convert.ToInt32(user.idAdmin));          

                    switch (user.niveau)
                    {
                        case 1:
                           /* MainSuperAdmin mainSuperAdmin = new MainSuperAdmin(Convert.ToInt32(user.idAdmin));
                            this.Hide();
                            MessageBox.Show(DB.getAllCountEleve().ToString());
                            mainSuperAdmin.ShowDialog();
                            mainSuperAdmin.Dispose();
                            this.Show();
                            txtPassword.TextName = "";*/

                            MainEnseignant mainEnseignant = new MainEnseignant(Convert.ToInt32(user.idAdmin));
                            this.Hide();
                            mainEnseignant.ShowDialog();
                            mainEnseignant.Dispose();
                            this.Show();
                            txtPassword.TextName = "";
                            break;
                        case 2:
                          
                            MainNiveau1 mainNiveau1 = new MainNiveau1(Convert.ToInt32(user.idAdmin));
                            this.Hide();
                            mainNiveau1.ShowDialog();
                            mainNiveau1.Dispose();
                            this.Show();
                            GlobalVars.clear();
                            txtPassword.TextName = "";
                            break;
                        case 3:
                            MainDiscipline mainDiscipline = new MainDiscipline(user.idAdmin);
                            //this.Hide();
                            mainDiscipline.ShowDialog();
                            this.Show();
                            GlobalVars.clear();
                            txtPassword.TextName = "";
                            break;
                        default:
                            MessageBox.Show("Erreur Authentification: Veuillez vérifier votre username et password");
                            break;

                    }

                   
                }
                else
                {
                    MessageBox.Show("Error Passord");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une Ecole", "Erreur Login",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            this.Close();
        }

        private void choixBd_SelectedIndexChanged(object sender, EventArgs e)
        {

          /*  string conString = ConfigurationManager.ConnectionStrings["Futurix_School_Prim_En.Properties.Settings.college_fr"].ConnectionString;
            MySqlConnectionStringBuilder msb = new MySqlConnectionStringBuilder(conString);
            MySqlConnection cnn;*/
              switch (choixBd.SelectedIndex)
               {
                   case 0:
                 
                      GlobalVars.connection = new MySqlConnection("server='" + GlobalVars.adresseServeur + "';port=3306;username='" + GlobalVars.serveurUsername + "';password='" + GlobalVars.serveurPassword + "';database=open_school_prim_en");
                    
                    idChoix = 0;
                       break;
                   case 1:
                    GlobalVars.BD = "open_school_prim_fr.";
                     
                     GlobalVars.connection = new MySqlConnection("server='" + GlobalVars.adresseServeur + "';port=3306;username='" + GlobalVars.serveurUsername + "';password='" + GlobalVars.serveurPassword + "';database=open_school_prim_fr");
               
                     idChoix = 1;

                       break;
                   case 2:
                       GlobalVars.connection = new MySqlConnection("server='" + GlobalVars.adresseServeur + "';port=3306;username='" + GlobalVars.serveurUsername + "';password='" + GlobalVars.serveurPassword + "';database=open_school_en");
                       idChoix = 2;

                       break;
                   case 3:
                       GlobalVars.connection = new MySqlConnection("server='" + GlobalVars.adresseServeur + "';port=3306;username='" + GlobalVars.serveurUsername + "';password='" + GlobalVars.serveurPassword + "';database=open_school");
                       idChoix = 3;

                       break;
                   case 4:
                       GlobalVars.connection = new MySqlConnection("server='"+GlobalVars.adresseServeur+ "';port=3306;username='" + GlobalVars.serveurUsername + "';password='" + GlobalVars.serveurPassword + "';database=open_school_tech_en");
                       idChoix = 4;

                       break;
                   case 5:
                       GlobalVars.connection = new MySqlConnection("server='" + GlobalVars.adresseServeur + "';port=3306;username='" + GlobalVars.serveurUsername + "';password='" + GlobalVars.serveurPassword + "';database=open_school_tech_fr");
                       idChoix = 5;

                       break;
               }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
