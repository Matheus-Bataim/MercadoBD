namespace MercadoBD.View.TelaFuncionarios
{
    partial class CadastroFuncionarios
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
            label1 = new Label();
            tbx_nomeFun = new TextBox();
            tbx_emailFun = new TextBox();
            btn_cadastrarFun = new Button();
            hhhhh = new Label();
            label2 = new Label();
            foneFun = new MaskedTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(480, 45);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Funcionario";
            // 
            // tbx_nomeFun
            // 
            tbx_nomeFun.Location = new Point(189, 194);
            tbx_nomeFun.Margin = new Padding(4, 5, 4, 5);
            tbx_nomeFun.Name = "tbx_nomeFun";
            tbx_nomeFun.Size = new Size(318, 31);
            tbx_nomeFun.TabIndex = 1;
            // 
            // tbx_emailFun
            // 
            tbx_emailFun.Location = new Point(189, 279);
            tbx_emailFun.Margin = new Padding(4, 5, 4, 5);
            tbx_emailFun.Name = "tbx_emailFun";
            tbx_emailFun.Size = new Size(318, 31);
            tbx_emailFun.TabIndex = 2;
            // 
            // btn_cadastrarFun
            // 
            btn_cadastrarFun.Location = new Point(213, 549);
            btn_cadastrarFun.Margin = new Padding(4, 5, 4, 5);
            btn_cadastrarFun.Name = "btn_cadastrarFun";
            btn_cadastrarFun.Size = new Size(271, 107);
            btn_cadastrarFun.TabIndex = 3;
            btn_cadastrarFun.Text = "Cadastrar";
            btn_cadastrarFun.UseVisualStyleBackColor = true;
            btn_cadastrarFun.Click += btn_cadastrarFun_Click;
            // 
            // hhhhh
            // 
            hhhhh.AutoSize = true;
            hhhhh.Location = new Point(318, 164);
            hhhhh.Margin = new Padding(4, 0, 4, 0);
            hhhhh.Name = "hhhhh";
            hhhhh.Size = new Size(61, 25);
            hhhhh.TabIndex = 4;
            hhhhh.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 249);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // foneFun
            // 
            foneFun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            foneFun.Location = new Point(270, 386);
            foneFun.Margin = new Padding(4, 5, 4, 5);
            foneFun.Mask = "(99) 0000-0000";
            foneFun.Name = "foneFun";
            foneFun.Size = new Size(165, 39);
            foneFun.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 356);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 7;
            label3.Text = "Fone";
            // 
            // CadastroFuncionarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 750);
            Controls.Add(label3);
            Controls.Add(foneFun);
            Controls.Add(label2);
            Controls.Add(hhhhh);
            Controls.Add(btn_cadastrarFun);
            Controls.Add(tbx_emailFun);
            Controls.Add(tbx_nomeFun);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CadastroFuncionarios";
            Text = "CadastroFuncionarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbx_nomeFun;
        private TextBox tbx_emailFun;
        private Button btn_cadastrarFun;
        private Label hhhhh;
        private Label label2;
        private MaskedTextBox foneFun;
        private Label label3;
    }
}