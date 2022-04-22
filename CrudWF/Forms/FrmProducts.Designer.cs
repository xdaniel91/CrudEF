namespace CrudWF
{
    partial class FrmProducts
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
            this.lbl_productregister = new System.Windows.Forms.Label();
            this.txt_nameproduct = new System.Windows.Forms.TextBox();
            this.btn_searchbydescription = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.group_dados.SuspendLayout();
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
            this.Controls.Add(this.lbl_productregister);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.group_dados);
            this.Controls.Add(this.dgv_products);
            this.Name = "frm_Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.group_dados.ResumeLayout(false);
            this.group_dados.PerformLayout();
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
        private MaskedTextBox txt_nascimento;
        private Label lbl_nascimento;
        private Label lbl_productregister;
        private Label lbl_quantity;
        private TextBox txt_quantity;
        private DataGridViewTextBoxColumn IdProduct;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private TextBox txt_nameproduct;
        private Button btn_searchbydescription;
    }
}