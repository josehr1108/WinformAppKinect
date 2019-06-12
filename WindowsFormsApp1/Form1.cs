using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using DotNetBrowser;
using DotNetBrowser.WinForms;


namespace WindowsFormsApp1
{
    public partial class Form1 : MaterialForm
    {
        private delegate int safeGetIndex();
        private delegate void safeSetIndex(int index);

        public Form1()
        {
            InitializeComponent();
        }

        private void MaterialTabSelector1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(destinatario.Text);
            mmsg.Subject= asunto.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = mensaje.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;

            mmsg.IsBodyHtml = true;


            mmsg.From = new System.Net.Mail.MailAddress("pruebacuentafake@gmail.com");
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("pruebacuentafake@gmail.com", "jurguen11");

            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";

            try
            {
                client.Send(mmsg);
                MessageBox.Show("Mensaje enviado");
            }
            catch(Exception exe)
            {
                MessageBox.Show("Ocurrio un error, por favor comunicalo a la escuela"); 
            }
        }

        public int safeGetSelectedTabIndex()
        {
            if (materialTabControl1.InvokeRequired)
            {
                var del = new safeGetIndex(safeGetSelectedTabIndex);
                var returnValue = Invoke(del, null);
                return (int)returnValue;
            }
            else
            {
                return materialTabControl1.SelectedIndex;
            }
        }
        public int getSelectedTabIndex()
        {
            return safeGetSelectedTabIndex();
        }

        public void safeSetSelectedTabIndex(int index)
        {
            if(index >= 0 && index <= 3)
            {
                if (materialTabControl1.InvokeRequired)
                {
                    var del = new safeSetIndex(safeSetSelectedTabIndex);
                    Invoke(del, new object[] { index });
                }
                else
                {
                    materialTabControl1.SelectTab(index);
                }
            }
        }

        public void setSelectedTabIndex(int index)
        {
            safeSetSelectedTabIndex(index);
        }
    }
}
/*if (index >= 0 && index <= 3)
            {
                materialTabControl1.SelectTab(index);
            }*/