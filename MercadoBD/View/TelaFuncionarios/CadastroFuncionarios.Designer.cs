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
            label1.AutoSize = true;
            label1.Location = new Point(162, 36);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadatro Funcionario";
            // 
            // tbx_nomeFun
            // 
            tbx_nomeFun.Location = new Point(117, 95);
            tbx_nomeFun.Name = "tbx_nomeFun";
            tbx_nomeFun.Size = new Size(100, 23);
            tbx_nomeFun.TabIndex = 1;
            // 
            // tbx_emailFun
            // 
            tbx_emailFun.Location = new Point(117, 146);
            tbx_emailFun.Name = "tbx_emailFun";
            tbx_emailFun.Size = new Size(100, 23);
            tbx_emailFun.TabIndex = 2;
            // 
            // btn_cadastrarFun
            // 
            btn_cadastrarFun.Location = new Point(150, 308);
            btn_cadastrarFun.Name = "btn_cadastrarFun";
            btn_cadastrarFun.Size = new Size(190, 64);
            btn_cadastrarFun.TabIndex = 3;
            btn_cadastrarFun.Text = "Cadastrar";
            btn_cadastrarFun.UseVisualStyleBackColor = true;
            btn_cadastrarFun.Click += btn_cadastrarFun_Click;
            // 
            // hhhhh
            // 
            hhhhh.AutoSize = true;
            hhhhh.Location = new Point(142, 77);
            hhhhh.Name = "hhhhh";
            hhhhh.Size = new Size(40, 15);
            hhhhh.TabIndex = 4;
            hhhhh.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 128);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // foneFun
            // 
            foneFun.Location = new Point(117, 229);
            foneFun.Mask = "(99) 0000-0000";
            foneFun.Name = "foneFun";
            foneFun.Size = new Size(100, 23);
            foneFun.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 192);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Fone";
            // 
            // CadastroFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(label3);
            Controls.Add(foneFun);
            Controls.Add(label2);
            Controls.Add(hhhhh);
            Controls.Add(btn_cadastrarFun);
            Controls.Add(tbx_emailFun);
            Controls.Add(tbx_nomeFun);
            Controls.Add(label1);
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