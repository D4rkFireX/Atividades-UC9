namespace AppToDo
{
    partial class frm_Principal
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
            this.components = new System.ComponentModel.Container();
            this.mnstrip_Principal = new System.Windows.Forms.MenuStrip();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.famíliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbox_Principal = new System.Windows.Forms.PictureBox();
            this.sstrip_Principal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tim_Principal = new System.Windows.Forms.Timer(this.components);
            this.mnstrip_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Principal)).BeginInit();
            this.sstrip_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnstrip_Principal
            // 
            this.mnstrip_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnstrip_Principal.Location = new System.Drawing.Point(0, 0);
            this.mnstrip_Principal.Name = "mnstrip_Principal";
            this.mnstrip_Principal.Size = new System.Drawing.Size(800, 24);
            this.mnstrip_Principal.TabIndex = 0;
            this.mnstrip_Principal.Text = "menuStrip1";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarefaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.famíliaToolStripMenuItem});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // tarefaToolStripMenuItem
            // 
            this.tarefaToolStripMenuItem.Name = "tarefaToolStripMenuItem";
            this.tarefaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.tarefaToolStripMenuItem.Text = "Tarefa";
            this.tarefaToolStripMenuItem.Click += new System.EventHandler(this.tarefaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // famíliaToolStripMenuItem
            // 
            this.famíliaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insumoToolStripMenuItem});
            this.famíliaToolStripMenuItem.Name = "famíliaToolStripMenuItem";
            this.famíliaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.famíliaToolStripMenuItem.Text = "Família";
            this.famíliaToolStripMenuItem.Click += new System.EventHandler(this.famíliaToolStripMenuItem_Click);
            // 
            // insumoToolStripMenuItem
            // 
            this.insumoToolStripMenuItem.Name = "insumoToolStripMenuItem";
            this.insumoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.insumoToolStripMenuItem.Text = "Insumo";
            this.insumoToolStripMenuItem.Click += new System.EventHandler(this.insumoToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pbox_Principal
            // 
            this.pbox_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_Principal.Image = global::AppToDo.Properties.Resources.img_Principal;
            this.pbox_Principal.Location = new System.Drawing.Point(0, 24);
            this.pbox_Principal.Name = "pbox_Principal";
            this.pbox_Principal.Size = new System.Drawing.Size(800, 426);
            this.pbox_Principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Principal.TabIndex = 1;
            this.pbox_Principal.TabStop = false;
            // 
            // sstrip_Principal
            // 
            this.sstrip_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslb_Data,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tsslb_Hora,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel5,
            this.tsslb_Usuario});
            this.sstrip_Principal.Location = new System.Drawing.Point(0, 426);
            this.sstrip_Principal.Name = "sstrip_Principal";
            this.sstrip_Principal.Size = new System.Drawing.Size(800, 24);
            this.sstrip_Principal.TabIndex = 2;
            this.sstrip_Principal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 19);
            this.toolStripStatusLabel1.Text = "Data: ";
            // 
            // tsslb_Data
            // 
            this.tsslb_Data.AutoSize = false;
            this.tsslb_Data.Name = "tsslb_Data";
            this.tsslb_Data.Size = new System.Drawing.Size(70, 19);
            this.tsslb_Data.Text = "--/--/----";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 19);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 19);
            this.toolStripStatusLabel3.Text = "Hora: ";
            // 
            // tsslb_Hora
            // 
            this.tsslb_Hora.AutoSize = false;
            this.tsslb_Hora.Name = "tsslb_Hora";
            this.tsslb_Hora.Size = new System.Drawing.Size(70, 19);
            this.tsslb_Hora.Text = "--:--:--";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(70, 19);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(53, 19);
            this.toolStripStatusLabel5.Text = "Usuário: ";
            // 
            // tsslb_Usuario
            // 
            this.tsslb_Usuario.Name = "tsslb_Usuario";
            this.tsslb_Usuario.Size = new System.Drawing.Size(63, 19);
            this.tsslb_Usuario.Text = "onononon";
            // 
            // tim_Principal
            // 
            this.tim_Principal.Enabled = true;
            this.tim_Principal.Tick += new System.EventHandler(this.tim_Principal_Tick);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sstrip_Principal);
            this.Controls.Add(this.pbox_Principal);
            this.Controls.Add(this.mnstrip_Principal);
            this.MainMenuStrip = this.mnstrip_Principal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frm_Principal_Shown);
            this.mnstrip_Principal.ResumeLayout(false);
            this.mnstrip_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Principal)).EndInit();
            this.sstrip_Principal.ResumeLayout(false);
            this.sstrip_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnstrip_Principal;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem famíliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbox_Principal;
        private System.Windows.Forms.StatusStrip sstrip_Principal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Data;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Usuario;
        private System.Windows.Forms.Timer tim_Principal;
    }
}

