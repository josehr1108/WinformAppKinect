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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.winFormsBrowserView2 = new DotNetBrowser.WinForms.WinFormsBrowserView();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
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
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 106);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(802, 348);
            this.materialTabControl1.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private DotNetBrowser.WinForms.WinFormsBrowserView winFormsBrowserView1;
        private DotNetBrowser.WinForms.WinFormsBrowserView winFormsBrowserView2;
    }
}

