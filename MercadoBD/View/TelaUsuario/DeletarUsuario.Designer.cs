namespace MercadoBD.View.TelaUsuario
{
    partial class DeletarUsuario
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
            label2 = new Label();
            tbx_buscaDelser = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            btn_exUser = new Button();
            label5 = new Label();
            label4 = new Label();
            cbox_tipoExUser = new ComboBox();
            tbx_EmailDelUser = new TextBox();
            label3 = new Label();
            tbx_NomeDelUser = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 51);
            label1.Name = "label1";
            label1.Size = new Size(191, 37);
            label1.TabIndex = 0;
            label1.Text = "Excluir Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 95);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite o código do Usuário:";
            // 
            // tbx_buscaDelser
            // 
            tbx_buscaDelser.Location = new Point(216, 92);
            tbx_buscaDelser.Name = "tbx_buscaDelser";
            tbx_buscaDelser.Size = new Size(124, 23);
            tbx_buscaDelser.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(366, 86);
            button1.Name = "button1";
            button1.Size = new Size(92, 29);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_exUser);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbox_tipoExUser);
            groupBox1.Controls.Add(tbx_EmailDelUser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbx_NomeDelUser);
            groupBox1.Location = new Point(35, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 265);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Acesso";
            // 
            // btn_exUser
            // 
            btn_exUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exUser.Location = new Point(278, 190);
            btn_exUser.Name = "btn_exUser";
            btn_exUser.Size = new Size(124, 60);
            btn_exUser.TabIndex = 8;
            btn_exUser.Text = "Excluir";
            btn_exUser.UseVisualStyleBackColor = true;
            btn_exUser.Click += btn_exUser_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 149);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 6;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 91);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 5;
            label4.Text = "E_mail";
            // 
            // cbox_tipoExUser
            // 
            cbox_tipoExUser.FormattingEnabled = true;
            cbox_tipoExUser.Location = new Point(27, 172);
            cbox_tipoExUser.Name = "cbox_tipoExUser";
            cbox_tipoExUser.Size = new Size(121, 23);
            cbox_tipoExUser.TabIndex = 4;
            // 
            // tbx_EmailDelUser
            // 
            tbx_EmailDelUser.Location = new Point(27, 114);
            tbx_EmailDelUser.Name = "tbx_EmailDelUser";
            tbx_EmailDelUser.Size = new Size(255, 23);
            tbx_EmailDelUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 38);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 1;
            label3.Text = "Nome";
            // 
            // tbx_NomeDelUser
            // 
            tbx_NomeDelUser.Location = new Point(27, 60);
            tbx_NomeDelUser.Name = "tbx_NomeDelUser";
            tbx_NomeDelUser.Size = new Size(255, 23);
            tbx_NomeDelUser.TabIndex = 0;
            // 
            // DeletarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(tbx_buscaDelser);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeletarUsuario";
            Text = "Sistema de Gerenciamento de Vendas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbx_buscaDelser;
        private Button button1;
        private GroupBox groupBox1;
        private Button btn_exUser;
        private Label label5;
        private Label label4;
        private ComboBox cbox_tipoExUser;
        private TextBox tbx_EmailDelUser;
        private Label label3;
        private TextBox tbx_NomeDelUser;
    }
}