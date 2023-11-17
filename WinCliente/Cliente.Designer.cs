
namespace WinCliente
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnvia = new System.Windows.Forms.Button();
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.btnLigar = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblipservidor = new System.Windows.Forms.Label();
            this.txtipservidor = new System.Windows.Forms.TextBox();
            this.txtporta = new System.Windows.Forms.TextBox();
            this.lblporta = new System.Windows.Forms.Label();
            this.ltbUtilizadoresCliente = new System.Windows.Forms.ListBox();
            this.ctmConversar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enviarMensagemPrivadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConversaprivada = new System.Windows.Forms.Label();
            this.lblNomeConversaPriv = new System.Windows.Forms.Label();
            this.btnSairConversaPriv = new System.Windows.Forms.Button();
            this.ctmConversar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Enabled = false;
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(273, 57);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(349, 29);
            this.txtMensagem.TabIndex = 0;
            // 
            // btnEnvia
            // 
            this.btnEnvia.Enabled = false;
            this.btnEnvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvia.Location = new System.Drawing.Point(628, 52);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(160, 38);
            this.btnEnvia.TabIndex = 1;
            this.btnEnvia.Text = "&Enviar";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // richLog
            // 
            this.richLog.Enabled = false;
            this.richLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richLog.Location = new System.Drawing.Point(13, 96);
            this.richLog.Name = "richLog";
            this.richLog.Size = new System.Drawing.Size(609, 342);
            this.richLog.TabIndex = 2;
            this.richLog.Text = "";
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(628, 8);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(160, 38);
            this.btnLigar.TabIndex = 4;
            this.btnLigar.Text = "&Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(369, 17);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(253, 29);
            this.txtUser.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(270, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(93, 18);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "UserName:";
            // 
            // lblipservidor
            // 
            this.lblipservidor.AutoSize = true;
            this.lblipservidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblipservidor.Location = new System.Drawing.Point(10, 24);
            this.lblipservidor.Name = "lblipservidor";
            this.lblipservidor.Size = new System.Drawing.Size(96, 18);
            this.lblipservidor.TabIndex = 7;
            this.lblipservidor.Text = "IP Servidor:";
            // 
            // txtipservidor
            // 
            this.txtipservidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtipservidor.Location = new System.Drawing.Point(112, 17);
            this.txtipservidor.Name = "txtipservidor";
            this.txtipservidor.Size = new System.Drawing.Size(144, 29);
            this.txtipservidor.TabIndex = 8;
            // 
            // txtporta
            // 
            this.txtporta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtporta.Location = new System.Drawing.Point(138, 57);
            this.txtporta.Name = "txtporta";
            this.txtporta.Size = new System.Drawing.Size(118, 29);
            this.txtporta.TabIndex = 10;
            // 
            // lblporta
            // 
            this.lblporta.AutoSize = true;
            this.lblporta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporta.Location = new System.Drawing.Point(10, 64);
            this.lblporta.Name = "lblporta";
            this.lblporta.Size = new System.Drawing.Size(122, 18);
            this.lblporta.TabIndex = 9;
            this.lblporta.Text = "Porta Servidor:";
            // 
            // ltbUtilizadoresCliente
            // 
            this.ltbUtilizadoresCliente.ContextMenuStrip = this.ctmConversar;
            this.ltbUtilizadoresCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbUtilizadoresCliente.FormattingEnabled = true;
            this.ltbUtilizadoresCliente.ItemHeight = 20;
            this.ltbUtilizadoresCliente.Location = new System.Drawing.Point(628, 96);
            this.ltbUtilizadoresCliente.Name = "ltbUtilizadoresCliente";
            this.ltbUtilizadoresCliente.Size = new System.Drawing.Size(160, 344);
            this.ltbUtilizadoresCliente.TabIndex = 11;
            // 
            // ctmConversar
            // 
            this.ctmConversar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarMensagemPrivadaToolStripMenuItem});
            this.ctmConversar.Name = "ctmConversar";
            this.ctmConversar.Size = new System.Drawing.Size(211, 26);
            // 
            // enviarMensagemPrivadaToolStripMenuItem
            // 
            this.enviarMensagemPrivadaToolStripMenuItem.Name = "enviarMensagemPrivadaToolStripMenuItem";
            this.enviarMensagemPrivadaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.enviarMensagemPrivadaToolStripMenuItem.Text = "Enviar mensagem privada";
            this.enviarMensagemPrivadaToolStripMenuItem.Click += new System.EventHandler(this.enviarMensagemPrivadaToolStripMenuItem_Click);
            // 
            // lblConversaprivada
            // 
            this.lblConversaprivada.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversaprivada.Location = new System.Drawing.Point(628, 96);
            this.lblConversaprivada.Name = "lblConversaprivada";
            this.lblConversaprivada.Size = new System.Drawing.Size(160, 181);
            this.lblConversaprivada.TabIndex = 13;
            this.lblConversaprivada.Text = "Em conversa privada com";
            this.lblConversaprivada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConversaprivada.Visible = false;
            // 
            // lblNomeConversaPriv
            // 
            this.lblNomeConversaPriv.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeConversaPriv.Location = new System.Drawing.Point(628, 268);
            this.lblNomeConversaPriv.Name = "lblNomeConversaPriv";
            this.lblNomeConversaPriv.Size = new System.Drawing.Size(160, 68);
            this.lblNomeConversaPriv.TabIndex = 14;
            this.lblNomeConversaPriv.Text = "EU :)";
            this.lblNomeConversaPriv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomeConversaPriv.Visible = false;
            // 
            // btnSairConversaPriv
            // 
            this.btnSairConversaPriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairConversaPriv.Location = new System.Drawing.Point(628, 349);
            this.btnSairConversaPriv.Name = "btnSairConversaPriv";
            this.btnSairConversaPriv.Size = new System.Drawing.Size(160, 89);
            this.btnSairConversaPriv.TabIndex = 15;
            this.btnSairConversaPriv.Text = "Sair da Conversa";
            this.btnSairConversaPriv.UseVisualStyleBackColor = true;
            this.btnSairConversaPriv.Visible = false;
            this.btnSairConversaPriv.Click += new System.EventHandler(this.btnSairConversaPriv_Click);
            // 
            // frmPrincipal
            // 
            this.AcceptButton = this.btnEnvia;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSairConversaPriv);
            this.Controls.Add(this.lblNomeConversaPriv);
            this.Controls.Add(this.lblConversaprivada);
            this.Controls.Add(this.ltbUtilizadoresCliente);
            this.Controls.Add(this.txtporta);
            this.Controls.Add(this.lblporta);
            this.Controls.Add(this.txtipservidor);
            this.Controls.Add(this.lblipservidor);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.richLog);
            this.Controls.Add(this.btnEnvia);
            this.Controls.Add(this.txtMensagem);
            this.Name = "frmPrincipal";
            this.Text = "WinChat - Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ctmConversar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.RichTextBox richLog;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblipservidor;
        private System.Windows.Forms.TextBox txtipservidor;
        private System.Windows.Forms.TextBox txtporta;
        private System.Windows.Forms.Label lblporta;
        private System.Windows.Forms.ListBox ltbUtilizadoresCliente;
        private System.Windows.Forms.ContextMenuStrip ctmConversar;
        private System.Windows.Forms.ToolStripMenuItem enviarMensagemPrivadaToolStripMenuItem;
        private System.Windows.Forms.Label lblConversaprivada;
        private System.Windows.Forms.Label lblNomeConversaPriv;
        private System.Windows.Forms.Button btnSairConversaPriv;
    }
}

