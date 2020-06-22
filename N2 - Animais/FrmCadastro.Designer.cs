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
            this.nmrQtdMamas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbPelosSim = new System.Windows.Forms.RadioButton();
            this.rdbPelosNao = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorPelo = new System.Windows.Forms.TextBox();
            this.grpReptil = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbEscamaNao = new System.Windows.Forms.RadioButton();
            this.rdbEscamaSim = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbCascoNao = new System.Windows.Forms.RadioButton();
            this.rdbCascoSim = new System.Windows.Forms.RadioButton();
            this.grpAve = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbRapinaNao = new System.Windows.Forms.RadioButton();
            this.rdbRapinaSim = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorPena = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdbCarnivoroSim = new System.Windows.Forms.RadioButton();
            this.rdbCarnivoroNao = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdbPeconhencoSim = new System.Windows.Forms.RadioButton();
            this.rdbPeconhencoNao = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grpMamifero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtdMamas)).BeginInit();
            this.grpReptil.SuspendLayout();
            this.grpAve.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.cmbTipoAnimal.Location = new System.Drawing.Point(89, 123);
            this.cmbTipoAnimal.Name = "cmbTipoAnimal";
            this.cmbTipoAnimal.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoAnimal.TabIndex = 23;
            this.cmbTipoAnimal.SelectedIndexChanged += new System.EventHandler(this.cmbTipoAnimal_SelectedIndexChanged);
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(134, 87);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(70, 17);
            this.rdbFem.TabIndex = 22;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Feminino ";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(43, 87);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(76, 17);
            this.rdbMasc.TabIndex = 21;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino ";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data de Nascimento:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(155, 46);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(71, 20);
            this.txtDataNascimento.TabIndex = 19;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 17;
            // 
            // grpMamifero
            // 
            this.grpMamifero.Controls.Add(this.label5);
            this.grpMamifero.Controls.Add(this.txtCorPelo);
            this.grpMamifero.Controls.Add(this.label2);
            this.grpMamifero.Controls.Add(this.rdbPelosNao);
            this.grpMamifero.Controls.Add(this.rdbPelosSim);
            this.grpMamifero.Controls.Add(this.label1);
            this.grpMamifero.Controls.Add(this.nmrQtdMamas);
            this.grpMamifero.Enabled = false;
            this.grpMamifero.Location = new System.Drawing.Point(15, 307);
            this.grpMamifero.Name = "grpMamifero";
            this.grpMamifero.Size = new System.Drawing.Size(267, 100);
            this.grpMamifero.TabIndex = 24;
            this.grpMamifero.TabStop = false;
            this.grpMamifero.Text = "Mamífero";
            // 
            // nmrQtdMamas
            // 
            this.nmrQtdMamas.Location = new System.Drawing.Point(129, 19);
            this.nmrQtdMamas.Name = "nmrQtdMamas";
            this.nmrQtdMamas.Size = new System.Drawing.Size(120, 20);
            this.nmrQtdMamas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quantidade de Mamas:";
            // 
            // rdbPelosSim
            // 
            this.rdbPelosSim.AutoSize = true;
            this.rdbPelosSim.Location = new System.Drawing.Point(129, 46);
            this.rdbPelosSim.Name = "rdbPelosSim";
            this.rdbPelosSim.Size = new System.Drawing.Size(42, 17);
            this.rdbPelosSim.TabIndex = 20;
            this.rdbPelosSim.TabStop = true;
            this.rdbPelosSim.Text = "Sim";
            this.rdbPelosSim.UseVisualStyleBackColor = true;
            // 
            // rdbPelosNao
            // 
            this.rdbPelosNao.AutoSize = true;
            this.rdbPelosNao.Location = new System.Drawing.Point(204, 46);
            this.rdbPelosNao.Name = "rdbPelosNao";
            this.rdbPelosNao.Size = new System.Drawing.Size(45, 17);
            this.rdbPelosNao.TabIndex = 21;
            this.rdbPelosNao.TabStop = true;
            this.rdbPelosNao.Text = "Não";
            this.rdbPelosNao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Possui Pelos?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cor do Pelo:";
            // 
            // txtCorPelo
            // 
            this.txtCorPelo.Location = new System.Drawing.Point(129, 65);
            this.txtCorPelo.Name = "txtCorPelo";
            this.txtCorPelo.Size = new System.Drawing.Size(120, 20);
            this.txtCorPelo.TabIndex = 23;
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
            this.grpReptil.Location = new System.Drawing.Point(15, 532);
            this.grpReptil.Name = "grpReptil";
            this.grpReptil.Size = new System.Drawing.Size(267, 99);
            this.grpReptil.TabIndex = 25;
            this.grpReptil.TabStop = false;
            this.grpReptil.Text = "Réptil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Possui Escamas?";
            // 
            // rdbEscamaNao
            // 
            this.rdbEscamaNao.AutoSize = true;
            this.rdbEscamaNao.Location = new System.Drawing.Point(204, 19);
            this.rdbEscamaNao.Name = "rdbEscamaNao";
            this.rdbEscamaNao.Size = new System.Drawing.Size(45, 17);
            this.rdbEscamaNao.TabIndex = 21;
            this.rdbEscamaNao.TabStop = true;
            this.rdbEscamaNao.Text = "Não";
            this.rdbEscamaNao.UseVisualStyleBackColor = true;
            // 
            // rdbEscamaSim
            // 
            this.rdbEscamaSim.AutoSize = true;
            this.rdbEscamaSim.Location = new System.Drawing.Point(129, 19);
            this.rdbEscamaSim.Name = "rdbEscamaSim";
            this.rdbEscamaSim.Size = new System.Drawing.Size(42, 17);
            this.rdbEscamaSim.TabIndex = 20;
            this.rdbEscamaSim.TabStop = true;
            this.rdbEscamaSim.Text = "Sim";
            this.rdbEscamaSim.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Possui Casco?";
            // 
            // rdbCascoNao
            // 
            this.rdbCascoNao.AutoSize = true;
            this.rdbCascoNao.Location = new System.Drawing.Point(204, 43);
            this.rdbCascoNao.Name = "rdbCascoNao";
            this.rdbCascoNao.Size = new System.Drawing.Size(45, 17);
            this.rdbCascoNao.TabIndex = 24;
            this.rdbCascoNao.TabStop = true;
            this.rdbCascoNao.Text = "Não";
            this.rdbCascoNao.UseVisualStyleBackColor = true;
            // 
            // rdbCascoSim
            // 
            this.rdbCascoSim.AutoSize = true;
            this.rdbCascoSim.Location = new System.Drawing.Point(129, 43);
            this.rdbCascoSim.Name = "rdbCascoSim";
            this.rdbCascoSim.Size = new System.Drawing.Size(42, 17);
            this.rdbCascoSim.TabIndex = 23;
            this.rdbCascoSim.TabStop = true;
            this.rdbCascoSim.Text = "Sim";
            this.rdbCascoSim.UseVisualStyleBackColor = true;
            // 
            // grpAve
            // 
            this.grpAve.Controls.Add(this.label10);
            this.grpAve.Controls.Add(this.txtCorPena);
            this.grpAve.Controls.Add(this.label9);
            this.grpAve.Controls.Add(this.rdbRapinaNao);
            this.grpAve.Controls.Add(this.rdbRapinaSim);
            this.grpAve.Enabled = false;
            this.grpAve.Location = new System.Drawing.Point(15, 420);
            this.grpAve.Name = "grpAve";
            this.grpAve.Size = new System.Drawing.Size(267, 99);
            this.grpAve.TabIndex = 26;
            this.grpAve.TabStop = false;
            this.grpAve.Text = "Ave";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "É de rapina?";
            // 
            // rdbRapinaNao
            // 
            this.rdbRapinaNao.AutoSize = true;
            this.rdbRapinaNao.Location = new System.Drawing.Point(204, 19);
            this.rdbRapinaNao.Name = "rdbRapinaNao";
            this.rdbRapinaNao.Size = new System.Drawing.Size(45, 17);
            this.rdbRapinaNao.TabIndex = 21;
            this.rdbRapinaNao.TabStop = true;
            this.rdbRapinaNao.Text = "Não";
            this.rdbRapinaNao.UseVisualStyleBackColor = true;
            // 
            // rdbRapinaSim
            // 
            this.rdbRapinaSim.AutoSize = true;
            this.rdbRapinaSim.Location = new System.Drawing.Point(129, 19);
            this.rdbRapinaSim.Name = "rdbRapinaSim";
            this.rdbRapinaSim.Size = new System.Drawing.Size(42, 17);
            this.rdbRapinaSim.TabIndex = 20;
            this.rdbRapinaSim.TabStop = true;
            this.rdbRapinaSim.Text = "Sim";
            this.rdbRapinaSim.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cor do Pena:";
            // 
            // txtCorPena
            // 
            this.txtCorPena.Location = new System.Drawing.Point(129, 42);
            this.txtCorPena.Name = "txtCorPena";
            this.txtCorPena.Size = new System.Drawing.Size(120, 20);
            this.txtCorPena.TabIndex = 26;
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
            this.groupBox4.Location = new System.Drawing.Point(15, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 282);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações Básicas";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdbCarnivoroSim);
            this.groupBox5.Controls.Add(this.rdbCarnivoroNao);
            this.groupBox5.Location = new System.Drawing.Point(22, 150);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 47);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Carnívoro";
            // 
            // rdbCarnivoroSim
            // 
            this.rdbCarnivoroSim.AutoSize = true;
            this.rdbCarnivoroSim.Location = new System.Drawing.Point(37, 19);
            this.rdbCarnivoroSim.Name = "rdbCarnivoroSim";
            this.rdbCarnivoroSim.Size = new System.Drawing.Size(42, 17);
            this.rdbCarnivoroSim.TabIndex = 23;
            this.rdbCarnivoroSim.TabStop = true;
            this.rdbCarnivoroSim.Text = "Sim";
            this.rdbCarnivoroSim.UseVisualStyleBackColor = true;
            // 
            // rdbCarnivoroNao
            // 
            this.rdbCarnivoroNao.AutoSize = true;
            this.rdbCarnivoroNao.Location = new System.Drawing.Point(128, 19);
            this.rdbCarnivoroNao.Name = "rdbCarnivoroNao";
            this.rdbCarnivoroNao.Size = new System.Drawing.Size(45, 17);
            this.rdbCarnivoroNao.TabIndex = 24;
            this.rdbCarnivoroNao.TabStop = true;
            this.rdbCarnivoroNao.Text = "Não";
            this.rdbCarnivoroNao.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdbPeconhencoSim);
            this.groupBox6.Controls.Add(this.rdbPeconhencoNao);
            this.groupBox6.Location = new System.Drawing.Point(22, 218);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(222, 47);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Peçonhento";
            // 
            // rdbPeconhencoSim
            // 
            this.rdbPeconhencoSim.AutoSize = true;
            this.rdbPeconhencoSim.Location = new System.Drawing.Point(37, 19);
            this.rdbPeconhencoSim.Name = "rdbPeconhencoSim";
            this.rdbPeconhencoSim.Size = new System.Drawing.Size(42, 17);
            this.rdbPeconhencoSim.TabIndex = 23;
            this.rdbPeconhencoSim.TabStop = true;
            this.rdbPeconhencoSim.Text = "Sim";
            this.rdbPeconhencoSim.UseVisualStyleBackColor = true;
            // 
            // rdbPeconhencoNao
            // 
            this.rdbPeconhencoNao.AutoSize = true;
            this.rdbPeconhencoNao.Location = new System.Drawing.Point(128, 19);
            this.rdbPeconhencoNao.Name = "rdbPeconhencoNao";
            this.rdbPeconhencoNao.Size = new System.Drawing.Size(45, 17);
            this.rdbPeconhencoNao.TabIndex = 24;
            this.rdbPeconhencoNao.TabStop = true;
            this.rdbPeconhencoNao.Text = "Não";
            this.rdbPeconhencoNao.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(97, 637);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 29);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 678);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpAve);
            this.Controls.Add(this.grpReptil);
            this.Controls.Add(this.grpMamifero);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.grpMamifero.ResumeLayout(false);
            this.grpMamifero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtdMamas)).EndInit();
            this.grpReptil.ResumeLayout(false);
            this.grpReptil.PerformLayout();
            this.grpAve.ResumeLayout(false);
            this.grpAve.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

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
    }
}