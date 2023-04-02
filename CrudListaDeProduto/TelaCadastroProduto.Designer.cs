namespace CrudListaDeProduto
{
    partial class TelaDeCadastroDeProduto
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
            labelId = new Label();
            labelNome = new Label();
            labelMarca = new Label();
            labelDataDeVencimento = new Label();
            labelPreço = new Label();
            campoTextoId = new TextBox();
            campoTextoNome = new TextBox();
            campoTextoMarca = new TextBox();
            dataDeVencimento = new DateTimePicker();
            campoDeTextoPreço = new TextBox();
            botaoSalvar = new Button();
            botaoSair = new Button();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(28, 25);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 15);
            labelId.TabIndex = 0;
            labelId.Text = "ID";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(25, 63);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(28, 101);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(40, 15);
            labelMarca.TabIndex = 2;
            labelMarca.Text = "Marca";
            // 
            // labelDataDeVencimento
            // 
            labelDataDeVencimento.AutoSize = true;
            labelDataDeVencimento.Location = new Point(25, 139);
            labelDataDeVencimento.Name = "labelDataDeVencimento";
            labelDataDeVencimento.Size = new Size(113, 15);
            labelDataDeVencimento.TabIndex = 3;
            labelDataDeVencimento.Text = "Data de Vencimento";
            // 
            // labelPreço
            // 
            labelPreço.AutoSize = true;
            labelPreço.Location = new Point(28, 175);
            labelPreço.Name = "labelPreço";
            labelPreço.Size = new Size(37, 15);
            labelPreço.TabIndex = 4;
            labelPreço.Text = "Preço";
            // 
            // campoTextoId
            // 
            campoTextoId.Enabled = false;
            campoTextoId.Location = new Point(141, 22);
            campoTextoId.Name = "campoTextoId";
            campoTextoId.Size = new Size(281, 23);
            campoTextoId.TabIndex = 5;
            // 
            // campoTextoNome
            // 
            campoTextoNome.Location = new Point(141, 60);
            campoTextoNome.Name = "campoTextoNome";
            campoTextoNome.Size = new Size(281, 23);
            campoTextoNome.TabIndex = 6;
            // 
            // campoTextoMarca
            // 
            campoTextoMarca.Location = new Point(141, 93);
            campoTextoMarca.Name = "campoTextoMarca";
            campoTextoMarca.Size = new Size(281, 23);
            campoTextoMarca.TabIndex = 7;
            // 
            // dataDeVencimento
            // 
            dataDeVencimento.Location = new Point(141, 131);
            dataDeVencimento.Name = "dataDeVencimento";
            dataDeVencimento.Size = new Size(281, 23);
            dataDeVencimento.TabIndex = 8;
            // 
            // campoDeTextoPreço
            // 
            campoDeTextoPreço.Location = new Point(141, 175);
            campoDeTextoPreço.Name = "campoDeTextoPreço";
            campoDeTextoPreço.Size = new Size(281, 23);
            campoDeTextoPreço.TabIndex = 9;
            campoDeTextoPreço.KeyPress += AoInformarPreco_KeyPess;
            // 
            // botaoSalvar
            // 
            botaoSalvar.Location = new Point(156, 221);
            botaoSalvar.Name = "botaoSalvar";
            botaoSalvar.Size = new Size(111, 28);
            botaoSalvar.TabIndex = 10;
            botaoSalvar.Text = "Salvar";
            botaoSalvar.UseVisualStyleBackColor = true;
            botaoSalvar.Click += AoClicarNoBotaoSalvar;
            // 
            // botaoSair
            // 
            botaoSair.Location = new Point(311, 221);
            botaoSair.Name = "botaoSair";
            botaoSair.Size = new Size(111, 28);
            botaoSair.TabIndex = 12;
            botaoSair.Text = "Sair";
            botaoSair.UseVisualStyleBackColor = true;
            botaoSair.Click += AoClicarNoBotaoSair;
            // 
            // TelaDeCadastroDeProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 273);
            Controls.Add(botaoSair);
            Controls.Add(botaoSalvar);
            Controls.Add(campoDeTextoPreço);
            Controls.Add(dataDeVencimento);
            Controls.Add(campoTextoMarca);
            Controls.Add(campoTextoNome);
            Controls.Add(campoTextoId);
            Controls.Add(labelPreço);
            Controls.Add(labelDataDeVencimento);
            Controls.Add(labelMarca);
            Controls.Add(labelNome);
            Controls.Add(labelId);
            Name = "TelaDeCadastroDeProduto";
            Text = "Tela de Cadastro de Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private Label labelNome;
        private Label labelMarca;
        private Label labelDataDeVencimento;
        private Label labelPreço;
        private TextBox campoTextoId;
        private TextBox campoTextoNome;
        private TextBox campoTextoMarca;
        private DateTimePicker dataDeVencimento;
        private TextBox campoDeTextoPreço;
        private Button botaoSalvar;
        private Button botaoSair;
    }
}