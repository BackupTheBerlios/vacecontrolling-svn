using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using VACE_Controlling.Outlookbar;

namespace VACE_Controlling
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem schließenToolStripMenuItem;
        private ToolStripMenuItem bearbeitenToolStripMenuItem;
        private ToolStripMenuItem ansichtToolStripMenuItem;
        private ToolStripMenuItem hilfeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private SplitContainer splitContainer1;
        private OutlookBar outlookBar;
        private TabControl TabControl;
        private TabPage tabPage1;
        TabPage neu = new TabPage("Hallo");
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private BindingSource testdatenbankDataSetBindingSource;
        private TestdatenbankDataSet testdatenbankDataSet;
        private SplitContainer splitContainer2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn SVNr;
        private DataGridViewTextBoxColumn Vorname;
        private DataGridViewTextBoxColumn Nachname;
        private DataGridViewTextBoxColumn Abteilung;
        private DataGridViewTextBoxColumn Arbeitszeitmodell;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label labelID;
        private Button button2;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private ImageList imageList1;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem öffnenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem speichernToolStripMenuItem;
        private ToolStripMenuItem speichernUnterToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem druckenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private TabPage tabPage2;
        private SplitContainer splitContainer3;
        private Button button3;
        private Button button4;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox8;
        private Label label11;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TabPage tabPage3;
        private SplitContainer splitContainer4;
        private DataGridView dataGridView3;
        private Label label42;
        private CheckBox checkBox1;
        private Button button5;
        private Button button6;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label12;
        private Label label13;
        private TextBox textBox9;
        private Label label14;
        private TextBox textBox10;
        private Label label15;
        private TextBox textBox11;
        private Label label16;
        private TextBox textBox12;
        private Label label17;
        private TabPage tabPage4;
        private SplitContainer splitContainer5;
        private Button button7;
        private Button button8;
        private Label label19;
        private TextBox textBox13;
        private Label label20;
        private TextBox textBox14;
        private Label label21;
        private TextBox textBox15;
        private Label label22;
        private TextBox textBox16;
        private Label label23;
        private DataGridView dataGridView4;
        private TabPage tabPage5;
        private SplitContainer splitContainer6;
        private Button button9;
        private Button button10;
        private DataGridView dataGridView5;
        private TabPage tabPage6;
        private SplitContainer splitContainer7;
        private DataGridView dataGridView6;
        private TabPage tabPage7;
        private SplitContainer splitContainer8;
        private Button button13;
        private Button button14;
        private ComboBox comboBox14;
        private Label label40;
        private TextBox textBox28;
        private Label label41;
        private DataGridView dataGridView7;
        private DataGridViewTextBoxColumn ProjektNr;
        private DataGridViewTextBoxColumn Projektbez;
        private DataGridViewTextBoxColumn Partner;
        private DataGridViewTextBoxColumn TelNr;
        private DataGridViewTextBoxColumn Bestellwert;
        private DataGridViewTextBoxColumn Auftragswert;
        private DataGridViewCheckBoxColumn Abgeschlossen;
        private Label label18;
        private TextBox textBox29;
        private DataGridView dataGridView8;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewTextBoxColumn Arbeitszeit;
        private Label label25;
        private ComboBox comboBox8;
        private Label label24;
        private ComboBox comboBox7;
        private Label label26;
        private Label label27;
        private Button button15;
        private Button button16;
        private TextBox textBox17;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label49;
        private Label label48;
        private TextBox textBox34;
        private Label label47;
        private TextBox textBox33;
        private Label label46;
        private TextBox textBox32;
        private Label label45;
        private TextBox textBox31;
        private Label label44;
        private TextBox textBox30;
        private Label label43;
        private TextBox textBox20;
        private Label label29;
        private TextBox textBox19;
        private Label label28;
        private Label label35;
        private DataGridViewTextBoxColumn Monat;
        private DataGridViewTextBoxColumn Mitarbeiter;
        private DataGridViewTextBoxColumn Anzahl;
        private DataGridViewTextBoxColumn Krank;
        private DataGridViewTextBoxColumn FB;
        private DataGridViewTextBoxColumn Urlaub;
        private DataGridViewTextBoxColumn UrlaubUnbezahlt;
        private DataGridViewTextBoxColumn Sonstiges;
        private DataGridViewTextBoxColumn ZADiff;
        private DataGridViewTextBoxColumn ZA;
        private ComboBox comboBox18;
        private Label label51;
        private ComboBox comboBox9;
        private ComboBox comboBox12;
        private Label label32;
        private ComboBox comboBox10;
        private Label label30;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label33;
        private ComboBox comboBox15;
        private Label label52;
        private Label label36;
        private TextBox textBox22;
        private Label label34;
        private TextBox textBox21;
        private Label label37;
        private TextBox textBox23;
        private Label label38;
        private Button button11;
        private Button button12;
        private Label label39;
        private Label label50;
        private TextBox textBox18;
        private Label label53;
        private ComboBox comboBox11;
        private RadioButton radioButton5;
        private Label label55;
        private TextBox textBox26;
        private Label label54;
        private TextBox textBox25;
        private Label label31;
        private TextBox textBox24;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private DataGridViewTextBoxColumn Bezeichnung;
        private DataGridViewTextBoxColumn Montag;
        private DataGridViewTextBoxColumn Dienstag;
        private DataGridViewTextBoxColumn Mittwoch;
        private DataGridViewTextBoxColumn Donnerstag;
        private DataGridViewTextBoxColumn Freitag;
        private DataGridViewTextBoxColumn Projekt;
        private DataGridViewTextBoxColumn Mitarbeiter1;
        private DataGridViewTextBoxColumn Konditionen;
        private DataGridViewTextBoxColumn Monat1;
        private DataGridViewTextBoxColumn Norm;
        private DataGridViewTextBoxColumn Stund50;
        private DataGridViewTextBoxColumn Stund100;
        private DataGridViewTextBoxColumn Projekt01;
        private DataGridViewTextBoxColumn Rechnungsnummer;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Text;
        private DataGridViewTextBoxColumn Preis;
        private DataGridViewTextBoxColumn Monat29;
        private ComboBox comboBox13;
        private RadioButton radioButton6;
        private IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call				 
			//
			outlookBar.Location=new Point(0, 0);
			outlookBar.Size=new Size(150, this.ClientSize.Height);
			outlookBar.BorderStyle=BorderStyle.FixedSingle;
           

			outlookBar.Initialize();
            
			IconPanel iconPanel1=new IconPanel();
			IconPanel iconPanel2=new IconPanel();
			IconPanel iconPanel3=new IconPanel();

			outlookBar.AddBand("Stammdaten", iconPanel1);
			outlookBar.AddBand("Stundeneingabe", iconPanel2);
			outlookBar.AddBand("Berichte", iconPanel3);

            iconPanel1.setColor(Color.LightBlue);
            iconPanel1.AddIcon("Mitarbeiterdaten",  new EventHandler(PanelEvent));
            iconPanel1.AddIcon("Projektdaten",  new EventHandler(PanelEvent));
            iconPanel1.AddIcon("Arbeitszeitmodelle",  new EventHandler(PanelEvent));

            iconPanel2.setColor(Color.LightBlue);
            iconPanel2.AddIcon("Produktive Stunden",  new EventHandler(PanelEvent));
            iconPanel2.AddIcon("Unproduktive Stunden",  new EventHandler(PanelEvent));
            iconPanel2.AddIcon("Fremdleistungen",  new EventHandler(PanelEvent));


            iconPanel3.setColor(Color.LightBlue);
            iconPanel3.AddIcon("Mitarbeiterübersicht",  new EventHandler(PanelEvent));
            //iconPanel2.AddIcon("Produktivstundenübersicht", new EventHandler(PanelEvent));
            //iconPanel2.AddIcon("Unproduktivstundenübersicht",  new EventHandler(PanelEvent));
            iconPanel3.AddIcon("Projektübersicht",  new EventHandler(PanelEvent));
            iconPanel3.AddIcon("Projektdetails",  new EventHandler(PanelEvent));
            iconPanel3.AddIcon("Abteilungsübersicht",  new EventHandler(PanelEvent));
            iconPanel3.AddIcon("Fremdleistungsübersicht",  new EventHandler(PanelEvent));


            outlookBar.SelectBand(0);

            

            
		}

		public void PanelEvent(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.outlookBar = new VACE_Controlling.Outlookbar.OutlookBar();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SVNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abteilung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arbeitszeitmodell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testdatenbankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testdatenbankDataSet = new VACE_Controlling.TestdatenbankDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label42 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ProjektNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projektbez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bestellwert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auftragswert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abgeschlossen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arbeitszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mittwoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donnerstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freitag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Monat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mitarbeiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Krank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urlaub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlaubUnbezahlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonstiges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZADiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label33 = new System.Windows.Forms.Label();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Projekt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mitarbeiter1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konditionen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stund50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stund100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.Projekt01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rechnungsnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monat29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdatenbankDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdatenbankDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.ansichtToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.toolStripSeparator4,
            this.speichernToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.toolStripSeparator6,
            this.druckenToolStripMenuItem,
            this.toolStripSeparator5,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Image = global::VACE_Controlling.Properties.Resources.newdocument;
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öffnenToolStripMenuItem.Image")));
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("speichernToolStripMenuItem.Image")));
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.speichernUnterToolStripMenuItem.Text = "Speichern unter";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(158, 6);
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("druckenToolStripMenuItem.Image")));
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.druckenToolStripMenuItem.Text = "Drucken";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(158, 6);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(814, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "Jahr: 2006";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(814, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::VACE_Controlling.Properties.Resources.newdocument;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::VACE_Controlling.Properties.Resources.copy;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::VACE_Controlling.Properties.Resources.paste;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::VACE_Controlling.Properties.Resources.cut;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.outlookBar);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabControl);
            this.splitContainer1.Size = new System.Drawing.Size(814, 511);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 3;
            // 
            // outlookBar
            // 
            this.outlookBar.ButtonHeight = 25;
            this.outlookBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outlookBar.Location = new System.Drawing.Point(0, 0);
            this.outlookBar.Name = "outlookBar";
            this.outlookBar.SelectedBand = 0;
            this.outlookBar.Size = new System.Drawing.Size(145, 511);
            this.outlookBar.TabIndex = 0;
            this.outlookBar.Paint += new System.Windows.Forms.PaintEventHandler(this.outlookBar_Paint);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Controls.Add(this.tabPage5);
            this.TabControl.Controls.Add(this.tabPage6);
            this.TabControl.Controls.Add(this.tabPage7);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImageList = this.imageList1;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(665, 511);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.ImageKey = "(Keine)";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(657, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mitarbeiter";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.labelID);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(651, 478);
            this.splitContainer2.SplitterDistance = 196;
            this.splitContainer2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(110, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "38,5 Stunden";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "ATI2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Arbeitszeitmodell:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Abteilung:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Mustermann";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nachname:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vorname:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "938719121900";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "SVNr:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "1";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(16, 17);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            this.labelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SVNr,
            this.Vorname,
            this.Nachname,
            this.Abteilung,
            this.Arbeitszeitmodell});
            this.dataGridView1.DataSource = this.testdatenbankDataSetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // SVNr
            // 
            this.SVNr.HeaderText = "SVNr";
            this.SVNr.Name = "SVNr";
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.Name = "Vorname";
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.Name = "Nachname";
            // 
            // Abteilung
            // 
            this.Abteilung.HeaderText = "Abteilung";
            this.Abteilung.Name = "Abteilung";
            // 
            // Arbeitszeitmodell
            // 
            this.Arbeitszeitmodell.HeaderText = "Arbeitszeitmodell";
            this.Arbeitszeitmodell.Name = "Arbeitszeitmodell";
            // 
            // testdatenbankDataSetBindingSource
            // 
            this.testdatenbankDataSetBindingSource.DataSource = this.testdatenbankDataSet;
            this.testdatenbankDataSetBindingSource.Position = 0;
            // 
            // testdatenbankDataSet
            // 
            this.testdatenbankDataSet.DataSetName = "TestdatenbankDataSet";
            this.testdatenbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer4);
            this.tabPage3.ImageKey = "(Keine)";
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(657, 484);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Projekte";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label42);
            this.splitContainer4.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer4.Panel1.Controls.Add(this.button5);
            this.splitContainer4.Panel1.Controls.Add(this.button6);
            this.splitContainer4.Panel1.Controls.Add(this.comboBox5);
            this.splitContainer4.Panel1.Controls.Add(this.comboBox6);
            this.splitContainer4.Panel1.Controls.Add(this.label12);
            this.splitContainer4.Panel1.Controls.Add(this.label13);
            this.splitContainer4.Panel1.Controls.Add(this.textBox9);
            this.splitContainer4.Panel1.Controls.Add(this.label14);
            this.splitContainer4.Panel1.Controls.Add(this.textBox10);
            this.splitContainer4.Panel1.Controls.Add(this.label15);
            this.splitContainer4.Panel1.Controls.Add(this.textBox11);
            this.splitContainer4.Panel1.Controls.Add(this.label16);
            this.splitContainer4.Panel1.Controls.Add(this.textBox12);
            this.splitContainer4.Panel1.Controls.Add(this.label17);
            this.splitContainer4.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer4_Panel1_Paint);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer4.Size = new System.Drawing.Size(651, 478);
            this.splitContainer4.SplitterDistance = 231;
            this.splitContainer4.TabIndex = 0;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(16, 173);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(82, 13);
            this.label42.TabIndex = 21;
            this.label42.Text = "Abgeschlossen:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(110, 172);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(213, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Abbrechen";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(132, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Speichern";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(110, 144);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(176, 21);
            this.comboBox5.TabIndex = 17;
            this.comboBox5.Text = "15000";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(110, 117);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(176, 21);
            this.comboBox6.TabIndex = 16;
            this.comboBox6.Text = "10000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Auftragswert:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Bestellwert:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(110, 91);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(176, 20);
            this.textBox9.TabIndex = 12;
            this.textBox9.Text = "0725 / 9283672";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Tel.-Nr. Partner";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(110, 66);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(176, 20);
            this.textBox10.TabIndex = 10;
            this.textBox10.Text = "Haider";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Partner:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(110, 40);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(176, 20);
            this.textBox11.TabIndex = 8;
            this.textBox11.Text = "APRHAD01";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Projektbez:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(110, 14);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(176, 20);
            this.textBox12.TabIndex = 6;
            this.textBox12.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "ProjektNr:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjektNr,
            this.Projektbez,
            this.Partner,
            this.TelNr,
            this.Bestellwert,
            this.Auftragswert,
            this.Abgeschlossen});
            this.dataGridView3.DataSource = this.testdatenbankDataSetBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(651, 243);
            this.dataGridView3.TabIndex = 0;
            // 
            // ProjektNr
            // 
            this.ProjektNr.HeaderText = "ProjektNr";
            this.ProjektNr.Name = "ProjektNr";
            // 
            // Projektbez
            // 
            this.Projektbez.HeaderText = "Projektbez";
            this.Projektbez.Name = "Projektbez";
            // 
            // Partner
            // 
            this.Partner.HeaderText = "Partner";
            this.Partner.Name = "Partner";
            // 
            // TelNr
            // 
            this.TelNr.HeaderText = "TelNr";
            this.TelNr.Name = "TelNr";
            // 
            // Bestellwert
            // 
            this.Bestellwert.HeaderText = "Bestellwert";
            this.Bestellwert.Name = "Bestellwert";
            // 
            // Auftragswert
            // 
            this.Auftragswert.HeaderText = "Auftragswert";
            this.Auftragswert.Name = "Auftragswert";
            // 
            // Abgeschlossen
            // 
            this.Abgeschlossen.HeaderText = "Abgeschlossen";
            this.Abgeschlossen.Name = "Abgeschlossen";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer5);
            this.tabPage4.ImageKey = "(Keine)";
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(657, 484);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Arbeitszeitmodelle";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.textBox18);
            this.splitContainer5.Panel1.Controls.Add(this.label53);
            this.splitContainer5.Panel1.Controls.Add(this.dataGridView8);
            this.splitContainer5.Panel1.Controls.Add(this.label18);
            this.splitContainer5.Panel1.Controls.Add(this.textBox29);
            this.splitContainer5.Panel1.Controls.Add(this.button7);
            this.splitContainer5.Panel1.Controls.Add(this.button8);
            this.splitContainer5.Panel1.Controls.Add(this.label19);
            this.splitContainer5.Panel1.Controls.Add(this.textBox13);
            this.splitContainer5.Panel1.Controls.Add(this.label20);
            this.splitContainer5.Panel1.Controls.Add(this.textBox14);
            this.splitContainer5.Panel1.Controls.Add(this.label21);
            this.splitContainer5.Panel1.Controls.Add(this.textBox15);
            this.splitContainer5.Panel1.Controls.Add(this.label22);
            this.splitContainer5.Panel1.Controls.Add(this.textBox16);
            this.splitContainer5.Panel1.Controls.Add(this.label23);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.dataGridView4);
            this.splitContainer5.Size = new System.Drawing.Size(651, 478);
            this.splitContainer5.SplitterDistance = 196;
            this.splitContainer5.TabIndex = 0;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(111, 10);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(176, 20);
            this.textBox18.TabIndex = 24;
            this.textBox18.Text = "38,5 Stunden";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(17, 13);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(72, 13);
            this.label53.TabIndex = 23;
            this.label53.Text = "Bezeichnung:";
            // 
            // dataGridView8
            // 
            this.dataGridView8.AllowUserToOrderColumns = true;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag,
            this.Arbeitszeit});
            this.dataGridView8.Location = new System.Drawing.Point(316, 33);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.Size = new System.Drawing.Size(246, 160);
            this.dataGridView8.TabIndex = 22;
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            // 
            // Arbeitszeit
            // 
            this.Arbeitszeit.HeaderText = "Arbeitszeit";
            this.Arbeitszeit.Name = "Arbeitszeit";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(313, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Besondere Tage:";
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(111, 140);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(176, 20);
            this.textBox29.TabIndex = 20;
            this.textBox29.Text = "5,5";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(214, 163);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Abbrechen";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(133, 163);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Speichern";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Freitag:";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(111, 110);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(176, 20);
            this.textBox13.TabIndex = 12;
            this.textBox13.Text = "8,25";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Donnerstag:";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(111, 85);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(176, 20);
            this.textBox14.TabIndex = 10;
            this.textBox14.Text = "8,25";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Mittwoch:";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(111, 59);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(176, 20);
            this.textBox15.TabIndex = 8;
            this.textBox15.Text = "8,25";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Dienstag:";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(111, 33);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(176, 20);
            this.textBox16.TabIndex = 6;
            this.textBox16.Text = "8,25";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Montag:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bezeichnung,
            this.Montag,
            this.Dienstag,
            this.Mittwoch,
            this.Donnerstag,
            this.Freitag});
            this.dataGridView4.DataSource = this.testdatenbankDataSetBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(651, 278);
            this.dataGridView4.TabIndex = 0;
            // 
            // Bezeichnung
            // 
            this.Bezeichnung.HeaderText = "Bezeichnung";
            this.Bezeichnung.Name = "Bezeichnung";
            // 
            // Montag
            // 
            this.Montag.HeaderText = "Montag";
            this.Montag.Name = "Montag";
            // 
            // Dienstag
            // 
            this.Dienstag.HeaderText = "Dienstag";
            this.Dienstag.Name = "Dienstag";
            // 
            // Mittwoch
            // 
            this.Mittwoch.HeaderText = "Mittwoch";
            this.Mittwoch.Name = "Mittwoch";
            // 
            // Donnerstag
            // 
            this.Donnerstag.HeaderText = "Donnerstag";
            this.Donnerstag.Name = "Donnerstag";
            // 
            // Freitag
            // 
            this.Freitag.HeaderText = "Freitag";
            this.Freitag.Name = "Freitag";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer6);
            this.tabPage5.ImageKey = "(Keine)";
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(657, 484);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Unproduktivstunden";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.comboBox13);
            this.splitContainer6.Panel1.Controls.Add(this.radioButton6);
            this.splitContainer6.Panel1.Controls.Add(this.radioButton2);
            this.splitContainer6.Panel1.Controls.Add(this.radioButton1);
            this.splitContainer6.Panel1.Controls.Add(this.label49);
            this.splitContainer6.Panel1.Controls.Add(this.label48);
            this.splitContainer6.Panel1.Controls.Add(this.textBox34);
            this.splitContainer6.Panel1.Controls.Add(this.label47);
            this.splitContainer6.Panel1.Controls.Add(this.textBox33);
            this.splitContainer6.Panel1.Controls.Add(this.label46);
            this.splitContainer6.Panel1.Controls.Add(this.textBox32);
            this.splitContainer6.Panel1.Controls.Add(this.label45);
            this.splitContainer6.Panel1.Controls.Add(this.textBox31);
            this.splitContainer6.Panel1.Controls.Add(this.label44);
            this.splitContainer6.Panel1.Controls.Add(this.textBox30);
            this.splitContainer6.Panel1.Controls.Add(this.label43);
            this.splitContainer6.Panel1.Controls.Add(this.textBox20);
            this.splitContainer6.Panel1.Controls.Add(this.label29);
            this.splitContainer6.Panel1.Controls.Add(this.textBox19);
            this.splitContainer6.Panel1.Controls.Add(this.label28);
            this.splitContainer6.Panel1.Controls.Add(this.textBox17);
            this.splitContainer6.Panel1.Controls.Add(this.label25);
            this.splitContainer6.Panel1.Controls.Add(this.comboBox8);
            this.splitContainer6.Panel1.Controls.Add(this.label24);
            this.splitContainer6.Panel1.Controls.Add(this.comboBox7);
            this.splitContainer6.Panel1.Controls.Add(this.button9);
            this.splitContainer6.Panel1.Controls.Add(this.button10);
            this.splitContainer6.Panel1.Controls.Add(this.label26);
            this.splitContainer6.Panel1.Controls.Add(this.label27);
            this.splitContainer6.Panel1.Controls.Add(this.button15);
            this.splitContainer6.Panel1.Controls.Add(this.button16);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.dataGridView5);
            this.splitContainer6.Size = new System.Drawing.Size(651, 478);
            this.splitContainer6.SplitterDistance = 196;
            this.splitContainer6.TabIndex = 0;
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(510, 97);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(121, 21);
            this.comboBox13.TabIndex = 55;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(491, 74);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(74, 17);
            this.radioButton6.TabIndex = 54;
            this.radioButton6.Text = "Mitarbeiter";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(490, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(195, 17);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nicht eingetragene in diesem Monat";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(491, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 41;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Alle";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(490, 14);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(45, 13);
            this.label49.TabIndex = 40;
            this.label49.Text = "Ansicht:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(241, 94);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(21, 13);
            this.label48.TabIndex = 39;
            this.label48.Text = "ZA";
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(334, 92);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(121, 20);
            this.textBox34.TabIndex = 38;
            this.textBox34.Text = "-45,2";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(241, 68);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(66, 13);
            this.label47.TabIndex = 37;
            this.label47.Text = "ZA-Differenz";
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(334, 66);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(121, 20);
            this.textBox33.TabIndex = 36;
            this.textBox33.Text = "-2,7";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(241, 42);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(53, 13);
            this.label46.TabIndex = 35;
            this.label46.Text = "Sonstiges";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(334, 40);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(121, 20);
            this.textBox32.TabIndex = 34;
            this.textBox32.Text = "0";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(241, 17);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(87, 13);
            this.label45.TabIndex = 33;
            this.label45.Text = "Urlaub unbezahlt";
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(334, 15);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(121, 20);
            this.textBox31.TabIndex = 32;
            this.textBox31.Text = "2";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(33, 148);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(38, 13);
            this.label44.TabIndex = 31;
            this.label44.Text = "Urlaub";
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(114, 145);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(121, 20);
            this.textBox30.TabIndex = 30;
            this.textBox30.Text = "3";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(33, 123);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(78, 13);
            this.label43.TabIndex = 29;
            this.label43.Text = "Freizeit Bezahlt";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(114, 120);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(121, 20);
            this.textBox20.TabIndex = 28;
            this.textBox20.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(33, 97);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 13);
            this.label29.TabIndex = 27;
            this.label29.Text = "Krank";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(114, 94);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(121, 20);
            this.textBox19.TabIndex = 26;
            this.textBox19.Text = "10";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(33, 71);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 13);
            this.label28.TabIndex = 25;
            this.label28.Text = "Anzahl";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(114, 68);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(121, 20);
            this.textBox17.TabIndex = 1;
            this.textBox17.Text = "15";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(33, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "Mitarbeiter";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(114, 41);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 23;
            this.comboBox8.Text = "Max Mustermann";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(33, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "Monat:";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(114, 14);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 21;
            this.comboBox7.Text = "DEZEMBER";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(211, 171);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Abbrechen";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(130, 171);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 18;
            this.button10.Text = "Speichern";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(33, 44);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 24;
            this.label26.Text = "Mitarbeiter";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(33, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Monat:";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(211, 171);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 19;
            this.button15.Text = "Abbrechen";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(130, 171);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 18;
            this.button16.Text = "Speichern";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monat,
            this.Mitarbeiter,
            this.Anzahl,
            this.Krank,
            this.FB,
            this.Urlaub,
            this.UrlaubUnbezahlt,
            this.Sonstiges,
            this.ZADiff,
            this.ZA});
            this.dataGridView5.DataSource = this.testdatenbankDataSetBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(651, 278);
            this.dataGridView5.TabIndex = 0;
            // 
            // Monat
            // 
            this.Monat.HeaderText = "Monat";
            this.Monat.Name = "Monat";
            // 
            // Mitarbeiter
            // 
            this.Mitarbeiter.HeaderText = "Mitarbeiter";
            this.Mitarbeiter.Name = "Mitarbeiter";
            // 
            // Anzahl
            // 
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.Name = "Anzahl";
            // 
            // Krank
            // 
            this.Krank.HeaderText = "Krank";
            this.Krank.Name = "Krank";
            // 
            // FB
            // 
            this.FB.HeaderText = "FB";
            this.FB.Name = "FB";
            // 
            // Urlaub
            // 
            this.Urlaub.HeaderText = "Urlaub";
            this.Urlaub.Name = "Urlaub";
            // 
            // UrlaubUnbezahlt
            // 
            this.UrlaubUnbezahlt.HeaderText = "UrlaubUnbezahlt";
            this.UrlaubUnbezahlt.Name = "UrlaubUnbezahlt";
            // 
            // Sonstiges
            // 
            this.Sonstiges.HeaderText = "Sonstiges";
            this.Sonstiges.Name = "Sonstiges";
            // 
            // ZADiff
            // 
            this.ZADiff.HeaderText = "ZADiff";
            this.ZADiff.Name = "ZADiff";
            // 
            // ZA
            // 
            this.ZA.HeaderText = "ZA";
            this.ZA.Name = "ZA";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.splitContainer7);
            this.tabPage6.ImageKey = "(Keine)";
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(657, 484);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "Produktivstunden";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.comboBox11);
            this.splitContainer7.Panel1.Controls.Add(this.radioButton5);
            this.splitContainer7.Panel1.Controls.Add(this.label55);
            this.splitContainer7.Panel1.Controls.Add(this.textBox26);
            this.splitContainer7.Panel1.Controls.Add(this.label54);
            this.splitContainer7.Panel1.Controls.Add(this.textBox25);
            this.splitContainer7.Panel1.Controls.Add(this.label31);
            this.splitContainer7.Panel1.Controls.Add(this.textBox24);
            this.splitContainer7.Panel1.Controls.Add(this.radioButton3);
            this.splitContainer7.Panel1.Controls.Add(this.radioButton4);
            this.splitContainer7.Panel1.Controls.Add(this.label33);
            this.splitContainer7.Panel1.Controls.Add(this.comboBox18);
            this.splitContainer7.Panel1.Controls.Add(this.label51);
            this.splitContainer7.Panel1.Controls.Add(this.comboBox9);
            this.splitContainer7.Panel1.Controls.Add(this.label35);
            this.splitContainer7.Panel1.Controls.Add(this.comboBox12);
            this.splitContainer7.Panel1.Controls.Add(this.label32);
            this.splitContainer7.Panel1.Controls.Add(this.comboBox10);
            this.splitContainer7.Panel1.Controls.Add(this.label30);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.dataGridView6);
            this.splitContainer7.Size = new System.Drawing.Size(651, 478);
            this.splitContainer7.SplitterDistance = 196;
            this.splitContainer7.TabIndex = 0;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(470, 98);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 21);
            this.comboBox11.TabIndex = 53;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(451, 75);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(74, 17);
            this.radioButton5.TabIndex = 52;
            this.radioButton5.Text = "Mitarbeiter";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(219, 63);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(97, 13);
            this.label55.TabIndex = 51;
            this.label55.Text = "Überstunden 100%";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(324, 61);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(121, 20);
            this.textBox26.TabIndex = 50;
            this.textBox26.Text = "10";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(219, 40);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(91, 13);
            this.label54.TabIndex = 49;
            this.label54.Text = "Überstunden 50%";
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(324, 38);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(121, 20);
            this.textBox25.TabIndex = 48;
            this.textBox25.Text = "3";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(219, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(81, 13);
            this.label31.TabIndex = 47;
            this.label31.Text = "Normalstunden:";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(324, 14);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(121, 20);
            this.textBox24.TabIndex = 46;
            this.textBox24.Text = "15";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(451, 51);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(195, 17);
            this.radioButton3.TabIndex = 45;
            this.radioButton3.Text = "Nicht eingetragene in diesem Monat";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(452, 28);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(42, 17);
            this.radioButton4.TabIndex = 44;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Alle";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(451, 11);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(45, 13);
            this.label33.TabIndex = 43;
            this.label33.Text = "Ansicht:";
            // 
            // comboBox18
            // 
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(88, 93);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(121, 21);
            this.comboBox18.TabIndex = 12;
            this.comboBox18.Text = "DEZEMBER";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(22, 96);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(40, 13);
            this.label51.TabIndex = 11;
            this.label51.Text = "Monat:";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(88, 38);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 1;
            this.comboBox9.Text = "Max Mustermann";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(22, 41);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 13);
            this.label35.TabIndex = 0;
            this.label35.Text = "Mitarbeiter:";
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(88, 65);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(121, 21);
            this.comboBox12.TabIndex = 7;
            this.comboBox12.Text = "Mustermann ab 19.11.2006";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(22, 68);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(66, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Konditionen:";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(88, 11);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 21);
            this.comboBox10.TabIndex = 1;
            this.comboBox10.Text = "APRHAD01";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(22, 14);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Projekt:";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Projekt,
            this.Mitarbeiter1,
            this.Konditionen,
            this.Monat1,
            this.Norm,
            this.Stund50,
            this.Stund100});
            this.dataGridView6.DataSource = this.testdatenbankDataSetBindingSource;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(651, 278);
            this.dataGridView6.TabIndex = 0;
            // 
            // Projekt
            // 
            this.Projekt.HeaderText = "Projekt";
            this.Projekt.Name = "Projekt";
            // 
            // Mitarbeiter1
            // 
            this.Mitarbeiter1.HeaderText = "Mitarbeiter";
            this.Mitarbeiter1.Name = "Mitarbeiter1";
            // 
            // Konditionen
            // 
            this.Konditionen.HeaderText = "Konditionen";
            this.Konditionen.Name = "Konditionen";
            // 
            // Monat1
            // 
            this.Monat1.HeaderText = "Monat";
            this.Monat1.Name = "Monat1";
            // 
            // Norm
            // 
            this.Norm.HeaderText = "Norm";
            this.Norm.Name = "Norm";
            // 
            // Stund50
            // 
            this.Stund50.HeaderText = "50%";
            this.Stund50.Name = "Stund50";
            // 
            // Stund100
            // 
            this.Stund100.HeaderText = "100%";
            this.Stund100.Name = "Stund100";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.splitContainer8);
            this.tabPage7.ImageKey = "(Keine)";
            this.tabPage7.Location = new System.Drawing.Point(4, 23);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(657, 484);
            this.tabPage7.TabIndex = 5;
            this.tabPage7.Text = "Fremdleistungen";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(3, 3);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.comboBox15);
            this.splitContainer8.Panel1.Controls.Add(this.label52);
            this.splitContainer8.Panel1.Controls.Add(this.label36);
            this.splitContainer8.Panel1.Controls.Add(this.textBox22);
            this.splitContainer8.Panel1.Controls.Add(this.label34);
            this.splitContainer8.Panel1.Controls.Add(this.textBox21);
            this.splitContainer8.Panel1.Controls.Add(this.button13);
            this.splitContainer8.Panel1.Controls.Add(this.button14);
            this.splitContainer8.Panel1.Controls.Add(this.comboBox14);
            this.splitContainer8.Panel1.Controls.Add(this.label40);
            this.splitContainer8.Panel1.Controls.Add(this.textBox28);
            this.splitContainer8.Panel1.Controls.Add(this.label41);
            this.splitContainer8.Panel1.Controls.Add(this.label37);
            this.splitContainer8.Panel1.Controls.Add(this.textBox23);
            this.splitContainer8.Panel1.Controls.Add(this.label38);
            this.splitContainer8.Panel1.Controls.Add(this.button11);
            this.splitContainer8.Panel1.Controls.Add(this.button12);
            this.splitContainer8.Panel1.Controls.Add(this.label39);
            this.splitContainer8.Panel1.Controls.Add(this.label50);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.dataGridView7);
            this.splitContainer8.Size = new System.Drawing.Size(651, 478);
            this.splitContainer8.SplitterDistance = 196;
            this.splitContainer8.TabIndex = 0;
            // 
            // comboBox15
            // 
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(130, 144);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(176, 21);
            this.comboBox15.TabIndex = 25;
            this.comboBox15.Text = "DEZEMBER";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(16, 147);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(40, 13);
            this.label52.TabIndex = 24;
            this.label52.Text = "Monat:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(16, 121);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(33, 13);
            this.label36.TabIndex = 23;
            this.label36.Text = "Preis:";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(130, 118);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(176, 20);
            this.textBox22.TabIndex = 22;
            this.textBox22.Text = "15.092";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(16, 69);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(94, 13);
            this.label34.TabIndex = 21;
            this.label34.Text = "Rechnungsdatum:";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(130, 66);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(176, 20);
            this.textBox21.TabIndex = 20;
            this.textBox21.Text = "19.11.2006";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(211, 171);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 19;
            this.button13.Text = "Abbrechen";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(130, 171);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 18;
            this.button14.Text = "Speichern";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(130, 14);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(176, 21);
            this.comboBox14.TabIndex = 16;
            this.comboBox14.Text = "APRHAD01";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(16, 43);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(102, 13);
            this.label40.TabIndex = 7;
            this.label40.Text = "Rechnungsnummer:";
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(130, 40);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(176, 20);
            this.textBox28.TabIndex = 6;
            this.textBox28.Text = "9287362893";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(16, 17);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(43, 13);
            this.label41.TabIndex = 0;
            this.label41.Text = "Projekt:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(16, 95);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(31, 13);
            this.label37.TabIndex = 23;
            this.label37.Text = "Text:";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(130, 92);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(176, 20);
            this.textBox23.TabIndex = 22;
            this.textBox23.Text = "Reisekosten";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(16, 69);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(94, 13);
            this.label38.TabIndex = 21;
            this.label38.Text = "Rechnungsdatum:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(211, 171);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "Abbrechen";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(130, 171);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 18;
            this.button12.Text = "Speichern";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(16, 43);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(102, 13);
            this.label39.TabIndex = 7;
            this.label39.Text = "Rechnungsnummer:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(16, 17);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(43, 13);
            this.label50.TabIndex = 0;
            this.label50.Text = "Projekt:";
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Projekt01,
            this.Rechnungsnummer,
            this.Datum,
            this.Text,
            this.Preis,
            this.Monat29});
            this.dataGridView7.DataSource = this.testdatenbankDataSetBindingSource;
            this.dataGridView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView7.Location = new System.Drawing.Point(0, 0);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(651, 278);
            this.dataGridView7.TabIndex = 0;
            // 
            // Projekt01
            // 
            this.Projekt01.HeaderText = "Projekt";
            this.Projekt01.Name = "Projekt01";
            // 
            // Rechnungsnummer
            // 
            this.Rechnungsnummer.HeaderText = "Rechnungsnummer";
            this.Rechnungsnummer.Name = "Rechnungsnummer";
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Text
            // 
            this.Text.HeaderText = "Text";
            this.Text.Name = "Text";
            // 
            // Preis
            // 
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            // 
            // Monat29
            // 
            this.Monat29.HeaderText = "Monat";
            this.Monat29.Name = "Monat29";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close_tab.png");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.ImageKey = "(Keine)";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(657, 484);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Mitarbeiter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.button3);
            this.splitContainer3.Panel1.Controls.Add(this.button4);
            this.splitContainer3.Panel1.Controls.Add(this.comboBox3);
            this.splitContainer3.Panel1.Controls.Add(this.comboBox4);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            this.splitContainer3.Panel1.Controls.Add(this.label7);
            this.splitContainer3.Panel1.Controls.Add(this.textBox5);
            this.splitContainer3.Panel1.Controls.Add(this.label8);
            this.splitContainer3.Panel1.Controls.Add(this.textBox6);
            this.splitContainer3.Panel1.Controls.Add(this.label9);
            this.splitContainer3.Panel1.Controls.Add(this.textBox7);
            this.splitContainer3.Panel1.Controls.Add(this.label10);
            this.splitContainer3.Panel1.Controls.Add(this.textBox8);
            this.splitContainer3.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer3.Size = new System.Drawing.Size(651, 478);
            this.splitContainer3.SplitterDistance = 196;
            this.splitContainer3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Abbrechen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(130, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Speichern";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(110, 144);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(176, 21);
            this.comboBox3.TabIndex = 17;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(110, 117);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(176, 21);
            this.comboBox4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Arbeitszeitmodell:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Abteilung:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(110, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(176, 20);
            this.textBox5.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nachname:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(110, 66);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(176, 20);
            this.textBox6.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Vorname:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(110, 40);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(176, 20);
            this.textBox7.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "SVNr:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(110, 14);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(176, 20);
            this.textBox8.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.DataSource = this.testdatenbankDataSetBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(651, 278);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "SVNr";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Vorname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nachname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Abteilung";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Arbeitszeitmodell";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(814, 582);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdatenbankDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdatenbankDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void outlookBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
	}
}
