namespace CrudWF.Forms
{
    partial class FrmMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btn_persons = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_companys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(115, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1427, 763);
            this.tabControl.TabIndex = 0;
            // 
            // btn_persons
            // 
            this.btn_persons.Location = new System.Drawing.Point(7, 31);
            this.btn_persons.Name = "btn_persons";
            this.btn_persons.Size = new System.Drawing.Size(102, 49);
            this.btn_persons.TabIndex = 1;
            this.btn_persons.Text = "Persons";
            this.btn_persons.UseVisualStyleBackColor = true;
            this.btn_persons.Click += new System.EventHandler(this.btn_persons_Click);
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(7, 86);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(102, 49);
            this.btn_products.TabIndex = 2;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_companys
            // 
            this.btn_companys.Location = new System.Drawing.Point(7, 141);
            this.btn_companys.Name = "btn_companys";
            this.btn_companys.Size = new System.Drawing.Size(102, 49);
            this.btn_companys.TabIndex = 3;
            this.btn_companys.Text = "Companies";
            this.btn_companys.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 787);
            this.Controls.Add(this.btn_companys);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_persons);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private Button btn_persons;
        private Button btn_products;
        private Button btn_companys;
    }
}