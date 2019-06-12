namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.winFormsBrowserView1 = new DotNetBrowser.WinForms.WinFormsBrowserView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.winFormsBrowserView2 = new DotNetBrowser.WinForms.WinFormsBrowserView();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.winFormsBrowserView3 = new DotNetBrowser.WinForms.WinFormsBrowserView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.destinatario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.asunto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mensaje = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.winFormsBrowserView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Laboratorios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // winFormsBrowserView1
            // 
            this.winFormsBrowserView1.AcceptLanguage = null;
            this.winFormsBrowserView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winFormsBrowserView1.AudioMuted = null;
            this.winFormsBrowserView1.BrowserType = DotNetBrowser.BrowserType.LIGHTWEIGHT;
            this.winFormsBrowserView1.InitialFocusOwner = false;
            this.winFormsBrowserView1.Location = new System.Drawing.Point(0, 0);
            this.winFormsBrowserView1.Name = "winFormsBrowserView1";
            this.winFormsBrowserView1.Preferences = null;
            this.winFormsBrowserView1.Size = new System.Drawing.Size(794, 322);
            this.winFormsBrowserView1.TabIndex = 1;
            this.winFormsBrowserView1.URL = "http://172.24.160.5:1155";
            this.winFormsBrowserView1.ZoomLevel = null;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.winFormsBrowserView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Noticias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // winFormsBrowserView2
            // 
            this.winFormsBrowserView2.AcceptLanguage = null;
            this.winFormsBrowserView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winFormsBrowserView2.AudioMuted = null;
            this.winFormsBrowserView2.BrowserType = DotNetBrowser.BrowserType.LIGHTWEIGHT;
            this.winFormsBrowserView2.InitialFocusOwner = false;
            this.winFormsBrowserView2.Location = new System.Drawing.Point(0, 0);
            this.winFormsBrowserView2.Name = "winFormsBrowserView2";
            this.winFormsBrowserView2.Preferences = null;
            this.winFormsBrowserView2.Size = new System.Drawing.Size(794, 322);
            this.winFormsBrowserView2.TabIndex = 0;
            this.winFormsBrowserView2.URL = "https://www.facebook.com/Ingenier%C3%ADa-en-Computaci%C3%B3n-SSC-159116403110/";
            this.winFormsBrowserView2.ZoomLevel = null;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 106);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(802, 348);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.winFormsBrowserView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(794, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clima";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // winFormsBrowserView3
            // 
            this.winFormsBrowserView3.AcceptLanguage = null;
            this.winFormsBrowserView3.AudioMuted = null;
            this.winFormsBrowserView3.BrowserType = DotNetBrowser.BrowserType.LIGHTWEIGHT;
            this.winFormsBrowserView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winFormsBrowserView3.InitialFocusOwner = false;
            this.winFormsBrowserView3.Location = new System.Drawing.Point(3, 3);
            this.winFormsBrowserView3.Name = "winFormsBrowserView3";
            this.winFormsBrowserView3.Preferences = null;
            this.winFormsBrowserView3.Size = new System.Drawing.Size(788, 316);
            this.winFormsBrowserView3.TabIndex = 0;
            this.winFormsBrowserView3.URL = "https://app.ubidots.com/ubi/public/getdashboard/5aoOnYuVUck8jPwfrQZf2MlP_jk#/";
            this.winFormsBrowserView3.ZoomLevel = null;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.materialFlatButton1);
            this.tabPage4.Controls.Add(this.materialLabel3);
            this.tabPage4.Controls.Add(this.mensaje);
            this.tabPage4.Controls.Add(this.asunto);
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Controls.Add(this.destinatario);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(794, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Enviar correo";
            // 
            // destinatario
            // 
            this.destinatario.Depth = 0;
            this.destinatario.Hint = "";
            this.destinatario.Location = new System.Drawing.Point(193, 25);
            this.destinatario.MaxLength = 32767;
            this.destinatario.MouseState = MaterialSkin.MouseState.HOVER;
            this.destinatario.Name = "destinatario";
            this.destinatario.PasswordChar = '\0';
            this.destinatario.SelectedText = "";
            this.destinatario.SelectionLength = 0;
            this.destinatario.SelectionStart = 0;
            this.destinatario.Size = new System.Drawing.Size(176, 23);
            this.destinatario.TabIndex = 0;
            this.destinatario.TabStop = false;
            this.destinatario.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 61);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTabSelector1.Size = new System.Drawing.Size(802, 45);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Click += new System.EventHandler(this.MaterialTabSelector1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(44, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Correo destinatario:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(392, 29);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Asunto:";
            // 
            // asunto
            // 
            this.asunto.Depth = 0;
            this.asunto.Hint = "";
            this.asunto.Location = new System.Drawing.Point(459, 25);
            this.asunto.MaxLength = 32767;
            this.asunto.MouseState = MaterialSkin.MouseState.HOVER;
            this.asunto.Name = "asunto";
            this.asunto.PasswordChar = '\0';
            this.asunto.SelectedText = "";
            this.asunto.SelectionLength = 0;
            this.asunto.SelectionStart = 0;
            this.asunto.Size = new System.Drawing.Size(176, 23);
            this.asunto.TabIndex = 3;
            this.asunto.TabStop = false;
            this.asunto.UseSystemPasswordChar = false;
            // 
            // mensaje
            // 
            this.mensaje.Location = new System.Drawing.Point(216, 102);
            this.mensaje.Multiline = true;
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(386, 143);
            this.mensaje.TabIndex = 4;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(135, 102);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Mensaje";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(375, 254);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(69, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "Enviar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Form1";
            this.Text = "Escuela de Ingeniería en Computación";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private DotNetBrowser.WinForms.WinFormsBrowserView winFormsBrowserView1;
        private DotNetBrowser.WinForms.WinFormsBrowserView winFormsBrowserView2;
        private System.Windows.Forms.TabPage tabPage3;
        private DotNetBrowser.WinForms.WinFormsBrowserView winFormsBrowserView3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialSingleLineTextField destinatario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox mensaje;
        private MaterialSkin.Controls.MaterialSingleLineTextField asunto;
    }
}

