namespace CrudWF
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.group_dados = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_searchperson = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.btn_deleteperson = new System.Windows.Forms.Button();
            this.btn_saveperson = new System.Windows.Forms.Button();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.dgv_persons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.group_dados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.AllowUserToResizeRows = false;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_products.Location = new System.Drawing.Point(12, 184);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.RowHeadersVisible = false;
            this.dgv_products.RowTemplate.Height = 25;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(526, 429);
            this.dgv_products.TabIndex = 0;
            this.dgv_products.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellDoubleClick);
            // 
            // group_dados
            // 
            this.group_dados.Controls.Add(this.btn_delete);
            this.group_dados.Controls.Add(this.btn_save);
            this.group_dados.Controls.Add(this.lbl_description);
            this.group_dados.Controls.Add(this.lbl_price);
            this.group_dados.Controls.Add(this.txt_price);
            this.group_dados.Controls.Add(this.txt_description);
            this.group_dados.Location = new System.Drawing.Point(12, 17);
            this.group_dados.Name = "group_dados";
            this.group_dados.Size = new System.Drawing.Size(323, 161);
            this.group_dados.TabIndex = 2;
            this.group_dados.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(247, 132);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(149, 132);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(6, 34);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(66, 15);
            this.lbl_description.TabIndex = 8;
            this.lbl_description.Text = "description";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(6, 68);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(33, 15);
            this.lbl_price.TabIndex = 7;
            this.lbl_price.Text = "price";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(79, 60);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(67, 23);
            this.txt_price.TabIndex = 2;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(79, 31);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(149, 23);
            this.txt_description.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(444, 155);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Buscar todos";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_searchperson
            // 
            this.btn_searchperson.Location = new System.Drawing.Point(1116, 155);
            this.btn_searchperson.Name = "btn_searchperson";
            this.btn_searchperson.Size = new System.Drawing.Size(84, 23);
            this.btn_searchperson.TabIndex = 14;
            this.btn_searchperson.Text = "Buscar todos";
            this.btn_searchperson.UseVisualStyleBackColor = true;
            this.btn_searchperson.Click += new System.EventHandler(this.btn_searchperson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.lbl_cpf);
            this.groupBox1.Controls.Add(this.btn_deleteperson);
            this.groupBox1.Controls.Add(this.btn_saveperson);
            this.groupBox1.Controls.Add(this.lbl_firstname);
            this.groupBox1.Controls.Add(this.lbl_lastname);
            this.groupBox1.Controls.Add(this.txt_lastname);
            this.groupBox1.Controls.Add(this.txt_firstname);
            this.groupBox1.Location = new System.Drawing.Point(592, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 161);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(79, 107);
            this.txt_cpf.Mask = "00000000000";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(77, 23);
            this.txt_cpf.TabIndex = 17;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(6, 110);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(24, 15);
            this.lbl_cpf.TabIndex = 15;
            this.lbl_cpf.Text = "cpf";
            // 
            // btn_deleteperson
            // 
            this.btn_deleteperson.Location = new System.Drawing.Point(291, 132);
            this.btn_deleteperson.Name = "btn_deleteperson";
            this.btn_deleteperson.Size = new System.Drawing.Size(56, 23);
            this.btn_deleteperson.TabIndex = 10;
            this.btn_deleteperson.Text = "delete";
            this.btn_deleteperson.UseVisualStyleBackColor = true;
            this.btn_deleteperson.Click += new System.EventHandler(this.btn_deleteperson_Click);
            // 
            // btn_saveperson
            // 
            this.btn_saveperson.Location = new System.Drawing.Point(203, 132);
            this.btn_saveperson.Name = "btn_saveperson";
            this.btn_saveperson.Size = new System.Drawing.Size(56, 23);
            this.btn_saveperson.TabIndex = 9;
            this.btn_saveperson.Text = "save";
            this.btn_saveperson.UseVisualStyleBackColor = true;
            this.btn_saveperson.Click += new System.EventHandler(this.btn_saveperson_Click);
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(6, 39);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(60, 15);
            this.lbl_firstname.TabIndex = 8;
            this.lbl_firstname.Text = "frist name";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(8, 81);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(58, 15);
            this.lbl_lastname.TabIndex = 7;
            this.lbl_lastname.Text = "last name";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(81, 73);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(67, 23);
            this.txt_lastname.TabIndex = 2;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(79, 36);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(149, 23);
            this.txt_firstname.TabIndex = 1;
            // 
            // dgv_persons
            // 
            this.dgv_persons.AllowUserToAddRows = false;
            this.dgv_persons.AllowUserToDeleteRows = false;
            this.dgv_persons.AllowUserToResizeRows = false;
            this.dgv_persons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_persons.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_persons.Location = new System.Drawing.Point(592, 184);
            this.dgv_persons.Name = "dgv_persons";
            this.dgv_persons.ReadOnly = true;
            this.dgv_persons.RowHeadersVisible = false;
            this.dgv_persons.RowTemplate.Height = 25;
            this.dgv_persons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_persons.Size = new System.Drawing.Size(608, 429);
            this.dgv_persons.TabIndex = 12;
            this.dgv_persons.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_persons_CellDoubleClick);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1217, 625);
            this.Controls.Add(this.btn_searchperson);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_persons);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.group_dados);
            this.Controls.Add(this.dgv_products);
            this.Name = "frm_Main";
            this.Text = "ProductList";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.group_dados.ResumeLayout(false);
            this.group_dados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_products;
        private GroupBox group_dados;
        private TextBox txt_price;
        private TextBox txt_description;
        private Label lbl_description;
        private Label lbl_price;
        private Button btn_delete;
        private Button btn_save;
        private Button btn_search;
        private Button btn_searchperson;
        private GroupBox groupBox1;
        private Button btn_deleteperson;
        private Button btn_saveperson;
        private Label lbl_firstname;
        private Label lbl_lastname;
        private TextBox txt_lastname;
        private TextBox txt_firstname;
        private DataGridView dgv_persons;
        private Label lbl_cpf;
        private MaskedTextBox txt_nascimento;
        private MaskedTextBox txt_cpf;
        private Label lbl_nascimento;
    }
}