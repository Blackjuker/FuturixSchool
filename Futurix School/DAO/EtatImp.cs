using Futurix_School_Prim_En.Entite;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futurix_School_Prim_En.DAO
{
    class EtatImp
    {

        /*
         * Génération facture 
         * 
         * */

        private static string chemin = @"C:\docs\";
        //private static string chemin = @"\\192.168.8.3\Users\CAISSE1\Documents\partage";    

        public static void factureInscription(string matricule, string dateFacture, string numeroFacture, string classe, string nomEleve, string prenomEleve, string nomUser, string montant, string resteAPayer)
        {

            Document doc = new iTextSharp.text.Document(PageSize.A4);
            BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font f_15_bold = new iTextSharp.text.Font(arial, 15, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_13_bold = new iTextSharp.text.Font(arial, 13, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_12_normal = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font f_12_bold = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_10_normal = new iTextSharp.text.Font(arial, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font f_11_bold = new iTextSharp.text.Font(arial, 11, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_18_bold = new iTextSharp.text.Font(arial, 18, iTextSharp.text.Font.BOLD);
            try
            {
               /* Random rnd = new Random();
            int name = rnd.Next(1, 1000);*/
            FileStream os = new FileStream(@"C:\docs\recu" + matricule + numeroFacture + ".pdf", FileMode.Create);
          
                using (os)
                {
                    PdfWriter.GetInstance(doc, os);

                    doc.Open();
                    doc.NewPage();
                    // PdfPTable page0 = new PdfPTable(2);
                    Paragraph title = new Paragraph("Test PDF");
                    title.Alignment = Element.ALIGN_CENTER;

                    Chunk nameChunk = new Chunk("Name: " + "\r\n");
                    Chunk bday = new Chunk("Date of Birth: ");
                    doc.Add(title);
                    

                    doc.Close();
                    System.Diagnostics.Process.Start(@"C:\docs\recu" + matricule + numeroFacture + ".pdf");

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        /**
         * Liste de classe
         * 
         * */
        public static void ListeEleve(string nomEns, string telEns, string nomClasse, string nomMat, string trimestre, string effectif, string evaluation1, string moyenne1, string evaluation2, string moyenne2, string moyenneT)

        {
            Document doc = new iTextSharp.text.Document(PageSize.A4);
            BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font f_15_bold = new iTextSharp.text.Font(arial, 15, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_13_bold = new iTextSharp.text.Font(arial, 13, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_12_normal = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font f_12_bold = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_10_normal = new iTextSharp.text.Font(arial, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font f_11_bold = new iTextSharp.text.Font(arial, 11, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_18_bold = new iTextSharp.text.Font(arial, 18, iTextSharp.text.Font.BOLD);
            //  iTextSharp.text.Font f_1_bold = new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.Color.YELLOW
            Random rnd = new Random();
            int name = rnd.Next(1, 1000);
            FileStream os = new FileStream("eleve" + name.ToString() + ".pdf", FileMode.Create);

            using (os)
            {
                PdfWriter.GetInstance(doc, os);
                doc.Open();
                iTextSharp.text.Image JPG = iTextSharp.text.Image.GetInstance("C:/Users/ARNEAUD/source/repos/Futurix School/Futurix School/bin/Debug/c.jpg");
                JPG.ScalePercent(7f);
                JPG.SetAbsolutePosition(doc.PageSize.Width - 245f - 70f, doc.PageSize.Height - 6f - 110f);
                doc.Add(JPG);

                PdfPTable table2 = new PdfPTable(1);
                float[] widths = new float[] { 40f, 60f };
                PdfPCell cel5 = new PdfPCell(new Phrase("", f_18_bold));

                cel5.Border = iTextSharp.text.Rectangle.NO_BORDER;

                cel5.HorizontalAlignment = Element.ALIGN_CENTER;

                table2.WidthPercentage = 110;

                table2.HorizontalAlignment = Element.ALIGN_CENTER;
                table2.AddCell(cel5);


                doc.Add(table2);

                //entete
                PdfPTable table5 = new PdfPTable(4);
                float[] widthd = new float[] { 40f, 60f };

                table5.SpacingAfter = 10;
                table5.SpacingBefore = 10;
                doc.Add(table5);


                // information 
                PdfPTable table7 = new PdfPTable(3);
                PdfPCell c1 = new PdfPCell(new Phrase("LES COCOTIERS GROUP ", f_15_bold));
                PdfPCell c2 = new PdfPCell(new Phrase(" ", f_15_bold));
                PdfPCell c3 = new PdfPCell(new Phrase("Compétence(s) visée(s) du trimestre", f_15_bold));
                PdfPCell c4 = new PdfPCell(new Phrase("BP: 1131 Yaoundé-Cameroun ", f_15_bold));
                PdfPCell c5 = new PdfPCell(new Phrase("  ", f_15_bold));
                PdfPCell c6 = new PdfPCell(new Phrase("Période I :", f_15_bold));
                PdfPCell c7 = new PdfPCell(new Phrase("Tel: +237 675 004 991/ 237 699 650 094", f_15_bold));
                PdfPCell c8 = new PdfPCell(new Phrase(" ", f_15_bold));
                PdfPCell c9 = new PdfPCell(new Phrase("Période II:", f_15_bold));
                PdfPCell c10 = new PdfPCell(new Phrase("Email: lescocotiers@gmail.com", f_15_bold));
                PdfPCell c11 = new PdfPCell(new Phrase(" ", f_15_bold));
                PdfPCell c12 = new PdfPCell(new Phrase("Nom de l'Enseignant:" + nomEns, f_15_bold));
                PdfPCell c13 = new PdfPCell(new Phrase(" ", f_15_bold));
                PdfPCell c14 = new PdfPCell(new Phrase(" ", f_15_bold));
                PdfPCell c15 = new PdfPCell(new Phrase("TEL:" + telEns, f_15_bold));

                c1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c9.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c11.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c12.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c13.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c14.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c15.Border = iTextSharp.text.Rectangle.NO_BORDER;
                table7.WidthPercentage = 100;
                c3.HorizontalAlignment = Element.ALIGN_LEFT;
                c6.HorizontalAlignment = Element.ALIGN_LEFT;
                c9.HorizontalAlignment = Element.ALIGN_LEFT;
                c12.HorizontalAlignment = Element.ALIGN_LEFT;
                c15.HorizontalAlignment = Element.ALIGN_LEFT;
                table7.HorizontalAlignment = Element.ALIGN_CENTER;
                table7.AddCell(c1);
                table7.AddCell(c2);
                table7.AddCell(c3);
                table7.AddCell(c4);
                table7.AddCell(c5);
                table7.AddCell(c6);
                table7.AddCell(c7);
                table7.AddCell(c8);
                table7.AddCell(c9);
                table7.AddCell(c10);
                table7.AddCell(c11);
                table7.AddCell(c12);
                table7.AddCell(c13);
                table7.AddCell(c14);
                table7.AddCell(c15);


                doc.Add(table7);



                PdfPTable table3 = new PdfPTable(2);

                PdfPCell cell = new PdfPCell(new Phrase("Liste des élèves de :" + nomClasse, new iTextSharp.text.Font(Font.FontFamily.TIMES_ROMAN, 18f, iTextSharp.text.Font.BOLD, BaseColor.GREEN)));
                PdfPCell cell0 = new PdfPCell(new Phrase("Année :2020/2021", new iTextSharp.text.Font(Font.FontFamily.TIMES_ROMAN, 18f, iTextSharp.text.Font.BOLD, BaseColor.GREEN)));

                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 150, 0);
                cell0.BackgroundColor = new iTextSharp.text.BaseColor(0, 150, 0);
                cell.BorderColor = new iTextSharp.text.BaseColor(0, 242, 0);
                cell0.BorderColor = new iTextSharp.text.BaseColor(0, 242, 0);
                cell.Border = iTextSharp.text.Rectangle.NO_BORDER | iTextSharp.text.Rectangle.NO_BORDER;
                cell0.Border = iTextSharp.text.Rectangle.NO_BORDER | iTextSharp.text.Rectangle.NO_BORDER;
                cell.BorderWidthBottom = 3f;
                cell0.BorderWidthBottom = 3f;
                cell.BorderWidthTop = 3f;
                cell0.BorderWidthTop = 3f;
                cell.PaddingBottom = 5f;
                cell0.PaddingBottom = 10f;
                cell.PaddingLeft = 10f;
                cell0.PaddingLeft = 10f;
                cell.PaddingTop = 4f;
                cell0.PaddingTop = 4f;
                table3.WidthPercentage = 80;
                cell.HorizontalAlignment = Element.ALIGN_LEFT;
                cell0.HorizontalAlignment = Element.ALIGN_LEFT;

                table3.AddCell(cell);
                table3.AddCell(cell0);

                // table3.AddCell("");

                table3.SpacingAfter = 20;
                table3.SpacingBefore = 20;
                doc.Add(table3);

                // information matière
                PdfPTable table8 = new PdfPTable(3);
                PdfPCell m1 = new PdfPCell(new Phrase("Matière: " + nomMat, f_15_bold));
                PdfPCell m2 = new PdfPCell(new Phrase("Trimestre: " + trimestre, f_15_bold));
                PdfPCell m3 = new PdfPCell(new Phrase("Effectif :" + effectif, f_15_bold));

                m1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                m2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                m3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                table8.WidthPercentage = 100;
                table8.HorizontalAlignment = Element.ALIGN_CENTER;
                table8.AddCell(m1);
                table8.AddCell(m2);
                table8.AddCell(m3);

                table8.SpacingAfter = 5;
                table8.SpacingBefore = 7;
                doc.Add(table8);

                // tableau des elèves

                // element

                PdfPTable table = new PdfPTable(7);
                // table.WidthPercentage = 100;
                // table.TotalWidth = 400f;

                //actual width of table in points
                table.TotalWidth = 525f;
                // table5.WidthPercentage = 100;

                //fix the absolute width of the table
                table.LockedWidth = true;

                //relative col widths in proportions - 1/3 and 2/3
                float[] width1 = new float[] { 50f, 136f, 46f, 46f, 46f, 46f, 51f };
                table.SetWidths(width1);
                table.HorizontalAlignment = 0;
                //leave a gap before and after the table
                table.SpacingBefore = 20f;
                table.SpacingAfter = 30f;
                // table.LockedWidth = true;
                PdfPCell header = new PdfPCell(new Phrase("Header"));
                //  header.Colspan = 7;

                // table.AddCell(header);
                //
                PdfPCell heade = new PdfPCell(new Phrase(" ", f_13_bold));
                PdfPCell head = new PdfPCell(new Phrase("PERIODE I ", f_13_bold));
                PdfPCell hea = new PdfPCell(new Phrase("PERIODE II ", f_13_bold));
                // header.Colspan = 7;
                heade.Colspan = 2;
                heade.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(heade);
                //
                head.Colspan = 2;
                head.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(head);
                //
                hea.Colspan = 2;
                hea.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(hea);

                //
                PdfPCell h1 = new PdfPCell(new Phrase(" ", f_11_bold));
                PdfPCell h2 = new PdfPCell(new Phrase("Matricule", f_11_bold));
                PdfPCell h3 = new PdfPCell(new Phrase("Nom et Prénom", f_11_bold));
                PdfPCell h4 = new PdfPCell(new Phrase("Evaluation", f_11_bold));
                PdfPCell h5 = new PdfPCell(new Phrase("Moyenne", f_11_bold));
                PdfPCell h6 = new PdfPCell(new Phrase("Evaluation", f_11_bold));
                PdfPCell h7 = new PdfPCell(new Phrase("Moyenne", f_11_bold));
                PdfPCell h8 = new PdfPCell(new Phrase("Moyenne Trimestrielle", f_11_bold));


                h1.HorizontalAlignment = Element.ALIGN_CENTER;
                h2.HorizontalAlignment = Element.ALIGN_CENTER;
                h3.HorizontalAlignment = Element.ALIGN_CENTER;
                h4.HorizontalAlignment = Element.ALIGN_CENTER;
                h5.HorizontalAlignment = Element.ALIGN_CENTER;
                h6.HorizontalAlignment = Element.ALIGN_CENTER;
                h7.HorizontalAlignment = Element.ALIGN_CENTER;
                h8.HorizontalAlignment = Element.ALIGN_CENTER;


                table.AddCell(h1);
                table.AddCell(h2);
                table.AddCell(h3);
                table.AddCell(h4);
                table.AddCell(h5);
                table.AddCell(h6);
                table.AddCell(h7);
                table.AddCell(h8);


                //


                //Generation automatique des lignes 

                EEleve ele = new EEleve();

                List<EEleve> listEleve = new List<EEleve>();

                for (int i = 0; i < 100; i++)
                {
                    listEleve.Add(new EEleve("fmarare" + i, "nom prenom"));
                }



                foreach (EEleve el in listEleve)
                {
                    PdfPCell ee1 = new PdfPCell(new Phrase(el.matricule, f_10_normal));
                    PdfPCell ee2 = new PdfPCell(new Phrase(el.nom, f_10_normal));
                    PdfPCell ee3 = new PdfPCell(new Phrase(evaluation1, f_10_normal));
                    PdfPCell ee4 = new PdfPCell(new Phrase(moyenne1, f_10_normal));
                    PdfPCell ee5 = new PdfPCell(new Phrase(evaluation2, f_10_normal));
                    PdfPCell ee6 = new PdfPCell(new Phrase(moyenne2, f_10_normal));
                    PdfPCell ee7 = new PdfPCell(new Phrase(moyenneT, f_10_normal));
                    ee1.HorizontalAlignment = Element.ALIGN_LEFT;
                    ee2.HorizontalAlignment = Element.ALIGN_LEFT;
                    ee3.HorizontalAlignment = Element.ALIGN_CENTER;
                    ee4.HorizontalAlignment = Element.ALIGN_CENTER;
                    ee5.HorizontalAlignment = Element.ALIGN_CENTER;
                    ee6.HorizontalAlignment = Element.ALIGN_CENTER;

                    table.AddCell(ee1);
                    table.AddCell(ee2);
                    table.AddCell(ee3);
                    table.AddCell(ee4);
                    table.AddCell(ee5);
                    table.AddCell(ee6);
                    table.AddCell(ee7);

                }


                doc.Add(table);

                doc.Close();
                System.Diagnostics.Process.Start(@"eleve" + name.ToString() + ".pdf");
            }
        }

        // fonction solvable 
        public static void Solvabilite(List<EInsolvable> eInsolvables, string classe, string libelleTranche, string nbreEleve, string TotalPension, string TotalRestant)
        {


            Document doc1 = new iTextSharp.text.Document(PageSize.A4);
            BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font f_15_bold = new iTextSharp.text.Font(arial, 15, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_13_bold = new iTextSharp.text.Font(arial, 13, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_12_normal = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font f_10_normal = new iTextSharp.text.Font(arial, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font f_12_bold = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_11_bold = new iTextSharp.text.Font(arial, 11, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_18_bold = new iTextSharp.text.Font(arial, 18, iTextSharp.text.Font.BOLD);
            //  iTextSharp.text.Font f_1_bold = new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.Color.YELLOW
            Random rnd = new Random();
            int name = rnd.Next(1, 1000);
            FileStream os = new FileStream(chemin+"Insolvable" + classe+libelleTranche +  ".pdf", FileMode.Create);

            using (os)
            {
                PdfWriter.GetInstance(doc1, os);
                doc1.Open();


                iTextSharp.text.Image JPG = iTextSharp.text.Image.GetInstance("C:/Users/Armel Fopa/source/repos/Futurix School/Futurix School/bin/Debug/c.jpg");
                JPG.ScalePercent(7f);
                JPG.SetAbsolutePosition(doc1.PageSize.Width - 48f - 50f, doc1.PageSize.Height - 5f - 120f);
                doc1.Add(JPG);


                // information 
                PdfPTable table7 = new PdfPTable(3);

                //actual width of table in points
                table7.TotalWidth = 525f;
                // table5.WidthPercentage = 100;

                //fix the absolute width of the table
                table7.LockedWidth = true;

                //relative col widths in proportions - 1/3 and 2/3
                float[] width1a = new float[] { 205f, 140f, 180f };
                table7.SetWidths(width1a);
                table7.HorizontalAlignment = 0;

                PdfPCell c1 = new PdfPCell(new Phrase("LES COCOTIERS GROUP", f_15_bold));
                PdfPCell c2 = new PdfPCell(new Phrase(" ", f_15_bold));
                PdfPCell c3 = new PdfPCell(new Phrase("", f_15_bold));
                PdfPCell c4 = new PdfPCell(new Phrase("BP: 1131 Yaoundé-Cameroun", f_15_bold));
                PdfPCell c5 = new PdfPCell(new Phrase("  ", f_15_bold));
                PdfPCell c6 = new PdfPCell(new Phrase("", f_15_bold));
                PdfPCell c7 = new PdfPCell(new Phrase("Tel: +237 675 004 991/ 237 699 650 094", f_15_bold));
                PdfPCell c8 = new PdfPCell(new Phrase(" ", f_15_bold));
                PdfPCell c9 = new PdfPCell(new Phrase("", f_15_bold));
                PdfPCell c10 = new PdfPCell(new Phrase("Email: lescocotiers@gmail.com", f_15_bold));
                PdfPCell c11 = new PdfPCell(new Phrase(" ", f_15_bold));
                PdfPCell c12 = new PdfPCell(new Phrase("", f_15_bold));
                PdfPCell c13 = new PdfPCell(new Phrase(" ", f_15_bold));
                PdfPCell c14 = new PdfPCell(new Phrase(" ", f_15_bold));
                PdfPCell c15 = new PdfPCell(new Phrase("", f_15_bold));

                c1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c9.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c11.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c12.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c13.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c14.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c15.Border = iTextSharp.text.Rectangle.NO_BORDER;
                table7.WidthPercentage = 100;
                c3.HorizontalAlignment = Element.ALIGN_LEFT;
                c6.HorizontalAlignment = Element.ALIGN_LEFT;
                c9.HorizontalAlignment = Element.ALIGN_LEFT;
                c12.HorizontalAlignment = Element.ALIGN_LEFT;
                c15.HorizontalAlignment = Element.ALIGN_LEFT;
                table7.HorizontalAlignment = Element.ALIGN_CENTER;
                table7.AddCell(c1);
                table7.AddCell(c2);
                table7.AddCell(c3);
                table7.AddCell(c4);
                table7.AddCell(c5);
                table7.AddCell(c6);
                table7.AddCell(c7);
                table7.AddCell(c8);
                table7.AddCell(c9);
                table7.AddCell(c10);
                table7.AddCell(c11);
                table7.AddCell(c12);
                table7.AddCell(c13);
                table7.AddCell(c14);
                table7.AddCell(c15);



                table7.SpacingAfter = 10;
                table7.SpacingBefore = 10;
                doc1.Add(table7);



                PdfPTable table3 = new PdfPTable(2);

                // table3.AddCell("");

                PdfPCell cell = new PdfPCell(new Phrase("Liste des élèves de :" + classe, new iTextSharp.text.Font(Font.FontFamily.TIMES_ROMAN, 18f, iTextSharp.text.Font.BOLD, BaseColor.GREEN)));
                PdfPCell cell0 = new PdfPCell(new Phrase("Année :2020/2021", new iTextSharp.text.Font(Font.FontFamily.TIMES_ROMAN, 18f, iTextSharp.text.Font.BOLD, BaseColor.GREEN)));

                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 150, 0);
                cell0.BackgroundColor = new iTextSharp.text.BaseColor(0, 150, 0);
                cell.BorderColor = new iTextSharp.text.BaseColor(0, 242, 0);
                cell0.BorderColor = new iTextSharp.text.BaseColor(0, 242, 0);
                cell.Border = iTextSharp.text.Rectangle.NO_BORDER | iTextSharp.text.Rectangle.NO_BORDER;
                cell0.Border = iTextSharp.text.Rectangle.NO_BORDER | iTextSharp.text.Rectangle.NO_BORDER;
                cell.BorderWidthBottom = 3f;
                cell0.BorderWidthBottom = 3f;
                cell.BorderWidthTop = 3f;
                cell0.BorderWidthTop = 3f;
                cell.PaddingBottom = 5f;
                cell0.PaddingBottom = 10f;
                cell.PaddingLeft = 10f;
                cell0.PaddingLeft = 10f;
                cell.PaddingTop = 4f;
                cell0.PaddingTop = 4f;
                table3.WidthPercentage = 80;
                cell.HorizontalAlignment = Element.ALIGN_LEFT;
                cell0.HorizontalAlignment = Element.ALIGN_LEFT;

                table3.AddCell(cell);
                table3.AddCell(cell0);

                // table3.AddCell("");

                table3.SpacingAfter = 20;
                table3.SpacingBefore = 7;
                doc1.Add(table3);

                // info versement total
                PdfPTable table8 = new PdfPTable(3);
                //actual width of table in points
                table8.TotalWidth = 525f;
                // table5.WidthPercentage = 100;

                //fix the absolute width of the table
                table8.LockedWidth = true;

                //relative col widths in proportions - 1/3 and 2/3
                float[] widthd8 = new float[] { 145f, 190f, 190f };
                table8.SetWidths(widthd8);
                table8.HorizontalAlignment = 0;

                PdfPCell m1 = new PdfPCell(new Phrase("Nombre d'élève: "+nbreEleve, f_12_bold));
                PdfPCell m2 = new PdfPCell(new Phrase("Montant total à verser: "+TotalPension, f_12_bold));
                PdfPCell m3 = new PdfPCell(new Phrase("Reste total à verser: "+TotalRestant, f_12_bold));

                m1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                m2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                m3.Border = iTextSharp.text.Rectangle.NO_BORDER;

                table8.WidthPercentage = 100;
                table8.HorizontalAlignment = Element.ALIGN_CENTER;
                table8.AddCell(m1);
                table8.AddCell(m2);
                table8.AddCell(m3);


                table8.SpacingAfter = 5;
                table8.SpacingBefore = 7;
                doc1.Add(table8);



                //entete
                PdfPTable table5 = new PdfPTable(4);
                //actual width of table in points
                table5.TotalWidth = 525f;
                // table5.WidthPercentage = 100;

                //fix the absolute width of the table
                table5.LockedWidth = true;

                //relative col widths in proportions - 1/3 and 2/3
                float[] widthd = new float[] { 50f, 136f, 47f, 47f };
                table5.SetWidths(widthd);
                table5.HorizontalAlignment = 0;
                //leave a gap before and after the table
                table5.SpacingBefore = 20f;
                table5.SpacingAfter = 30f;
                //
                PdfPCell header1 = new PdfPCell(new Phrase("Header"));
   
                // table.AddCell(header);
                //
                PdfPCell heade1 = new PdfPCell(new Phrase(" ", f_13_bold));
                PdfPCell head1 = new PdfPCell(new Phrase(libelleTranche, f_13_bold));
         
                heade1.Colspan = 2;
                heade1.HorizontalAlignment = Element.ALIGN_CENTER;
                table5.AddCell(heade1);
                //
                head1.Colspan = 2;
                head1.HorizontalAlignment = Element.ALIGN_CENTER;
                table5.AddCell(head1);

                PdfPCell h21 = new PdfPCell(new Phrase("Matricule ", f_11_bold));
                PdfPCell h31 = new PdfPCell(new Phrase("Nom et Prénom ", f_11_bold));
                PdfPCell h41 = new PdfPCell(new Phrase("Montant payé ", f_11_bold));
                PdfPCell h51 = new PdfPCell(new Phrase("Montant restant ", f_11_bold));

                h21.HorizontalAlignment = Element.ALIGN_CENTER;
                h31.HorizontalAlignment = Element.ALIGN_CENTER;
                h41.HorizontalAlignment = Element.ALIGN_CENTER;
                h51.HorizontalAlignment = Element.ALIGN_CENTER;

                table5.AddCell(h21);
                table5.AddCell(h31);
                table5.AddCell(h41);
                table5.AddCell(h51);
         

                EEleve elee = new EEleve();

               

               

                foreach (EInsolvable eInsolvable in eInsolvables)
                {

                    PdfPCell ce1 = new PdfPCell(new Phrase(eInsolvable.matricule, f_10_normal));
                    PdfPCell ce2 = new PdfPCell(new Phrase(eInsolvable.nom+" "+eInsolvable.prenom, f_10_normal));
                    PdfPCell ce3 = new PdfPCell(new Phrase(eInsolvable.montantPayer, f_10_normal));
                    PdfPCell ce4 = new PdfPCell(new Phrase(eInsolvable.montantRestant, f_10_normal));

                    ce1.HorizontalAlignment = Element.ALIGN_LEFT;
                    ce2.HorizontalAlignment = Element.ALIGN_LEFT;
                    ce3.HorizontalAlignment = Element.ALIGN_CENTER;
                    ce4.HorizontalAlignment = Element.ALIGN_CENTER;

                    table5.AddCell(ce1);
                    table5.AddCell(ce2);
                    table5.AddCell(ce3);
                    table5.AddCell(ce4);

                    table5.SpacingAfter = 10;
                    table5.SpacingBefore = 10;
                }
                doc1.Add(table5);

                doc1.Close();
                System.Diagnostics.Process.Start(@"C:\docs\Insolvable" + classe + libelleTranche + ".pdf");

            }
        }



    }
}
