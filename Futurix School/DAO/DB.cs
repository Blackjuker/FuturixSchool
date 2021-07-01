using Futurix_School_Prim_En.Entite;
using Futurix_School_Prim_En.Globals;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futurix_School_Prim_En.DAO
{
    class DB
    {
        // static MySqlConnection connection = new MySqlConnection("server=192.168.100.58;port=3306;username=FuturixSchool;password=Blackjuker2021;database=open_school");
        //static MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=test");
        //static MySqlConnection connection = new MySqlConnection("server=192.168.100.58;port=3306;username=FuturixSchool;password=Blackjuker2021;database=test");
        //static MySqlConnection connection = new MySqlConnection("server=192.168.100.58;port=3306;username=FuturixSchool;password=Blackjuker2021;database=open_school");
        //static MySqlConnection connection = new MySqlConnection("server=192.168.100.58;port=3306;username=root;password=;database=open_school_prim_fr");
        //static MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=open_school_tech_fr");
        //static MySqlConnection connection = new MySqlConnection("server=192.168.100.58;port=3306;username=root;password=;database=open_school");
        // static MySqlConnection connection = new MySqlConnection("server=192.168.100.58;port=3306;username=FuturixSchool;password=Blackjuker2021;database=open_school_tech_fr");

        static MySqlConnection connection = GlobalVars.connection;

        internal static DataTable getEleveNoteByClasseByMatiere(int idClasse, int idTrimestre, int idMatiere)
        {
            //open connection 
            openConnection();

            MySqlCommand mySqlCommand = new MySqlCommand("select  eleve.MATRICULE,concat(UPPER(eleve.NOM),' '," +
                "LOWER(eleve.PRENOM)) as 'NOM PRENOM', COALESCE(note.NOTE,0) as notes from eleve LEFT JOIN note on" +
                " eleve.MATRICULE = note.MATRICULE and note.IDPERIODE = '"+idTrimestre+"' and note.IDMATIERE = '"+idMatiere+"' where" +
                " eleve.IDCLASSE = '"+idClasse+"' ORDER by eleve.nom asc", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close connection
            closeConnection();
         
            return dataTable;
        }

        internal static int getIdMatiere(string lblMatiere)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * from matiere where DESIGNATION='" + lblMatiere + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idMatiere = 0;
            if (reader.HasRows)
            {
                idMatiere = reader.GetInt32(0);

            }


            closeConnection();
      
            return idMatiere;
        }

        internal static int getIdTrimestre(string lblTrimestre)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * from periode where DESIGNATION='" + lblTrimestre + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idTrimestre = 0;
            if (reader.HasRows)
            {
                idTrimestre = reader.GetInt32(0);

            }


            closeConnection();
           
            return idTrimestre;
        }

        internal static void addNotes(ENote not)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO note (NOTE,IDPERIODE,IDMATIERE,MATRICULE,RANG,IDUSER) VALUES " +
                "(@note,@idPeriode,@idMatiere,@matricule,@rang,@idUser)", connection);

            mySqlCommand.Parameters.Add("@note", MySqlDbType.Int32).Value = not.note;
            mySqlCommand.Parameters.Add("@idPeriode", MySqlDbType.Int32).Value = not.idPeriode;
            mySqlCommand.Parameters.Add("@idMatiere", MySqlDbType.Int32).Value = not.idMatiere;
            mySqlCommand.Parameters.Add("@matricule", MySqlDbType.VarChar).Value = not.matricule;
            mySqlCommand.Parameters.Add("@rang", MySqlDbType.Int32).Value = not.rang;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = not.idUser;
           


            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
               
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }


        internal static bool addIfNotesExiste(ENote not)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT NOTE from note where IDPERIODE=@idPeriode AND IDMATIERE=@idMatiere AND MATRICULE=@matricule", connection);

            //Open connection
            openConnection();

            mySqlCommand.Parameters.Add("@idPeriode", MySqlDbType.Int32).Value = not.idPeriode;
            mySqlCommand.Parameters.Add("@idMatiere", MySqlDbType.Int32).Value = not.idMatiere;
            mySqlCommand.Parameters.Add("@matricule", MySqlDbType.VarChar).Value = not.matricule;



            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            reader.Read();
            int note = -1;
            if (reader.HasRows)
            {
                note = reader.GetInt32(0);
            }
            //Close connection
            closeConnection();

            if (note < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
               
        }

        internal static void updateNotes(ENote not)
        {
          
            openConnection();
            try { 
            string requete = "UPDATE note SET NOTE = '" + not.note + "'  where IDPERIODE='" + not.idPeriode + "' AND IDMATIERE='"+not.idMatiere+"' AND MATRICULE='"+not.matricule+"' AND IDUSER='"+not.idUser+"'";
            MySqlCommand mySqlCommand = new MySqlCommand(requete, connection);
            mySqlCommand.ExecuteNonQuery();
            closeConnection();
            }catch(Exception ex)
            {
                closeConnection();
                MessageBox.Show("error "+ex.Message.ToString());
                
            }
        }





        //create a function to open the connection
        public static void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //create a function to close the connection
        public static void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static EUser login(String username, String password)
        {
            EUser user = null;
            MySqlCommand command = new MySqlCommand("SELECT * from admin where username = '" + username
                + "'  and password = '" + password + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            user = new EUser();
            if (reader.HasRows)
            {
                user.idAdmin = reader.GetInt32(0);
                user.niveau = reader.GetInt32(1);
                user.nom = reader.GetString(2);
                user.prenom = reader.GetString(3);
                user.sexe = reader.GetString(4);
                user.telephone = reader.GetInt32(5);
                user.username = reader.GetString(6);
                user.password = reader.GetString(7);

            }

            closeConnection();
            return user;
        }

        internal static object getTotalCompteParClasse(int idClass)
        {

            int soldeClasse = 0;
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT SUM(MONTANT) as somm from versement where IDCLASSE='" + 26 + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();



            while (reader.Read() && !reader.IsDBNull(0))
            {

                soldeClasse = reader.GetInt32(0);

            }


            closeConnection();
            return soldeClasse;
        }

        /**
         * recupere le nombre d'élève actuelle par classe
         * 
         * */

        public static int getAllNumberEleveParClasse(int idClass)
        {
            int nmbreEleve = 0;
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) from eleve where IDCLASSE='" + idClass + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                nmbreEleve = reader.GetInt32(0);

            }


            closeConnection();
            return nmbreEleve;
        }

        public void createEtablissement(EEtablissement etab)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO etablissement (IDETABLISSEMENT,NOM,NOAUTORISATION,STATUT,CAPACITE,ADRESSE,CODEPOSTAL,SITEWEB,TELEPHONE,PAYS,VILLE,DESCRIPTION,IMAGE) VALUES" +
                "(1,@nom,@noAutorisation,@statut,@capacite,@adresse,@codePostal,@siteweb,@telephone,@pays,@ville,@description,@image) ON DUPLICATE KEY UPDATE " +
                "NOM=@nom,NOAUTORISATION=@noAutorisation,STATUT=@statut,CAPACITE=@capacite,ADRESSE=@adresse,CODEPOSTAL=@codePostal,SITEWEB=@siteweb,TELEPHONE=@telephone,PAYS=@pays,VILLE=@ville,DESCRIPTION=@description,IMAGE=@image", connection);

            mySqlCommand.Parameters.Add("@nom", MySqlDbType.VarChar).Value = etab.nom;
            mySqlCommand.Parameters.Add("@noAutorisation", MySqlDbType.VarChar).Value = etab.noAutorisation;
            mySqlCommand.Parameters.Add("@statut", MySqlDbType.Int32).Value = etab.statut;
            mySqlCommand.Parameters.Add("@capacite", MySqlDbType.Int32).Value = etab.capacite;
            mySqlCommand.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = etab.adresse;
            mySqlCommand.Parameters.Add("@codePostal", MySqlDbType.VarChar).Value = etab.codePostal;
            mySqlCommand.Parameters.Add("@siteweb", MySqlDbType.VarChar).Value = etab.siteWeb;
            mySqlCommand.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = etab.siteWeb;
            mySqlCommand.Parameters.Add("@pays", MySqlDbType.VarChar).Value = etab.telephone;
            mySqlCommand.Parameters.Add("@ville", MySqlDbType.VarChar).Value = etab.ville;
            mySqlCommand.Parameters.Add("@description", MySqlDbType.VarChar).Value = etab.description;
            mySqlCommand.Parameters.Add("@image", MySqlDbType.VarChar).Value = etab.image;


            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("INFORMATION SAVED");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();

        }

        /**
         * 
         * */
        internal static int getIdClasse(string libelle)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * from classe where DESIGNATION='" + libelle + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idClasse = 0;
            if (reader.HasRows)
            {
                idClasse = reader.GetInt32(0);

            }


            closeConnection();
            return idClasse;
        }


        internal static int getIdClasseFromEleve(string matricule)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT eleve.IDCLASSE from eleve where MATRICULE='" + matricule + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idClasse = 0;
            if (reader.HasRows)
            {
                idClasse = reader.GetInt32(0);

            }


            closeConnection();
            return idClasse;
        }
        //getId School
        public static int getIdEtablissement()
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * from etablissement where idetablissement = 1 and statut=1", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idEtat = 0;
            if (reader.HasRows)
            {
                idEtat = reader.GetInt32(0);

            }


            closeConnection();
            return idEtat;
        }

        public static void createCycle(ECycle cycle)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO cycle (DESIGNATION,IDETABLISSEMENT,IDUSER) VALUES" +
               "(@designation,@idEtablissement,@idUser)", connection);

            mySqlCommand.Parameters.Add("@designation", MySqlDbType.VarChar).Value = cycle.designation;
            mySqlCommand.Parameters.Add("@idEtablissement", MySqlDbType.Int32).Value = cycle.idEtablissement;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = cycle.idUser;



            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                listCycles();
                MessageBox.Show("Cycle SAVED");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }


        /**
         * Creation élève 
         * */
        internal static void createEleve(EEleve eleve)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO eleve (NOM,PRENOM,NATIONALITE,LIEUNAISSANCE,MALADIF,APTE,NOMANCIENECOLE,IDCLASSE,NOTEANCIENNE,MATRICULE,GENRE,REDOUBLANT,IDUSER) VALUES" +
               "(@nom,@prenom,@nationalite,@lieunaissance,@maladif,@apte,@nomancienecole,@idclasse,@noteancienne,@matricule,@genre,@redoublant,@iduser)", connection);

            mySqlCommand.Parameters.Add("@nom", MySqlDbType.VarChar).Value = eleve.nom;
            mySqlCommand.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = eleve.prenom;
            mySqlCommand.Parameters.Add("@nationalite", MySqlDbType.VarChar).Value = eleve.nationalite;
            mySqlCommand.Parameters.Add("@lieunaissance", MySqlDbType.VarChar).Value = eleve.lieuNaissance;
            mySqlCommand.Parameters.Add("@maladif", MySqlDbType.VarChar).Value = eleve.maladif;
            mySqlCommand.Parameters.Add("@apte", MySqlDbType.VarChar).Value = eleve.apte;
            mySqlCommand.Parameters.Add("@nomancienecole", MySqlDbType.VarChar).Value = eleve.nomAncienEcole;
            mySqlCommand.Parameters.Add("@idclasse", MySqlDbType.VarChar).Value = eleve.idClasse;
            mySqlCommand.Parameters.Add("@noteancienne", MySqlDbType.VarChar).Value = eleve.noteAncienne;
            mySqlCommand.Parameters.Add("@matricule", MySqlDbType.VarChar).Value = eleve.matricule;
            mySqlCommand.Parameters.Add("@genre", MySqlDbType.VarChar).Value = eleve.genre;
            mySqlCommand.Parameters.Add("@redoublant", MySqlDbType.VarChar).Value = eleve.redoublant;
            mySqlCommand.Parameters.Add("@iduser", MySqlDbType.VarChar).Value = eleve.iduser;



            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                updateClasseNumberStudentAdd(eleve.idClasse);
                MessageBox.Show("Enregistrement Eleve Ok ");
            }
            else
            {
                MessageBox.Show("Error d'enregitrement Eleve ");
            }

            //Close connection
            closeConnection();
        }

        //affichage des listes des Cycles
        public static DataTable listCycles()
        {
            //Open connection 
            openConnection();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select IDCYCLE as CODE, DESIGNATION from cycle", connection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            closeConnection();
            return dataTable;

        }


        // get id Cycle
        public static int getIdCycle(string designation)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * from cycle where DESIGNATION = '" + designation + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idCycle = 0;
            if (reader.HasRows)
            {
                idCycle = reader.GetInt32(0);

            }


            closeConnection();
            return idCycle;
        }

        //creation niveau 
        public static void createNiveau(ENiveau niveau, string libelle)
        {
            int lib = getIdCycle(libelle);
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO niveau (DESIGNATION,IDCYCLE,IDUSER) VALUES" +
               "(@designation,@idCycle,@idUser)", connection);

            mySqlCommand.Parameters.Add("@designation", MySqlDbType.VarChar).Value = niveau.designation;
            mySqlCommand.Parameters.Add("@idCycle", MySqlDbType.Int32).Value = lib;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = niveau.idUser;



            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                listCycles();
                MessageBox.Show("Niveau SAVED");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }




        //Creation Série
        public static void createSerie(ESerie serie)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO serie (DESIGNATION,IDUSER) VALUES" +
               "(@designation,@idUser)", connection);

            mySqlCommand.Parameters.Add("@designation", MySqlDbType.VarChar).Value = serie.designation;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = serie.idUser;



            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                listCycles();
                MessageBox.Show("Serie   SAVED");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }

        //Creation Classe
        public static void createClasse(EClasse classe, int id)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO classe (DESIGNATION,CAPACITEACCUEIL,NBR_ELEVE,IDNIVEAU,IDSERIE,IDUSER) VALUES" +
               "(@designation,@capacite,@nbrEleve,@idNiveau,@idSerie,@idUser)", connection);

            mySqlCommand.Parameters.Add("@designation", MySqlDbType.VarChar).Value = classe.designation;
            mySqlCommand.Parameters.Add("@capacite", MySqlDbType.VarChar).Value = classe.capaciteAccueil;
            mySqlCommand.Parameters.Add("@nbrEleve", MySqlDbType.VarChar).Value = classe.nbrEleve;
            mySqlCommand.Parameters.Add("@idNiveau", MySqlDbType.VarChar).Value = classe.idNiveau;
            mySqlCommand.Parameters.Add("@idSerie", MySqlDbType.VarChar).Value = classe.idSerie;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.VarChar).Value = id;


            

            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                listCycles();
                MessageBox.Show("Serie   SAVED");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }


        // get id Niveau
        public static int getIdNiveau(string designation)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * from niveau where DESIGNATION = '" + designation + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idNiveau = 0;
            if (reader.HasRows)
            {
                idNiveau = reader.GetInt32(0);

            }


            closeConnection();
            return idNiveau;
        }


        // get id Serie
        public static int getIdSerie(string designation)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * from serie where DESIGNATION = '" + designation + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idSerie = 0;
            if (reader.HasRows)
            {
                idSerie = reader.GetInt32(0);

            }


            closeConnection();
            return idSerie;
        }

        public static void createPension(EPension pension, int id)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO pension (MONTANT,IDNIVEAU,IDUSER) VALUES" +
               "(@montant,@idNiveau,@idUser) ON DUPLICATE KEY UPDATE montant=@montant", connection);

            mySqlCommand.Parameters.Add("@montant", MySqlDbType.VarChar).Value = pension.montant;
            mySqlCommand.Parameters.Add("@idNiveau", MySqlDbType.VarChar).Value = pension.idNiveau;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.VarChar).Value = id;

            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                listCycles();
                MessageBox.Show("Pension SAVED");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }

        //Get all Niveau
        public static DataTable listNiveau()
        {
            //Open connection 
            openConnection();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select IDCYCLE as CODE, DESIGNATION from cycle", connection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            closeConnection();
            return dataTable;

        }
        public static DataTable getAllTrancheNiveau(int idNiveau)
        {
            //open connection 
            openConnection();
            // MySqlCommand mySqlCommand = new MySqlCommand("getTrancheNiveau", connection);
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT tr.`LIBELLE`,tr.`MONTANT`,tr.`DATEFIN`  FROM tranche as tr WHERE tr.`IDPENSION`='" + idNiveau + "'", connection);
            //  mySqlCommand.CommandType = CommandType.StoredProcedure;
            //mySqlCommand.Parameters.AddWithValue("@idPen", MySqlDbType.Int32).Value = idNiveau;
            //mySqlCommand.Parameters["?idPen"].Value = idNiveau;
            //mySqlCommand.Parameters.AddWithValue("?idPen", idNiveau);
            //  mySqlCommand.Parameters["?idPen"].Direction = ParameterDirection.Input;
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close connection
            closeConnection();
            return dataTable;
        }

        public static String getPrixPension(int idNiveau)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT MONTANT from pension where IDNIVEAU = '" + idNiveau + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string montant = null;
            if (reader.HasRows)
            {
                montant = reader.GetString(0);

            }


            closeConnection();
            return montant;
        }


        public static void createTranche(ETranche tranche, int idU)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO tranche (LIBELLE,MONTANT,DATEFIN,IDPENSION,IDUSER) VALUES" +
               "(@libelle,@montant,@datefin,@idPension,@idUser)", connection);

            mySqlCommand.Parameters.Add("@libelle", MySqlDbType.VarChar).Value = tranche.libelle;
            mySqlCommand.Parameters.Add("@montant", MySqlDbType.Int32).Value = tranche.montant;
            mySqlCommand.Parameters.Add("@datefin", MySqlDbType.VarChar).Value = tranche.dateFin;
            mySqlCommand.Parameters.Add("@idPension", MySqlDbType.Int32).Value = tranche.idPension;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = idU;

            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                listCycles();
                MessageBox.Show("Tranche SAVED");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }

        public static int getIdPension(int idN)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * from pension where IDNIVEAU = '" + idN + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idPen = 0;
            if (reader.HasRows)
            {
                idPen = reader.GetInt32(0);
            }


            closeConnection();
            return idPen;
        }

        public static int getAllCountEleve()
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) from eleve ", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idEleve = 0;
            if (reader.HasRows)
            {
                idEleve = reader.GetInt32(0) + 1;
            }


            closeConnection();
            return idEleve;
        }

        public static DataTable fillNiveauByCycle(int idCy)
        {
            openConnection();

            MySqlCommand command = new MySqlCommand("SELECT DESIGNATION from niveau where niveau.IDCYCLE ='" + idCy + "' ", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable("DESIGNATION");
            da.Fill(table);

            closeConnection();

            return table;

        }
        public static DataTable fillCycle()
        {
            openConnection();

            MySqlCommand command = new MySqlCommand("SELECT DESIGNATION from cycle  ", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable("DESIGNATION");
            da.Fill(table);

            closeConnection();

            return table;

        }
        public static DataTable fillClasse()
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT DESIGNATION from classe", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable("DESIGNATION");
            da.Fill(table);

            closeConnection();

            return table;
        }
        public static DataTable fillNiveau()
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT DESIGNATION from niveau", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable("DESIGNATION");
            da.Fill(table);

            closeConnection();

            return table;
        }
        public static DataTable fillSerie()
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT DESIGNATION from serie", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable("DESIGNATION");
            da.Fill(table);

            closeConnection();

            return table;
        }

      
       
        public static DataTable fillClasseByNiveau(int idNiv)
        {
            openConnection();

            MySqlCommand command = new MySqlCommand("SELECT DESIGNATION from classe where classe.IDNIVEAU ='" + idNiv + "' ", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable("DESIGNATION");
            da.Fill(table);

            closeConnection();

            return table;

        }

        public static int getIdClasseInscription(string design, Label capacite, Label nbreEleve)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * from classe where DESIGNATION = '" + design + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idClasse = 0;
            if (reader.HasRows)
            {
                idClasse = reader.GetInt32(0);
                nbreEleve.Text = Convert.ToString(reader.GetInt32(3));
                capacite.Text = Convert.ToString(reader.GetInt32(2));
            }


            closeConnection();
            return idClasse;
        }

        private static int getAllStudentInAClasse(int idClasse)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) from eleve where IDCLASSE = '" + idClasse + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int compteur = 0;
            if (reader.HasRows)
            {
                compteur = reader.GetInt32(0);

            }


            closeConnection();
            return compteur;
        }

        /**
         * update le nombre d'éleve dans une classe
         **/
        public static void updateClasseNumberStudentAdd(int idClasse)
        {

            int nombreEleve = 0;
            nombreEleve = getAllStudentInAClasse(idClasse);
            openConnection();
            string requete = "UPDATE classe SET NBR_ELEVE = '" + nombreEleve + "' where IDCLASSE='" + idClasse + "'";
            MySqlCommand mySqlCommand = new MySqlCommand(requete, connection);
            mySqlCommand.ExecuteNonQuery();
            closeConnection();

        }

        public static void createParent(EParent parent, string nomP)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO personne (NOM,PRENOM,PROFESSION,TELEPHONE_P,TELEPHONE_F,MATRICULE,GENRE) VALUES" +
               "(@nom,@prenom,@profession,@tel_p,@tel_f,@matricule,@genre)", connection);

            mySqlCommand.Parameters.Add("@nom", MySqlDbType.VarChar).Value = parent.nomPere;
            mySqlCommand.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = parent.prenomPere;
            mySqlCommand.Parameters.Add("@profession", MySqlDbType.VarChar).Value = parent.profession;
            mySqlCommand.Parameters.Add("@tel_p", MySqlDbType.VarChar).Value = parent.telephone_p;
            mySqlCommand.Parameters.Add("@tel_f", MySqlDbType.VarChar).Value = parent.telephone_f;
            mySqlCommand.Parameters.Add("@matricule", MySqlDbType.VarChar).Value = parent.matriculeEnfant;
            mySqlCommand.Parameters.Add("@genre", MySqlDbType.VarChar).Value = parent.role;

            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {


            }
            else
            {
                MessageBox.Show("Error d'enregitrement " + nomP);
            }

            //Close connection
            closeConnection();
        }

        public static int getIdNiveauFromClasse(int idClasse)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT IDNIVEAU from classe where IDCLASSE= '" + idClasse + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idNiveau = 0;
            if (reader.HasRows)
            {
                idNiveau = reader.GetInt32(0);

            }


            closeConnection();
            return idNiveau;
        }

        public static string getPensionParClasse(int idClasse)
        {
            int idNiveau = 0;
            idNiveau = getIdNiveauFromClasse(idClasse);
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT MONTANT from pension where IDNIVEAU= '" + idNiveau + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int montantPension = 0;
            if (reader.HasRows)
            {
                montantPension = reader.GetInt32(0);

            }


            closeConnection();
            return montantPension.ToString();
        }



        public static int getIdPensionParNiveau(int idNiveau)
        {
            
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT IDPENSION from pension where IDNIVEAU= '" + idNiveau + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int idPension = 0;
            if (reader.HasRows)
            {
                idPension = reader.GetInt32(0);

            }


            closeConnection();
            return idPension;
        }

        public static string getSoldeEleve(string matricule)
        {
            int solde = 0;

            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT SUM(MONTANT) as somm from versement where MATRICULE= '" + matricule + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read() && !reader.IsDBNull(0))
            {
                /*if (reader.HasRows)
                {
                  /*  if (reader.GetOrdinal("somm") != DBNull.Value)
                    {

                    }
                    else
                    {

                    }
                    solde = reader.GetInt32(0);

                }*/
                solde = reader.GetInt32(0);
            }



            closeConnection();
            return Convert.ToString(solde);
        }


        public static int getNumeroFacture()
        {

            int numero = 0;

            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) from versement", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                numero = reader.GetInt32(0);

            }


            closeConnection();
            return numero + 1;

        }

        public static string getNomUser(int idU)
        {
            string nomUser = null;

            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT NOM from admin where IDADMIN='" + idU + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                nomUser = reader.GetString(0);

            }


            closeConnection();
            return nomUser;
        }

        public static int versementP(EVersement versement)
        {
            int good = 0;
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO versement (MATRICULE,IDCLASSE,MONTANT,MOTIF,IDUSER,DATE) VALUES" +
               "(@matricule,@idclasse,@montant,@motif,@idUser,@date)", connection);

            mySqlCommand.Parameters.Add("@matricule", MySqlDbType.VarChar).Value = versement.matricule;
            mySqlCommand.Parameters.Add("@idclasse", MySqlDbType.Int32).Value = versement.idClasse;
            mySqlCommand.Parameters.Add("@montant", MySqlDbType.Int32).Value = versement.montant;
            mySqlCommand.Parameters.Add("@motif", MySqlDbType.VarChar).Value = versement.motif;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = versement.idUser;
            mySqlCommand.Parameters.Add("@date", MySqlDbType.VarChar).Value = versement.dateV;


            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                good = 1;

            }
            else
            {
                MessageBox.Show("Error d'enregitrement VersemeentP CODE 747");
            }

            //Close connection
            closeConnection();

            return good;
        }

        //affichage des listes des Cycles
        public static DataTable listAllEleve()
        {
            //Open connection 
            openConnection();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select MATRICULE, CONCAT(PRENOM,' ',NOM) as NOM, DATENAISSANCE from eleve where ACTIF=1", connection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            closeConnection();
            return dataTable;

        }

        public static DataTable listParClasse(int idClasse)
        {
            //Open connection 
            openConnection();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select MATRICULE, CONCAT(PRENOM,' ',NOM) as NOM, DATENAISSANCE from eleve where ACTIF=1 AND IDCLASSE = '" + idClasse + "'", connection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            closeConnection();
            return dataTable;

        }


        public static EEleve getEleveInscription(string matricule)
        {
            openConnection();
            EEleve eleve;
            MySqlCommand command = new MySqlCommand("SELECT * from eleve where MATRICULE = '" + matricule + "'", connection);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            eleve = new EEleve();
            if (reader.HasRows)
            {
                eleve.idEleve = reader.GetInt32(0);
                eleve.prenom = reader.GetString(2);
                eleve.nom = reader.GetString(3);


            }
            closeConnection();
            return eleve;
        }
        public static DataTable listAllEleve(string filtre)
        {
            //Open connection 
            openConnection();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(filtre, connection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            closeConnection();
            return dataTable;

        }

       
       

        public static string verifIfMatExiste(EMatiere matiere)
        {
            openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * from matiere where DESIGNATION = '" + matiere.designation + "'", connection);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string message;
            if (reader.HasRows)
            {
                message = "Matieres déjà crée ";

                closeConnection();
            }
            else
            {
                closeConnection();
                addMatieres(matiere);
                message = "Matieres crée avec succes";
            }

            return message;
        }
        public static int addMatieres(EMatiere eMatiere)
        {
            //Open connection
            openConnection();
            int good = 0;

            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO matiere (DESIGNATION,IDUSER) VALUES" +
              "(@designation,@idUser)", connection);


            mySqlCommand.Parameters.Add("@designation", MySqlDbType.VarChar).Value = eMatiere.designation;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = eMatiere.idUser;
            



            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                good = 1;

            }
            else
            {
                MessageBox.Show("Error d'enregitrement Coefficient Matiere CODE 747");
            }

            //Close connection
            closeConnection();
            return good;
        }
        public static int deleteMatiere(string libelle)
        {
            //Open connection
            openConnection();
            int good = 0;

            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM matiere WHERE matiere.DESIGNATION ='"+libelle+"'", connection);


            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                good = 1;

            }
            else
            {
                MessageBox.Show("Error d'enregitrement Coefficient Matiere CODE 747");
            }

            //Close connection
            closeConnection();
            return good;
        }
        public static int createCoefMatiere(int coefficient, int idClasse, int idMatiere, int idUser, string groupe)
        {
            //Open connection
            openConnection();
            int good = 0;

            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO matiere_classe (IDCLASSE,IDMATIERE,COEFFICIENT,GROUPE,IDUSER) VALUES" +
              "(@idClasse,@idMatiere,@coefficient,@groupe,@idUser)", connection);


            mySqlCommand.Parameters.Add("@idClasse", MySqlDbType.Int32).Value = idClasse;
            mySqlCommand.Parameters.Add("@idMatiere", MySqlDbType.Int32).Value = idMatiere;
            mySqlCommand.Parameters.Add("@coefficient", MySqlDbType.Int32).Value = coefficient;
            mySqlCommand.Parameters.Add("@groupe", MySqlDbType.VarChar).Value = groupe;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = idUser;



            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                good = 1;

            }
            else
            {
                MessageBox.Show("Error d'enregitrement Coefficient Matiere CODE 747");
            }

            //Close connection
            closeConnection();
            return good;
        }


        public static DataTable listMatiereCoef(int idClasse)
        {
            //Open connection 
            openConnection();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select matiere_classe. matiere.DESIGNATION, matiere_classe.COEFFICIENT,matiere_classe.GROUPE FROM matiere_classe, matiere where matiere_classe.IDMATIERE=matiere.IDMATIERE and matiere_classe.IDCLASSE='" + idClasse + "'", connection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            closeConnection();
            return dataTable;

        }

        public static DataTable gridVersementJournalier(int idU, string dateJ)
        {
            //Open Connection
            openConnection();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select matricule,montant,motif from versement where versement.IDUSER='" + idU + "' and versement.DATE='" + dateJ + "'", connection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close Connection
            closeConnection();

            return dataTable;

        }

        public static String getNomAdmin(int idU)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT NOM,PRENOM,SEXE from admin where IDADMIN = '" + idU + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string nom = null;
            string prenom = null;
            string sexe = null;
            string resultat = null;
            if (reader.HasRows)
            {
                nom = reader.GetString(0);
                prenom = reader.GetString(1);
                sexe = reader.GetString(2);

            }

            if (sexe != null)
            {
                if (sexe == "F")
                {
                    resultat = "Mme " + nom.ToUpper() + " " + prenom.ToLower();
                }
                else if (sexe == "M")
                {
                    resultat = "M " + nom.ToUpper() + " " + prenom.ToLower();
                }
            }


            closeConnection();
            return resultat;
        }

        public static DataTable getAllClasse()
        {
            //open connection 
            openConnection();
            // MySqlCommand mySqlCommand = new MySqlCommand("getTrancheNiveau", connection);
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT classe.IDCLASSE as CODE,classe.DESIGNATION as CLASSE,niveau.DESIGNATION as NIVEAU,serie.DESIGNATION as SERIE  FROM classe,niveau,serie WHERE classe.IDNIVEAU=niveau.IDNIVEAU AND classe.IDSERIE=serie.IDSERIE ORDER BY niveau.IDNIVEAU", connection);
            //  mySqlCommand.CommandType = CommandType.StoredProcedure;
            //mySqlCommand.Parameters.AddWithValue("@idPen", MySqlDbType.Int32).Value = idNiveau;
            //mySqlCommand.Parameters["?idPen"].Value = idNiveau;
            //mySqlCommand.Parameters.AddWithValue("?idPen", idNiveau);
            //  mySqlCommand.Parameters["?idPen"].Direction = ParameterDirection.Input;
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close connection
            closeConnection();
            return dataTable;
        }

        public static DataTable getAllTrimestre()
        {
            //open connection 
            openConnection();
          
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM PERIODE where PERIODE.CLOTURE=0", connection);
           
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close connection
            closeConnection();
            return dataTable;
        }

        internal static DataTable getMatieresParClasse(int idClasse)
        {
            //open connection 
            openConnection();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT matiere.DESIGNATION as matieres FROM matiere,matiere_classe WHERE matiere_classe.IDCLASSE='"+idClasse+"' AND matiere.IDMATIERE = matiere_classe.IDMATIERE", connection);

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close connection
            closeConnection();
            return dataTable;
        }
        public static DataTable getLibelleTrancheFromPension(int idPension)
        {

            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT LIBELLE as DESIGNATION from tranche where IDPENSION= '" + idPension + "'", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable("DESIGNATION");
            da.Fill(table);

            closeConnection();

            return table;
        }
        public static DataTable getAllInsolvableByTranche(int idClasse,string designationTranche,int idPension)
        {
            //open connection 
            openConnection();
           
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT versement.MATRICULE,eleve.NOM,eleve.PRENOM,SUM(versement.MONTANT) as SOLDE_ELEVE ,tranche.MONTANT-SUM(versement.MONTANT) as 'RESTE A PAYER',tranche.DATEFIN as 'DATE LIMITE' FROM versement,eleve,tranche where versement.MATRICULE=eleve.MATRICULE and versement.IDCLASSE='"+idClasse+"' and tranche.LIBELLE='"+designationTranche+"' and tranche.IDPENSION='"+idPension+"' GROUP BY MATRICULE HAVING SOLDE_ELEVE<(select tranche.MONTANT from tranche where tranche.LIBELLE='"+designationTranche+"' and tranche.IDPENSION='"+idPension+"')", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close connection
            closeConnection();
            return dataTable;
        }

        public static DataTable getAllEleveByClasse(int idClasse)
        {
            //open connection 
            openConnection();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT eleve.MATRICULE, CONCAT(eleve.NOM,' ',eleve.PRENOM) as 'NOM et Prenom' FROM eleve WHERE eleve.IDCLASSE = '"+idClasse+"'ORDER BY eleve.nom ", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close connection
            closeConnection();
            return dataTable;
        }

        public static void createMatiere(EMatiere matiere)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO matiere (DESIGNATION,IDUSER) VALUES" +
               "(@designation,@idUser)", connection);

            mySqlCommand.Parameters.Add("@designation", MySqlDbType.VarChar).Value = matiere.designation;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = matiere.idUser;



            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                listCycles();
                MessageBox.Show("Serie   SAVED");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }

        public static DataTable getAllMatieres()
        {
            //open connection 
            openConnection();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT matiere.IDMATIERE as CODE,matiere.DESIGNATION as LIBELLE, matiere.IDUSER as CODE_UTILISATEUR from matiere", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close connection
            closeConnection();
            return dataTable;
        }

        public static int deleteVersement(string matricule)
        {
            int good = 0;
            try
            {
                //Open connection
                openConnection();
                //MessageBox.Show(matricule);

                MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM versement where  MATRICULE ='" + matricule + "'", connection);

                mySqlCommand.ExecuteNonQuery();


              
                //Close connection
                closeConnection();
                return good;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return good;
            }
          
        }


        public static void insertDiscipline(EDiscipline discipline)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO discipline (MATRICULE,DATEDEBUT,DATEFIN,NBRHR,NBRJR,NBRCONV,MOTIF,IDUSER) VALUES" +
               "(@matricule,@dateDebut,@dateFin,@nbrHr,@nbrJr,@nbrConv,@motif,@idUser)", connection);

            mySqlCommand.Parameters.Add("@matricule", MySqlDbType.VarChar).Value = discipline.matricule;
            mySqlCommand.Parameters.Add("@dateDebut", MySqlDbType.VarChar).Value = discipline.dateDebut;
            mySqlCommand.Parameters.Add("@dateFin", MySqlDbType.VarChar).Value = discipline.dateFin;
            mySqlCommand.Parameters.Add("@nbrHr", MySqlDbType.Int32).Value = discipline.nbreHr;
            mySqlCommand.Parameters.Add("@nbrJr", MySqlDbType.Int32).Value = discipline.nbrJr;
            mySqlCommand.Parameters.Add("@nbrConv", MySqlDbType.Int32).Value = discipline.nbrConv;
            mySqlCommand.Parameters.Add("@motif", MySqlDbType.VarChar).Value = discipline.motif;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = discipline.idUser;

            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                
                MessageBox.Show("Absences  SAVED");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }

        public static int getAllHeureAbsence(string matricule,string dateAbsence)
        {
            openConnection();
            int nombreHeure = 0;
            MySqlCommand command = new MySqlCommand("SELECT COALESCE((sum(NBRHR)-sum(NBRHRJ)), 0) as SOMME from discipline where discipline.MATRICULE = '"+matricule+"' AND discipline.DATEDEBUT = '"+dateAbsence+"'", connection);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
           
            if (reader.HasRows)
            {
                nombreHeure = reader.GetInt32(0);
            }
            closeConnection();
            return nombreHeure;
        }
        public static int getAllTotalHeureAbsence(string matricule)
        {
            openConnection();
            int nombreHeure = 0;
            MySqlCommand command = new MySqlCommand("SELECT COALESCE((sum(NBRHR)-sum(NBRHRJ)), 0) as SOMME from discipline where discipline.MATRICULE = '" + matricule + "' ", connection);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                nombreHeure = reader.GetInt32(0);
            }
            closeConnection();
            return nombreHeure;
        }

        public static int getAllNombreEleve(int idClasse)
        {
            openConnection();
            int nbrEleve = 0;
            MySqlCommand command = new MySqlCommand("SELECT COALESCE(NBR_ELEVE, 0) as nombre_Eleve from classe where classe.IDCLASSE = '" + idClasse + "' ", connection);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                nbrEleve = reader.GetInt32(0);
            }
            closeConnection();
            return nbrEleve;
        }

        public static int getAllConvocation(string matricule, string dateAbsence)
        {
            openConnection();
            int nombreHeure = 0;
            MySqlCommand command = new MySqlCommand("SELECT COALESCE(sum(NBRCONV), 0) as SOME from discipline where discipline.MATRICULE = '" + matricule + "' AND discipline.DATEDEBUT = '" + dateAbsence + "'", connection);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                nombreHeure = reader.GetInt32(0);
            }
            closeConnection();
            return nombreHeure;
        }

        public static int getAllExclusion(string matricule, string dateAbsence)
        {
            openConnection();
            int nombreHeure = 0;
            MySqlCommand command = new MySqlCommand("SELECT COALESCE(sum(NBRJR), 0) as SOME from discipline where discipline.MATRICULE = '" + matricule + "' AND discipline.DATEDEBUT = '" + dateAbsence + "'", connection);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                nombreHeure = reader.GetInt32(0);
            }
            closeConnection();
            return nombreHeure;
        }


        public static void justificationHeure(int heure, string mat)
        {


            openConnection();
            string requete = "UPDATE discipline SET NBRHRJ = '" + heure + "' ,JUSTIFIER = 1 where 	MATRICULE='" + mat + "'";
            MySqlCommand mySqlCommand = new MySqlCommand(requete, connection);
            mySqlCommand.ExecuteNonQuery();
            closeConnection();

        }

        public static void updateCravate(int val,string mat)
        {

           
            openConnection();
            string requete = "UPDATE eleve SET CRAVATE = '" + val + "' where 	MATRICULE='" + mat + "'";
            MySqlCommand mySqlCommand = new MySqlCommand(requete, connection);
            mySqlCommand.ExecuteNonQuery();
            closeConnection();

        }
        public static void updateEcusson(int val, string mat)
        {


            openConnection();
            string requete = "UPDATE eleve SET ECUSSON = '" + val + "' where 	MATRICULE='" + mat + "'";
            MySqlCommand mySqlCommand = new MySqlCommand(requete, connection);
            mySqlCommand.ExecuteNonQuery();
            closeConnection();

        }


        public static void updatePullOver(int val, string mat)
        {


            openConnection();
            string requete = "UPDATE eleve SET PULLOVER = '" + val + "' where 	MATRICULE='" + mat + "'";
            MySqlCommand mySqlCommand = new MySqlCommand(requete, connection);
            mySqlCommand.ExecuteNonQuery();
            closeConnection();

        }

        public static DataTable getAllFonction()
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT FONCTION from agent where IDAGENT > 0", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable("FONCTION");
            da.Fill(table);

            closeConnection();

            return table;
        }

         /**
         * GET Agent by Role 
         * */
        public static DataTable getAllEnseignantByRole(int idAgent)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT concat(UPPER(NOM),' '," +
                "LOWER(PRENOM)) as nomPrenom from admin where NIVEAU ='"+idAgent+"'", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable("nomPrenom");
            da.Fill(table);

            closeConnection();

            return table;
        }



        public static int getRoleUser(string libelle)
        {
            openConnection();
            int idRole = 0;
            MySqlCommand command = new MySqlCommand("SELECT IDAGENT FROM agent where FONCTION = '"+libelle+"'", connection);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                idRole = reader.GetInt32(0);
            }
            closeConnection();
            return idRole;
        }

        public static void createAdministrators(EAdmin admin)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO admin (nom,prenom,niveau,sexe,telephone,username,password) VALUES" +
               "(@nom,@prenom,@niveau,@sexe,@telephone,@username,@password)", connection);

            mySqlCommand.Parameters.Add("@nom", MySqlDbType.VarChar).Value = admin.nom;
            mySqlCommand.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = admin.prenom;
            mySqlCommand.Parameters.Add("@niveau", MySqlDbType.Int32).Value = admin.niveau;
            mySqlCommand.Parameters.Add("@sexe", MySqlDbType.VarChar).Value = admin.sexe;
            mySqlCommand.Parameters.Add("@telephone", MySqlDbType.Int32).Value = Convert.ToInt32(admin.telephone);
            mySqlCommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = admin.username;
            mySqlCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = admin.password;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.VarChar).Value = admin.idUser;

           

            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Admin   SAVED");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }
        /*
        public static DataTable ()
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT DESIGNATION from serie", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable("DESIGNATION");
            da.Fill(table);

            closeConnection();

            return table;
        }
        */

        public static DataTable getAllEnseignant()
        {
            //open connection 
            openConnection();

            MySqlCommand mySqlCommand = new MySqlCommand("select IDADMIN as CODE,CONCAT(NOM,' ',PRENOM) as 'NOM et Prenom', sexe, telephone from admin", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close connection
            closeConnection();
            return dataTable;
        }

        public static int ifExistEnseignantMatiere(int idEnseigne, int idMatiere, int idClasse)
        {

            int i = 0;
            //open connection 
            openConnection();

            MySqlCommand mySqlCommand = new MySqlCommand("select * from enseigne where IDENSEIGNANT='"+idEnseigne+"' AND IDMATIERE='"+idMatiere+"' AND IDCLASSE='"+idClasse+"' ", connection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                i = 1;

            }

            closeConnection();
            return i;
        }


        public static void createEnseignantMatiere(int idEnseigne,int idMatiere,int idClasse)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO enseigne (IDENSEIGNANT,IDMATIERE,IDCLASSE) VALUES" +
               "(@idEnseignant,@idMatiere,@idClasse)", connection);

            mySqlCommand.Parameters.Add("@idEnseignant", MySqlDbType.Int32).Value = idEnseigne;
            mySqlCommand.Parameters.Add("@idMatiere", MySqlDbType.Int32).Value = idMatiere;
            mySqlCommand.Parameters.Add("@idClasse", MySqlDbType.Int32).Value = idClasse;
         

            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Cours ajouter");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }

        public static DataTable getAllClasseEnseigner(int idEn)
        {
            //open connection 
            openConnection();

            MySqlCommand mySqlCommand = new MySqlCommand("select  matiere.DESIGNATION as Matiere,classe.DESIGNATION as Classe from enseigne,matiere,classe where enseigne.IDMATIERE=matiere.IDMATIERE And enseigne.IDCLASSE=classe.IDCLASSE and enseigne.IDENSEIGNANT='" + idEn+"'", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            //close connection
            closeConnection();
            return dataTable;
        }

        public static DataTable getAllClasseEnseignant(int idEn)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT classe.DESIGNATION as Classe from enseigne,classe,matiere where enseigne.IDENSEIGNANT='"+idEn+"' AND enseigne.IDCLASSE=classe.IDCLASSE and enseigne.IDMATIERE =  matiere.IDMATIERE", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);

            closeConnection();

            return table;
        }
        public static DataTable getAllMatiereEnseignant(int idEn,int idClasse)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT matiere.DESIGNATION as Matiere from enseigne,matiere where enseigne.IDENSEIGNANT='" + idEn + "' AND enseigne.IDCLASSE='"+idClasse+"' and enseigne.IDMATIERE =  matiere.IDMATIERE", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);

            closeConnection();

            return table;
        }

        public static void createModuleMatieres(ETitreModule eTitreModule)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO titremodule (TITRE,NBREUA,NBREHEURE,IDUSER,IDMATIERE,IDCLASSE) VALUES" +
               "(@titre,@nbreUA,@nbreLecon,@nbreHeure,@idUser,@idMatiere,@idClasse)", connection);

            mySqlCommand.Parameters.Add("@titre", MySqlDbType.VarChar).Value = eTitreModule.titreModule;
            mySqlCommand.Parameters.Add("@nbreUA", MySqlDbType.Int32).Value = eTitreModule.nbreUA;
            mySqlCommand.Parameters.Add("@nbreHeure", MySqlDbType.Int32).Value = eTitreModule.nbreHeure;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = eTitreModule.idUser;
            mySqlCommand.Parameters.Add("@idMatiere", MySqlDbType.Int32).Value = eTitreModule.idMatiere;
            mySqlCommand.Parameters.Add("@idClasse", MySqlDbType.Int32).Value = eTitreModule.idClasse;
           



            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Module  Créer");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }

        public static DataTable getAllCreatedModuleByClasseAndMatiere(int idMatiere, int idClasse)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT IDMODULE as code,TITRE, NBREHEURE as 'Nbre Heure(s)' from titremodule where IDMATIERE='" + idMatiere + "' AND IDCLASSE='" + idClasse + "' ORDER BY IDMODULE ASC", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);

            closeConnection();

            return table;
        }

        public static void createUAMatieres(ETITREUA eTITREUA)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO titreua (TITREUA,NBREUE,NBREHEURE,IDUSER,IDMODULE) VALUES" +
               "(@titre,@nbreUE,@nbreHeure,@idUser,@idModule)", connection);

            mySqlCommand.Parameters.Add("@titre", MySqlDbType.VarChar).Value = eTITREUA.titreUA;
            mySqlCommand.Parameters.Add("@nbreUE", MySqlDbType.Int32).Value = eTITREUA.nbreUE;
            mySqlCommand.Parameters.Add("@nbreHeure", MySqlDbType.Int32).Value = eTITREUA.nbreHeure;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = eTITREUA.idUser;
            mySqlCommand.Parameters.Add("@idModule", MySqlDbType.Int32).Value = eTITREUA.idModule;
           




            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("U.A  Créer");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }


        public static DataTable getAllCreatedUABy(int idModule)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT IDTITREUA as Code,TITREUA as TITRE, NBREUE as 'Nbre U.E',NBREHEURE as 'Nbre Heure(s)'  from titreua where IDMODULE='" + idModule + "' ORDER BY IDTITREUA ASC", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);

            closeConnection();

            return table;
        }

        public static int getIdModuleTitre(int idClasse,int idMatiere,string titreModule)
        {
            int idModule = 0;
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT IDMODULE from titremodule where IDCLASSE='" + idClasse + "' AND IDMATIERE='" + idMatiere + "' AND TITRE = '"+MySqlHelper.EscapeString(titreModule)+ "'", connection);
            try { 
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            
            if (reader.HasRows)
            {
                idModule = reader.GetInt32(0);

            }


            closeConnection();

            }catch(Exception ex)
            {
                closeConnection();
                MessageBox.Show("Module : " + ex.ToString());
            }
            return idModule;
        }

        public static void createUE(ETitreUE eTitreUE)
        {
            openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO titreue (TITRE,TYPELECON,NBREHEURE,IDUSER,IDUA) VALUES" +
               "(@titre,@typeLecon,@nbreHeure,@idUser,@idUA)", connection);

            mySqlCommand.Parameters.Add("@titre", MySqlDbType.VarChar).Value = eTitreUE.titre ;
            mySqlCommand.Parameters.Add("@typeLecon", MySqlDbType.Int32).Value = eTitreUE.typeLecon;
            mySqlCommand.Parameters.Add("@nbreHeure", MySqlDbType.Int32).Value = eTitreUE.nbreHeure;
            mySqlCommand.Parameters.Add("@idUser", MySqlDbType.Int32).Value = eTitreUE.idUser;
            mySqlCommand.Parameters.Add("@idUA", MySqlDbType.Int32).Value = eTitreUE.idUA;

            //Open connection
            openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("U.E  Créer");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Close connection
            closeConnection();
        }

        public static DataTable getAllCreatedUEBy(int idUA)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT IDUE as Code, TITRE ,NBREHEURE as 'Nbre Heure(s)'," +
                "if (TYPELECON=0," +
                "'Théorique','Pratique') as 'Type De Lecon'" +
                "from titreue where IDUA='" + idUA + "' ORDER BY IDUE ASC", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);

            closeConnection();

            return table;
        }

        public static int getIdUA(int idModule,string titreUA)
        {
            int idUA = 0;
            openConnection();
            MySqlCommand command = new MySqlCommand("SELECT IDTITREUA from titreua where  IDMODULE='" + idModule + "' AND TITREUA = '" + MySqlHelper.EscapeString(titreUA) + "'", connection);
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    idUA = reader.GetInt32(0);

                }


                closeConnection();

            }
            catch (Exception ex)
            {
                closeConnection();
                MessageBox.Show("U.A : " + ex.ToString());
            }
            return idUA;
        }
    }
}
