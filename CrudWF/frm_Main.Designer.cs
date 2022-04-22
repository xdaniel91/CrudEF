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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_dados = new System.Windows.Forms.GroupBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_searchperson = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.datepicket_birthdate = new System.Windows.Forms.DateTimePicker();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.btn_deleteperson = new System.Windows.Forms.Button();
            this.btn_saveperson = new System.Windows.Forms.Button();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.dgv_persons = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_productregister = new System.Windows.Forms.Label();
            this.lbl_personregister = new System.Windows.Forms.Label();
            this.btn_searchbyname = new System.Windows.Forms.Button();
            this.txt_searchbyname = new System.Windows.Forms.TextBox();
            this.txt_nameproduct = new System.Windows.Forms.TextBox();
            this.btn_searchbydescription = new System.Windows.Forms.Button();
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
            this.dgv_products.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.Description,
            this.Price,
            this.Quantity});
            this.dgv_products.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_products.Location = new System.Drawing.Point(12, 268);
            this.dgv_products.MultiSelect = false;
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.RowHeadersVisible = false;
            this.dgv_products.RowTemplate.Height = 25;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(505, 429);
            this.dgv_products.TabIndex = 0;
            this.dgv_products.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellDoubleClick);
            // 
            // IdProduct
            // 
            this.IdProduct.DataPropertyName = "Id";
            this.IdProduct.HeaderText = "Id";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            this.IdProduct.Width = 90;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle2;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 110;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "AvaliableQuantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // group_dados
            // 
            this.group_dados.Controls.Add(this.lbl_quantity);
            this.group_dados.Controls.Add(this.txt_quantity);
            this.group_dados.Controls.Add(this.btn_delete);
            this.group_dados.Controls.Add(this.btn_save);
            this.group_dados.Controls.Add(this.lbl_description);
            this.group_dados.Controls.Add(this.lbl_price);
            this.group_dados.Controls.Add(this.txt_price);
            this.group_dados.Controls.Add(this.txt_description);
            this.group_dados.Location = new System.Drawing.Point(12, 81);
            this.group_dados.Name = "group_dados";
            this.group_dados.Size = new System.Drawing.Size(305, 161);
            this.group_dados.TabIndex = 2;
            this.group_dados.TabStop = false;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(6, 97);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(51, 15);
            this.lbl_quantity.TabIndex = 12;
            this.lbl_quantity.Text = "quantity";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(79, 89);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(67, 23);
            this.txt_quantity.TabIndex = 11;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(243, 132);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(181, 132);
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
            this.btn_search.Location = new System.Drawing.Point(405, 219);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Buscar todos";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_searchperson
            // 
            this.btn_searchperson.Location = new System.Drawing.Point(1124, 219);
            this.btn_searchperson.Name = "btn_searchperson";
            this.btn_searchperson.Size = new System.Drawing.Size(112, 23);
            this.btn_searchperson.TabIndex = 14;
            this.btn_searchperson.Text = "Buscar todos";
            this.btn_searchperson.UseVisualStyleBackColor = true;
            this.btn_searchperson.Click += new System.EventHandler(this.btn_searchperson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_birthdate);
            this.groupBox1.Controls.Add(this.datepicket_birthdate);
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.lbl_cpf);
            this.groupBox1.Controls.Add(this.btn_deleteperson);
            this.groupBox1.Controls.Add(this.btn_saveperson);
            this.groupBox1.Controls.Add(this.lbl_firstname);
            this.groupBox1.Controls.Add(this.lbl_lastname);
            this.groupBox1.Controls.Add(this.txt_lastname);
            this.groupBox1.Controls.Add(this.txt_firstname);
            this.groupBox1.Location = new System.Drawing.Point(590, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 161);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(8, 136);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(58, 15);
            this.lbl_birthdate.TabIndex = 19;
            this.lbl_birthdate.Text = "Birth date";
            // 
            // datepicket_birthdate
            // 
            this.datepicket_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicket_birthdate.Location = new System.Drawing.Point(109, 130);
            this.datepicket_birthdate.Name = "datepicket_birthdate";
            this.datepicket_birthdate.Size = new System.Drawing.Size(98, 23);
            this.datepicket_birthdate.TabIndex = 18;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(109, 89);
            this.txt_cpf.Mask = "00000000000";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(77, 23);
            this.txt_cpf.TabIndex = 17;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(8, 97);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(24, 15);
            this.lbl_cpf.TabIndex = 15;
            this.lbl_cpf.Text = "cpf";
            // 
            // btn_deleteperson
            // 
            this.btn_deleteperson.Location = new System.Drawing.Point(393, 132);
            this.btn_deleteperson.Name = "btn_deleteperson";
            this.btn_deleteperson.Size = new System.Drawing.Size(56, 23);
            this.btn_deleteperson.TabIndex = 10;
            this.btn_deleteperson.Text = "delete";
            this.btn_deleteperson.UseVisualStyleBackColor = true;
            this.btn_deleteperson.Click += new System.EventHandler(this.btn_deleteperson_Click);
            // 
            // btn_saveperson
            // 
            this.btn_saveperson.Location = new System.Drawing.Point(331, 132);
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
            this.lbl_firstname.Location = new System.Drawing.Point(8, 22);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(60, 15);
            this.lbl_firstname.TabIndex = 8;
            this.lbl_firstname.Text = "frist name";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(8, 60);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(58, 15);
            this.lbl_lastname.TabIndex = 7;
            this.lbl_lastname.Text = "last name";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(109, 57);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(149, 23);
            this.txt_lastname.TabIndex = 2;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(109, 19);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(149, 23);
            this.txt_firstname.TabIndex = 1;
            // 
            // dgv_persons
            // 
            this.dgv_persons.AllowUserToAddRows = false;
            this.dgv_persons.AllowUserToDeleteRows = false;
            this.dgv_persons.AllowUserToResizeRows = false;
            this.dgv_persons.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_persons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_persons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_persons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Age,
            this.Nome,
            this.Cpf,
            this.Birthdate,
            this.FirstName,
            this.LastName});
            this.dgv_persons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_persons.Location = new System.Drawing.Point(590, 268);
            this.dgv_persons.MultiSelect = false;
            this.dgv_persons.Name = "dgv_persons";
            this.dgv_persons.ReadOnly = true;
            this.dgv_persons.RowHeadersVisible = false;
            this.dgv_persons.RowTemplate.Height = 25;
            this.dgv_persons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_persons.Size = new System.Drawing.Size(646, 429);
            this.dgv_persons.TabIndex = 12;
            this.dgv_persons.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_persons_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 90;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "FullName";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Width = 200;
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "BirthDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Birthdate.DefaultCellStyle = dataGridViewCellStyle4;
            this.Birthdate.HeaderText = "Brith date";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Visible = false;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Visible = false;
            // 
            // lbl_productregister
            // 
            this.lbl_productregister.AutoSize = true;
            this.lbl_productregister.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbl_productregister.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_productregister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_productregister.Location = new System.Drawing.Point(18, 9);
            this.lbl_productregister.Name = "lbl_productregister";
            this.lbl_productregister.Size = new System.Drawing.Size(220, 28);
            this.lbl_productregister.TabIndex = 15;
            this.lbl_productregister.Text = "Product register";
            // 
            // lbl_personregister
            // 
            this.lbl_personregister.AutoSize = true;
            this.lbl_personregister.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbl_personregister.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_personregister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_personregister.Location = new System.Drawing.Point(590, 9);
            this.lbl_personregister.Name = "lbl_personregister";
            this.lbl_personregister.Size = new System.Drawing.Size(207, 28);
            this.lbl_personregister.TabIndex = 16;
            this.lbl_personregister.Text = "Person register";
            // 
            // btn_searchbyname
            // 
            this.btn_searchbyname.Location = new System.Drawing.Point(1124, 244);
            this.btn_searchbyname.Name = "btn_searchbyname";
            this.btn_searchbyname.Size = new System.Drawing.Size(112, 23);
            this.btn_searchbyname.TabIndex = 17;
            this.btn_searchbyname.Text = "Buscar por nome";
            this.btn_searchbyname.UseVisualStyleBackColor = true;
            this.btn_searchbyname.Click += new System.EventHandler(this.btn_searchbyname_Click);
            // 
            // txt_searchbyname
            // 
            this.txt_searchbyname.Location = new System.Drawing.Point(590, 245);
            this.txt_searchbyname.Name = "txt_searchbyname";
            this.txt_searchbyname.Size = new System.Drawing.Size(508, 23);
            this.txt_searchbyname.TabIndex = 13;
            // 
            // txt_nameproduct
            // 
            this.txt_nameproduct.Location = new System.Drawing.Point(12, 245);
            this.txt_nameproduct.Name = "txt_nameproduct";
            this.txt_nameproduct.Size = new System.Drawing.Size(369, 23);
            this.txt_nameproduct.TabIndex = 18;
            // 
            // btn_searchbydescription
            // 
            this.btn_searchbydescription.Location = new System.Drawing.Point(405, 245);
            this.btn_searchbydescription.Name = "btn_searchbydescription";
            this.btn_searchbydescription.Size = new System.Drawing.Size(112, 23);
            this.btn_searchbydescription.TabIndex = 19;
            this.btn_searchbydescription.Text = "Buscar por nome";
            this.btn_searchbydescription.UseVisualStyleBackColor = true;
            this.btn_searchbydescription.Click += new System.EventHandler(this.btn_searchbydescription_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1362, 700);
            this.Controls.Add(this.txt_nameproduct);
            this.Controls.Add(this.btn_searchbydescription);
            this.Controls.Add(this.txt_searchbyname);
            this.Controls.Add(this.btn_searchbyname);
            this.Controls.Add(this.lbl_personregister);
            this.Controls.Add(this.lbl_productregister);
            this.Controls.Add(this.btn_searchperson);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_persons);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.group_dados);
            this.Controls.Add(this.dgv_products);
            this.Name = "frm_Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.group_dados.ResumeLayout(false);
            this.group_dados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label lbl_productregister;
        private Label lbl_personregister;
        private Label lbl_quantity;
        private TextBox txt_quantity;
        private DataGridViewTextBoxColumn IdProduct;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DateTimePicker datepicket_birthdate;
        private Label lbl_birthdate;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Birthdate;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private Button btn_searchbyname;
        private TextBox txt_searchbyname;
        private TextBox txt_nameproduct;
        private Button btn_searchbydescription;
    }
}