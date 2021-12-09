using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace HTTPSMTPTASK1
{
    public partial class Form1 : Form
    {
        static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var url = textBox1.Text;          
            

        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            var url = textBox1.Text;
            if (url != string.Empty)
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    /* HttpResponseMessage response = await client.GetAsync(url);*/
                    var response = (HttpWebResponse)request.GetResponse();
                    var code = ((int)response.StatusCode);
                    label2.Text = code.ToString();
                    if(code == 200)
                    {
                        webBrowser1.Navigate(url);
                    }
                    else
                    {
                        label2.Text = ((int)response.StatusCode).ToString();
                    }
                }
                catch (Exception msg)
                {

                    label2.Text = msg.Message;
                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
