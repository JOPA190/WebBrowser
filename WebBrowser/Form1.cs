using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Diminuir largura em pixels 50 em relação ao forms
            webBrowser1.Width = this.Width - 50;
            //diminuir altura em pixels 125 em relação ao form
            webBrowser1.Height = this.Height - 125;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //Diminuir largura em pixels 50 em relação ao forms
            webBrowser1.Width = this.Width - 50;
            //diminuir altura em pixels 125 em relação ao form
            webBrowser1.Height = this.Height - 125;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //liberar todos os recursos utilizados pelo componente
            webBrowser1.Dispose();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            try
            {
                Uri abrirUrl = new Uri(txt_URL.Text);
                webBrowser1.Url = abrirUrl;
            }
            catch (Exception erroURL) 
            {
                MessageBox.Show("ops" + erroURL.Message, "nosso navegador");
                MessageBox.Show("Não esqueça de colocar o endereço completo", "nosso navegador");
            }

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_Avançar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
