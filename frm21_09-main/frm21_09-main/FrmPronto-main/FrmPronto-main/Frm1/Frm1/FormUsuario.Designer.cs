namespace Frm1
{
    partial class FormUsuario
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
            System.Windows.Forms.Label cd_usuarioLabel;
            System.Windows.Forms.Label nm_usuarioLabel;
            System.Windows.Forms.Label sg_nivelLabel;
            System.Windows.Forms.Label nm_loginLabel;
            System.Windows.Forms.Label cd_senhaLabel;
            this.database1DataSet = new Frm1.Database1DataSet();
            this.tbusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbusuarioTableAdapter = new Frm1.Database1DataSetTableAdapters.TbusuarioTableAdapter();
            this.cd_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.nm_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.sg_nivelTextBox = new System.Windows.Forms.TextBox();
            this.nm_loginTextBox = new System.Windows.Forms.TextBox();
            this.cd_senhaTextBox = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPequisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            cd_usuarioLabel = new System.Windows.Forms.Label();
            nm_usuarioLabel = new System.Windows.Forms.Label();
            sg_nivelLabel = new System.Windows.Forms.Label();
            nm_loginLabel = new System.Windows.Forms.Label();
            cd_senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_usuarioLabel
            // 
            cd_usuarioLabel.AutoSize = true;
            cd_usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_usuarioLabel.Location = new System.Drawing.Point(64, 49);
            cd_usuarioLabel.Name = "cd_usuarioLabel";
            cd_usuarioLabel.Size = new System.Drawing.Size(63, 20);
            cd_usuarioLabel.TabIndex = 1;
            cd_usuarioLabel.Text = "Código:";
            cd_usuarioLabel.Click += new System.EventHandler(this.Cd_usuarioLabel_Click);
            // 
            // nm_usuarioLabel
            // 
            nm_usuarioLabel.AutoSize = true;
            nm_usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_usuarioLabel.Location = new System.Drawing.Point(64, 107);
            nm_usuarioLabel.Name = "nm_usuarioLabel";
            nm_usuarioLabel.Size = new System.Drawing.Size(55, 20);
            nm_usuarioLabel.TabIndex = 3;
            nm_usuarioLabel.Text = "Nome:";
            // 
            // sg_nivelLabel
            // 
            sg_nivelLabel.AutoSize = true;
            sg_nivelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_nivelLabel.Location = new System.Drawing.Point(64, 165);
            sg_nivelLabel.Name = "sg_nivelLabel";
            sg_nivelLabel.Size = new System.Drawing.Size(46, 20);
            sg_nivelLabel.TabIndex = 5;
            sg_nivelLabel.Text = "Nível:";
            // 
            // nm_loginLabel
            // 
            nm_loginLabel.AutoSize = true;
            nm_loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_loginLabel.Location = new System.Drawing.Point(64, 223);
            nm_loginLabel.Name = "nm_loginLabel";
            nm_loginLabel.Size = new System.Drawing.Size(52, 20);
            nm_loginLabel.TabIndex = 7;
            nm_loginLabel.Text = "Login:";
            // 
            // cd_senhaLabel
            // 
            cd_senhaLabel.AutoSize = true;
            cd_senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_senhaLabel.Location = new System.Drawing.Point(64, 281);
            cd_senhaLabel.Name = "cd_senhaLabel";
            cd_senhaLabel.Size = new System.Drawing.Size(60, 20);
            cd_senhaLabel.TabIndex = 9;
            cd_senhaLabel.Text = "Senha:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbusuarioBindingSource
            // 
            this.tbusuarioBindingSource.DataMember = "Tbusuario";
            this.tbusuarioBindingSource.DataSource = this.database1DataSet;
            // 
            // tbusuarioTableAdapter
            // 
            this.tbusuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cd_usuarioTextBox
            // 
            this.cd_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbusuarioBindingSource, "cd_usuario", true));
            this.cd_usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_usuarioTextBox.Location = new System.Drawing.Point(133, 49);
            this.cd_usuarioTextBox.MaxLength = 50;
            this.cd_usuarioTextBox.Name = "cd_usuarioTextBox";
            this.cd_usuarioTextBox.Size = new System.Drawing.Size(62, 26);
            this.cd_usuarioTextBox.TabIndex = 2;
            // 
            // nm_usuarioTextBox
            // 
            this.nm_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbusuarioBindingSource, "nm_usuario", true));
            this.nm_usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_usuarioTextBox.Location = new System.Drawing.Point(133, 110);
            this.nm_usuarioTextBox.Name = "nm_usuarioTextBox";
            this.nm_usuarioTextBox.Size = new System.Drawing.Size(253, 26);
            this.nm_usuarioTextBox.TabIndex = 4;
            this.nm_usuarioTextBox.TextChanged += new System.EventHandler(this.Nm_usuarioTextBox_TextChanged);
            this.nm_usuarioTextBox.Leave += new System.EventHandler(this.Nm_usuarioTextBox_Leave);
            // 
            // sg_nivelTextBox
            // 
            this.sg_nivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbusuarioBindingSource, "sg_nivel", true));
            this.sg_nivelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_nivelTextBox.Location = new System.Drawing.Point(133, 165);
            this.sg_nivelTextBox.Name = "sg_nivelTextBox";
            this.sg_nivelTextBox.Size = new System.Drawing.Size(62, 26);
            this.sg_nivelTextBox.TabIndex = 6;
            this.sg_nivelTextBox.TextChanged += new System.EventHandler(this.Sg_nivelTextBox_TextChanged);
            this.sg_nivelTextBox.Leave += new System.EventHandler(this.Sg_nivelTextBox_Leave);
            // 
            // nm_loginTextBox
            // 
            this.nm_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbusuarioBindingSource, "nm_login", true));
            this.nm_loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_loginTextBox.Location = new System.Drawing.Point(133, 223);
            this.nm_loginTextBox.Name = "nm_loginTextBox";
            this.nm_loginTextBox.Size = new System.Drawing.Size(253, 26);
            this.nm_loginTextBox.TabIndex = 8;
            this.nm_loginTextBox.TextChanged += new System.EventHandler(this.Nm_loginTextBox_TextChanged);
            this.nm_loginTextBox.Leave += new System.EventHandler(this.Nm_loginTextBox_Leave);
            // 
            // cd_senhaTextBox
            // 
            this.cd_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbusuarioBindingSource, "cd_senha", true));
            this.cd_senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_senhaTextBox.Location = new System.Drawing.Point(133, 275);
            this.cd_senhaTextBox.Name = "cd_senhaTextBox";
            this.cd_senhaTextBox.Size = new System.Drawing.Size(253, 26);
            this.cd_senhaTextBox.TabIndex = 10;
            this.cd_senhaTextBox.TextChanged += new System.EventHandler(this.Cd_senhaTextBox_TextChanged);
            this.cd_senhaTextBox.Leave += new System.EventHandler(this.Cd_senhaTextBox_Leave);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(409, 52);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 30);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(409, 110);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 30);
            this.btnProximo.TabIndex = 12;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(409, 168);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 30);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(409, 226);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 30);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(409, 284);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 30);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(536, 284);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.Button6_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(536, 226);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnPequisar
            // 
            this.btnPequisar.AutoSize = true;
            this.btnPequisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPequisar.Location = new System.Drawing.Point(536, 168);
            this.btnPequisar.Name = "btnPequisar";
            this.btnPequisar.Size = new System.Drawing.Size(89, 30);
            this.btnPequisar.TabIndex = 18;
            this.btnPequisar.Text = "Pesquisar";
            this.btnPequisar.UseVisualStyleBackColor = true;
            this.btnPequisar.Click += new System.EventHandler(this.BtnPequisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(536, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 30);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Button9_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(536, 52);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 30);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.Button10_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 359);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPequisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cd_usuarioLabel);
            this.Controls.Add(this.cd_usuarioTextBox);
            this.Controls.Add(nm_usuarioLabel);
            this.Controls.Add(this.nm_usuarioTextBox);
            this.Controls.Add(sg_nivelLabel);
            this.Controls.Add(this.sg_nivelTextBox);
            this.Controls.Add(nm_loginLabel);
            this.Controls.Add(this.nm_loginTextBox);
            this.Controls.Add(cd_senhaLabel);
            this.Controls.Add(this.cd_senhaTextBox);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tbusuarioBindingSource;
        private Database1DataSetTableAdapters.TbusuarioTableAdapter tbusuarioTableAdapter;
        private System.Windows.Forms.TextBox cd_usuarioTextBox;
        private System.Windows.Forms.TextBox nm_usuarioTextBox;
        private System.Windows.Forms.TextBox sg_nivelTextBox;
        private System.Windows.Forms.TextBox nm_loginTextBox;
        private System.Windows.Forms.TextBox cd_senhaTextBox;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPequisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}