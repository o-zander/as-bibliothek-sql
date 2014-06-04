using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace as_bibliothek_sql
{
  public partial class frmMain : Form
  {
    private TabControl tabControl1;
    private TabPage tbpgeBooks;
    private TabPage tbPgeClients;
    private TabPage tbPgeEmployes;
    private TextBox txtBoxSearchBook;
    private Label lblSearchBook;
    private DataGridView dataGridViewBooks;
    private Label lblSearchClients;
    private TextBox txtBoxSearchClients;
    private DataGridView dataGridView1;
    private TableLayoutPanel tblOpeningHours;
    private Label lblMonday;
    private Button btnEditLibrary;
    private Label lblTuesday;
    private Label lblWednesday;
    private Label lblThursday;
    private Label lblFriday;
    private Label lblSaturday;
    private Label lblSunday;
    private TextBox txtBoxMondayfrom;
    private TextBox txtBoxTuesdayFrom;
    private TextBox txtBoxWednesdayFrom;
    private TextBox txtBoxThursdayFrom;
    private TextBox txtBoxFridayFrom;
    private TextBox txtBoxSaturdayFrom;
    private TextBox txtBoxSundayFrom;
    private TextBox txtBoxMondayTo;
    private TextBox txtBoxTuesdayTo;
    private TextBox txtBoxWednesdayTo;
    private TextBox txtBoxThursdayTo;
    private TextBox txtBoxFridayTo;
    private TextBox txtBoxSaturdayTo;
    private TextBox txtBoxSundayTo;
    private TextBox txtBoxPostal;
    private TextBox txtBoxCountry;
    private TextBox txtBoxCity;
    private TextBox txtBoxLibHouseNumber;
    private TextBox txtBoxLibStreet;
    private TextBox txtBoxLibName;
    private TabPage tbpPgeLibrary;
  
    public frmMain()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tbpgeBooks = new System.Windows.Forms.TabPage();
      this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
      this.txtBoxSearchBook = new System.Windows.Forms.TextBox();
      this.lblSearchBook = new System.Windows.Forms.Label();
      this.tbPgeClients = new System.Windows.Forms.TabPage();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.lblSearchClients = new System.Windows.Forms.Label();
      this.txtBoxSearchClients = new System.Windows.Forms.TextBox();
      this.tbPgeEmployes = new System.Windows.Forms.TabPage();
      this.tbpPgeLibrary = new System.Windows.Forms.TabPage();
      this.btnEditLibrary = new System.Windows.Forms.Button();
      this.tblOpeningHours = new System.Windows.Forms.TableLayoutPanel();
      this.lblMonday = new System.Windows.Forms.Label();
      this.lblTuesday = new System.Windows.Forms.Label();
      this.lblWednesday = new System.Windows.Forms.Label();
      this.lblThursday = new System.Windows.Forms.Label();
      this.lblFriday = new System.Windows.Forms.Label();
      this.lblSaturday = new System.Windows.Forms.Label();
      this.lblSunday = new System.Windows.Forms.Label();
      this.txtBoxMondayfrom = new System.Windows.Forms.TextBox();
      this.txtBoxTuesdayFrom = new System.Windows.Forms.TextBox();
      this.txtBoxWednesdayFrom = new System.Windows.Forms.TextBox();
      this.txtBoxThursdayFrom = new System.Windows.Forms.TextBox();
      this.txtBoxFridayFrom = new System.Windows.Forms.TextBox();
      this.txtBoxSaturdayFrom = new System.Windows.Forms.TextBox();
      this.txtBoxSundayFrom = new System.Windows.Forms.TextBox();
      this.txtBoxMondayTo = new System.Windows.Forms.TextBox();
      this.txtBoxTuesdayTo = new System.Windows.Forms.TextBox();
      this.txtBoxWednesdayTo = new System.Windows.Forms.TextBox();
      this.txtBoxThursdayTo = new System.Windows.Forms.TextBox();
      this.txtBoxFridayTo = new System.Windows.Forms.TextBox();
      this.txtBoxSaturdayTo = new System.Windows.Forms.TextBox();
      this.txtBoxSundayTo = new System.Windows.Forms.TextBox();
      this.txtBoxLibName = new System.Windows.Forms.TextBox();
      this.txtBoxLibStreet = new System.Windows.Forms.TextBox();
      this.txtBoxLibHouseNumber = new System.Windows.Forms.TextBox();
      this.txtBoxCity = new System.Windows.Forms.TextBox();
      this.txtBoxCountry = new System.Windows.Forms.TextBox();
      this.txtBoxPostal = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.tbpgeBooks.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
      this.tbPgeClients.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.tbpPgeLibrary.SuspendLayout();
      this.tblOpeningHours.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
      this.tabControl1.Controls.Add(this.tbpgeBooks);
      this.tabControl1.Controls.Add(this.tbPgeClients);
      this.tabControl1.Controls.Add(this.tbPgeEmployes);
      this.tabControl1.Controls.Add(this.tbpPgeLibrary);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Multiline = true;
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(648, 434);
      this.tabControl1.TabIndex = 2;
      // 
      // tbpgeBooks
      // 
      this.tbpgeBooks.BackColor = System.Drawing.Color.Transparent;
      this.tbpgeBooks.Controls.Add(this.dataGridViewBooks);
      this.tbpgeBooks.Controls.Add(this.txtBoxSearchBook);
      this.tbpgeBooks.Controls.Add(this.lblSearchBook);
      this.tbpgeBooks.ForeColor = System.Drawing.Color.Black;
      this.tbpgeBooks.Location = new System.Drawing.Point(4, 25);
      this.tbpgeBooks.Name = "tbpgeBooks";
      this.tbpgeBooks.Padding = new System.Windows.Forms.Padding(3);
      this.tbpgeBooks.Size = new System.Drawing.Size(640, 405);
      this.tbpgeBooks.TabIndex = 0;
      this.tbpgeBooks.Text = "Bücher";
      // 
      // dataGridViewBooks
      // 
      this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewBooks.Location = new System.Drawing.Point(9, 38);
      this.dataGridViewBooks.Name = "dataGridViewBooks";
      this.dataGridViewBooks.Size = new System.Drawing.Size(628, 361);
      this.dataGridViewBooks.TabIndex = 2;
      // 
      // txtBoxSearchBook
      // 
      this.txtBoxSearchBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtBoxSearchBook.Location = new System.Drawing.Point(53, 8);
      this.txtBoxSearchBook.Name = "txtBoxSearchBook";
      this.txtBoxSearchBook.Size = new System.Drawing.Size(581, 13);
      this.txtBoxSearchBook.TabIndex = 1;
      // 
      // lblSearchBook
      // 
      this.lblSearchBook.AutoSize = true;
      this.lblSearchBook.ForeColor = System.Drawing.Color.Black;
      this.lblSearchBook.Location = new System.Drawing.Point(6, 8);
      this.lblSearchBook.Name = "lblSearchBook";
      this.lblSearchBook.Size = new System.Drawing.Size(41, 13);
      this.lblSearchBook.TabIndex = 0;
      this.lblSearchBook.Text = "Suche:";
      // 
      // tbPgeClients
      // 
      this.tbPgeClients.BackColor = System.Drawing.Color.Transparent;
      this.tbPgeClients.Controls.Add(this.dataGridView1);
      this.tbPgeClients.Controls.Add(this.lblSearchClients);
      this.tbPgeClients.Controls.Add(this.txtBoxSearchClients);
      this.tbPgeClients.ForeColor = System.Drawing.SystemColors.ControlText;
      this.tbPgeClients.Location = new System.Drawing.Point(4, 25);
      this.tbPgeClients.Name = "tbPgeClients";
      this.tbPgeClients.Padding = new System.Windows.Forms.Padding(3);
      this.tbPgeClients.Size = new System.Drawing.Size(640, 405);
      this.tbPgeClients.TabIndex = 1;
      this.tbPgeClients.Text = "Kunden";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(6, 44);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(628, 355);
      this.dataGridView1.TabIndex = 2;
      // 
      // lblSearchClients
      // 
      this.lblSearchClients.AutoSize = true;
      this.lblSearchClients.ForeColor = System.Drawing.Color.Black;
      this.lblSearchClients.Location = new System.Drawing.Point(17, 10);
      this.lblSearchClients.Name = "lblSearchClients";
      this.lblSearchClients.Size = new System.Drawing.Size(41, 13);
      this.lblSearchClients.TabIndex = 1;
      this.lblSearchClients.Text = "Suche:";
      // 
      // txtBoxSearchClients
      // 
      this.txtBoxSearchClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtBoxSearchClients.Location = new System.Drawing.Point(64, 10);
      this.txtBoxSearchClients.Name = "txtBoxSearchClients";
      this.txtBoxSearchClients.Size = new System.Drawing.Size(570, 13);
      this.txtBoxSearchClients.TabIndex = 0;
      // 
      // tbPgeEmployes
      // 
      this.tbPgeEmployes.BackColor = System.Drawing.Color.Transparent;
      this.tbPgeEmployes.ForeColor = System.Drawing.SystemColors.ControlText;
      this.tbPgeEmployes.Location = new System.Drawing.Point(4, 25);
      this.tbPgeEmployes.Name = "tbPgeEmployes";
      this.tbPgeEmployes.Size = new System.Drawing.Size(640, 405);
      this.tbPgeEmployes.TabIndex = 2;
      this.tbPgeEmployes.Text = "Mitarbeiter";
      // 
      // tbpPgeLibrary
      // 
      this.tbpPgeLibrary.BackColor = System.Drawing.Color.Transparent;
      this.tbpPgeLibrary.Controls.Add(this.txtBoxPostal);
      this.tbpPgeLibrary.Controls.Add(this.txtBoxCountry);
      this.tbpPgeLibrary.Controls.Add(this.txtBoxCity);
      this.tbpPgeLibrary.Controls.Add(this.txtBoxLibHouseNumber);
      this.tbpPgeLibrary.Controls.Add(this.txtBoxLibStreet);
      this.tbpPgeLibrary.Controls.Add(this.txtBoxLibName);
      this.tbpPgeLibrary.Controls.Add(this.btnEditLibrary);
      this.tbpPgeLibrary.Controls.Add(this.tblOpeningHours);
      this.tbpPgeLibrary.ForeColor = System.Drawing.Color.Black;
      this.tbpPgeLibrary.Location = new System.Drawing.Point(4, 25);
      this.tbpPgeLibrary.Name = "tbpPgeLibrary";
      this.tbpPgeLibrary.Size = new System.Drawing.Size(640, 405);
      this.tbpPgeLibrary.TabIndex = 3;
      this.tbpPgeLibrary.Text = "Bibliothek";
      // 
      // btnEditLibrary
      // 
      this.btnEditLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditLibrary.Location = new System.Drawing.Point(562, 379);
      this.btnEditLibrary.Name = "btnEditLibrary";
      this.btnEditLibrary.Size = new System.Drawing.Size(75, 23);
      this.btnEditLibrary.TabIndex = 1;
      this.btnEditLibrary.Text = "bearbeiten";
      this.btnEditLibrary.UseVisualStyleBackColor = true;
      // 
      // tblOpeningHours
      // 
      this.tblOpeningHours.ColumnCount = 7;
      this.tblOpeningHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tblOpeningHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tblOpeningHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tblOpeningHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
      this.tblOpeningHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
      this.tblOpeningHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
      this.tblOpeningHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
      this.tblOpeningHours.Controls.Add(this.lblMonday, 3, 0);
      this.tblOpeningHours.Controls.Add(this.lblTuesday, 3, 1);
      this.tblOpeningHours.Controls.Add(this.lblWednesday, 3, 2);
      this.tblOpeningHours.Controls.Add(this.lblThursday, 3, 3);
      this.tblOpeningHours.Controls.Add(this.lblFriday, 3, 4);
      this.tblOpeningHours.Controls.Add(this.lblSaturday, 3, 5);
      this.tblOpeningHours.Controls.Add(this.lblSunday, 3, 6);
      this.tblOpeningHours.Controls.Add(this.txtBoxMondayfrom, 4, 0);
      this.tblOpeningHours.Controls.Add(this.txtBoxTuesdayFrom, 4, 1);
      this.tblOpeningHours.Controls.Add(this.txtBoxWednesdayFrom, 4, 2);
      this.tblOpeningHours.Controls.Add(this.txtBoxThursdayFrom, 4, 3);
      this.tblOpeningHours.Controls.Add(this.txtBoxFridayFrom, 4, 4);
      this.tblOpeningHours.Controls.Add(this.txtBoxSaturdayFrom, 4, 5);
      this.tblOpeningHours.Controls.Add(this.txtBoxSundayFrom, 4, 6);
      this.tblOpeningHours.Controls.Add(this.txtBoxMondayTo, 6, 0);
      this.tblOpeningHours.Controls.Add(this.txtBoxTuesdayTo, 6, 1);
      this.tblOpeningHours.Controls.Add(this.txtBoxWednesdayTo, 6, 2);
      this.tblOpeningHours.Controls.Add(this.txtBoxThursdayTo, 6, 3);
      this.tblOpeningHours.Controls.Add(this.txtBoxFridayTo, 6, 4);
      this.tblOpeningHours.Controls.Add(this.txtBoxSaturdayTo, 6, 5);
      this.tblOpeningHours.Controls.Add(this.txtBoxSundayTo, 6, 6);
      this.tblOpeningHours.Location = new System.Drawing.Point(21, 16);
      this.tblOpeningHours.Name = "tblOpeningHours";
      this.tblOpeningHours.RowCount = 7;
      this.tblOpeningHours.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tblOpeningHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tblOpeningHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tblOpeningHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
      this.tblOpeningHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
      this.tblOpeningHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
      this.tblOpeningHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
      this.tblOpeningHours.Size = new System.Drawing.Size(316, 201);
      this.tblOpeningHours.TabIndex = 0;
      // 
      // lblMonday
      // 
      this.lblMonday.AutoSize = true;
      this.lblMonday.Location = new System.Drawing.Point(3, 0);
      this.lblMonday.Name = "lblMonday";
      this.lblMonday.Size = new System.Drawing.Size(43, 13);
      this.lblMonday.TabIndex = 0;
      this.lblMonday.Text = "Montag";
      // 
      // lblTuesday
      // 
      this.lblTuesday.AutoSize = true;
      this.lblTuesday.Location = new System.Drawing.Point(3, 26);
      this.lblTuesday.Name = "lblTuesday";
      this.lblTuesday.Size = new System.Drawing.Size(49, 13);
      this.lblTuesday.TabIndex = 1;
      this.lblTuesday.Text = "Dienstag";
      // 
      // lblWednesday
      // 
      this.lblWednesday.AutoSize = true;
      this.lblWednesday.Location = new System.Drawing.Point(3, 54);
      this.lblWednesday.Name = "lblWednesday";
      this.lblWednesday.Size = new System.Drawing.Size(50, 13);
      this.lblWednesday.TabIndex = 2;
      this.lblWednesday.Text = "Mittwoch";
      // 
      // lblThursday
      // 
      this.lblThursday.AutoSize = true;
      this.lblThursday.Location = new System.Drawing.Point(3, 82);
      this.lblThursday.Name = "lblThursday";
      this.lblThursday.Size = new System.Drawing.Size(62, 13);
      this.lblThursday.TabIndex = 3;
      this.lblThursday.Text = "Donnerstag";
      // 
      // lblFriday
      // 
      this.lblFriday.AutoSize = true;
      this.lblFriday.Location = new System.Drawing.Point(3, 111);
      this.lblFriday.Name = "lblFriday";
      this.lblFriday.Size = new System.Drawing.Size(39, 13);
      this.lblFriday.TabIndex = 4;
      this.lblFriday.Text = "Freitag";
      // 
      // lblSaturday
      // 
      this.lblSaturday.AutoSize = true;
      this.lblSaturday.Location = new System.Drawing.Point(3, 140);
      this.lblSaturday.Name = "lblSaturday";
      this.lblSaturday.Size = new System.Drawing.Size(48, 13);
      this.lblSaturday.TabIndex = 5;
      this.lblSaturday.Text = "Samstag";
      // 
      // lblSunday
      // 
      this.lblSunday.AutoSize = true;
      this.lblSunday.Location = new System.Drawing.Point(3, 169);
      this.lblSunday.Name = "lblSunday";
      this.lblSunday.Size = new System.Drawing.Size(47, 13);
      this.lblSunday.TabIndex = 6;
      this.lblSunday.Text = "Sonntag";
      // 
      // txtBoxMondayfrom
      // 
      this.txtBoxMondayfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxMondayfrom.Location = new System.Drawing.Point(91, 3);
      this.txtBoxMondayfrom.Name = "txtBoxMondayfrom";
      this.txtBoxMondayfrom.Size = new System.Drawing.Size(90, 20);
      this.txtBoxMondayfrom.TabIndex = 7;
      // 
      // txtBoxTuesdayFrom
      // 
      this.txtBoxTuesdayFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxTuesdayFrom.Location = new System.Drawing.Point(91, 29);
      this.txtBoxTuesdayFrom.Name = "txtBoxTuesdayFrom";
      this.txtBoxTuesdayFrom.Size = new System.Drawing.Size(90, 20);
      this.txtBoxTuesdayFrom.TabIndex = 8;
      // 
      // txtBoxWednesdayFrom
      // 
      this.txtBoxWednesdayFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxWednesdayFrom.Location = new System.Drawing.Point(91, 57);
      this.txtBoxWednesdayFrom.Name = "txtBoxWednesdayFrom";
      this.txtBoxWednesdayFrom.Size = new System.Drawing.Size(90, 20);
      this.txtBoxWednesdayFrom.TabIndex = 9;
      // 
      // txtBoxThursdayFrom
      // 
      this.txtBoxThursdayFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxThursdayFrom.Location = new System.Drawing.Point(91, 85);
      this.txtBoxThursdayFrom.Name = "txtBoxThursdayFrom";
      this.txtBoxThursdayFrom.Size = new System.Drawing.Size(90, 20);
      this.txtBoxThursdayFrom.TabIndex = 10;
      // 
      // txtBoxFridayFrom
      // 
      this.txtBoxFridayFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxFridayFrom.Location = new System.Drawing.Point(91, 114);
      this.txtBoxFridayFrom.Name = "txtBoxFridayFrom";
      this.txtBoxFridayFrom.Size = new System.Drawing.Size(90, 20);
      this.txtBoxFridayFrom.TabIndex = 11;
      // 
      // txtBoxSaturdayFrom
      // 
      this.txtBoxSaturdayFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxSaturdayFrom.Location = new System.Drawing.Point(91, 143);
      this.txtBoxSaturdayFrom.Name = "txtBoxSaturdayFrom";
      this.txtBoxSaturdayFrom.Size = new System.Drawing.Size(90, 20);
      this.txtBoxSaturdayFrom.TabIndex = 12;
      // 
      // txtBoxSundayFrom
      // 
      this.txtBoxSundayFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxSundayFrom.Location = new System.Drawing.Point(91, 172);
      this.txtBoxSundayFrom.Name = "txtBoxSundayFrom";
      this.txtBoxSundayFrom.Size = new System.Drawing.Size(90, 20);
      this.txtBoxSundayFrom.TabIndex = 13;
      // 
      // txtBoxMondayTo
      // 
      this.txtBoxMondayTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxMondayTo.Location = new System.Drawing.Point(206, 3);
      this.txtBoxMondayTo.Name = "txtBoxMondayTo";
      this.txtBoxMondayTo.Size = new System.Drawing.Size(97, 20);
      this.txtBoxMondayTo.TabIndex = 14;
      // 
      // txtBoxTuesdayTo
      // 
      this.txtBoxTuesdayTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxTuesdayTo.Location = new System.Drawing.Point(206, 29);
      this.txtBoxTuesdayTo.Name = "txtBoxTuesdayTo";
      this.txtBoxTuesdayTo.Size = new System.Drawing.Size(97, 20);
      this.txtBoxTuesdayTo.TabIndex = 15;
      // 
      // txtBoxWednesdayTo
      // 
      this.txtBoxWednesdayTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxWednesdayTo.Location = new System.Drawing.Point(206, 57);
      this.txtBoxWednesdayTo.Name = "txtBoxWednesdayTo";
      this.txtBoxWednesdayTo.Size = new System.Drawing.Size(97, 20);
      this.txtBoxWednesdayTo.TabIndex = 16;
      // 
      // txtBoxThursdayTo
      // 
      this.txtBoxThursdayTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxThursdayTo.Location = new System.Drawing.Point(206, 85);
      this.txtBoxThursdayTo.Name = "txtBoxThursdayTo";
      this.txtBoxThursdayTo.Size = new System.Drawing.Size(97, 20);
      this.txtBoxThursdayTo.TabIndex = 17;
      // 
      // txtBoxFridayTo
      // 
      this.txtBoxFridayTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxFridayTo.Location = new System.Drawing.Point(206, 114);
      this.txtBoxFridayTo.Name = "txtBoxFridayTo";
      this.txtBoxFridayTo.Size = new System.Drawing.Size(97, 20);
      this.txtBoxFridayTo.TabIndex = 18;
      // 
      // txtBoxSaturdayTo
      // 
      this.txtBoxSaturdayTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxSaturdayTo.Location = new System.Drawing.Point(206, 143);
      this.txtBoxSaturdayTo.Name = "txtBoxSaturdayTo";
      this.txtBoxSaturdayTo.Size = new System.Drawing.Size(97, 20);
      this.txtBoxSaturdayTo.TabIndex = 19;
      // 
      // txtBoxSundayTo
      // 
      this.txtBoxSundayTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxSundayTo.Location = new System.Drawing.Point(206, 172);
      this.txtBoxSundayTo.Name = "txtBoxSundayTo";
      this.txtBoxSundayTo.Size = new System.Drawing.Size(97, 20);
      this.txtBoxSundayTo.TabIndex = 20;
      // 
      // txtBoxLibName
      // 
      this.txtBoxLibName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.txtBoxLibName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxLibName.Location = new System.Drawing.Point(385, 64);
      this.txtBoxLibName.Name = "txtBoxLibName";
      this.txtBoxLibName.Size = new System.Drawing.Size(225, 20);
      this.txtBoxLibName.TabIndex = 2;
      this.txtBoxLibName.Text = "Library Name";
      // 
      // txtBoxLibStreet
      // 
      this.txtBoxLibStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxLibStreet.Location = new System.Drawing.Point(385, 91);
      this.txtBoxLibStreet.Name = "txtBoxLibStreet";
      this.txtBoxLibStreet.Size = new System.Drawing.Size(160, 20);
      this.txtBoxLibStreet.TabIndex = 3;
      this.txtBoxLibStreet.Text = "Test Straße ";
      // 
      // txtBoxLibHouseNumber
      // 
      this.txtBoxLibHouseNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxLibHouseNumber.Location = new System.Drawing.Point(551, 90);
      this.txtBoxLibHouseNumber.Name = "txtBoxLibHouseNumber";
      this.txtBoxLibHouseNumber.Size = new System.Drawing.Size(59, 20);
      this.txtBoxLibHouseNumber.TabIndex = 4;
      this.txtBoxLibHouseNumber.Text = "145";
      // 
      // txtBoxCity
      // 
      this.txtBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxCity.Location = new System.Drawing.Point(385, 119);
      this.txtBoxCity.Name = "txtBoxCity";
      this.txtBoxCity.Size = new System.Drawing.Size(160, 20);
      this.txtBoxCity.TabIndex = 5;
      this.txtBoxCity.Text = "Musterstadt";
      // 
      // txtBoxCountry
      // 
      this.txtBoxCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxCountry.Location = new System.Drawing.Point(385, 144);
      this.txtBoxCountry.Name = "txtBoxCountry";
      this.txtBoxCountry.Size = new System.Drawing.Size(225, 20);
      this.txtBoxCountry.TabIndex = 6;
      this.txtBoxCountry.Text = "Musterland";
      // 
      // txtBoxPostal
      // 
      this.txtBoxPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxPostal.Location = new System.Drawing.Point(551, 118);
      this.txtBoxPostal.Name = "txtBoxPostal";
      this.txtBoxPostal.Size = new System.Drawing.Size(59, 20);
      this.txtBoxPostal.TabIndex = 7;
      this.txtBoxPostal.Text = "31515";
      // 
      // frmMain
      // 
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ClientSize = new System.Drawing.Size(672, 458);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmMain";
      this.tabControl1.ResumeLayout(false);
      this.tbpgeBooks.ResumeLayout(false);
      this.tbpgeBooks.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
      this.tbPgeClients.ResumeLayout(false);
      this.tbPgeClients.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.tbpPgeLibrary.ResumeLayout(false);
      this.tbpPgeLibrary.PerformLayout();
      this.tblOpeningHours.ResumeLayout(false);
      this.tblOpeningHours.PerformLayout();
      this.ResumeLayout(false);

    }
  }
}
