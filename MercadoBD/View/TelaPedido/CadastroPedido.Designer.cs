namespace MercadoBD.View.TelaPedido
{
    partial class CadastroPedido
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
            label2 = new Label();
            hhhhh = new Label();
            btn_cadastrarFun = new Button();
            tbx_FunPedi = new TextBox();
            tbx_nomePediCli = new TextBox();
            label1 = new Label();
            tbx_dataPedi = new TextBox();
            label4 = new Label();
            tbx_totalPedi = new TextBox();
            Total = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 151);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 13;
            label2.Text = "Funcionário";
            // 
            // hhhhh
            // 
            hhhhh.AutoSize = true;
            hhhhh.Location = new Point(223, 100);
            hhhhh.Name = "hhhhh";
            hhhhh.Size = new Size(40, 15);
            hhhhh.TabIndex = 12;
            hhhhh.Text = "Nome";
            // 
            // btn_cadastrarFun
            // 
            btn_cadastrarFun.Location = new Point(148, 359);
            btn_cadastrarFun.Name = "btn_cadastrarFun";
            btn_cadastrarFun.Size = new Size(190, 64);
            btn_cadastrarFun.TabIndex = 11;
            btn_cadastrarFun.Text = "Cadastrar";
            btn_cadastrarFun.UseVisualStyleBackColor = true;
            btn_cadastrarFun.Click += btn_cadastrarFun_Click;
            // 
            // tbx_FunPedi
            // 
            tbx_FunPedi.Location = new Point(132, 169);
            tbx_FunPedi.Name = "tbx_FunPedi";
            tbx_FunPedi.Size = new Size(224, 23);
            tbx_FunPedi.TabIndex = 10;
            // 
            // tbx_nomePediCli
            // 
            tbx_nomePediCli.Location = new Point(132, 118);
            tbx_nomePediCli.Name = "tbx_nomePediCli";
            tbx_nomePediCli.Size = new Size(224, 23);
            tbx_nomePediCli.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 45);
            label1.Name = "label1";
            label1.Size = new Size(336, 37);
            label1.TabIndex = 8;
            label1.Text = "Cadastro de Pedido";
            // 
            // tbx_dataPedi
            // 
            tbx_dataPedi.Location = new Point(200, 257);
            tbx_dataPedi.Margin = new Padding(2, 2, 2, 2);
            tbx_dataPedi.Name = "tbx_dataPedi";
            tbx_dataPedi.Size = new Size(106, 23);
            tbx_dataPedi.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 240);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 16;
            label4.Text = "Data Compra";
            // 
            // tbx_totalPedi
            // 
            tbx_totalPedi.Location = new Point(200, 316);
            tbx_totalPedi.Margin = new Padding(2, 2, 2, 2);
            tbx_totalPedi.Name = "tbx_totalPedi";
            tbx_totalPedi.Size = new Size(106, 23);
            tbx_totalPedi.TabIndex = 17;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(228, 296);
            Total.Margin = new Padding(2, 0, 2, 0);
            Total.Name = "Total";
            Total.Size = new Size(32, 15);
            Total.TabIndex = 18;
            Total.Text = "Total";
            // 
            // CadastroPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(Total);
            Controls.Add(tbx_totalPedi);
            Controls.Add(label4);
            Controls.Add(tbx_dataPedi);
            Controls.Add(label2);
            Controls.Add(hhhhh);
            Controls.Add(btn_cadastrarFun);
            Controls.Add(tbx_FunPedi);
            Controls.Add(tbx_nomePediCli);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CadastroPedido";
            Text = "CadastroPedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label hhhhh;
        private Button btn_cadastrarFun;
        private TextBox tbx_FunPedi;
        private TextBox tbx_nomePediCli;
        private Label label1;
        private TextBox tbx_dataPedi;
        private Label label4;
        private TextBox tbx_totalPedi;
        private Label Total;
    }
}