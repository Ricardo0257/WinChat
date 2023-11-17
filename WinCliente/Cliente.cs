using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCliente
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        Socket clientSock;
        // Versão 2
        byte[] serverData = new byte[1024];
        bool ConversaPrivada=false ;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtipservidor.Text = "127.0.0.1";
            txtporta.Text = "9000";
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] byData;
                if(ConversaPrivada)
                {
                    string strEnvia = "3" + txtUser.Text + "|" + ltbUtilizadoresCliente.SelectedItem.ToString() + "|" + txtMensagem.Text;
                    byData = System.Text.Encoding.UTF8.GetBytes(strEnvia);
                    richLog.Text = "(Privado)Enviaste a " + ltbUtilizadoresCliente.SelectedItem.ToString() + ": " +txtMensagem.Text + "\r\n" + richLog.Text;
                }
                else
                {
                    string strEnvia = "2" + txtUser.Text + ": " + txtMensagem.Text;
                    byData = System.Text.Encoding.UTF8.GetBytes(strEnvia);
                }

                clientSock.Send(byData);
                txtMensagem.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Versão 2
        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndReceive(ar);

                string strRecebe = Encoding.UTF8.GetString(serverData).TrimEnd('\0');
                int protocolo = int.Parse(strRecebe[0].ToString());
                switch (protocolo)
                {
                    case 1:     // Login
                        richLog.Text = "Entrou " + strRecebe.Substring(1, strRecebe.Length - 1) + "\r\n" + richLog.Text;
                        break;
                    case 2:     // Mensagem
                        richLog.Text = strRecebe.Substring(1, strRecebe.Length - 1) + "\r\n" + richLog.Text;
                        break;
                    case 3:
                        string ConversaPriv = strRecebe.Substring(1, strRecebe.Length - 1);
                        String[] DadosConvPriv = ConversaPriv.Split('|');
                        if (txtUser.Text == DadosConvPriv[1])
                        {
                            richLog.Text = DadosConvPriv[0] + "(Privado): " + DadosConvPriv[2] + "\r\n" + richLog.Text;
                        }
                        
                        break;
                    case 7:

                        ltbUtilizadoresCliente.Items.Clear();
                        string Utilizadores = strRecebe.Substring(1, strRecebe.Length - 1);
                        string[] listaUtil = Utilizadores.Split('|');

                        foreach(var a in listaUtil)
                        {
                            ltbUtilizadoresCliente.Items.Add(a);
                        }
                        ltbUtilizadoresCliente.Text += listaUtil;
                        break;
                    case 8:     // Kick

                        if(strRecebe.Substring(1, strRecebe.Length - 1) == txtUser.Text)
                        {
                            MessageBox.Show("Voce foi banido","Banido",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            clientSock.Send(Encoding.UTF8.GetBytes("9" + txtUser.Text));
                            Application.Exit();
                        }
                        else
                        {
                            richLog.Text = strRecebe.Substring(1, strRecebe.Length - 1)+ " foi expulso." + "\r\n" + richLog.Text;
                        }
                        
                        break;
                    case 9:     // Logoout
                        richLog.Text = "Saiu " + strRecebe.Substring(1, strRecebe.Length - 1) + "\r\n" + richLog.Text;
                        break;
                }
                Array.Clear(serverData, 0, serverData.Length);

                clientSock.BeginReceive(serverData, 0, serverData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel estabelecer a ligação." + ex.Message);
            }

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if(txtipservidor.Text == "" || txtUser.Text == "" || txtUser.Text.Length < 4)
            {
                string mserro = "";
                if (txtipservidor.Text == "")
                {
                    mserro += "Coloque o IP do servidor\n";
                }
                if (txtUser.Text == "")
                {
                    mserro += "Coloque o Username";
                }
                else if (txtUser.Text.Length < 4)
                {
                    mserro += "Username demasiado pequeno";
                }
                MessageBox.Show(mserro);
            }
            else
            {
                try
                {
                    IPAddress[] ipAddress = Dns.GetHostAddresses(txtipservidor.Text);
                    IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], Convert.ToInt32(txtporta.Text));
                    clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    clientSock.BeginConnect(ipEnd, null, null);
                    // Versão 2
                    clientSock.BeginReceive(serverData, 0, serverData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSock);
                    clientSock.Send(Encoding.UTF8.GetBytes("1" + txtUser.Text));
                    txtMensagem.Enabled = true;
                    txtipservidor.Enabled = false;
                    lblipservidor.Enabled = false;
                    lblUser.Enabled = false;
                    lblporta.Enabled = false;
                    txtporta.Enabled = false;
                    btnEnvia.Enabled = true;
                    txtUser.Enabled = false;
                    btnLigar.Enabled = false;
                    richLog.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clientSock != null)
            {
                clientSock.Send(Encoding.UTF8.GetBytes("9" + txtUser.Text));
            }
        }

        private void enviarMensagemPrivadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(txtUser.Text != ltbUtilizadoresCliente.SelectedItem.ToString())
            {
                ltbUtilizadoresCliente.Visible = false;
                lblConversaprivada.Visible = true;
                lblNomeConversaPriv.Visible = true;
                btnSairConversaPriv.Visible = true;

                ConversaPrivada = true;
                lblNomeConversaPriv.Text = ltbUtilizadoresCliente.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Não pode mandar a si mesmo!");
            }
            
        }

        private void btnSairConversaPriv_Click(object sender, EventArgs e)
        {
            ltbUtilizadoresCliente.Visible = true;
            lblConversaprivada.Visible = false;
            lblNomeConversaPriv.Visible = false;
            btnSairConversaPriv.Visible = false;
            ConversaPrivada = false;
        }
    }
}
