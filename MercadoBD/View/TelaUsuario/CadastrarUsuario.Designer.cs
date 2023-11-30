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
            label2 = new Label();
            tbx_MatriFunUser = new TextBox();
            btn_CadUser = new Button();
            label6 = new Label();
            label5 = new Label();
            cbx_TipoCadUser = new ComboBox();
            tbx_SenhaCadUser = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbx_MatriFunUser);
            groupBox1.Controls.Add(btn_CadUser);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbx_TipoCadUser);
            groupBox1.Controls.Add(tbx_SenhaCadUser);
            groupBox1.Location = new Point(31, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 272);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Acesso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 21);
            label2.TabIndex = 21;
            label2.Text = "Matrícula do Funcionário";
            // 
            // tbx_MatriFunUser
            // 
            tbx_MatriFunUser.Location = new Point(28, 115);
            tbx_MatriFunUser.Margin = new Padding(2);
            tbx_MatriFunUser.Name = "tbx_MatriFunUser";
            tbx_MatriFunUser.Size = new Size(121, 23);
            tbx_MatriFunUser.TabIndex = 20;
            
            // 
            // btn_CadUser
            // 
            btn_CadUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CadUser.Location = new Point(278, 190);
            btn_CadUser.Name = "btn_CadUser";
            btn_CadUser.Size = new Size(124, 60);
            btn_CadUser.TabIndex = 8;
            btn_CadUser.Text = "Cadastrar";
            btn_CadUser.UseVisualStyleBackColor = true;
            btn_CadUser.Click += btn_CadUser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 154);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 7;
            label6.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 31);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 6;
            label5.Text = "Tipo";
            // 
            // cbx_TipoCadUser
            // 
            cbx_TipoCadUser.FormattingEnabled = true;
            cbx_TipoCadUser.Items.AddRange(new object[] { "Gerente", "Caixa", "Atendente" });
            cbx_TipoCadUser.Location = new Point(28, 57);
            cbx_TipoCadUser.Name = "cbx_TipoCadUser";
            cbx_TipoCadUser.Size = new Size(121, 23);
            cbx_TipoCadUser.TabIndex = 4;
            // 
            // tbx_SenhaCadUser
            // 
            tbx_SenhaCadUser.Location = new Point(28, 176);
            tbx_SenhaCadUser.Name = "tbx_SenhaCadUser";
            tbx_SenhaCadUser.Size = new Size(165, 23);
            tbx_SenhaCadUser.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 45);
            label1.TabIndex = 9;
            label1.Text = "Cadastrar Usuário";
            // 
            // CadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
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
        private Label label2;
        private TextBox tbx_MatriFunUser;
    }
}