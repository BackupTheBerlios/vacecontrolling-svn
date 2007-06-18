using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;



namespace VACE_Prototyp
{
    public partial class importForm : Form
    {

        Microsoft.Office.Interop.Excel.Application ExcelObj = new Microsoft.Office.Interop.Excel.Application();

        public importForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Excel Sheet importieren und in DB speichern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Andere Methode:
            //OleDbConnection oconn = new OleDbConnection();
            //oconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\test.xls;Extended Properties=Excel 8.0;HDR=Yes";
            //oconn.Open();


            //Excel Sheet ausgewählt
            if (this.excelOpenFileDialog.ShowDialog() == DialogResult.OK)
             {
                 Microsoft.Office.Interop.Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(excelOpenFileDialog.FileName, 0, true, 5,"", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true,null,null);
                 Microsoft.Office.Interop.Excel.Sheets sheets = theWorkbook.Worksheets;
                 Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)sheets.get_Item(1);
                 ExcelimportDataSet.MitarbeiterDataTable mdt = new  ExcelimportDataSet.MitarbeiterDataTable();
                 ExcelimportDataSetTableAdapters.MitarbeiterTableAdapter mta = new VACE_Prototyp.ExcelimportDataSetTableAdapters.MitarbeiterTableAdapter();
                 int i = 1;
                
                //Solange Datensätze im Sheet sind
                while(true)
                 {
 
                    Microsoft.Office.Interop.Excel.Range range = worksheet.get_Range("A" + i.ToString(), "G"+ i.ToString());
                     System.Array myvalues = (System.Array)range.Cells.Value2;
                     ExcelimportDataSet.MitarbeiterRow mr = mdt.NewMitarbeiterRow();

                    //Falls kein Wert in der Zeile
                    if (myvalues.GetValue(1, 1) == null)
                         break;

                    //Prüfen ob der Mitarbeiter bereits existiert, wenn ja löschen
                     if (((int)mta.CheckExistMA(Convert.ToInt32(myvalues.GetValue(1, 1).ToString()))) == 1)
                         mta.DeleteByMitarbeiterNr(Convert.ToInt32(myvalues.GetValue(1, 1).ToString()));
                     
                    //Alle Spalten durchgehen
                     for (int k = 1; k < myvalues.Length; k++)
                     {
                         DateTime itemDate;
                         String itemString;

                         mdt.ImportRow(mdt.NewMitarbeiterRow());
                         //if (myvalues.GetValue(1,k)!=null)

                         //Falls Geburtsdatum in Datumsformat konvertieren und im richtigen Feld speichern
                         if (k==4)
                         {
                             itemDate = getDateTime(myvalues.GetValue(1, k));
                             empListView.Items.Add(itemDate.ToString());
                             mr.GebDatum = itemDate;
                            
                         }
                         //Falls Einstelldatum in Datumsformat konvertieren und im richtigen Feld speichern
                         else if (k== 6)
                         {
                              itemDate = getDateTime(myvalues.GetValue(1, k));

                              mr.EinstellDatum = itemDate;
                         }
                         //Spalte hat das Format String
                         else
                         {
                             itemString = myvalues.GetValue(1, k).ToString();
                             empListView.Items.Add(itemString);

                             //Die verschiedenen Felder in der DB sind zu unterscheiden
                             if (k == 1)
                                 mr.MitarbeiterNr = Convert.ToInt32(itemString);
                             else if (k == 2)
                                 mr.Vorname = itemString;
                             else if (k == 3)
                                 mr.Nachname = itemString;
                             else if (k == 5)
                                 mr.Abteilung = itemString;

                         }

                     
                     }
                         //Reihe in der Datatable hinzufügen
                         mdt.Rows.Add(mr);
                         
                     i++;


                 }
                empGridView.DataSource = mdt;

                //Änderungen in der DB speichern
                mta.Update(mdt);
                mdt.AcceptChanges();
                ExcelObj.Quit();
                MessageBox.Show("Daten erfolgreich importiert!");
             
             }

}
        /// <summary>
        /// Objekt in String konvertieren
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private String getString(object p)
        {
            return p.ToString();
        }
        /// <summary>
        /// Objekt in Datum konvertieren
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private DateTime getDateTime(object p)
        {
            return DateTime.FromOADate(Convert.ToDouble(p));
        }

        /// <summary>
        /// Excel Objekt beim Schließen der Form löschen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Testform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ExcelObj != null)
                ExcelObj.Quit();
        }


        }



}
