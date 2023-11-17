
namespace WinServidor
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.ctmUtilizadores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kickUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ltbUtilizadores = new System.Windows.Forms.ListBox();
            this.ctmUtilizadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(12, 12);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(518, 341);
            this.txtLog.TabIndex = 0;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // ctmUtilizadores
            // 
            this.ctmUtilizadores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kickUserToolStripMenuItem});
            this.ctmUtilizadores.Name = "ctmUtilizadores";
            this.ctmUtilizadores.Size = new System.Drawing.Size(122, 26);
            this.ctmUtilizadores.Opening += new System.ComponentModel.CancelEventHandler(this.ctmUtilizadores_Opening);
            // 
            // kickUserToolStripMenuItem
            // 
            this.kickUserToolStripMenuItem.Name = "kickUserToolStripMenuItem";
            this.kickUserToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.kickUserToolStripMenuItem.Text = "Kick user";
            this.kickUserToolStripMenuItem.Click += new System.EventHandler(this.kickUserToolStripMenuItem_Click);
            // 
            // ltbUtilizadores
            // 
            this.ltbUtilizadores.ContextMenuStrip = this.ctmUtilizadores;
            this.ltbUtilizadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbUtilizadores.FormattingEnabled = true;
            this.ltbUtilizadores.ItemHeight = 20;
            this.ltbUtilizadores.Location = new System.Drawing.Point(536, 9);
            this.ltbUtilizadores.Name = "ltbUtilizadores";
            this.ltbUtilizadores.Size = new System.Drawing.Size(137, 344);
            this.ltbUtilizadores.TabIndex = 2;
            this.ltbUtilizadores.SelectedIndexChanged += new System.EventHandler(this.ltbUtilizadores_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 360);
            this.Controls.Add(this.ltbUtilizadores);
            this.Controls.Add(this.txtLog);
            this.Name = "frmPrincipal";
            this.Text = "WinChat - Servidor";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ctmUtilizadores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ContextMenuStrip ctmUtilizadores;
        private System.Windows.Forms.ListBox ltbUtilizadores;
        private System.Windows.Forms.ToolStripMenuItem kickUserToolStripMenuItem;
    }
}

