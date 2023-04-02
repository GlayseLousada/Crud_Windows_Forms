namespace CrudListaDeProduto
{
    partial class TelaDeListaDeProduto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            botaoCadastrar = new Button();
            botaoRemover = new Button();
            botaoAtualizar = new Button();
            botaoSair = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(740, 309);
            dataGridView1.TabIndex = 0;
            // 
            // botaoCadastrar
            // 
            botaoCadastrar.Location = new Point(14, 336);
            botaoCadastrar.Name = "botaoCadastrar";
            botaoCadastrar.Size = new Size(137, 30);
            botaoCadastrar.TabIndex = 1;
            botaoCadastrar.Text = "Cadastrar";
            botaoCadastrar.UseVisualStyleBackColor = true;
            botaoCadastrar.Click += AoClicarNoBotaoCadastrar;
            // 
            // botaoRemover
            // 
            botaoRemover.Location = new Point(615, 336);
            botaoRemover.Name = "botaoRemover";
            botaoRemover.Size = new Size(137, 30);
            botaoRemover.TabIndex = 2;
            botaoRemover.Text = "Remover";
            botaoRemover.UseVisualStyleBackColor = true;
            botaoRemover.Click += AoClicarNoBotaoRemover;
            // 
            // botaoAtualizar
            // 
            botaoAtualizar.Location = new Point(449, 336);
            botaoAtualizar.Name = "botaoAtualizar";
            botaoAtualizar.Size = new Size(137, 30);
            botaoAtualizar.TabIndex = 3;
            botaoAtualizar.Text = "Atualizar";
            botaoAtualizar.UseVisualStyleBackColor = true;
            botaoAtualizar.Click += AoClicarNoBotaoAtualizar;
            // 
            // botaoSair
            // 
            botaoSair.Location = new Point(615, 408);
            botaoSair.Name = "botaoSair";
            botaoSair.Size = new Size(137, 30);
            botaoSair.TabIndex = 4;
            botaoSair.Text = "Sair";
            botaoSair.UseVisualStyleBackColor = true;
            botaoSair.Click += AoClicarNoBotaoSair;
            // 
            // TelaDeListaDeProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 450);
            Controls.Add(botaoSair);
            Controls.Add(botaoAtualizar);
            Controls.Add(botaoRemover);
            Controls.Add(botaoCadastrar);
            Controls.Add(dataGridView1);
            Name = "TelaDeListaDeProduto";
            Text = "Tela de Lista de Produto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button botaoCadastrar;
        private Button botaoRemover;
        private Button botaoAtualizar;
        private Button botaoSair;
    }
}