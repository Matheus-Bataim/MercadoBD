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
            tbx_ExBuscarUser = new TextBox();
            btn_ExBuscarUser = new Button();
            groupBox1 = new GroupBox();
            btn_ExUser = new Button();
            label5 = new Label();
            label4 = new Label();
            cbox_ExTipoUser = new ComboBox();
            tbx_ExEmailUser = new TextBox();
            label3 = new Label();
            tbx_ExNomeUser = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(161, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(281, 54);
            label1.TabIndex = 0;
            label1.Text = "Excluir Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 158);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(228, 50);
            label2.TabIndex = 1;
            label2.Text = "Digite o código do Usuário\r\n:";
            // 
            // tbx_ExBuscarUser
            // 
            tbx_ExBuscarUser.Location = new Point(309, 153);
            tbx_ExBuscarUser.Margin = new Padding(4, 5, 4, 5);
            tbx_ExBuscarUser.Name = "tbx_ExBuscarUser";
            tbx_ExBuscarUser.Size = new Size(175, 31);
            tbx_ExBuscarUser.TabIndex = 2;
            // 
            // btn_ExBuscarUser
            // 
            btn_ExBuscarUser.Location = new Point(523, 143);
            btn_ExBuscarUser.Margin = new Padding(4, 5, 4, 5);
            btn_ExBuscarUser.Name = "btn_ExBuscarUser";
            btn_ExBuscarUser.Size = new Size(131, 48);
            btn_ExBuscarUser.TabIndex = 3;
            btn_ExBuscarUser.Text = "Buscar";
            btn_ExBuscarUser.UseVisualStyleBackColor = true;
            btn_ExBuscarUser.Click += btn_BuscarExUser_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ExUser);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbox_ExTipoUser);
            groupBox1.Controls.Add(tbx_ExEmailUser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbx_ExNomeUser);
            groupBox1.Location = new Point(50, 202);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(604, 442);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Usuário";
            // 
            // btn_ExUser
            // 
            btn_ExUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ExUser.Location = new Point(397, 317);
            btn_ExUser.Margin = new Padding(4, 5, 4, 5);
            btn_ExUser.Name = "btn_ExUser";
            btn_ExUser.Size = new Size(177, 100);
            btn_ExUser.TabIndex = 8;
            btn_ExUser.Text = "Excluir";
            btn_ExUser.UseVisualStyleBackColor = true;
            btn_ExUser.Click += btn_exUser_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 248);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 6;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 152);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 5;
            label4.Text = "E_mail";
            // 
            // cbox_ExTipoUser
            // 
            cbox_ExTipoUser.FormattingEnabled = true;
            cbox_ExTipoUser.Location = new Point(39, 287);
            cbox_ExTipoUser.Margin = new Padding(4, 5, 4, 5);
            cbox_ExTipoUser.Name = "cbox_ExTipoUser";
            cbox_ExTipoUser.Size = new Size(171, 33);
            cbox_ExTipoUser.TabIndex = 4;
            // 
            // tbx_ExEmailUser
            // 
            tbx_ExEmailUser.Location = new Point(39, 190);
            tbx_ExEmailUser.Margin = new Padding(4, 5, 4, 5);
            tbx_ExEmailUser.Name = "tbx_ExEmailUser";
            tbx_ExEmailUser.Size = new Size(363, 31);
            tbx_ExEmailUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 63);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 1;
            label3.Text = "Nome";
            // 
            // tbx_ExNomeUser
            // 
            tbx_ExNomeUser.Location = new Point(39, 100);
            tbx_ExNomeUser.Margin = new Padding(4, 5, 4, 5);
            tbx_ExNomeUser.Name = "tbx_ExNomeUser";
            tbx_ExNomeUser.Size = new Size(363, 31);
            tbx_ExNomeUser.TabIndex = 0;
            // 
            // DeletarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 750);
            Controls.Add(groupBox1);
            Controls.Add(btn_ExBuscarUser);
            Controls.Add(tbx_ExBuscarUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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
        private TextBox tbx_ExBuscarUser;
        private Button btn_ExBuscarUser;
        private Button btn_ExUser;
        private Label label5;
        private Label label4;
        private ComboBox cbox_ExTipoUser;
        private TextBox tbx_ExEmailUser;
        private Label label3;
        private TextBox tbx_ExNomeUser;
        protected internal GroupBox groupBox1;
    }
}