namespace testeForm.Forms
{
    partial class ListarDonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarDonos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btEditarDono = new Button();
            btExcluirDono = new Button();
            btPesquisaDono = new Button();
            dtgListDonos = new DataGridView();
            IdDono = new DataGridViewTextBoxColumn();
            nomeDono = new DataGridViewTextBoxColumn();
            TelefoneDono = new DataGridViewTextBoxColumn();
            CpfDono = new DataGridViewTextBoxColumn();
            iconPetShop = new PictureBox();
            lbDonoCadastrado = new Label();
            btLimparGrid = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgListDonos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPetShop).BeginInit();
            SuspendLayout();
            // 
            // btEditarDono
            // 
            btEditarDono.BackColor = Color.Peru;
            btEditarDono.Image = (Image)resources.GetObject("btEditarDono.Image");
            btEditarDono.Location = new Point(664, 98);
            btEditarDono.Name = "btEditarDono";
            btEditarDono.Size = new Size(63, 60);
            btEditarDono.TabIndex = 24;
            btEditarDono.UseVisualStyleBackColor = false;
            btEditarDono.Click += btEditarDono_Click;
            // 
            // btExcluirDono
            // 
            btExcluirDono.BackColor = Color.Peru;
            btExcluirDono.Image = (Image)resources.GetObject("btExcluirDono.Image");
            btExcluirDono.Location = new Point(586, 98);
            btExcluirDono.Name = "btExcluirDono";
            btExcluirDono.Size = new Size(63, 60);
            btExcluirDono.TabIndex = 23;
            btExcluirDono.UseVisualStyleBackColor = false;
            btExcluirDono.Click += btExcluirDono_Click;
            // 
            // btPesquisaDono
            // 
            btPesquisaDono.BackColor = Color.Peru;
            btPesquisaDono.Image = (Image)resources.GetObject("btPesquisaDono.Image");
            btPesquisaDono.Location = new Point(501, 98);
            btPesquisaDono.Name = "btPesquisaDono";
            btPesquisaDono.Size = new Size(63, 60);
            btPesquisaDono.TabIndex = 22;
            btPesquisaDono.UseVisualStyleBackColor = false;
            btPesquisaDono.Click += btPesquisaDono_Click;
            // 
            // dtgListDonos
            // 
            dtgListDonos.AllowUserToOrderColumns = true;
            dtgListDonos.BackgroundColor = SystemColors.HighlightText;
            dtgListDonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListDonos.Columns.AddRange(new DataGridViewColumn[] { IdDono, nomeDono, TelefoneDono, CpfDono });
            dtgListDonos.Location = new Point(64, 175);
            dtgListDonos.Name = "dtgListDonos";
            dtgListDonos.RowHeadersWidth = 51;
            dtgListDonos.Size = new Size(673, 254);
            dtgListDonos.TabIndex = 54;
            dtgListDonos.CellClick += dtgListDonos_CellClick;
            // 
            // IdDono
            // 
            IdDono.DataPropertyName = "_idDono";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            IdDono.DefaultCellStyle = dataGridViewCellStyle1;
            IdDono.FillWeight = 60F;
            IdDono.HeaderText = "ID";
            IdDono.MinimumWidth = 6;
            IdDono.Name = "IdDono";
            IdDono.Width = 60;
            // 
            // nomeDono
            // 
            nomeDono.DataPropertyName = "_nome";
            nomeDono.HeaderText = "Nome";
            nomeDono.MinimumWidth = 6;
            nomeDono.Name = "nomeDono";
            nomeDono.Width = 200;
            // 
            // TelefoneDono
            // 
            TelefoneDono.DataPropertyName = "_telefone";
            TelefoneDono.HeaderText = "Telefone";
            TelefoneDono.MinimumWidth = 6;
            TelefoneDono.Name = "TelefoneDono";
            TelefoneDono.Width = 190;
            // 
            // CpfDono
            // 
            CpfDono.DataPropertyName = "_cpf";
            CpfDono.HeaderText = "CPF";
            CpfDono.MinimumWidth = 6;
            CpfDono.Name = "CpfDono";
            CpfDono.Width = 170;
            // 
            // iconPetShop
            // 
            iconPetShop.BackColor = Color.SaddleBrown;
            iconPetShop.Image = (Image)resources.GetObject("iconPetShop.Image");
            iconPetShop.Location = new Point(557, 30);
            iconPetShop.Name = "iconPetShop";
            iconPetShop.Size = new Size(32, 44);
            iconPetShop.SizeMode = PictureBoxSizeMode.Zoom;
            iconPetShop.TabIndex = 53;
            iconPetShop.TabStop = false;
            // 
            // lbDonoCadastrado
            // 
            lbDonoCadastrado.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDonoCadastrado.ForeColor = SystemColors.Control;
            lbDonoCadastrado.Location = new Point(213, 21);
            lbDonoCadastrado.Name = "lbDonoCadastrado";
            lbDonoCadastrado.Size = new Size(352, 64);
            lbDonoCadastrado.TabIndex = 52;
            lbDonoCadastrado.Text = "DONOS CADASTRADOS";
            lbDonoCadastrado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btLimparGrid
            // 
            btLimparGrid.BackColor = Color.Peru;
            btLimparGrid.Image = (Image)resources.GetObject("btLimparGrid.Image");
            btLimparGrid.Location = new Point(412, 98);
            btLimparGrid.Name = "btLimparGrid";
            btLimparGrid.Size = new Size(63, 60);
            btLimparGrid.TabIndex = 21;
            btLimparGrid.UseVisualStyleBackColor = false;
            btLimparGrid.Click += btLimparGrid_Click;
            // 
            // ListarDonos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(btLimparGrid);
            Controls.Add(btEditarDono);
            Controls.Add(btExcluirDono);
            Controls.Add(btPesquisaDono);
            Controls.Add(dtgListDonos);
            Controls.Add(iconPetShop);
            Controls.Add(lbDonoCadastrado);
            Name = "ListarDonos";
            Text = "ListarDonos";
            ((System.ComponentModel.ISupportInitialize)dtgListDonos).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPetShop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btEditarDono;
        private Button btExcluirDono;
        private Button btPesquisaDono;
        private DataGridView dtgListDonos;
        private PictureBox iconPetShop;
        private Label lbDonoCadastrado;
        private Button btLimparGrid;
        private DataGridViewTextBoxColumn IdDono;
        private DataGridViewTextBoxColumn nomeDono;
        private DataGridViewTextBoxColumn TelefoneDono;
        private DataGridViewTextBoxColumn CpfDono;
    }
}