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

namespace WinServidor
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        byte[] clientData = new byte[1024];
        Socket ServerSock;
        struct ClienteInfo
        {
            public Socket sock;
            public string nome;
        }
        List<ClienteInfo> Clientes = new List<ClienteInfo>();
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 9000);
            ServerSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ServerSock.Bind(ipEnd);
            ServerSock.Listen(100);           // 100 = Número de ligações

            //clientSock é o socket do cliente receber a mensagem
            ServerSock.BeginAccept(new AsyncCallback(OnAccept), null);
        }
        private void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = ServerSock.EndAccept(ar);

                //Inicia para receber mais clientes
                ServerSock.BeginAccept(new AsyncCallback(OnAccept), null);

                //Assim que estabelece a ligação começa a receber dados
                clientSocket.BeginReceive(clientData, 0, clientData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Utilizadores()
        {
            ltbUtilizadores.Items.Clear();
            string ListaUtil = "7";
            foreach (ClienteInfo obj in Clientes)
            {
                ltbUtilizadores.Items.Add(obj.nome);
                ListaUtil += obj.nome + "|";
            }
            ListaUtil = ListaUtil.Substring(0, ListaUtil.Length - 1);

            foreach (ClienteInfo obj in Clientes)
            {
               obj.sock.Send(Encoding.UTF8.GetBytes(ListaUtil));
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndReceive(ar);

                string strRecebe = Encoding.UTF8.GetString(clientData);
                strRecebe = strRecebe.Replace("\0", string.Empty);
                // Versão 3
                int protocolo = int.Parse(strRecebe[0].ToString());
                switch (protocolo)
                {
                    case 1: // Login
                        ClienteInfo cliente = new ClienteInfo();
                        cliente.nome = strRecebe.Substring(1, strRecebe.Length - 1);
                        cliente.sock = clientSocket;
                        Clientes.Add(cliente);
                        txtLog.Text = "Entrou " + cliente.nome + "\r\n" + txtLog.Text;
                        Utilizadores();
                        break;
                    case 2: // Mensagem para Todos
                        txtLog.Text = strRecebe.Substring(1, strRecebe.Length - 1) + "\r\n" + txtLog.Text;
                        break;

                    case 3:
                        string ConversaPriv = strRecebe.Substring(1, strRecebe.Length - 1);
                        String[] DadosConvPriv = ConversaPriv.Split('|');
                        txtLog.Text = DadosConvPriv[0] + " enviou a " + DadosConvPriv[1] + ": " + DadosConvPriv[2] + "\r\n" + txtLog.Text; 
                        break;

                    case 9: //Logout
                        int npos = 0;
                        string nome = "";
                        foreach (ClienteInfo obj in Clientes)
                        {
                            if (obj.sock == clientSocket)
                            {
                                nome = obj.nome;
                                Clientes.RemoveAt(npos);
                                break;
                            }
                            npos++;
                        }
                        clientSocket.Close();
                        clientSocket = null;
                        txtLog.Text = "Saiu " + nome + "\r\n" + txtLog.Text;
                        Utilizadores();
                        break;
                }
                Array.Clear(clientData, 0, clientData.Length);
                foreach (ClienteInfo obj in Clientes)
                {
                    obj.sock.Send(Encoding.UTF8.GetBytes(strRecebe));
                }
                if (clientSocket != null)
                {
                    clientSocket.BeginReceive(clientData, 0, clientData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSocket);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel estabelecer a ligação." + ex.Message);
            }
        }
        private void kickUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ltbUtilizadores.SelectedItem != null)
            {
                foreach (ClienteInfo obj in Clientes)
                {
                    obj.sock.Send(Encoding.UTF8.GetBytes("8" + ltbUtilizadores.SelectedItem.ToString()));
                }
                txtLog.Text = ltbUtilizadores.SelectedItem.ToString()+ " foi banido."+ "\r\n" + txtLog.Text;
            }
        }
        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void ltbUtilizadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ctmUtilizadores_Opening(object sender, CancelEventArgs e)
        {

        }


    }
}
