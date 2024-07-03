namespace AppToDo
{
    partial class frm_Tarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Tarefa));
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.lv_Itens = new System.Windows.Forms.ListView();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.tbox_Qtde_Item = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_Nm_Insumo = new System.Windows.Forms.Label();
            this.btn_Insumo = new System.Windows.Forms.Button();
            this.tbox_Cod_Insumo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbox_Prior_Tarefa = new System.Windows.Forms.ComboBox();
            this.cbox_Stat_Tarefa = new System.Windows.Forms.ComboBox();
            this.lb_Nm_Categoria = new System.Windows.Forms.Label();
            this.btn_Categoria = new System.Windows.Forms.Button();
            this.tbox_Cod_Categoria = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_Nm_Usuario = new System.Windows.Forms.Label();
            this.btn_Usuario = new System.Windows.Forms.Button();
            this.tbox_Cod_Usuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbox_Term_Tarefa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbox_Desc_Tarefa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_Tit_Tarefa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_Cod_Tarefa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_List = new System.Windows.Forms.Panel();
            this.ltbox_Tarefas = new System.Windows.Forms.ListBox();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Detail.SuspendLayout();
            this.pnl_List.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.BackColor = System.Drawing.Color.Linen;
            this.pnl_Detail.Controls.Add(this.lv_Itens);
            this.pnl_Detail.Controls.Add(this.btn_Up);
            this.pnl_Detail.Controls.Add(this.btn_Down);
            this.pnl_Detail.Controls.Add(this.tbox_Qtde_Item);
            this.pnl_Detail.Controls.Add(this.label16);
            this.pnl_Detail.Controls.Add(this.lb_Nm_Insumo);
            this.pnl_Detail.Controls.Add(this.btn_Insumo);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Insumo);
            this.pnl_Detail.Controls.Add(this.label17);
            this.pnl_Detail.Controls.Add(this.label14);
            this.pnl_Detail.Controls.Add(this.label13);
            this.pnl_Detail.Controls.Add(this.cbox_Prior_Tarefa);
            this.pnl_Detail.Controls.Add(this.cbox_Stat_Tarefa);
            this.pnl_Detail.Controls.Add(this.lb_Nm_Categoria);
            this.pnl_Detail.Controls.Add(this.btn_Categoria);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Categoria);
            this.pnl_Detail.Controls.Add(this.label15);
            this.pnl_Detail.Controls.Add(this.lb_Nm_Usuario);
            this.pnl_Detail.Controls.Add(this.btn_Usuario);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Usuario);
            this.pnl_Detail.Controls.Add(this.label12);
            this.pnl_Detail.Controls.Add(this.tbox_Term_Tarefa);
            this.pnl_Detail.Controls.Add(this.label11);
            this.pnl_Detail.Controls.Add(this.tbox_Desc_Tarefa);
            this.pnl_Detail.Controls.Add(this.label10);
            this.pnl_Detail.Controls.Add(this.tbox_Tit_Tarefa);
            this.pnl_Detail.Controls.Add(this.label9);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Tarefa);
            this.pnl_Detail.Controls.Add(this.label8);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(167, 69);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(496, 492);
            this.pnl_Detail.TabIndex = 7;
            // 
            // lv_Itens
            // 
            this.lv_Itens.BackColor = System.Drawing.SystemColors.Window;
            this.lv_Itens.FullRowSelect = true;
            this.lv_Itens.GridLines = true;
            this.lv_Itens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Itens.HideSelection = false;
            this.lv_Itens.Location = new System.Drawing.Point(19, 313);
            this.lv_Itens.MultiSelect = false;
            this.lv_Itens.Name = "lv_Itens";
            this.lv_Itens.Size = new System.Drawing.Size(460, 162);
            this.lv_Itens.TabIndex = 30;
            this.lv_Itens.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Up
            // 
            this.btn_Up.Image = global::AppToDo.Properties.Resources.img_Up;
            this.btn_Up.Location = new System.Drawing.Point(454, 287);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(25, 22);
            this.btn_Up.TabIndex = 29;
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Image = global::AppToDo.Properties.Resources.img_Down;
            this.btn_Down.Location = new System.Drawing.Point(416, 287);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(25, 22);
            this.btn_Down.TabIndex = 28;
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // tbox_Qtde_Item
            // 
            this.tbox_Qtde_Item.Location = new System.Drawing.Point(344, 288);
            this.tbox_Qtde_Item.Name = "tbox_Qtde_Item";
            this.tbox_Qtde_Item.Size = new System.Drawing.Size(62, 20);
            this.tbox_Qtde_Item.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(341, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Quantidade";
            // 
            // lb_Nm_Insumo
            // 
            this.lb_Nm_Insumo.BackColor = System.Drawing.Color.PeachPuff;
            this.lb_Nm_Insumo.Location = new System.Drawing.Point(108, 293);
            this.lb_Nm_Insumo.Name = "lb_Nm_Insumo";
            this.lb_Nm_Insumo.Size = new System.Drawing.Size(223, 12);
            this.lb_Nm_Insumo.TabIndex = 25;
            this.lb_Nm_Insumo.Tag = "1";
            // 
            // btn_Insumo
            // 
            this.btn_Insumo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Insumo.Image")));
            this.btn_Insumo.Location = new System.Drawing.Point(82, 287);
            this.btn_Insumo.Name = "btn_Insumo";
            this.btn_Insumo.Size = new System.Drawing.Size(23, 22);
            this.btn_Insumo.TabIndex = 24;
            this.btn_Insumo.UseVisualStyleBackColor = true;
            this.btn_Insumo.Click += new System.EventHandler(this.btn_Insumo_Click);
            // 
            // tbox_Cod_Insumo
            // 
            this.tbox_Cod_Insumo.Location = new System.Drawing.Point(19, 288);
            this.tbox_Cod_Insumo.Name = "tbox_Cod_Insumo";
            this.tbox_Cod_Insumo.Size = new System.Drawing.Size(62, 20);
            this.tbox_Cod_Insumo.TabIndex = 23;
            this.tbox_Cod_Insumo.Leave += new System.EventHandler(this.tbox_Cod_Insumo_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Insumo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Prioridade da Tarefa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Status da Tarefa";
            // 
            // cbox_Prior_Tarefa
            // 
            this.cbox_Prior_Tarefa.FormattingEnabled = true;
            this.cbox_Prior_Tarefa.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.cbox_Prior_Tarefa.Location = new System.Drawing.Point(314, 214);
            this.cbox_Prior_Tarefa.Name = "cbox_Prior_Tarefa";
            this.cbox_Prior_Tarefa.Size = new System.Drawing.Size(165, 21);
            this.cbox_Prior_Tarefa.TabIndex = 19;
            // 
            // cbox_Stat_Tarefa
            // 
            this.cbox_Stat_Tarefa.FormattingEnabled = true;
            this.cbox_Stat_Tarefa.Items.AddRange(new object[] {
            "Parada",
            "Em Andamento",
            "Finalizada"});
            this.cbox_Stat_Tarefa.Location = new System.Drawing.Point(314, 174);
            this.cbox_Stat_Tarefa.Name = "cbox_Stat_Tarefa";
            this.cbox_Stat_Tarefa.Size = new System.Drawing.Size(165, 21);
            this.cbox_Stat_Tarefa.TabIndex = 18;
            // 
            // lb_Nm_Categoria
            // 
            this.lb_Nm_Categoria.BackColor = System.Drawing.Color.PeachPuff;
            this.lb_Nm_Categoria.Location = new System.Drawing.Point(344, 82);
            this.lb_Nm_Categoria.Name = "lb_Nm_Categoria";
            this.lb_Nm_Categoria.Size = new System.Drawing.Size(135, 12);
            this.lb_Nm_Categoria.TabIndex = 17;
            this.lb_Nm_Categoria.Tag = "1";
            // 
            // btn_Categoria
            // 
            this.btn_Categoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_Categoria.Image")));
            this.btn_Categoria.Location = new System.Drawing.Point(319, 77);
            this.btn_Categoria.Name = "btn_Categoria";
            this.btn_Categoria.Size = new System.Drawing.Size(23, 22);
            this.btn_Categoria.TabIndex = 16;
            this.btn_Categoria.UseVisualStyleBackColor = true;
            this.btn_Categoria.Click += new System.EventHandler(this.btn_Categoria_Click);
            // 
            // tbox_Cod_Categoria
            // 
            this.tbox_Cod_Categoria.Location = new System.Drawing.Point(256, 78);
            this.tbox_Cod_Categoria.Name = "tbox_Cod_Categoria";
            this.tbox_Cod_Categoria.Size = new System.Drawing.Size(62, 20);
            this.tbox_Cod_Categoria.TabIndex = 15;
            this.tbox_Cod_Categoria.Leave += new System.EventHandler(this.tbox_Cod_Categoria_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(253, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Categoria";
            // 
            // lb_Nm_Usuario
            // 
            this.lb_Nm_Usuario.BackColor = System.Drawing.Color.PeachPuff;
            this.lb_Nm_Usuario.Location = new System.Drawing.Point(107, 82);
            this.lb_Nm_Usuario.Name = "lb_Nm_Usuario";
            this.lb_Nm_Usuario.Size = new System.Drawing.Size(135, 12);
            this.lb_Nm_Usuario.TabIndex = 13;
            this.lb_Nm_Usuario.Tag = "1";
            // 
            // btn_Usuario
            // 
            this.btn_Usuario.Image = global::AppToDo.Properties.Resources.img_Lupa;
            this.btn_Usuario.Location = new System.Drawing.Point(82, 77);
            this.btn_Usuario.Name = "btn_Usuario";
            this.btn_Usuario.Size = new System.Drawing.Size(23, 22);
            this.btn_Usuario.TabIndex = 12;
            this.btn_Usuario.UseVisualStyleBackColor = true;
            this.btn_Usuario.Click += new System.EventHandler(this.btn_Usuario_Click);
            // 
            // tbox_Cod_Usuario
            // 
            this.tbox_Cod_Usuario.Location = new System.Drawing.Point(19, 78);
            this.tbox_Cod_Usuario.Name = "tbox_Cod_Usuario";
            this.tbox_Cod_Usuario.Size = new System.Drawing.Size(62, 20);
            this.tbox_Cod_Usuario.TabIndex = 11;
            this.tbox_Cod_Usuario.Leave += new System.EventHandler(this.tbox_Cod_Usuario_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Usuário";
            // 
            // tbox_Term_Tarefa
            // 
            this.tbox_Term_Tarefa.Location = new System.Drawing.Point(314, 120);
            this.tbox_Term_Tarefa.Name = "tbox_Term_Tarefa";
            this.tbox_Term_Tarefa.Size = new System.Drawing.Size(92, 20);
            this.tbox_Term_Tarefa.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dt. Término";
            // 
            // tbox_Desc_Tarefa
            // 
            this.tbox_Desc_Tarefa.Location = new System.Drawing.Point(19, 159);
            this.tbox_Desc_Tarefa.Multiline = true;
            this.tbox_Desc_Tarefa.Name = "tbox_Desc_Tarefa";
            this.tbox_Desc_Tarefa.Size = new System.Drawing.Size(283, 75);
            this.tbox_Desc_Tarefa.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Descrição";
            // 
            // tbox_Tit_Tarefa
            // 
            this.tbox_Tit_Tarefa.Location = new System.Drawing.Point(19, 119);
            this.tbox_Tit_Tarefa.Name = "tbox_Tit_Tarefa";
            this.tbox_Tit_Tarefa.Size = new System.Drawing.Size(283, 20);
            this.tbox_Tit_Tarefa.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Título da Tarefa";
            // 
            // tbox_Cod_Tarefa
            // 
            this.tbox_Cod_Tarefa.Enabled = false;
            this.tbox_Cod_Tarefa.Location = new System.Drawing.Point(19, 33);
            this.tbox_Cod_Tarefa.Name = "tbox_Cod_Tarefa";
            this.tbox_Cod_Tarefa.Size = new System.Drawing.Size(62, 20);
            this.tbox_Cod_Tarefa.TabIndex = 1;
            this.tbox_Cod_Tarefa.Tag = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Código";
            // 
            // pnl_List
            // 
            this.pnl_List.Controls.Add(this.ltbox_Tarefas);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 69);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(167, 492);
            this.pnl_List.TabIndex = 6;
            // 
            // ltbox_Tarefas
            // 
            this.ltbox_Tarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbox_Tarefas.FormattingEnabled = true;
            this.ltbox_Tarefas.Location = new System.Drawing.Point(0, 0);
            this.ltbox_Tarefas.Name = "ltbox_Tarefas";
            this.ltbox_Tarefas.Size = new System.Drawing.Size(167, 492);
            this.ltbox_Tarefas.TabIndex = 0;
            this.ltbox_Tarefas.Click += new System.EventHandler(this.ltbox_Tarefas_Click);
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnl_Button.Controls.Add(this.btn_Confirmar);
            this.pnl_Button.Controls.Add(this.btn_Cancelar);
            this.pnl_Button.Controls.Add(this.btn_Excluir);
            this.pnl_Button.Controls.Add(this.btn_Alterar);
            this.pnl_Button.Controls.Add(this.btn_Novo);
            this.pnl_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Button.Location = new System.Drawing.Point(0, 561);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(663, 35);
            this.pnl_Button.TabIndex = 5;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Location = new System.Drawing.Point(571, 6);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 4;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(490, 6);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Location = new System.Drawing.Point(173, 6);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.FlatAppearance.BorderSize = 0;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Location = new System.Drawing.Point(92, 6);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.FlatAppearance.BorderSize = 0;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Location = new System.Drawing.Point(11, 6);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.Bisque;
            this.pnl_Title.Controls.Add(this.label6);
            this.pnl_Title.Controls.Add(this.label7);
            this.pnl_Title.Controls.Add(this.label3);
            this.pnl_Title.Controls.Add(this.label1);
            this.pnl_Title.Controls.Add(this.label4);
            this.pnl_Title.Controls.Add(this.label5);
            this.pnl_Title.Controls.Add(this.label2);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(663, 69);
            this.pnl_Title.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(530, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarefa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Peru;
            this.label7.Location = new System.Drawing.Point(553, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tarefa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(482, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarefa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(512, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarefa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(437, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarefa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(425, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tarefa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(400, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarefa";
            // 
            // frm_Tarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 596);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Tarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnl_Detail.ResumeLayout(false);
            this.pnl_Detail.PerformLayout();
            this.pnl_List.ResumeLayout(false);
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Detail;
        private System.Windows.Forms.TextBox tbox_Term_Tarefa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbox_Desc_Tarefa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_Tit_Tarefa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.ListBox ltbox_Tarefas;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Cod_Tarefa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_Nm_Categoria;
        private System.Windows.Forms.Button btn_Categoria;
        private System.Windows.Forms.TextBox tbox_Cod_Categoria;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_Nm_Usuario;
        private System.Windows.Forms.Button btn_Usuario;
        private System.Windows.Forms.TextBox tbox_Cod_Usuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbox_Prior_Tarefa;
        private System.Windows.Forms.ComboBox cbox_Stat_Tarefa;
        private System.Windows.Forms.TextBox tbox_Qtde_Item;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_Nm_Insumo;
        private System.Windows.Forms.Button btn_Insumo;
        private System.Windows.Forms.TextBox tbox_Cod_Insumo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListView lv_Itens;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Down;
    }
}