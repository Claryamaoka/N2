namespace N2___Animais
{
    partial class FrmCadastro
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
            this.cmbTipoAnimal = new System.Windows.Forms.ComboBox();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpMamifero = new System.Windows.Forms.GroupBox();
            this.rdbElefante = new System.Windows.Forms.RadioButton();
            this.rdbLeao = new System.Windows.Forms.RadioButton();
            this.rdbBaleia = new System.Windows.Forms.RadioButton();
            this.rdbOrnitorrinco = new System.Windows.Forms.RadioButton();
            this.rdbCachorro = new System.Windows.Forms.RadioButton();
            this.rdbGato = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorPelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbPelosNao = new System.Windows.Forms.RadioButton();
            this.rdbPelosSim = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrQtdMamas = new System.Windows.Forms.NumericUpDown();
            this.grpReptil = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbCascoNao = new System.Windows.Forms.RadioButton();
            this.rdbCascoSim = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbEscamaNao = new System.Windows.Forms.RadioButton();
            this.rdbEscamaSim = new System.Windows.Forms.RadioButton();
            this.grpAve = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorPena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbRapinaNao = new System.Windows.Forms.RadioButton();
            this.rdbRapinaSim = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdbPeconhencoSim = new System.Windows.Forms.RadioButton();
            this.rdbPeconhencoNao = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdbCarnivoroSim = new System.Windows.Forms.RadioButton();
            this.rdbCarnivoroNao = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpMamifero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtdMamas)).BeginInit();
            this.grpReptil.SuspendLayout();
            this.grpAve.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoAnimal
            // 
            this.cmbTipoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoAnimal.FormattingEnabled = true;
            this.cmbTipoAnimal.Items.AddRange(new object[] {
            "Mamífero",
            "Ave",
            "Réptil"});
            this.cmbTipoAnimal.Location = new System.Drawing.Point(119, 151);
            this.cmbTipoAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoAnimal.Name = "cmbTipoAnimal";
            this.cmbTipoAnimal.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoAnimal.TabIndex = 23;
            this.cmbTipoAnimal.SelectedIndexChanged += new System.EventHandler(this.cmbTipoAnimal_SelectedIndexChanged);
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(179, 107);
            this.rdbFem.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(90, 21);
            this.rdbFem.TabIndex = 22;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Feminino ";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(57, 107);
            this.rdbMasc.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(96, 21);
            this.rdbMasc.TabIndex = 21;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino ";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data de Nascimento:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(207, 57);
            this.txtDataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(93, 22);
            this.txtDataNascimento.TabIndex = 19;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtDataNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDataNascimento_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 17;
            // 
            // grpMamifero
            // 
            this.grpMamifero.Controls.Add(this.rdbElefante);
            this.grpMamifero.Controls.Add(this.rdbLeao);
            this.grpMamifero.Controls.Add(this.rdbBaleia);
            this.grpMamifero.Controls.Add(this.rdbOrnitorrinco);
            this.grpMamifero.Controls.Add(this.rdbCachorro);
            this.grpMamifero.Controls.Add(this.rdbGato);
            this.grpMamifero.Controls.Add(this.label5);
            this.grpMamifero.Controls.Add(this.txtCorPelo);
            this.grpMamifero.Controls.Add(this.label2);
            this.grpMamifero.Controls.Add(this.rdbPelosNao);
            this.grpMamifero.Controls.Add(this.rdbPelosSim);
            this.grpMamifero.Controls.Add(this.label1);
            this.grpMamifero.Controls.Add(this.nmrQtdMamas);
            this.grpMamifero.Enabled = false;
            this.grpMamifero.Location = new System.Drawing.Point(412, 20);
            this.grpMamifero.Margin = new System.Windows.Forms.Padding(4);
            this.grpMamifero.Name = "grpMamifero";
            this.grpMamifero.Padding = new System.Windows.Forms.Padding(4);
            this.grpMamifero.Size = new System.Drawing.Size(364, 329);
            this.grpMamifero.TabIndex = 24;
            this.grpMamifero.TabStop = false;
            this.grpMamifero.Text = "Mamífero";
            // 
            // rdbElefante
            // 
            this.rdbElefante.AutoSize = true;
            this.rdbElefante.Location = new System.Drawing.Point(11, 290);
            this.rdbElefante.Name = "rdbElefante";
            this.rdbElefante.Size = new System.Drawing.Size(81, 21);
            this.rdbElefante.TabIndex = 30;
            this.rdbElefante.TabStop = true;
            this.rdbElefante.Text = "Elefante";
            this.rdbElefante.UseVisualStyleBackColor = true;
            // 
            // rdbLeao
            // 
            this.rdbLeao.AutoSize = true;
            this.rdbLeao.Location = new System.Drawing.Point(11, 256);
            this.rdbLeao.Name = "rdbLeao";
            this.rdbLeao.Size = new System.Drawing.Size(61, 21);
            this.rdbLeao.TabIndex = 29;
            this.rdbLeao.TabStop = true;
            this.rdbLeao.Text = "Leão";
            this.rdbLeao.UseVisualStyleBackColor = true;
            // 
            // rdbBaleia
            // 
            this.rdbBaleia.AutoSize = true;
            this.rdbBaleia.Location = new System.Drawing.Point(11, 222);
            this.rdbBaleia.Name = "rdbBaleia";
            this.rdbBaleia.Size = new System.Drawing.Size(68, 21);
            this.rdbBaleia.TabIndex = 28;
            this.rdbBaleia.TabStop = true;
            this.rdbBaleia.Text = "Baleia";
            this.rdbBaleia.UseVisualStyleBackColor = true;
            // 
            // rdbOrnitorrinco
            // 
            this.rdbOrnitorrinco.AutoSize = true;
            this.rdbOrnitorrinco.Location = new System.Drawing.Point(11, 188);
            this.rdbOrnitorrinco.Name = "rdbOrnitorrinco";
            this.rdbOrnitorrinco.Size = new System.Drawing.Size(104, 21);
            this.rdbOrnitorrinco.TabIndex = 27;
            this.rdbOrnitorrinco.TabStop = true;
            this.rdbOrnitorrinco.Text = "Ornitorrinco";
            this.rdbOrnitorrinco.UseVisualStyleBackColor = true;
            // 
            // rdbCachorro
            // 
            this.rdbCachorro.AutoSize = true;
            this.rdbCachorro.Location = new System.Drawing.Point(11, 154);
            this.rdbCachorro.Name = "rdbCachorro";
            this.rdbCachorro.Size = new System.Drawing.Size(91, 21);
            this.rdbCachorro.TabIndex = 26;
            this.rdbCachorro.TabStop = true;
            this.rdbCachorro.Text = "Cachorro ";
            this.rdbCachorro.UseVisualStyleBackColor = true;
            // 
            // rdbGato
            // 
            this.rdbGato.AutoSize = true;
            this.rdbGato.Location = new System.Drawing.Point(11, 120);
            this.rdbGato.Name = "rdbGato";
            this.rdbGato.Size = new System.Drawing.Size(60, 21);
            this.rdbGato.TabIndex = 25;
            this.rdbGato.TabStop = true;
            this.rdbGato.Text = "Gato";
            this.rdbGato.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cor do Pelo:";
            // 
            // txtCorPelo
            // 
            this.txtCorPelo.Location = new System.Drawing.Point(172, 81);
            this.txtCorPelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorPelo.Name = "txtCorPelo";
            this.txtCorPelo.Size = new System.Drawing.Size(159, 22);
            this.txtCorPelo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Possui Pelos?";
            // 
            // rdbPelosNao
            // 
            this.rdbPelosNao.AutoSize = true;
            this.rdbPelosNao.Location = new System.Drawing.Point(276, 57);
            this.rdbPelosNao.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPelosNao.Name = "rdbPelosNao";
            this.rdbPelosNao.Size = new System.Drawing.Size(55, 21);
            this.rdbPelosNao.TabIndex = 21;
            this.rdbPelosNao.TabStop = true;
            this.rdbPelosNao.Text = "Não";
            this.rdbPelosNao.UseVisualStyleBackColor = true;
            // 
            // rdbPelosSim
            // 
            this.rdbPelosSim.AutoSize = true;
            this.rdbPelosSim.Location = new System.Drawing.Point(172, 57);
            this.rdbPelosSim.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPelosSim.Name = "rdbPelosSim";
            this.rdbPelosSim.Size = new System.Drawing.Size(52, 21);
            this.rdbPelosSim.TabIndex = 20;
            this.rdbPelosSim.TabStop = true;
            this.rdbPelosSim.Text = "Sim";
            this.rdbPelosSim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quantidade de Mamas:";
            // 
            // nmrQtdMamas
            // 
            this.nmrQtdMamas.Location = new System.Drawing.Point(172, 23);
            this.nmrQtdMamas.Margin = new System.Windows.Forms.Padding(4);
            this.nmrQtdMamas.Name = "nmrQtdMamas";
            this.nmrQtdMamas.Size = new System.Drawing.Size(160, 22);
            this.nmrQtdMamas.TabIndex = 0;
            // 
            // grpReptil
            // 
            this.grpReptil.Controls.Add(this.label6);
            this.grpReptil.Controls.Add(this.rdbCascoNao);
            this.grpReptil.Controls.Add(this.rdbCascoSim);
            this.grpReptil.Controls.Add(this.label7);
            this.grpReptil.Controls.Add(this.rdbEscamaNao);
            this.grpReptil.Controls.Add(this.rdbEscamaSim);
            this.grpReptil.Enabled = false;
            this.grpReptil.Location = new System.Drawing.Point(20, 655);
            this.grpReptil.Margin = new System.Windows.Forms.Padding(4);
            this.grpReptil.Name = "grpReptil";
            this.grpReptil.Padding = new System.Windows.Forms.Padding(4);
            this.grpReptil.Size = new System.Drawing.Size(356, 122);
            this.grpReptil.TabIndex = 25;
            this.grpReptil.TabStop = false;
            this.grpReptil.Text = "Réptil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Possui Casco?";
            // 
            // rdbCascoNao
            // 
            this.rdbCascoNao.AutoSize = true;
            this.rdbCascoNao.Location = new System.Drawing.Point(272, 53);
            this.rdbCascoNao.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCascoNao.Name = "rdbCascoNao";
            this.rdbCascoNao.Size = new System.Drawing.Size(55, 21);
            this.rdbCascoNao.TabIndex = 24;
            this.rdbCascoNao.TabStop = true;
            this.rdbCascoNao.Text = "Não";
            this.rdbCascoNao.UseVisualStyleBackColor = true;
            // 
            // rdbCascoSim
            // 
            this.rdbCascoSim.AutoSize = true;
            this.rdbCascoSim.Location = new System.Drawing.Point(172, 53);
            this.rdbCascoSim.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCascoSim.Name = "rdbCascoSim";
            this.rdbCascoSim.Size = new System.Drawing.Size(52, 21);
            this.rdbCascoSim.TabIndex = 23;
            this.rdbCascoSim.TabStop = true;
            this.rdbCascoSim.Text = "Sim";
            this.rdbCascoSim.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Possui Escamas?";
            // 
            // rdbEscamaNao
            // 
            this.rdbEscamaNao.AutoSize = true;
            this.rdbEscamaNao.Location = new System.Drawing.Point(272, 23);
            this.rdbEscamaNao.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEscamaNao.Name = "rdbEscamaNao";
            this.rdbEscamaNao.Size = new System.Drawing.Size(55, 21);
            this.rdbEscamaNao.TabIndex = 21;
            this.rdbEscamaNao.TabStop = true;
            this.rdbEscamaNao.Text = "Não";
            this.rdbEscamaNao.UseVisualStyleBackColor = true;
            // 
            // rdbEscamaSim
            // 
            this.rdbEscamaSim.AutoSize = true;
            this.rdbEscamaSim.Location = new System.Drawing.Point(172, 23);
            this.rdbEscamaSim.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEscamaSim.Name = "rdbEscamaSim";
            this.rdbEscamaSim.Size = new System.Drawing.Size(52, 21);
            this.rdbEscamaSim.TabIndex = 20;
            this.rdbEscamaSim.TabStop = true;
            this.rdbEscamaSim.Text = "Sim";
            this.rdbEscamaSim.UseVisualStyleBackColor = true;
            // 
            // grpAve
            // 
            this.grpAve.Controls.Add(this.label10);
            this.grpAve.Controls.Add(this.txtCorPena);
            this.grpAve.Controls.Add(this.label9);
            this.grpAve.Controls.Add(this.rdbRapinaNao);
            this.grpAve.Controls.Add(this.rdbRapinaSim);
            this.grpAve.Enabled = false;
            this.grpAve.Location = new System.Drawing.Point(20, 517);
            this.grpAve.Margin = new System.Windows.Forms.Padding(4);
            this.grpAve.Name = "grpAve";
            this.grpAve.Padding = new System.Windows.Forms.Padding(4);
            this.grpAve.Size = new System.Drawing.Size(356, 122);
            this.grpAve.TabIndex = 26;
            this.grpAve.TabStop = false;
            this.grpAve.Text = "Ave";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cor do Pena:";
            // 
            // txtCorPena
            // 
            this.txtCorPena.Location = new System.Drawing.Point(172, 52);
            this.txtCorPena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorPena.Name = "txtCorPena";
            this.txtCorPena.Size = new System.Drawing.Size(159, 22);
            this.txtCorPena.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "É de rapina?";
            // 
            // rdbRapinaNao
            // 
            this.rdbRapinaNao.AutoSize = true;
            this.rdbRapinaNao.Location = new System.Drawing.Point(272, 23);
            this.rdbRapinaNao.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRapinaNao.Name = "rdbRapinaNao";
            this.rdbRapinaNao.Size = new System.Drawing.Size(55, 21);
            this.rdbRapinaNao.TabIndex = 21;
            this.rdbRapinaNao.TabStop = true;
            this.rdbRapinaNao.Text = "Não";
            this.rdbRapinaNao.UseVisualStyleBackColor = true;
            // 
            // rdbRapinaSim
            // 
            this.rdbRapinaSim.AutoSize = true;
            this.rdbRapinaSim.Location = new System.Drawing.Point(172, 23);
            this.rdbRapinaSim.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRapinaSim.Name = "rdbRapinaSim";
            this.rdbRapinaSim.Size = new System.Drawing.Size(52, 21);
            this.rdbRapinaSim.TabIndex = 20;
            this.rdbRapinaSim.TabStop = true;
            this.rdbRapinaSim.Text = "Sim";
            this.rdbRapinaSim.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.txtDataNascimento);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cmbTipoAnimal);
            this.groupBox4.Controls.Add(this.rdbMasc);
            this.groupBox4.Controls.Add(this.rdbFem);
            this.groupBox4.Location = new System.Drawing.Point(20, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(356, 347);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações Básicas";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdbPeconhencoSim);
            this.groupBox6.Controls.Add(this.rdbPeconhencoNao);
            this.groupBox6.Location = new System.Drawing.Point(29, 268);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(296, 58);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Peçonhento";
            // 
            // rdbPeconhencoSim
            // 
            this.rdbPeconhencoSim.AutoSize = true;
            this.rdbPeconhencoSim.Location = new System.Drawing.Point(49, 23);
            this.rdbPeconhencoSim.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPeconhencoSim.Name = "rdbPeconhencoSim";
            this.rdbPeconhencoSim.Size = new System.Drawing.Size(52, 21);
            this.rdbPeconhencoSim.TabIndex = 23;
            this.rdbPeconhencoSim.TabStop = true;
            this.rdbPeconhencoSim.Text = "Sim";
            this.rdbPeconhencoSim.UseVisualStyleBackColor = true;
            // 
            // rdbPeconhencoNao
            // 
            this.rdbPeconhencoNao.AutoSize = true;
            this.rdbPeconhencoNao.Location = new System.Drawing.Point(171, 23);
            this.rdbPeconhencoNao.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPeconhencoNao.Name = "rdbPeconhencoNao";
            this.rdbPeconhencoNao.Size = new System.Drawing.Size(55, 21);
            this.rdbPeconhencoNao.TabIndex = 24;
            this.rdbPeconhencoNao.TabStop = true;
            this.rdbPeconhencoNao.Text = "Não";
            this.rdbPeconhencoNao.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdbCarnivoroSim);
            this.groupBox5.Controls.Add(this.rdbCarnivoroNao);
            this.groupBox5.Location = new System.Drawing.Point(29, 185);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(296, 58);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Carnívoro";
            // 
            // rdbCarnivoroSim
            // 
            this.rdbCarnivoroSim.AutoSize = true;
            this.rdbCarnivoroSim.Location = new System.Drawing.Point(49, 23);
            this.rdbCarnivoroSim.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCarnivoroSim.Name = "rdbCarnivoroSim";
            this.rdbCarnivoroSim.Size = new System.Drawing.Size(52, 21);
            this.rdbCarnivoroSim.TabIndex = 23;
            this.rdbCarnivoroSim.TabStop = true;
            this.rdbCarnivoroSim.Text = "Sim";
            this.rdbCarnivoroSim.UseVisualStyleBackColor = true;
            // 
            // rdbCarnivoroNao
            // 
            this.rdbCarnivoroNao.AutoSize = true;
            this.rdbCarnivoroNao.Location = new System.Drawing.Point(171, 23);
            this.rdbCarnivoroNao.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCarnivoroNao.Name = "rdbCarnivoroNao";
            this.rdbCarnivoroNao.Size = new System.Drawing.Size(55, 21);
            this.rdbCarnivoroNao.TabIndex = 24;
            this.rdbCarnivoroNao.TabStop = true;
            this.rdbCarnivoroNao.Text = "Não";
            this.rdbCarnivoroNao.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(129, 784);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(135, 36);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "label8";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 834);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpAve);
            this.Controls.Add(this.grpReptil);
            this.Controls.Add(this.grpMamifero);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.grpMamifero.ResumeLayout(false);
            this.grpMamifero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtdMamas)).EndInit();
            this.grpReptil.ResumeLayout(false);
            this.grpReptil.PerformLayout();
            this.grpAve.ResumeLayout(false);
            this.grpAve.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTipoAnimal;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpMamifero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbPelosNao;
        private System.Windows.Forms.RadioButton rdbPelosSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrQtdMamas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorPelo;
        private System.Windows.Forms.GroupBox grpReptil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbCascoNao;
        private System.Windows.Forms.RadioButton rdbCascoSim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbEscamaNao;
        private System.Windows.Forms.RadioButton rdbEscamaSim;
        private System.Windows.Forms.GroupBox grpAve;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorPena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbRapinaNao;
        private System.Windows.Forms.RadioButton rdbRapinaSim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdbPeconhencoSim;
        private System.Windows.Forms.RadioButton rdbPeconhencoNao;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdbCarnivoroSim;
        private System.Windows.Forms.RadioButton rdbCarnivoroNao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton rdbElefante;
        private System.Windows.Forms.RadioButton rdbLeao;
        private System.Windows.Forms.RadioButton rdbBaleia;
        private System.Windows.Forms.RadioButton rdbOrnitorrinco;
        private System.Windows.Forms.RadioButton rdbCachorro;
        private System.Windows.Forms.RadioButton rdbGato;
        private System.Windows.Forms.Label label8;
    }
}