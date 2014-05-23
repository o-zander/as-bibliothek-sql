namespace as_bibliothek_sql
{
  partial class login
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtBoxLogin = new System.Windows.Forms.TextBox();
      this.txtBoxPasswort = new System.Windows.Forms.TextBox();
      this.lblLogIn = new System.Windows.Forms.Label();
      this.lblPasswort = new System.Windows.Forms.Label();
      this.btnLogin = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtBoxLogin
      // 
      this.txtBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxLogin.Location = new System.Drawing.Point(128, 24);
      this.txtBoxLogin.Name = "txtBoxLogin";
      this.txtBoxLogin.Size = new System.Drawing.Size(137, 20);
      this.txtBoxLogin.TabIndex = 0;
      // 
      // txtBoxPasswort
      // 
      this.txtBoxPasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtBoxPasswort.Location = new System.Drawing.Point(128, 53);
      this.txtBoxPasswort.Name = "txtBoxPasswort";
      this.txtBoxPasswort.Size = new System.Drawing.Size(137, 20);
      this.txtBoxPasswort.TabIndex = 1;
      // 
      // lblLogIn
      // 
      this.lblLogIn.AutoSize = true;
      this.lblLogIn.BackColor = System.Drawing.Color.Transparent;
      this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblLogIn.Location = new System.Drawing.Point(30, 27);
      this.lblLogIn.Name = "lblLogIn";
      this.lblLogIn.Size = new System.Drawing.Size(92, 17);
      this.lblLogIn.TabIndex = 2;
      this.lblLogIn.Text = "Login Name: ";
      // 
      // lblPasswort
      // 
      this.lblPasswort.AutoSize = true;
      this.lblPasswort.BackColor = System.Drawing.Color.Transparent;
      this.lblPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPasswort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblPasswort.Location = new System.Drawing.Point(30, 53);
      this.lblPasswort.Name = "lblPasswort";
      this.lblPasswort.Size = new System.Drawing.Size(73, 17);
      this.lblPasswort.TabIndex = 3;
      this.lblPasswort.Text = "Passwort: ";
      // 
      // btnLogin
      // 
      this.btnLogin.BackColor = System.Drawing.Color.Transparent;
      this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnLogin.Location = new System.Drawing.Point(165, 95);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(100, 29);
      this.btnLogin.TabIndex = 4;
      this.btnLogin.Text = "anmelden";
      this.btnLogin.UseVisualStyleBackColor = false;
      // 
      // login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.BackgroundImage = global::as_bibliothek_sql.Properties.Resources._171930__grass_grass_plants_herbs_green_nature_light_glare_bokeh_close_up_p;
      this.ClientSize = new System.Drawing.Size(297, 151);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.lblPasswort);
      this.Controls.Add(this.lblLogIn);
      this.Controls.Add(this.txtBoxPasswort);
      this.Controls.Add(this.txtBoxLogin);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "login";
      this.Text = "Login";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtBoxLogin;
    private System.Windows.Forms.TextBox txtBoxPasswort;
    private System.Windows.Forms.Label lblLogIn;
    private System.Windows.Forms.Label lblPasswort;
    private System.Windows.Forms.Button btnLogin;
  }
}

