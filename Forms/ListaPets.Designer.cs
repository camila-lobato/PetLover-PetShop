namespace testeForm.Forms
{
    partial class ListaPets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPets));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btEditarPet = new Button();
            btExcluirPet = new Button();
            btPesquisaPet = new Button();
            dtgListPets = new DataGridView();
            IdPet = new DataGridViewTextBoxColumn();
            NomePet = new DataGridViewTextBoxColumn();
            IdadePet = new DataGridViewTextBoxColumn();
            EspeciePet = new DataGridViewTextBoxColumn();
            RacaPet = new DataGridViewTextBoxColumn();
            DonoPet = new DataGridViewTextBoxColumn();
            iconPetShop = new PictureBox();
            lbPetCadastrado = new Label();
            btLimparGridPet = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgListPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPetShop).BeginInit();
            SuspendLayout();
            // 
            // btEditarPet
            // 
            btEditarPet.BackColor = Color.Peru;
            btEditarPet.Image = (Image)resources.GetObject("btEditarPet.Image");
            btEditarPet.Location = new Point(664, 98);
            btEditarPet.Name = "btEditarPet";
            btEditarPet.Size = new Size(63, 60);
            btEditarPet.TabIndex = 20;
            btEditarPet.UseVisualStyleBackColor = false;
            btEditarPet.Click += btEditarPet_Click;
            // 
            // btExcluirPet
            // 
            btExcluirPet.BackColor = Color.Peru;
            btExcluirPet.Image = (Image)resources.GetObject("btExcluirPet.Image");
            btExcluirPet.Location = new Point(586, 98);
            btExcluirPet.Name = "btExcluirPet";
            btExcluirPet.Size = new Size(63, 60);
            btExcluirPet.TabIndex = 19;
            btExcluirPet.UseVisualStyleBackColor = false;
            btExcluirPet.Click += btExcluirPet_Click;
            // 
            // btPesquisaPet
            // 
            btPesquisaPet.BackColor = Color.Peru;
            btPesquisaPet.Image = (Image)resources.GetObject("btPesquisaPet.Image");
            btPesquisaPet.Location = new Point(501, 98);
            btPesquisaPet.Name = "btPesquisaPet";
            btPesquisaPet.Size = new Size(63, 60);
            btPesquisaPet.TabIndex = 18;
            btPesquisaPet.UseVisualStyleBackColor = false;
            btPesquisaPet.Click += btPesquisaPet_Click;
            // 
            // dtgListPets
            // 
            dtgListPets.AllowUserToOrderColumns = true;
            dtgListPets.BackgroundColor = SystemColors.HighlightText;
            dtgListPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListPets.Columns.AddRange(new DataGridViewColumn[] { IdPet, NomePet, IdadePet, EspeciePet, RacaPet, DonoPet });
            dtgListPets.Location = new Point(64, 175);
            dtgListPets.Name = "dtgListPets";
            dtgListPets.RowHeadersWidth = 51;
            dtgListPets.Size = new Size(673, 254);
            dtgListPets.TabIndex = 47;
            // 
            // IdPet
            // 
            IdPet.DataPropertyName = "_idPet";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            IdPet.DefaultCellStyle = dataGridViewCellStyle1;
            IdPet.FillWeight = 60F;
            IdPet.HeaderText = "ID";
            IdPet.MinimumWidth = 6;
            IdPet.Name = "IdPet";
            IdPet.Width = 60;
            // 
            // NomePet
            // 
            NomePet.DataPropertyName = "_nomePet";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NomePet.DefaultCellStyle = dataGridViewCellStyle2;
            NomePet.HeaderText = "Nome";
            NomePet.MinimumWidth = 6;
            NomePet.Name = "NomePet";
            NomePet.Width = 125;
            // 
            // IdadePet
            // 
            IdadePet.DataPropertyName = "_idade";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            IdadePet.DefaultCellStyle = dataGridViewCellStyle3;
            IdadePet.HeaderText = "Idade";
            IdadePet.MinimumWidth = 6;
            IdadePet.Name = "IdadePet";
            IdadePet.Width = 60;
            // 
            // EspeciePet
            // 
            EspeciePet.DataPropertyName = "_especie";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EspeciePet.DefaultCellStyle = dataGridViewCellStyle4;
            EspeciePet.HeaderText = "Espécie";
            EspeciePet.MinimumWidth = 6;
            EspeciePet.Name = "EspeciePet";
            EspeciePet.Width = 125;
            // 
            // RacaPet
            // 
            RacaPet.DataPropertyName = "_raca";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            RacaPet.DefaultCellStyle = dataGridViewCellStyle5;
            RacaPet.HeaderText = "Raça";
            RacaPet.MinimumWidth = 6;
            RacaPet.Name = "RacaPet";
            RacaPet.Width = 125;
            // 
            // DonoPet
            // 
            DonoPet.DataPropertyName = "_fkIdDono";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DonoPet.DefaultCellStyle = dataGridViewCellStyle6;
            DonoPet.HeaderText = "ID Dono";
            DonoPet.MinimumWidth = 6;
            DonoPet.Name = "DonoPet";
            DonoPet.Width = 125;
            // 
            // iconPetShop
            // 
            iconPetShop.BackColor = Color.SaddleBrown;
            iconPetShop.Image = (Image)resources.GetObject("iconPetShop.Image");
            iconPetShop.Location = new Point(557, 30);
            iconPetShop.Name = "iconPetShop";
            iconPetShop.Size = new Size(32, 44);
            iconPetShop.SizeMode = PictureBoxSizeMode.Zoom;
            iconPetShop.TabIndex = 46;
            iconPetShop.TabStop = false;
            // 
            // lbPetCadastrado
            // 
            lbPetCadastrado.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPetCadastrado.ForeColor = SystemColors.Control;
            lbPetCadastrado.Location = new Point(237, 21);
            lbPetCadastrado.Name = "lbPetCadastrado";
            lbPetCadastrado.Size = new Size(327, 64);
            lbPetCadastrado.TabIndex = 45;
            lbPetCadastrado.Text = "PETS CADASTRADOS";
            lbPetCadastrado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btLimparGridPet
            // 
            btLimparGridPet.BackColor = Color.Peru;
            btLimparGridPet.Image = (Image)resources.GetObject("btLimparGridPet.Image");
            btLimparGridPet.Location = new Point(416, 98);
            btLimparGridPet.Name = "btLimparGridPet";
            btLimparGridPet.Size = new Size(63, 60);
            btLimparGridPet.TabIndex = 17;
            btLimparGridPet.UseVisualStyleBackColor = false;
            btLimparGridPet.Click += btLimparGridPet_Click;
            // 
            // ListaPets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(btLimparGridPet);
            Controls.Add(btEditarPet);
            Controls.Add(btExcluirPet);
            Controls.Add(btPesquisaPet);
            Controls.Add(dtgListPets);
            Controls.Add(iconPetShop);
            Controls.Add(lbPetCadastrado);
            Name = "ListaPets";
            Text = "ListaPets";
            ((System.ComponentModel.ISupportInitialize)dtgListPets).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPetShop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btEditarPet;
        private Button btExcluirPet;
        private Button btPesquisaPet;
        private DataGridView dtgListPets;
        private PictureBox iconPetShop;
        private Label lbPetCadastrado;
        private Button btLimparGridPet;
        private DataGridViewTextBoxColumn IdPet;
        private DataGridViewTextBoxColumn NomePet;
        private DataGridViewTextBoxColumn IdadePet;
        private DataGridViewTextBoxColumn EspeciePet;
        private DataGridViewTextBoxColumn RacaPet;
        private DataGridViewTextBoxColumn DonoPet;
    }
}