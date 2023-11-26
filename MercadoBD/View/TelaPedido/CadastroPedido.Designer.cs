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
            dataPedi = new TextBox();
            label4 = new Label();
            tbx_totalPedi = new TextBox();
            Total = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 251);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 13;
            label2.Text = "Funcionário";
            // 
            // hhhhh
            // 
            hhhhh.AutoSize = true;
            hhhhh.Location = new Point(318, 166);
            hhhhh.Margin = new Padding(4, 0, 4, 0);
            hhhhh.Name = "hhhhh";
            hhhhh.Size = new Size(61, 25);
            hhhhh.TabIndex = 12;
            hhhhh.Text = "Nome";
            // 
            // btn_cadastrarFun
            // 
            btn_cadastrarFun.Location = new Point(212, 598);
            btn_cadastrarFun.Margin = new Padding(4, 5, 4, 5);
            btn_cadastrarFun.Name = "btn_cadastrarFun";
            btn_cadastrarFun.Size = new Size(271, 107);
            btn_cadastrarFun.TabIndex = 11;
            btn_cadastrarFun.Text = "Cadastrar";
            btn_cadastrarFun.UseVisualStyleBackColor = true;
            btn_cadastrarFun.Click += btn_cadastrarFun_Click;
            // 
            // tbx_FunPedi
            // 
            tbx_FunPedi.Location = new Point(189, 281);
            tbx_FunPedi.Margin = new Padding(4, 5, 4, 5);
            tbx_FunPedi.Name = "tbx_FunPedi";
            tbx_FunPedi.Size = new Size(318, 31);
            tbx_FunPedi.TabIndex = 10;
            // 
            // tbx_nomePediCli
            // 
            tbx_nomePediCli.Location = new Point(189, 196);
            tbx_nomePediCli.Margin = new Padding(4, 5, 4, 5);
            tbx_nomePediCli.Name = "tbx_nomePediCli";
            tbx_nomePediCli.Size = new Size(318, 31);
            tbx_nomePediCli.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(480, 45);
            label1.TabIndex = 8;
            label1.Text = "Cadastro de Pedido";
            // 
            // dataPedi
            // 
            dataPedi.Location = new Point(286, 428);
            dataPedi.Name = "dataPedi";
            dataPedi.Size = new Size(150, 31);
            dataPedi.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 400);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 16;
            label4.Text = "Data Compra";
            // 
            // tbx_totalPedi
            // 
            tbx_totalPedi.Location = new Point(286, 526);
            tbx_totalPedi.Name = "tbx_totalPedi";
            tbx_totalPedi.Size = new Size(150, 31);
            tbx_totalPedi.TabIndex = 17;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(326, 493);
            Total.Name = "Total";
            Total.Size = new Size(49, 25);
            Total.TabIndex = 18;
            Total.Text = "Total";
            // 
            // CadastroPedido
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 750);
            Controls.Add(Total);
            Controls.Add(tbx_totalPedi);
            Controls.Add(label4);
            Controls.Add(dataPedi);
            Controls.Add(label2);
            Controls.Add(hhhhh);
            Controls.Add(btn_cadastrarFun);
            Controls.Add(tbx_FunPedi);
            Controls.Add(tbx_nomePediCli);
            Controls.Add(label1);
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
        private TextBox dataPedi;
        private Label label4;
        private TextBox tbx_totalPedi;
        private Label Total;
    }
}