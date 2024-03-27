
namespace Entertainment_Center_Database_Project
{
    partial class Checkout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.dv = new System.Windows.Forms.DataGridView();
            this.myDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet2 = new Entertainment_Center_Database_Project.myDBDataSet2();
            this.btn_load = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_paymnt = new System.Windows.Forms.TextBox();
            this.txt_ttlamount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dv
            // 
            this.dv.AutoGenerateColumns = false;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.DataSource = this.myDBDataSet2BindingSource;
            this.dv.Location = new System.Drawing.Point(447, 223);
            this.dv.Name = "dv";
            this.dv.RowHeadersWidth = 51;
            this.dv.RowTemplate.Height = 24;
            this.dv.Size = new System.Drawing.Size(240, 150);
            this.dv.TabIndex = 0;
            // 
            // myDBDataSet2BindingSource
            // 
            this.myDBDataSet2BindingSource.DataSource = this.myDBDataSet2;
            this.myDBDataSet2BindingSource.Position = 0;
            // 
            // myDBDataSet2
            // 
            this.myDBDataSet2.DataSetName = "myDBDataSet2";
            this.myDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(490, 389);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(158, 47);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 141);
            this.panel1.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(737, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(51, 29);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Finalize Reservation Details";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(176, 210);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(141, 22);
            this.txt_date.TabIndex = 3;
            this.txt_date.TextChanged += new System.EventHandler(this.txt_date_TextChanged);
            // 
            // txt_paymnt
            // 
            this.txt_paymnt.Location = new System.Drawing.Point(176, 318);
            this.txt_paymnt.Name = "txt_paymnt";
            this.txt_paymnt.Size = new System.Drawing.Size(141, 22);
            this.txt_paymnt.TabIndex = 4;
            // 
            // txt_ttlamount
            // 
            this.txt_ttlamount.Location = new System.Drawing.Point(176, 426);
            this.txt_ttlamount.Name = "txt_ttlamount";
            this.txt_ttlamount.Size = new System.Drawing.Size(141, 22);
            this.txt_ttlamount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Payement Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Amount";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(176, 490);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(144, 41);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ttlamount);
            this.Controls.Add(this.txt_paymnt);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.BindingSource myDBDataSet2BindingSource;
        private myDBDataSet2 myDBDataSet2;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_paymnt;
        private System.Windows.Forms.TextBox txt_ttlamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_exit;
    }
}