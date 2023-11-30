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
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            cbox_PesquTipoCodUser = new ComboBox();
            tbx_PesquEmailCodUser = new TextBox();
            label10 = new Label();
            tbx_PesquNomeCodUser = new TextBox();
            tbx_PesquBuscaCodUser = new TextBox();
            label6 = new Label();
            btn_PesquCodUser = new Button();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            grid_PesquNomeTipo = new DataGridViewTextBoxColumn();
            grid_PesquMatriFun = new DataGridViewTextBoxColumn();
            grid_PesquFunctionFun = new DataGridViewTextBoxColumn();
            cbox_PesquBuscaTipo = new ComboBox();
            btn_PesquTipoUser = new Button();
            label7 = new Label();
            tabControl1 = new TabControl();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 5);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar Usuário";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(tbx_PesquBuscaCodUser);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btn_PesquCodUser);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(385, 357);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar por código";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cbox_PesquTipoCodUser);
            groupBox2.Controls.Add(tbx_PesquEmailCodUser);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(tbx_PesquNomeCodUser);
            groupBox2.Location = new Point(3, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 279);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cadastro de Acesso";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 148);
            label8.Name = "label8";
            label8.Size = new Size(44, 21);
            label8.TabIndex = 6;
            label8.Text = "Tipo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(29, 90);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 5;
            label9.Text = "E_mail";
            // 
            // cbox_PesquTipoCodUser
            // 
            cbox_PesquTipoCodUser.FormattingEnabled = true;
            cbox_PesquTipoCodUser.Location = new Point(27, 172);
            cbox_PesquTipoCodUser.Name = "cbox_PesquTipoCodUser";
            cbox_PesquTipoCodUser.Size = new Size(121, 23);
            cbox_PesquTipoCodUser.TabIndex = 4;
            // 
            // tbx_PesquEmailCodUser
            // 
            tbx_PesquEmailCodUser.Location = new Point(27, 114);
            tbx_PesquEmailCodUser.Name = "tbx_PesquEmailCodUser";
            tbx_PesquEmailCodUser.Size = new Size(255, 23);
            tbx_PesquEmailCodUser.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(29, 37);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 1;
            label10.Text = "Nome";
            // 
            // tbx_PesquNomeCodUser
            // 
            tbx_PesquNomeCodUser.Location = new Point(27, 60);
            tbx_PesquNomeCodUser.Name = "tbx_PesquNomeCodUser";
            tbx_PesquNomeCodUser.Size = new Size(255, 23);
            tbx_PesquNomeCodUser.TabIndex = 0;
            // 
            // tbx_PesquBuscaCodUser
            // 
            tbx_PesquBuscaCodUser.Location = new Point(139, 20);
            tbx_PesquBuscaCodUser.Name = "tbx_PesquBuscaCodUser";
            tbx_PesquBuscaCodUser.Size = new Size(124, 23);
            tbx_PesquBuscaCodUser.TabIndex = 7;
            // 
            // label6
            // 
            label6.Location = new Point(5, 14);
            label6.Name = "label6";
            label6.Size = new Size(145, 32);
            label6.TabIndex = 6;
            label6.Text = "Digite o código do Usuário:";
            // 
            // btn_PesquCodUser
            // 
            btn_PesquCodUser.Location = new Point(268, 20);
            btn_PesquCodUser.Margin = new Padding(2);
            btn_PesquCodUser.Name = "btn_PesquCodUser";
            btn_PesquCodUser.Size = new Size(89, 25);
            btn_PesquCodUser.TabIndex = 0;
            btn_PesquCodUser.Text = "Buscar";
            btn_PesquCodUser.UseVisualStyleBackColor = true;
            btn_PesquCodUser.Click += btn_PesquCodUser_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(cbox_PesquBuscaTipo);
            tabPage1.Controls.Add(btn_PesquTipoUser);
            tabPage1.Controls.Add(label7);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(385, 357);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Buscar por Tipo de Usuário";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { grid_PesquNomeTipo, grid_PesquMatriFun, grid_PesquFunctionFun });
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(379, 314);
            dataGridView1.TabIndex = 10;
            // 
            // grid_PesquNomeTipo
            // 
            grid_PesquNomeTipo.HeaderText = "Nome";
            grid_PesquNomeTipo.Name = "grid_PesquNomeTipo";
            grid_PesquNomeTipo.ReadOnly = true;
            // 
            // grid_PesquMatriFun
            // 
            grid_PesquMatriFun.HeaderText = "Matrícula Funcionário";
            grid_PesquMatriFun.Name = "grid_PesquMatriFun";
            grid_PesquMatriFun.ReadOnly = true;
            // 
            // grid_PesquFunctionFun
            // 
            grid_PesquFunctionFun.HeaderText = "Função";
            grid_PesquFunctionFun.Name = "grid_PesquFunctionFun";
            grid_PesquFunctionFun.ReadOnly = true;
            // 
            // cbox_PesquBuscaTipo
            // 
            cbox_PesquBuscaTipo.FormattingEnabled = true;
            cbox_PesquBuscaTipo.Items.AddRange(new object[] { "Gerente", "Caixa", "Atendente" });
            cbox_PesquBuscaTipo.Location = new Point(150, 11);
            cbox_PesquBuscaTipo.Name = "cbox_PesquBuscaTipo";
            cbox_PesquBuscaTipo.Size = new Size(121, 23);
            cbox_PesquBuscaTipo.TabIndex = 9;
            // 
            // btn_PesquTipoUser
            // 
            btn_PesquTipoUser.Location = new Point(277, 7);
            btn_PesquTipoUser.Name = "btn_PesquTipoUser";
            btn_PesquTipoUser.Size = new Size(92, 29);
            btn_PesquTipoUser.TabIndex = 6;
            btn_PesquTipoUser.Text = "Buscar";
            btn_PesquTipoUser.UseVisualStyleBackColor = true;
            btn_PesquTipoUser.Click += btn_PesquTipoUser_Click;
            // 
            // label7
            // 
            label7.Location = new Point(9, 7);
            label7.Name = "label7";
            label7.Size = new Size(145, 32);
            label7.TabIndex = 4;
            label7.Text = "Escolha o Tipo de Usuário";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(8, 40);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(393, 385);
            tabControl1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(29, 233);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(249, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 209);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 8;
            label2.Text = "Ultimo Acesso";
            // 
            // PesquisarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PesquisarUsuario";
            Text = "PesquisarUsuario";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Label label8;
        private Label label9;
        private ComboBox cbox_PesquTipoCodUser;
        private TextBox tbx_PesquEmailCodUser;
        private Label label10;
        private TextBox tbx_PesquNomeCodUser;
        private TextBox tbx_PesquBuscaCodUser;
        private Label label6;
        private Button btn_PesquCodUser;
        private TabPage tabPage1;
        private Button btn_PesquTipoUser;
        private Label label7;
        private TabControl tabControl1;
        private ComboBox cbox_PesquBuscaTipo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn grid_PesquNomeTipo;
        private DataGridViewTextBoxColumn grid_PesquMatriFun;
        private DataGridViewTextBoxColumn grid_PesquFunctionFun;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}