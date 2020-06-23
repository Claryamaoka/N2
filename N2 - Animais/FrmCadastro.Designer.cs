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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpMamifero = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorPelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrQtdMamas = new System.Windows.Forms.NumericUpDown();
            this.grpAve = new System.Windows.Forms.GroupBox();
            this.nmrVelocidadeMAx = new System.Windows.Forms.NumericUpDown();
            this.nmrAlturaMax = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorPena = new System.Windows.Forms.TextBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpMamifero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtdMamas)).BeginInit();
            this.grpAve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVelocidadeMAx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAlturaMax)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoAnimal
            // 
            this.cmbTipoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoAnimal.FormattingEnabled = true;
            this.cmbTipoAnimal.Items.AddRange(new object[] {
            "Baleia",
            "Cachorro",
            "Elefante",
            "Morcego",
            "Gato",
            "Leao",
            "Ornitorrinco",
            "Pato",
            "Pombo",
            "Coruja",
            "Gaviao",
            "Galinha",
            "Pinguim",
            "Tartaruga"});
            this.cmbTipoAnimal.Location = new System.Drawing.Point(73, 123);
            this.cmbTipoAnimal.Name = "cmbTipoAnimal";
            this.cmbTipoAnimal.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoAnimal.TabIndex = 23;
            this.cmbTipoAnimal.Visible = false;
            this.cmbTipoAnimal.SelectedIndexChanged += new System.EventHandler(this.cmbTipoAnimal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data de Nascimento:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(155, 72);
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 20);
            this.txtNome.TabIndex = 17;
            // 
            // grpMamifero
            // 
            this.grpMamifero.Controls.Add(this.label5);
            this.grpMamifero.Controls.Add(this.txtCorPelo);
            this.grpMamifero.Controls.Add(this.label1);
            this.grpMamifero.Controls.Add(this.nmrQtdMamas);
            this.grpMamifero.Enabled = false;
            this.grpMamifero.Location = new System.Drawing.Point(22, 253);
            this.grpMamifero.Name = "grpMamifero";
            this.grpMamifero.Size = new System.Drawing.Size(267, 83);
            this.grpMamifero.TabIndex = 24;
            this.grpMamifero.TabStop = false;
            this.grpMamifero.Text = "Mamífero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cor do Pelo:";
            // 
            // txtCorPelo
            // 
            this.txtCorPelo.Location = new System.Drawing.Point(129, 45);
            this.txtCorPelo.Name = "txtCorPelo";
            this.txtCorPelo.Size = new System.Drawing.Size(120, 20);
            this.txtCorPelo.TabIndex = 23;
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
            // nmrQtdMamas
            // 
            this.nmrQtdMamas.Location = new System.Drawing.Point(129, 19);
            this.nmrQtdMamas.Name = "nmrQtdMamas";
            this.nmrQtdMamas.Size = new System.Drawing.Size(120, 20);
            this.nmrQtdMamas.TabIndex = 0;
            // 
            // grpAve
            // 
            this.grpAve.Controls.Add(this.nmrVelocidadeMAx);
            this.grpAve.Controls.Add(this.nmrAlturaMax);
            this.grpAve.Controls.Add(this.label13);
            this.grpAve.Controls.Add(this.label12);
            this.grpAve.Controls.Add(this.label10);
            this.grpAve.Controls.Add(this.txtCorPena);
            this.grpAve.Enabled = false;
            this.grpAve.Location = new System.Drawing.Point(22, 342);
            this.grpAve.Name = "grpAve";
            this.grpAve.Size = new System.Drawing.Size(267, 116);
            this.grpAve.TabIndex = 26;
            this.grpAve.TabStop = false;
            this.grpAve.Text = "Ave";
            // 
            // nmrVelocidadeMAx
            // 
            this.nmrVelocidadeMAx.Location = new System.Drawing.Point(129, 73);
            this.nmrVelocidadeMAx.Name = "nmrVelocidadeMAx";
            this.nmrVelocidadeMAx.Size = new System.Drawing.Size(120, 20);
            this.nmrVelocidadeMAx.TabIndex = 36;
            // 
            // nmrAlturaMax
            // 
            this.nmrAlturaMax.Location = new System.Drawing.Point(129, 46);
            this.nmrAlturaMax.Name = "nmrAlturaMax";
            this.nmrAlturaMax.Size = new System.Drawing.Size(120, 20);
            this.nmrAlturaMax.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Velocidade do Voo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Altura Máxima (m):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cor da Pena:";
            // 
            // txtCorPena
            // 
            this.txtCorPena.Location = new System.Drawing.Point(130, 20);
            this.txtCorPena.Name = "txtCorPena";
            this.txtCorPena.Size = new System.Drawing.Size(120, 20);
            this.txtCorPena.TabIndex = 26;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.cmbSexo);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.txtNome);
            this.grpInfo.Controls.Add(this.txtDataNascimento);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.cmbTipoAnimal);
            this.grpInfo.Location = new System.Drawing.Point(22, 67);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(267, 174);
            this.grpInfo.TabIndex = 27;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informações Básicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(84, 45);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(142, 21);
            this.cmbSexo.TabIndex = 24;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(92, 559);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 29);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "...";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpAve);
            this.Controls.Add(this.grpMamifero);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.grpMamifero.ResumeLayout(false);
            this.grpMamifero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtdMamas)).EndInit();
            this.grpAve.ResumeLayout(false);
            this.grpAve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVelocidadeMAx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAlturaMax)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTipoAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grpMamifero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrQtdMamas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorPelo;
        private System.Windows.Forms.GroupBox grpAve;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorPena;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.NumericUpDown nmrVelocidadeMAx;
        private System.Windows.Forms.NumericUpDown nmrAlturaMax;
    }
}