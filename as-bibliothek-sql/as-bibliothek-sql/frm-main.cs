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
    private DataGridView dataGridView1;
    private TabPage tbpPgeLibrary;
  
    public frmMain()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tbpgeBooks = new System.Windows.Forms.TabPage();
      this.tbPgeClients = new System.Windows.Forms.TabPage();
      this.tbPgeEmployes = new System.Windows.Forms.TabPage();
      this.tbpPgeLibrary = new System.Windows.Forms.TabPage();
      this.lblSearchBook = new System.Windows.Forms.Label();
      this.txtBoxSearchBook = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.tabControl1.SuspendLayout();
      this.tbpgeBooks.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
      this.tbpgeBooks.Controls.Add(this.dataGridView1);
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
      // tbPgeClients
      // 
      this.tbPgeClients.BackColor = System.Drawing.Color.Transparent;
      this.tbPgeClients.ForeColor = System.Drawing.Color.MediumSpringGreen;
      this.tbPgeClients.Location = new System.Drawing.Point(4, 25);
      this.tbPgeClients.Name = "tbPgeClients";
      this.tbPgeClients.Padding = new System.Windows.Forms.Padding(3);
      this.tbPgeClients.Size = new System.Drawing.Size(457, 209);
      this.tbPgeClients.TabIndex = 1;
      this.tbPgeClients.Text = "Kunden";
      // 
      // tbPgeEmployes
      // 
      this.tbPgeEmployes.BackColor = System.Drawing.Color.Transparent;
      this.tbPgeEmployes.ForeColor = System.Drawing.Color.MediumSpringGreen;
      this.tbPgeEmployes.Location = new System.Drawing.Point(4, 25);
      this.tbPgeEmployes.Name = "tbPgeEmployes";
      this.tbPgeEmployes.Size = new System.Drawing.Size(457, 209);
      this.tbPgeEmployes.TabIndex = 2;
      this.tbPgeEmployes.Text = "Mitarbeiter";
      // 
      // tbpPgeLibrary
      // 
      this.tbpPgeLibrary.BackColor = System.Drawing.Color.Transparent;
      this.tbpPgeLibrary.ForeColor = System.Drawing.Color.MediumSpringGreen;
      this.tbpPgeLibrary.Location = new System.Drawing.Point(4, 25);
      this.tbpPgeLibrary.Name = "tbpPgeLibrary";
      this.tbpPgeLibrary.Size = new System.Drawing.Size(457, 209);
      this.tbpPgeLibrary.TabIndex = 3;
      this.tbpPgeLibrary.Text = "Bibliothek";
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
      this.lblSearchBook.Click += new System.EventHandler(this.lblSearchBook_Click);
      // 
      // txtBoxSearchBook
      // 
      this.txtBoxSearchBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxSearchBook.Location = new System.Drawing.Point(53, 6);
      this.txtBoxSearchBook.Name = "txtBoxSearchBook";
      this.txtBoxSearchBook.Size = new System.Drawing.Size(581, 20);
      this.txtBoxSearchBook.TabIndex = 1;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(6, 49);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(628, 350);
      this.dataGridView1.TabIndex = 2;
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
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    private void lblSearchBook_Click(object sender, EventArgs e)
    {

    }


  }
}
