namespace MercadoBD.View.TelaPedido
{
    partial class TelaPDV
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
            Label tbx_QuantiPdv;
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            grid_Itens = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            tbx_PdvQuanti = new TextBox();
            tbx_PdvCod = new TextBox();
            tbx_CodPdv = new Label();
            tbx_PdvValUni = new Label();
            tbx_PdvValTotalten = new Label();
            label11 = new Label();
            btn_PdvFimVenda = new Button();
            btn_PdvBuscar = new Button();
            tbx_PdvProd = new Label();
            label8 = new Label();
            button1 = new Button();
            txn_valorFimPedi = new Label();
            label9 = new Label();
            tbx_QuantiPdv = new Label();
            ((System.ComponentModel.ISupportInitialize)grid_Itens).BeginInit();
            SuspendLayout();
            // 
            // tbx_QuantiPdv
            // 
            tbx_QuantiPdv.BackColor = SystemColors.ControlLightLight;
            tbx_QuantiPdv.Location = new Point(389, 287);
            tbx_QuantiPdv.Name = "tbx_QuantiPdv";
            tbx_QuantiPdv.Size = new Size(182, 28);
            tbx_QuantiPdv.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 3);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 0;
            label1.Text = "PDV - Mercado do Zé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 82);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Código de Barra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 82);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 158);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "Código de Barra";
            // 
            // grid_Itens
            // 
            grid_Itens.BorderStyle = BorderStyle.Fixed3D;
            grid_Itens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            grid_Itens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_Itens.Location = new Point(12, 129);
            grid_Itens.Name = "grid_Itens";
            grid_Itens.RightToLeft = RightToLeft.No;
            grid_Itens.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            grid_Itens.RowsDefaultCellStyle = dataGridViewCellStyle2;
            grid_Itens.RowTemplate.Height = 25;
            grid_Itens.Size = new Size(352, 269);
            grid_Itens.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 266);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 6;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(441, 323);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 7;
            label7.Text = "Valor Unitário";
            // 
            // tbx_PdvQuanti
            // 
            tbx_PdvQuanti.Location = new Point(203, 100);
            tbx_PdvQuanti.Name = "tbx_PdvQuanti";
            tbx_PdvQuanti.Size = new Size(161, 23);
            tbx_PdvQuanti.TabIndex = 8;
            // 
            // tbx_PdvCod
            // 
            tbx_PdvCod.Location = new Point(6, 100);
            tbx_PdvCod.Name = "tbx_PdvCod";
            tbx_PdvCod.Size = new Size(161, 23);
            tbx_PdvCod.TabIndex = 9;
            // 
            // tbx_CodPdv
            // 
            tbx_CodPdv.BackColor = Color.White;
            tbx_CodPdv.Location = new Point(389, 173);
            tbx_CodPdv.Name = "tbx_CodPdv";
            tbx_CodPdv.Size = new Size(182, 28);
            tbx_CodPdv.TabIndex = 10;
            // 
            // tbx_PdvValUni
            // 
            tbx_PdvValUni.BackColor = SystemColors.ControlLightLight;
            tbx_PdvValUni.Location = new Point(389, 344);
            tbx_PdvValUni.Name = "tbx_PdvValUni";
            tbx_PdvValUni.Size = new Size(182, 28);
            tbx_PdvValUni.TabIndex = 13;
            // 
            // tbx_PdvValTotalten
            // 
            tbx_PdvValTotalten.BackColor = SystemColors.ControlLightLight;
            tbx_PdvValTotalten.Location = new Point(389, 398);
            tbx_PdvValTotalten.Name = "tbx_PdvValTotalten";
            tbx_PdvValTotalten.Size = new Size(182, 28);
            tbx_PdvValTotalten.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(450, 377);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 14;
            label11.Text = "Valor Total";
            // 
            // btn_PdvFimVenda
            // 
            btn_PdvFimVenda.BackColor = Color.IndianRed;
            btn_PdvFimVenda.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_PdvFimVenda.Location = new Point(12, 509);
            btn_PdvFimVenda.Name = "btn_PdvFimVenda";
            btn_PdvFimVenda.Size = new Size(352, 44);
            btn_PdvFimVenda.TabIndex = 16;
            btn_PdvFimVenda.Text = "FINALIZAR";
            btn_PdvFimVenda.UseVisualStyleBackColor = false;
            // 
            // btn_PdvBuscar
            // 
            btn_PdvBuscar.BackColor = SystemColors.AppWorkspace;
            btn_PdvBuscar.ForeColor = Color.Black;
            btn_PdvBuscar.Location = new Point(389, 91);
            btn_PdvBuscar.Name = "btn_PdvBuscar";
            btn_PdvBuscar.Size = new Size(168, 39);
            btn_PdvBuscar.TabIndex = 17;
            btn_PdvBuscar.Text = "BUSCAR";
            btn_PdvBuscar.UseVisualStyleBackColor = false;
            btn_PdvBuscar.Click += btn_PdvBuscar_Click;
            // 
            // tbx_PdvProd
            // 
            tbx_PdvProd.BackColor = Color.White;
            tbx_PdvProd.Location = new Point(389, 226);
            tbx_PdvProd.Name = "tbx_PdvProd";
            tbx_PdvProd.Size = new Size(182, 32);
            tbx_PdvProd.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(450, 211);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 18;
            label8.Text = "Produto";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(389, 445);
            button1.Name = "button1";
            button1.Size = new Size(182, 47);
            button1.TabIndex = 20;
            button1.Text = "Confirmar Busca";
            button1.UseVisualStyleBackColor = false;
            // 
            // txn_valorFimPedi
            // 
            txn_valorFimPedi.BackColor = SystemColors.ControlLightLight;
            txn_valorFimPedi.Location = new Point(32, 433);
            txn_valorFimPedi.Name = "txn_valorFimPedi";
            txn_valorFimPedi.Size = new Size(135, 31);
            txn_valorFimPedi.TabIndex = 21;
            txn_valorFimPedi.Text = "R$0,00";
            txn_valorFimPedi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 411);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 22;
            label9.Text = "Total do Pedido";
            // 
            // TelaPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 565);
            Controls.Add(label9);
            Controls.Add(txn_valorFimPedi);
            Controls.Add(button1);
            Controls.Add(tbx_PdvProd);
            Controls.Add(label8);
            Controls.Add(btn_PdvBuscar);
            Controls.Add(btn_PdvFimVenda);
            Controls.Add(tbx_PdvValTotalten);
            Controls.Add(label11);
            Controls.Add(tbx_PdvValUni);
            Controls.Add(tbx_QuantiPdv);
            Controls.Add(tbx_CodPdv);
            Controls.Add(tbx_PdvCod);
            Controls.Add(tbx_PdvQuanti);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(grid_Itens);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPDV";
            RightToLeft = RightToLeft.No;
            Text = "TelaPDV";
            TransparencyKey = Color.Silver;
            ((System.ComponentModel.ISupportInitialize)grid_Itens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox tbx_PdvQuanti;
        private TextBox tbx_PdvCod;
        private Label tbx_CodPdv;
        private Label tbx_QuantiPdv;
        private Label tbx_PdvValUni;
        private Label tbx_PdvValTotalten;
        private Label label11;
        private Button btn_PdvFimVenda;
        private Button btn_PdvBuscar;
        private Label tbx_PdvProd;
        private Label label8;
        public DataGridView grid_Itens;
        private Button button1;
        private Label txn_valorFimPedi;
        private Label label9;
    }
}