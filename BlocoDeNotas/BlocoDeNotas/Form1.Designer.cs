namespace BlocoDeNotas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarPáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarPróximaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substituirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irParaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quebraAutomáticaDeLinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirAjudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreOBlocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.configurarPáginaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // configurarPáginaToolStripMenuItem
            // 
            this.configurarPáginaToolStripMenuItem.Enabled = false;
            this.configurarPáginaToolStripMenuItem.Name = "configurarPáginaToolStripMenuItem";
            this.configurarPáginaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configurarPáginaToolStripMenuItem.Text = "Configurar Página";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Enabled = false;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.toolStripSeparator3,
            this.recortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.toolStripSeparator4,
            this.localizarToolStripMenuItem,
            this.localizarPróximaToolStripMenuItem,
            this.substituirToolStripMenuItem,
            this.irParaToolStripMenuItem,
            this.toolStripSeparator5,
            this.selecionarTudoToolStripMenuItem,
            this.horaDataToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.desfazerToolStripMenuItem_Click);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // localizarToolStripMenuItem
            // 
            this.localizarToolStripMenuItem.Enabled = false;
            this.localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
            this.localizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localizarToolStripMenuItem.Text = "Localizar";
            // 
            // localizarPróximaToolStripMenuItem
            // 
            this.localizarPróximaToolStripMenuItem.Enabled = false;
            this.localizarPróximaToolStripMenuItem.Name = "localizarPróximaToolStripMenuItem";
            this.localizarPróximaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localizarPróximaToolStripMenuItem.Text = "Localizar próxima";
            // 
            // substituirToolStripMenuItem
            // 
            this.substituirToolStripMenuItem.Enabled = false;
            this.substituirToolStripMenuItem.Name = "substituirToolStripMenuItem";
            this.substituirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.substituirToolStripMenuItem.Text = "Substituir";
            // 
            // irParaToolStripMenuItem
            // 
            this.irParaToolStripMenuItem.Enabled = false;
            this.irParaToolStripMenuItem.Name = "irParaToolStripMenuItem";
            this.irParaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.irParaToolStripMenuItem.Text = "Ir para";
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar tudo";
            this.selecionarTudoToolStripMenuItem.Click += new System.EventHandler(this.selecionarTudoToolStripMenuItem_Click);
            // 
            // horaDataToolStripMenuItem
            // 
            this.horaDataToolStripMenuItem.Name = "horaDataToolStripMenuItem";
            this.horaDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horaDataToolStripMenuItem.Text = "Hora / data";
            this.horaDataToolStripMenuItem.Click += new System.EventHandler(this.horaDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quebraAutomáticaDeLinhToolStripMenuItem,
            this.fonteToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // quebraAutomáticaDeLinhToolStripMenuItem
            // 
            this.quebraAutomáticaDeLinhToolStripMenuItem.Enabled = false;
            this.quebraAutomáticaDeLinhToolStripMenuItem.Name = "quebraAutomáticaDeLinhToolStripMenuItem";
            this.quebraAutomáticaDeLinhToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.quebraAutomáticaDeLinhToolStripMenuItem.Text = "Quebra automática de linha";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.fonteToolStripMenuItem.Text = "Fonte...";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraDeStatusToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // barraDeStatusToolStripMenuItem
            // 
            this.barraDeStatusToolStripMenuItem.Enabled = false;
            this.barraDeStatusToolStripMenuItem.Name = "barraDeStatusToolStripMenuItem";
            this.barraDeStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barraDeStatusToolStripMenuItem.Text = "Barra de status";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirAjudaToolStripMenuItem,
            this.toolStripSeparator6,
            this.sobreOBlocoDeNotasToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // exibirAjudaToolStripMenuItem
            // 
            this.exibirAjudaToolStripMenuItem.Enabled = false;
            this.exibirAjudaToolStripMenuItem.Name = "exibirAjudaToolStripMenuItem";
            this.exibirAjudaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exibirAjudaToolStripMenuItem.Text = "Exibir Ajuda";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(192, 6);
            // 
            // sobreOBlocoDeNotasToolStripMenuItem
            // 
            this.sobreOBlocoDeNotasToolStripMenuItem.Name = "sobreOBlocoDeNotasToolStripMenuItem";
            this.sobreOBlocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.sobreOBlocoDeNotasToolStripMenuItem.Text = "Sobre o bloco de notas";
            this.sobreOBlocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.sobreOBlocoDeNotasToolStripMenuItem_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTexto.Location = new System.Drawing.Point(0, 24);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(800, 426);
            this.txtTexto.TabIndex = 1;
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bloco de Notas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configurarPáginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarPróximaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substituirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irParaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quebraAutomáticaDeLinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDeStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirAjudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem sobreOBlocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
    }
}

