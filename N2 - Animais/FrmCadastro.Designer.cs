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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadAll = new System.Windows.Forms.Button();
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
            this.cmbTipoAnimal.Location = new System.Drawing.Point(12, 628);
            this.cmbTipoAnimal.Name = "cmbTipoAnimal";
            this.cmbTipoAnimal.Size = new System.Drawing.Size(71, 21);
            this.cmbTipoAnimal.TabIndex = 23;
            this.cmbTipoAnimal.Visible = false;
            this.cmbTipoAnimal.SelectedIndexChanged += new System.EventHandler(this.cmbTipoAnimal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data de Nascimento:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(160)))), ((int)(((byte)(81)))));
            this.txtDataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataNascimento.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.ForeColor = System.Drawing.Color.White;
            this.txtDataNascimento.Location = new System.Drawing.Point(163, 124);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(65, 19);
            this.txtDataNascimento.TabIndex = 19;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(160)))), ((int)(((byte)(81)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(84, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 22);
            this.txtNome.TabIndex = 17;
            // 
            // grpMamifero
            // 
            this.grpMamifero.BackColor = System.Drawing.Color.Transparent;
            this.grpMamifero.Controls.Add(this.label5);
            this.grpMamifero.Controls.Add(this.txtCorPelo);
            this.grpMamifero.Controls.Add(this.label1);
            this.grpMamifero.Controls.Add(this.nmrQtdMamas);
            this.grpMamifero.Enabled = false;
            this.grpMamifero.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grpMamifero.Location = new System.Drawing.Point(131, 249);
            this.grpMamifero.Name = "grpMamifero";
            this.grpMamifero.Size = new System.Drawing.Size(243, 152);
            this.grpMamifero.TabIndex = 24;
            this.grpMamifero.TabStop = false;
            this.grpMamifero.Text = "Mamífero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cor do Pelo:";
            // 
            // txtCorPelo
            // 
            this.txtCorPelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(160)))), ((int)(((byte)(81)))));
            this.txtCorPelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorPelo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorPelo.ForeColor = System.Drawing.Color.White;
            this.txtCorPelo.Location = new System.Drawing.Point(113, 121);
            this.txtCorPelo.Name = "txtCorPelo";
            this.txtCorPelo.Size = new System.Drawing.Size(107, 22);
            this.txtCorPelo.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Qtde de Mamas:";
            // 
            // nmrQtdMamas
            // 
            this.nmrQtdMamas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(160)))), ((int)(((byte)(81)))));
            this.nmrQtdMamas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrQtdMamas.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrQtdMamas.ForeColor = System.Drawing.Color.White;
            this.nmrQtdMamas.Location = new System.Drawing.Point(132, 77);
            this.nmrQtdMamas.Name = "nmrQtdMamas";
            this.nmrQtdMamas.Size = new System.Drawing.Size(88, 25);
            this.nmrQtdMamas.TabIndex = 0;
            // 
            // grpAve
            // 
            this.grpAve.BackColor = System.Drawing.Color.Transparent;
            this.grpAve.Controls.Add(this.nmrVelocidadeMAx);
            this.grpAve.Controls.Add(this.nmrAlturaMax);
            this.grpAve.Controls.Add(this.label13);
            this.grpAve.Controls.Add(this.label12);
            this.grpAve.Controls.Add(this.label10);
            this.grpAve.Controls.Add(this.txtCorPena);
            this.grpAve.Enabled = false;
            this.grpAve.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAve.Location = new System.Drawing.Point(131, 421);
            this.grpAve.Name = "grpAve";
            this.grpAve.Size = new System.Drawing.Size(243, 151);
            this.grpAve.TabIndex = 26;
            this.grpAve.TabStop = false;
            this.grpAve.Text = "Ave";
            // 
            // nmrVelocidadeMAx
            // 
            this.nmrVelocidadeMAx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(160)))), ((int)(((byte)(81)))));
            this.nmrVelocidadeMAx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrVelocidadeMAx.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrVelocidadeMAx.ForeColor = System.Drawing.Color.White;
            this.nmrVelocidadeMAx.Location = new System.Drawing.Point(155, 116);
            this.nmrVelocidadeMAx.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.nmrVelocidadeMAx.Name = "nmrVelocidadeMAx";
            this.nmrVelocidadeMAx.Size = new System.Drawing.Size(65, 25);
            this.nmrVelocidadeMAx.TabIndex = 36;
            // 
            // nmrAlturaMax
            // 
            this.nmrAlturaMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(160)))), ((int)(((byte)(81)))));
            this.nmrAlturaMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrAlturaMax.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrAlturaMax.ForeColor = System.Drawing.Color.White;
            this.nmrAlturaMax.Location = new System.Drawing.Point(156, 73);
            this.nmrAlturaMax.Maximum = new decimal(new int[] {
            13000,
            0,
            0,
            0});
            this.nmrAlturaMax.Name = "nmrAlturaMax";
            this.nmrAlturaMax.Size = new System.Drawing.Size(64, 25);
            this.nmrAlturaMax.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(7, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Velocidade do Voo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(11, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Altura Máxima (m):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cor da Pena:";
            // 
            // txtCorPena
            // 
            this.txtCorPena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(160)))), ((int)(((byte)(81)))));
            this.txtCorPena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorPena.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorPena.ForeColor = System.Drawing.Color.White;
            this.txtCorPena.Location = new System.Drawing.Point(113, 31);
            this.txtCorPena.Name = "txtCorPena";
            this.txtCorPena.Size = new System.Drawing.Size(106, 22);
            this.txtCorPena.TabIndex = 26;
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.cmbSexo);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.txtNome);
            this.grpInfo.Controls.Add(this.txtDataNascimento);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grpInfo.Location = new System.Drawing.Point(124, 72);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(250, 154);
            this.grpInfo.TabIndex = 27;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informações Básicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(160)))), ((int)(((byte)(81)))));
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSexo.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.ForeColor = System.Drawing.Color.White;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(84, 78);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(142, 28);
            this.cmbSexo.TabIndex = 24;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(157, 590);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(168, 56);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(151)))), ((int)(((byte)(236)))));
            this.label8.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 30);
            this.label8.TabIndex = 31;
            this.label8.Text = "...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::N2___Animais.Properties.Resources.sair;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(416, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 46);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadAll
            // 
            this.btnCadAll.Location = new System.Drawing.Point(331, 621);
            this.btnCadAll.Name = "btnCadAll";
            this.btnCadAll.Size = new System.Drawing.Size(27, 25);
            this.btnCadAll.TabIndex = 33;
            this.btnCadAll.Text = "...";
            this.btnCadAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadAll.UseVisualStyleBackColor = true;
            this.btnCadAll.Click += new System.EventHandler(this.btnCadAll_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::N2___Animais.Properties.Resources.cadastro2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.btnCadAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpAve);
            this.Controls.Add(this.grpMamifero);
            this.Controls.Add(this.cmbTipoAnimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmCadastro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.NumericUpDown nmrVelocidadeMAx;
        private System.Windows.Forms.NumericUpDown nmrAlturaMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadAll;
    }
}