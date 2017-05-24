using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
namespace serwertTCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener serwer = null;
        private TcpClient klient = null;
        private void Start_Click(object sender, EventArgs e)
        {
            IPAddress adresIP = null;
            try
            {
                adresIP = IPAddress.Parse(adres.Text);
            }
            catch
            {
                MessageBox.Show("Błedny adres ,", "Błąd");
                adres.Text = String.Empty;
                return;
            }

            int port = System.Convert.ToInt32(my_port.Value);
            try
            {
                serwer = new TcpListener(adresIP, port);
                serwer.Start();

                klient = serwer.AcceptTcpClient();
                info_o_polaczeniu.Items.Add("Nawiazano polacz");

                Start.Enabled = false;
                Stop.Enabled = true;

                klient.Close();
                serwer.Stop();
            }
            catch (Exception ex)
            {
                info_o_polaczeniu.Items.Add("Blad inicjacji serwera ");
                MessageBox.Show(ex.ToString(), "Blad");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Start.Enabled = false;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            serwer.Stop();
            klient.Close();
            info_o_polaczeniu.Items.Add("zakonczono prace");

            Start.Enabled = true;
            Stop.Enabled = false;
        }
    }
}
