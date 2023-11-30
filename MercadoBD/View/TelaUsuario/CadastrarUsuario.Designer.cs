namespace MercadoBD.View.TelaUsuario
{
    partial class CadastrarUsuario
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
            groupBox1 = new GroupBox();
            btn_CadUser = new Button();
            label6 = new Label();
            label5 = new Label();
            cbx_TipoCadUser = new ComboBox();
            tbx_SenhaCadUser = new TextBox();
            label1 = new Label();
            tbx_CadEmailUser = new TextBox();
            tbx_CadNomeUser = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbx_CadCodUser = new TextBox();
            label4 = new Label();
            btn_CadBuscarUser = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbx_CadNomeUser);
            groupBox1.Controls.Add(tbx_CadEmailUser);
            groupBox1.Controls.Add(btn_CadUser);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbx_TipoCadUser);
            groupBox1.Controls.Add(tbx_SenhaCadUser);
            groupBox1.Location = new Point(44, 212);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(604, 453);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Acesso";
            // 
            // btn_CadUser
            // 
            btn_CadUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CadUser.Location = new Point(397, 317);
            btn_CadUser.Margin = new Padding(4, 5, 4, 5);
            btn_CadUser.Name = "btn_CadUser";
            btn_CadUser.Size = new Size(177, 100);
            btn_CadUser.TabIndex = 8;
            btn_CadUser.Text = "Cadastrar";
            btn_CadUser.UseVisualStyleBackColor = true;
            btn_CadUser.Click += btn_CadUser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 332);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 7;
            label6.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 245);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 6;
            label5.Text = "Tipo";
            // 
            // cbx_TipoCadUser
            // 
            cbx_TipoCadUser.FormattingEnabled = true;
            cbx_TipoCadUser.Location = new Point(31, 294);
            cbx_TipoCadUser.Margin = new Padding(4, 5, 4, 5);
            cbx_TipoCadUser.Name = "cbx_TipoCadUser";
            cbx_TipoCadUser.Size = new Size(171, 33);
            cbx_TipoCadUser.TabIndex = 4;
            // 
            // tbx_SenhaCadUser
            // 
            tbx_SenhaCadUser.Location = new Point(31, 369);
            tbx_SenhaCadUser.Margin = new Padding(4, 5, 4, 5);
            tbx_SenhaCadUser.Name = "tbx_SenhaCadUser";
            tbx_SenhaCadUser.Size = new Size(234, 31);
            tbx_SenhaCadUser.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(402, 65);
            label1.TabIndex = 9;
            label1.Text = "Cadastrar Usuário";
            // 
            // tbx_CadEmailUser
            // 
            tbx_CadEmailUser.Location = new Point(31, 209);
            tbx_CadEmailUser.Margin = new Padding(4, 5, 4, 5);
            tbx_CadEmailUser.Name = "tbx_CadEmailUser";
            tbx_CadEmailUser.Size = new Size(333, 31);
            tbx_CadEmailUser.TabIndex = 9;
            // 
            // tbx_CadNomeUser
            // 
            tbx_CadNomeUser.Location = new Point(31, 138);
            tbx_CadNomeUser.Name = "tbx_CadNomeUser";
            tbx_CadNomeUser.Size = new Size(333, 31);
            tbx_CadNomeUser.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 12;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 13;
            label3.Text = "Nome";
            // 
            // tbx_CadCodUser
            // 
            tbx_CadCodUser.Location = new Point(315, 141);
            tbx_CadCodUser.Name = "tbx_CadCodUser";
            tbx_CadCodUser.Size = new Size(121, 31);
            tbx_CadCodUser.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 141);
            label4.Name = "label4";
            label4.Size = new Size(242, 25);
            label4.TabIndex = 15;
            label4.Text = "Digite a Matrícula do Usuário";
            // 
            // btn_CadBuscarUser
            // 
            btn_CadBuscarUser.Location = new Point(480, 141);
            btn_CadBuscarUser.Name = "btn_CadBuscarUser";
            btn_CadBuscarUser.Size = new Size(112, 34);
            btn_CadBuscarUser.TabIndex = 16;
            btn_CadBuscarUser.Text = "Buscar";
            btn_CadBuscarUser.UseVisualStyleBackColor = true;
            // 
            // CadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 750);
            Controls.Add(btn_CadBuscarUser);
            Controls.Add(label4);
            Controls.Add(tbx_CadCodUser);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastrarUsuario";
            Text = "Cadast";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btn_CadUser;
        private Label label6;
        private Label label5;
        private ComboBox cbx_TipoCadUser;
        private TextBox tbx_SenhaCadUser;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox tbx_CadNomeUser;
        private TextBox tbx_CadEmailUser;
        private TextBox tbx_CadCodUser;
        private Label label4;
        private Button btn_CadBuscarUser;
    }
}