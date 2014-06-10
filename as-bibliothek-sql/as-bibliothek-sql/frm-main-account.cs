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
  public partial class frmMainAccount : Form
  {
    private TabControl tbControlMain;
    private TabPage tbPgeAccount;
    private TabPage tbPgeBook;
    private TabPage tbPgeUser;
    private Panel pnlBookHeader;
    private TextBox txtBoxSearchBooks;
    private Label lblBookHeader;
    private DataGridView dtGridViewBook;
    private Button btnAddBook;
    private Panel panel1;
    private Button btnAddUser;
    private TextBox txtBoxSearchUser;
    private Label lblUser;
    private DataGridView dataGridView1;
    private Label lblOpeningHours;
    private TextBox textBox3;
    private Label lblThursday;
    private TextBox textBox4;
    private TextBox txtBoxOpeningHourTuesday;
    private Label lblTuesday;
    private TextBox txtBoxOpeningHourTuesdayFrom;
    private TextBox txtBoxOpenenHourMondayto;
    private Label lblMonday;
    private TextBox txtBoxOpeningHourMondeyfrom;
    private TextBox textBox11;
    private Label lblSunday;
    private TextBox textBox12;
    private TextBox textBox9;
    private Label lblSaturday;
    private TextBox textBox10;
    private TextBox textBox7;
    private Label lblFriday;
    private TextBox textBox8;
    private TextBox textBox5;
    private Label lblWednesday;
    private TextBox textBox6;
    private TabPage tbPgeLibrary;
  
    public frmMainAccount()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      this.tbControlMain = new System.Windows.Forms.TabControl();
      this.tbPgeAccount = new System.Windows.Forms.TabPage();
      this.tbPgeBook = new System.Windows.Forms.TabPage();
      this.pnlBookHeader = new System.Windows.Forms.Panel();
      this.btnAddBook = new System.Windows.Forms.Button();
      this.txtBoxSearchBooks = new System.Windows.Forms.TextBox();
      this.lblBookHeader = new System.Windows.Forms.Label();
      this.dtGridViewBook = new System.Windows.Forms.DataGridView();
      this.tbPgeUser = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtBoxSearchUser = new System.Windows.Forms.TextBox();
      this.btnAddUser = new System.Windows.Forms.Button();
      this.lblUser = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.tbPgeLibrary = new System.Windows.Forms.TabPage();
      this.textBox11 = new System.Windows.Forms.TextBox();
      this.lblSunday = new System.Windows.Forms.Label();
      this.textBox12 = new System.Windows.Forms.TextBox();
      this.textBox9 = new System.Windows.Forms.TextBox();
      this.lblSaturday = new System.Windows.Forms.Label();
      this.textBox10 = new System.Windows.Forms.TextBox();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.lblFriday = new System.Windows.Forms.Label();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.lblWednesday = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.lblThursday = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.txtBoxOpeningHourTuesday = new System.Windows.Forms.TextBox();
      this.lblTuesday = new System.Windows.Forms.Label();
      this.txtBoxOpeningHourTuesdayFrom = new System.Windows.Forms.TextBox();
      this.txtBoxOpenenHourMondayto = new System.Windows.Forms.TextBox();
      this.lblMonday = new System.Windows.Forms.Label();
      this.txtBoxOpeningHourMondeyfrom = new System.Windows.Forms.TextBox();
      this.lblOpeningHours = new System.Windows.Forms.Label();
      this.tbControlMain.SuspendLayout();
      this.tbPgeBook.SuspendLayout();
      this.pnlBookHeader.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtGridViewBook)).BeginInit();
      this.tbPgeUser.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.tbPgeLibrary.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbControlMain
      // 
      this.tbControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
      this.tbControlMain.Controls.Add(this.tbPgeAccount);
      this.tbControlMain.Controls.Add(this.tbPgeBook);
      this.tbControlMain.Controls.Add(this.tbPgeUser);
      this.tbControlMain.Controls.Add(this.tbPgeLibrary);
      this.tbControlMain.ItemSize = new System.Drawing.Size(115, 45);
      this.tbControlMain.Location = new System.Drawing.Point(-1, -2);
      this.tbControlMain.Name = "tbControlMain";
      this.tbControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.tbControlMain.SelectedIndex = 0;
      this.tbControlMain.Size = new System.Drawing.Size(463, 600);
      this.tbControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
      this.tbControlMain.TabIndex = 0;
      // 
      // tbPgeAccount
      // 
      this.tbPgeAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.tbPgeAccount.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.tbPgeAccount.Location = new System.Drawing.Point(4, 4);
      this.tbPgeAccount.Name = "tbPgeAccount";
      this.tbPgeAccount.Padding = new System.Windows.Forms.Padding(3);
      this.tbPgeAccount.Size = new System.Drawing.Size(455, 547);
      this.tbPgeAccount.TabIndex = 0;
      this.tbPgeAccount.Text = "Account";
      // 
      // tbPgeBook
      // 
      this.tbPgeBook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.tbPgeBook.Controls.Add(this.pnlBookHeader);
      this.tbPgeBook.Controls.Add(this.dtGridViewBook);
      this.tbPgeBook.Location = new System.Drawing.Point(4, 4);
      this.tbPgeBook.Name = "tbPgeBook";
      this.tbPgeBook.Padding = new System.Windows.Forms.Padding(3);
      this.tbPgeBook.Size = new System.Drawing.Size(455, 547);
      this.tbPgeBook.TabIndex = 1;
      this.tbPgeBook.Text = "Book";
      // 
      // pnlBookHeader
      // 
      this.pnlBookHeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.pnlBookHeader.Controls.Add(this.btnAddBook);
      this.pnlBookHeader.Controls.Add(this.txtBoxSearchBooks);
      this.pnlBookHeader.Controls.Add(this.lblBookHeader);
      this.pnlBookHeader.Location = new System.Drawing.Point(3, 4);
      this.pnlBookHeader.Name = "pnlBookHeader";
      this.pnlBookHeader.Size = new System.Drawing.Size(449, 45);
      this.pnlBookHeader.TabIndex = 1;
      // 
      // btnAddBook
      // 
      this.btnAddBook.BackgroundImage = global::as_bibliothek_sql.Properties.Resources.glyphicons_190_circle_plus;
      this.btnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAddBook.FlatAppearance.BorderSize = 0;
      this.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddBook.Location = new System.Drawing.Point(402, 4);
      this.btnAddBook.Name = "btnAddBook";
      this.btnAddBook.Size = new System.Drawing.Size(41, 38);
      this.btnAddBook.TabIndex = 2;
      this.btnAddBook.UseVisualStyleBackColor = true;
      // 
      // txtBoxSearchBooks
      // 
      this.txtBoxSearchBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxSearchBooks.Location = new System.Drawing.Point(7, 12);
      this.txtBoxSearchBooks.Name = "txtBoxSearchBooks";
      this.txtBoxSearchBooks.Size = new System.Drawing.Size(173, 20);
      this.txtBoxSearchBooks.TabIndex = 1;
      // 
      // lblBookHeader
      // 
      this.lblBookHeader.AutoSize = true;
      this.lblBookHeader.Location = new System.Drawing.Point(197, 15);
      this.lblBookHeader.Name = "lblBookHeader";
      this.lblBookHeader.Size = new System.Drawing.Size(37, 13);
      this.lblBookHeader.TabIndex = 0;
      this.lblBookHeader.Text = "Books";
      // 
      // dtGridViewBook
      // 
      this.dtGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtGridViewBook.Location = new System.Drawing.Point(3, 55);
      this.dtGridViewBook.Name = "dtGridViewBook";
      this.dtGridViewBook.Size = new System.Drawing.Size(449, 489);
      this.dtGridViewBook.TabIndex = 0;
      // 
      // tbPgeUser
      // 
      this.tbPgeUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.tbPgeUser.Controls.Add(this.panel1);
      this.tbPgeUser.Controls.Add(this.dataGridView1);
      this.tbPgeUser.Location = new System.Drawing.Point(4, 4);
      this.tbPgeUser.Name = "tbPgeUser";
      this.tbPgeUser.Size = new System.Drawing.Size(455, 547);
      this.tbPgeUser.TabIndex = 2;
      this.tbPgeUser.Text = "User";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.panel1.Controls.Add(this.txtBoxSearchUser);
      this.panel1.Controls.Add(this.btnAddUser);
      this.panel1.Controls.Add(this.lblUser);
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(449, 45);
      this.panel1.TabIndex = 2;
      // 
      // txtBoxSearchUser
      // 
      this.txtBoxSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxSearchUser.Location = new System.Drawing.Point(7, 12);
      this.txtBoxSearchUser.Name = "txtBoxSearchUser";
      this.txtBoxSearchUser.Size = new System.Drawing.Size(173, 20);
      this.txtBoxSearchUser.TabIndex = 1;
      // 
      // btnAddUser
      // 
      this.btnAddUser.BackgroundImage = global::as_bibliothek_sql.Properties.Resources.glyphicons_006_user_add;
      this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAddUser.FlatAppearance.BorderSize = 0;
      this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddUser.Location = new System.Drawing.Point(402, 4);
      this.btnAddUser.Name = "btnAddUser";
      this.btnAddUser.Size = new System.Drawing.Size(41, 38);
      this.btnAddUser.TabIndex = 2;
      this.btnAddUser.UseVisualStyleBackColor = true;
      // 
      // lblUser
      // 
      this.lblUser.AutoSize = true;
      this.lblUser.Location = new System.Drawing.Point(197, 15);
      this.lblUser.Name = "lblUser";
      this.lblUser.Size = new System.Drawing.Size(49, 13);
      this.lblUser.TabIndex = 0;
      this.lblUser.Text = "Benutzer";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(3, 54);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(449, 490);
      this.dataGridView1.TabIndex = 0;
      // 
      // tbPgeLibrary
      // 
      this.tbPgeLibrary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.tbPgeLibrary.Controls.Add(this.textBox11);
      this.tbPgeLibrary.Controls.Add(this.lblSunday);
      this.tbPgeLibrary.Controls.Add(this.textBox12);
      this.tbPgeLibrary.Controls.Add(this.textBox9);
      this.tbPgeLibrary.Controls.Add(this.lblSaturday);
      this.tbPgeLibrary.Controls.Add(this.textBox10);
      this.tbPgeLibrary.Controls.Add(this.textBox7);
      this.tbPgeLibrary.Controls.Add(this.lblFriday);
      this.tbPgeLibrary.Controls.Add(this.textBox8);
      this.tbPgeLibrary.Controls.Add(this.textBox5);
      this.tbPgeLibrary.Controls.Add(this.lblWednesday);
      this.tbPgeLibrary.Controls.Add(this.textBox6);
      this.tbPgeLibrary.Controls.Add(this.textBox3);
      this.tbPgeLibrary.Controls.Add(this.lblThursday);
      this.tbPgeLibrary.Controls.Add(this.textBox4);
      this.tbPgeLibrary.Controls.Add(this.txtBoxOpeningHourTuesday);
      this.tbPgeLibrary.Controls.Add(this.lblTuesday);
      this.tbPgeLibrary.Controls.Add(this.txtBoxOpeningHourTuesdayFrom);
      this.tbPgeLibrary.Controls.Add(this.txtBoxOpenenHourMondayto);
      this.tbPgeLibrary.Controls.Add(this.lblMonday);
      this.tbPgeLibrary.Controls.Add(this.txtBoxOpeningHourMondeyfrom);
      this.tbPgeLibrary.Controls.Add(this.lblOpeningHours);
      this.tbPgeLibrary.Location = new System.Drawing.Point(4, 4);
      this.tbPgeLibrary.Name = "tbPgeLibrary";
      this.tbPgeLibrary.Size = new System.Drawing.Size(455, 547);
      this.tbPgeLibrary.TabIndex = 3;
      this.tbPgeLibrary.Text = "Library";
      // 
      // textBox11
      // 
      this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox11.Location = new System.Drawing.Point(208, 180);
      this.textBox11.Name = "textBox11";
      this.textBox11.Size = new System.Drawing.Size(64, 20);
      this.textBox11.TabIndex = 21;
      // 
      // lblSunday
      // 
      this.lblSunday.AutoSize = true;
      this.lblSunday.Location = new System.Drawing.Point(41, 183);
      this.lblSunday.Name = "lblSunday";
      this.lblSunday.Size = new System.Drawing.Size(46, 13);
      this.lblSunday.TabIndex = 20;
      this.lblSunday.Text = ":Sunday";
      // 
      // textBox12
      // 
      this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox12.Location = new System.Drawing.Point(119, 180);
      this.textBox12.Name = "textBox12";
      this.textBox12.Size = new System.Drawing.Size(64, 20);
      this.textBox12.TabIndex = 19;
      // 
      // textBox9
      // 
      this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox9.Location = new System.Drawing.Point(208, 154);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new System.Drawing.Size(64, 20);
      this.textBox9.TabIndex = 18;
      // 
      // lblSaturday
      // 
      this.lblSaturday.AutoSize = true;
      this.lblSaturday.Location = new System.Drawing.Point(41, 157);
      this.lblSaturday.Name = "lblSaturday";
      this.lblSaturday.Size = new System.Drawing.Size(52, 13);
      this.lblSaturday.TabIndex = 17;
      this.lblSaturday.Text = ":Saturday";
      // 
      // textBox10
      // 
      this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox10.Location = new System.Drawing.Point(119, 154);
      this.textBox10.Name = "textBox10";
      this.textBox10.Size = new System.Drawing.Size(64, 20);
      this.textBox10.TabIndex = 16;
      // 
      // textBox7
      // 
      this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox7.Location = new System.Drawing.Point(208, 128);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(64, 20);
      this.textBox7.TabIndex = 15;
      // 
      // lblFriday
      // 
      this.lblFriday.AutoSize = true;
      this.lblFriday.Location = new System.Drawing.Point(41, 131);
      this.lblFriday.Name = "lblFriday";
      this.lblFriday.Size = new System.Drawing.Size(42, 13);
      this.lblFriday.TabIndex = 14;
      this.lblFriday.Text = ":Freitag";
      // 
      // textBox8
      // 
      this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox8.Location = new System.Drawing.Point(119, 128);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(64, 20);
      this.textBox8.TabIndex = 13;
      // 
      // textBox5
      // 
      this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox5.Location = new System.Drawing.Point(208, 102);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(64, 20);
      this.textBox5.TabIndex = 12;
      // 
      // lblWednesday
      // 
      this.lblWednesday.AutoSize = true;
      this.lblWednesday.Location = new System.Drawing.Point(41, 105);
      this.lblWednesday.Name = "lblWednesday";
      this.lblWednesday.Size = new System.Drawing.Size(65, 13);
      this.lblWednesday.TabIndex = 11;
      this.lblWednesday.Text = ":Donnerstag";
      // 
      // textBox6
      // 
      this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox6.Location = new System.Drawing.Point(119, 102);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(64, 20);
      this.textBox6.TabIndex = 10;
      // 
      // textBox3
      // 
      this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox3.Location = new System.Drawing.Point(208, 76);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(64, 20);
      this.textBox3.TabIndex = 9;
      // 
      // lblThursday
      // 
      this.lblThursday.AutoSize = true;
      this.lblThursday.Location = new System.Drawing.Point(41, 83);
      this.lblThursday.Name = "lblThursday";
      this.lblThursday.Size = new System.Drawing.Size(53, 13);
      this.lblThursday.TabIndex = 8;
      this.lblThursday.Text = ":Mittwoch";
      // 
      // textBox4
      // 
      this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox4.Location = new System.Drawing.Point(119, 76);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(64, 20);
      this.textBox4.TabIndex = 7;
      // 
      // txtBoxOpeningHourTuesday
      // 
      this.txtBoxOpeningHourTuesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxOpeningHourTuesday.Location = new System.Drawing.Point(208, 50);
      this.txtBoxOpeningHourTuesday.Name = "txtBoxOpeningHourTuesday";
      this.txtBoxOpeningHourTuesday.Size = new System.Drawing.Size(64, 20);
      this.txtBoxOpeningHourTuesday.TabIndex = 6;
      // 
      // lblTuesday
      // 
      this.lblTuesday.AutoSize = true;
      this.lblTuesday.Location = new System.Drawing.Point(41, 57);
      this.lblTuesday.Name = "lblTuesday";
      this.lblTuesday.Size = new System.Drawing.Size(52, 13);
      this.lblTuesday.TabIndex = 5;
      this.lblTuesday.Text = ":Dienstag";
      // 
      // txtBoxOpeningHourTuesdayFrom
      // 
      this.txtBoxOpeningHourTuesdayFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxOpeningHourTuesdayFrom.Location = new System.Drawing.Point(119, 50);
      this.txtBoxOpeningHourTuesdayFrom.Name = "txtBoxOpeningHourTuesdayFrom";
      this.txtBoxOpeningHourTuesdayFrom.Size = new System.Drawing.Size(64, 20);
      this.txtBoxOpeningHourTuesdayFrom.TabIndex = 4;
      // 
      // txtBoxOpenenHourMondayto
      // 
      this.txtBoxOpenenHourMondayto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxOpenenHourMondayto.Location = new System.Drawing.Point(208, 24);
      this.txtBoxOpenenHourMondayto.Name = "txtBoxOpenenHourMondayto";
      this.txtBoxOpenenHourMondayto.Size = new System.Drawing.Size(64, 20);
      this.txtBoxOpenenHourMondayto.TabIndex = 3;
      // 
      // lblMonday
      // 
      this.lblMonday.AutoSize = true;
      this.lblMonday.Location = new System.Drawing.Point(41, 31);
      this.lblMonday.Name = "lblMonday";
      this.lblMonday.Size = new System.Drawing.Size(46, 13);
      this.lblMonday.TabIndex = 2;
      this.lblMonday.Text = ":Montag";
      // 
      // txtBoxOpeningHourMondeyfrom
      // 
      this.txtBoxOpeningHourMondeyfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxOpeningHourMondeyfrom.Location = new System.Drawing.Point(119, 24);
      this.txtBoxOpeningHourMondeyfrom.Name = "txtBoxOpeningHourMondeyfrom";
      this.txtBoxOpeningHourMondeyfrom.Size = new System.Drawing.Size(64, 20);
      this.txtBoxOpeningHourMondeyfrom.TabIndex = 1;
      // 
      // lblOpeningHours
      // 
      this.lblOpeningHours.AutoSize = true;
      this.lblOpeningHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOpeningHours.Location = new System.Drawing.Point(9, 7);
      this.lblOpeningHours.Name = "lblOpeningHours";
      this.lblOpeningHours.Size = new System.Drawing.Size(92, 13);
      this.lblOpeningHours.TabIndex = 0;
      this.lblOpeningHours.Text = "Öffnungszeiten";
      // 
      // frmMainAccount
      // 
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(461, 597);
      this.Controls.Add(this.tbControlMain);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmMainAccount";
      this.tbControlMain.ResumeLayout(false);
      this.tbPgeBook.ResumeLayout(false);
      this.pnlBookHeader.ResumeLayout(false);
      this.pnlBookHeader.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtGridViewBook)).EndInit();
      this.tbPgeUser.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.tbPgeLibrary.ResumeLayout(false);
      this.tbPgeLibrary.PerformLayout();
      this.ResumeLayout(false);

    }
  }
}
