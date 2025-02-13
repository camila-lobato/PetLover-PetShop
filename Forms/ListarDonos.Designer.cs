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
            btEditarDono = new Button();
            btExcluirDono = new Button();
            btPesquisaDono = new Button();
            txtPesquisaDono = new TextBox();
            dtgListPets = new DataGridView();
            IdPet = new DataGridViewTextBoxColumn();
            NomePet = new DataGridViewTextBoxColumn();
            TelefoneDono = new DataGridViewTextBoxColumn();
            CpfDono = new DataGridViewTextBoxColumn();
            iconPetShop = new PictureBox();
            lbDonoCadastrado = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgListPets).BeginInit();
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
            btEditarDono.TabIndex = 58;
            btEditarDono.UseVisualStyleBackColor = false;
            // 
            // btExcluirDono
            // 
            btExcluirDono.BackColor = Color.Peru;
            btExcluirDono.Image = (Image)resources.GetObject("btExcluirDono.Image");
            btExcluirDono.Location = new Point(586, 98);
            btExcluirDono.Name = "btExcluirDono";
            btExcluirDono.Size = new Size(63, 60);
            btExcluirDono.TabIndex = 57;
            btExcluirDono.UseVisualStyleBackColor = false;
            // 
            // btPesquisaDono
            // 
            btPesquisaDono.BackColor = Color.Peru;
            btPesquisaDono.Image = (Image)resources.GetObject("btPesquisaDono.Image");
            btPesquisaDono.Location = new Point(501, 98);
            btPesquisaDono.Name = "btPesquisaDono";
            btPesquisaDono.Size = new Size(63, 60);
            btPesquisaDono.TabIndex = 56;
            btPesquisaDono.UseVisualStyleBackColor = false;
            // 
            // txtPesquisaDono
            // 
            txtPesquisaDono.Location = new Point(63, 121);
            txtPesquisaDono.Name = "txtPesquisaDono";
            txtPesquisaDono.Size = new Size(432, 27);
            txtPesquisaDono.TabIndex = 55;
            // 
            // dtgListPets
            // 
            dtgListPets.AllowUserToOrderColumns = true;
            dtgListPets.BackgroundColor = SystemColors.HighlightText;
            dtgListPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListPets.Columns.AddRange(new DataGridViewColumn[] { IdPet, NomePet, TelefoneDono, CpfDono });
            dtgListPets.Location = new Point(64, 175);
            dtgListPets.Name = "dtgListPets";
            dtgListPets.RowHeadersWidth = 51;
            dtgListPets.Size = new Size(673, 254);
            dtgListPets.TabIndex = 54;
            // 
            // IdPet
            // 
            IdPet.FillWeight = 60F;
            IdPet.HeaderText = "ID";
            IdPet.MinimumWidth = 6;
            IdPet.Name = "IdPet";
            IdPet.Width = 60;
            // 
            // NomePet
            // 
            NomePet.HeaderText = "Nome";
            NomePet.MinimumWidth = 6;
            NomePet.Name = "NomePet";
            NomePet.Width = 200;
            // 
            // TelefoneDono
            // 
            TelefoneDono.HeaderText = "Telefone";
            TelefoneDono.MinimumWidth = 6;
            TelefoneDono.Name = "TelefoneDono";
            TelefoneDono.Width = 190;
            // 
            // CpfDono
            // 
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
            // ListarDonos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(btEditarDono);
            Controls.Add(btExcluirDono);
            Controls.Add(btPesquisaDono);
            Controls.Add(txtPesquisaDono);
            Controls.Add(dtgListPets);
            Controls.Add(iconPetShop);
            Controls.Add(lbDonoCadastrado);
            Name = "ListarDonos";
            Text = "ListarDonos";
            ((System.ComponentModel.ISupportInitialize)dtgListPets).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPetShop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEditarDono;
        private Button btExcluirDono;
        private Button btPesquisaDono;
        private TextBox txtPesquisaDono;
        private DataGridView dtgListPets;
        private DataGridViewTextBoxColumn IdPet;
        private DataGridViewTextBoxColumn NomePet;
        private DataGridViewTextBoxColumn TelefoneDono;
        private DataGridViewTextBoxColumn CpfDono;
        private PictureBox iconPetShop;
        private Label lbDonoCadastrado;
    }
}