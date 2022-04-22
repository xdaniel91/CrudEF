namespace CrudWF.Forms
{
    partial class FrmPersons
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_searchbyname = new System.Windows.Forms.TextBox();
            this.btn_searchbyname = new System.Windows.Forms.Button();
            this.lbl_personregister = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persons)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_searchbyname
            // 
            this.txt_searchbyname.Location = new System.Drawing.Point(167, 189);
            this.txt_searchbyname.Name = "txt_searchbyname";
            this.txt_searchbyname.Size = new System.Drawing.Size(508, 23);
            this.txt_searchbyname.TabIndex = 19;
            // 
            // btn_searchbyname
            // 
            this.btn_searchbyname.Location = new System.Drawing.Point(681, 192);
            this.btn_searchbyname.Name = "btn_searchbyname";
            this.btn_searchbyname.Size = new System.Drawing.Size(112, 23);
            this.btn_searchbyname.TabIndex = 23;
            this.btn_searchbyname.Text = "Buscar por nome";
            this.btn_searchbyname.UseVisualStyleBackColor = true;
            this.btn_searchbyname.Click += new System.EventHandler(this.btn_searchbyname_Click);
            // 
            // lbl_personregister
            // 
            this.lbl_personregister.AutoSize = true;
            this.lbl_personregister.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbl_personregister.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_personregister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_personregister.Location = new System.Drawing.Point(213, -73);
            this.lbl_personregister.Name = "lbl_personregister";
            this.lbl_personregister.Size = new System.Drawing.Size(207, 28);
            this.lbl_personregister.TabIndex = 22;
            this.lbl_personregister.Text = "Person register";
            // 
            // btn_searchperson
            // 
            this.btn_searchperson.Location = new System.Drawing.Point(681, 166);
            this.btn_searchperson.Name = "btn_searchperson";
            this.btn_searchperson.Size = new System.Drawing.Size(112, 23);
            this.btn_searchperson.TabIndex = 21;
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
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 161);
            this.groupBox1.TabIndex = 20;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_persons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgv_persons.Location = new System.Drawing.Point(15, 215);
            this.dgv_persons.MultiSelect = false;
            this.dgv_persons.Name = "dgv_persons";
            this.dgv_persons.ReadOnly = true;
            this.dgv_persons.RowHeadersVisible = false;
            this.dgv_persons.RowTemplate.Height = 25;
            this.dgv_persons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_persons.Size = new System.Drawing.Size(789, 429);
            this.dgv_persons.TabIndex = 18;
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
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Birthdate.DefaultCellStyle = dataGridViewCellStyle2;
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
            // FrmPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_searchbyname);
            this.Controls.Add(this.btn_searchbyname);
            this.Controls.Add(this.lbl_personregister);
            this.Controls.Add(this.btn_searchperson);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_persons);
            this.Name = "FrmPersons";
            this.Size = new System.Drawing.Size(1037, 706);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_persons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_searchbyname;
        private Button btn_searchbyname;
        private Label lbl_personregister;
        private Button btn_searchperson;
        private GroupBox groupBox1;
        private Label lbl_birthdate;
        private DateTimePicker datepicket_birthdate;
        private MaskedTextBox txt_cpf;
        private Label lbl_cpf;
        private Button btn_deleteperson;
        private Button btn_saveperson;
        private Label lbl_firstname;
        private Label lbl_lastname;
        private TextBox txt_lastname;
        private TextBox txt_firstname;
        private DataGridView dgv_persons;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Birthdate;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
    }
}
