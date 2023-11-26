namespace MercadoBD.View.TelaUsuario
{
    partial class PesquisarUsuario
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btn_BuscarNomeEser = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            tip_ = new ComboBox();
            tbx_EmailPediBusca = new TextBox();
            label3 = new Label();
            tbx_NomeBuscaUser = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label10 = new Label();
            tbx_ = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(111, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 54);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar Usuário";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(562, 642);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btn_BuscarNomeEser);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label7);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(554, 604);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Buscar por Usuário";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(554, 604);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar por código";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_BuscarNomeEser
            // 
            btn_BuscarNomeEser.Location = new Point(396, 11);
            btn_BuscarNomeEser.Margin = new Padding(4, 5, 4, 5);
            btn_BuscarNomeEser.Name = "btn_BuscarNomeEser";
            btn_BuscarNomeEser.Size = new Size(131, 48);
            btn_BuscarNomeEser.TabIndex = 6;
            btn_BuscarNomeEser.Text = "Buscar";
            btn_BuscarNomeEser.UseVisualStyleBackColor = true;
            
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tip_);
            groupBox1.Controls.Add(tbx_EmailPediBusca);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbx_NomeBuscaUser);
            groupBox1.Location = new Point(9, 69);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(541, 465);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Acesso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 251);
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
            label4.Location = new Point(41, 154);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 5;
            label4.Text = "E_mail";
            // 
            // tip_
            // 
            tip_.FormattingEnabled = true;
            tip_.Location = new Point(39, 287);
            tip_.Margin = new Padding(4, 5, 4, 5);
            tip_.Name = "tip_";
            tip_.Size = new Size(171, 33);
            tip_.TabIndex = 4;
            // 
            // tbx_EmailPediBusca
            // 
            tbx_EmailPediBusca.Location = new Point(39, 190);
            tbx_EmailPediBusca.Margin = new Padding(4, 5, 4, 5);
            tbx_EmailPediBusca.Name = "tbx_EmailPediBusca";
            tbx_EmailPediBusca.Size = new Size(363, 31);
            tbx_EmailPediBusca.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 66);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 1;
            label3.Text = "Nome";
            // 
            // tbx_NomeBuscaUser
            // 
            tbx_NomeBuscaUser.Location = new Point(39, 100);
            tbx_NomeBuscaUser.Margin = new Padding(4, 5, 4, 5);
            tbx_NomeBuscaUser.Name = "tbx_NomeBuscaUser";
            tbx_NomeBuscaUser.Size = new Size(363, 31);
            tbx_NomeBuscaUser.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(378, 24);
            button1.Name = "button1";
            button1.Size = new Size(127, 42);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 33);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 31);
            textBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.Location = new Point(7, 24);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(207, 53);
            label6.TabIndex = 6;
            label6.Text = "Digite o código do Usuário:";
            // 
            // label7
            // 
            label7.Location = new Point(13, 11);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(207, 53);
            label7.TabIndex = 4;
            label7.Text = "Digite o nome do Usuário:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 20);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 31);
            textBox2.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(tbx_);
            groupBox2.Location = new Point(4, 82);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(541, 465);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cadastro de Acesso";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(42, 253);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 32);
            label8.TabIndex = 6;
            label8.Text = "Tipo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(42, 156);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 32);
            label9.TabIndex = 5;
            label9.Text = "E_mail";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 287);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 33);
            comboBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(39, 190);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(363, 31);
            textBox3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(42, 68);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(79, 31);
            label10.TabIndex = 1;
            label10.Text = "Nome";
            // 
            // tbx_
            // 
            tbx_.Location = new Point(39, 100);
            tbx_.Margin = new Padding(4, 5, 4, 5);
            tbx_.Name = "tbx_";
            tbx_.Size = new Size(363, 31);
            tbx_.TabIndex = 0;
            // 
            // PesquisarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 750);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PesquisarUsuario";
            Text = "PesquisarUsuario";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btn_BuscarNomeEser;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private ComboBox tip_;
        private TextBox tbx_EmailPediBusca;
        private Label label3;
        private TextBox tbx_NomeBuscaUser;
        private TextBox textBox2;
        private Label label7;
        private GroupBox groupBox2;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label10;
        private TextBox tbx_;
        private TextBox textBox1;
        private Label label6;
        private Button button1;
    }
}