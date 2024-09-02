namespace Coffeeee
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            CustID = new Label();
            quant = new Label();
            typecof = new Label();
            nameofcof = new Label();
            am = new Label();
            custidtxtbx = new TextBox();
            amounttxtbx = new TextBox();
            cofnamecombo = new ComboBox();
            milktypecombotxtbx = new ComboBox();
            Quantcombo = new ComboBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name_of_Coffee = new DataGridViewTextBoxColumn();
            Type_of_Coffee = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            insbtn = new Button();
            editbtn = new Button();
            exitbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 33);
            label1.TabIndex = 0;
            label1.Text = "Bean There, Drank That ";
            // 
            // CustID
            // 
            CustID.AutoSize = true;
            CustID.BackColor = Color.Transparent;
            CustID.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            CustID.ForeColor = SystemColors.ActiveCaptionText;
            CustID.Location = new Point(12, 80);
            CustID.Name = "CustID";
            CustID.Size = new Size(116, 27);
            CustID.TabIndex = 1;
            CustID.Text = "Customer ID";
            // 
            // quant
            // 
            quant.AutoSize = true;
            quant.BackColor = Color.Transparent;
            quant.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            quant.ForeColor = SystemColors.ActiveCaptionText;
            quant.Location = new Point(12, 230);
            quant.Name = "quant";
            quant.Size = new Size(90, 27);
            quant.TabIndex = 2;
            quant.Text = "Quantity";
            // 
            // typecof
            // 
            typecof.AutoSize = true;
            typecof.BackColor = Color.Transparent;
            typecof.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            typecof.ForeColor = SystemColors.ActiveCaptionText;
            typecof.Location = new Point(12, 176);
            typecof.Name = "typecof";
            typecof.Size = new Size(118, 27);
            typecof.TabIndex = 3;
            typecof.Text = "Type of Milk";
            // 
            // nameofcof
            // 
            nameofcof.AutoSize = true;
            nameofcof.BackColor = Color.Transparent;
            nameofcof.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            nameofcof.ForeColor = SystemColors.ActiveCaptionText;
            nameofcof.Location = new Point(12, 127);
            nameofcof.Name = "nameofcof";
            nameofcof.Size = new Size(140, 27);
            nameofcof.TabIndex = 4;
            nameofcof.Text = "Name Of Coffee";
            // 
            // am
            // 
            am.AutoSize = true;
            am.BackColor = Color.Transparent;
            am.Font = new Font("Segoe Script", 12F, FontStyle.Bold);
            am.ForeColor = SystemColors.ActiveCaptionText;
            am.Location = new Point(12, 284);
            am.Name = "am";
            am.Size = new Size(81, 27);
            am.TabIndex = 5;
            am.Text = "Amount";
            // 
            // custidtxtbx
            // 
            custidtxtbx.Location = new Point(164, 84);
            custidtxtbx.Name = "custidtxtbx";
            custidtxtbx.Size = new Size(148, 23);
            custidtxtbx.TabIndex = 6;
            custidtxtbx.KeyPress += custidtxtbx_KeyPress;
            // 
            // amounttxtbx
            // 
            amounttxtbx.Location = new Point(164, 288);
            amounttxtbx.Name = "amounttxtbx";
            amounttxtbx.Size = new Size(148, 23);
            amounttxtbx.TabIndex = 7;
            // 
            // cofnamecombo
            // 
            cofnamecombo.FormattingEnabled = true;
            cofnamecombo.Items.AddRange(new object[] { "Americano", "Cappuccino", "Latte" });
            cofnamecombo.Location = new Point(164, 131);
            cofnamecombo.Name = "cofnamecombo";
            cofnamecombo.Size = new Size(148, 23);
            cofnamecombo.TabIndex = 10;
            // 
            // milktypecombotxtbx
            // 
            milktypecombotxtbx.FormattingEnabled = true;
            milktypecombotxtbx.Items.AddRange(new object[] { "Hot Milk", "Cold Milk", "No Milk" });
            milktypecombotxtbx.Location = new Point(164, 180);
            milktypecombotxtbx.Name = "milktypecombotxtbx";
            milktypecombotxtbx.Size = new Size(148, 23);
            milktypecombotxtbx.TabIndex = 11;
            // 
            // Quantcombo
            // 
            Quantcombo.FormattingEnabled = true;
            Quantcombo.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            Quantcombo.Location = new Point(164, 234);
            Quantcombo.Name = "Quantcombo";
            Quantcombo.Size = new Size(148, 23);
            Quantcombo.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Name_of_Coffee, Type_of_Coffee, Quantity, Amount });
            dataGridView1.Location = new Point(339, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(550, 315);
            dataGridView1.TabIndex = 13;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Name_of_Coffee
            // 
            Name_of_Coffee.HeaderText = "Name_of_Coffee";
            Name_of_Coffee.Name = "Name_of_Coffee";
            // 
            // Type_of_Coffee
            // 
            Type_of_Coffee.HeaderText = "Type_of_Coffee";
            Type_of_Coffee.Name = "Type_of_Coffee";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // insbtn
            // 
            insbtn.Location = new Point(606, 401);
            insbtn.Name = "insbtn";
            insbtn.RightToLeft = RightToLeft.No;
            insbtn.Size = new Size(75, 23);
            insbtn.TabIndex = 14;
            insbtn.Text = "Insert";
            insbtn.UseVisualStyleBackColor = true;
            insbtn.Click += insbtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(708, 401);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 23);
            editbtn.TabIndex = 15;
            editbtn.Text = "Clear";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += Clrbtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.Location = new Point(814, 401);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(75, 23);
            exitbtn.TabIndex = 16;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_coffee_48;
            pictureBox1.Location = new Point(242, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 430);
            Controls.Add(pictureBox1);
            Controls.Add(exitbtn);
            Controls.Add(editbtn);
            Controls.Add(insbtn);
            Controls.Add(dataGridView1);
            Controls.Add(Quantcombo);
            Controls.Add(milktypecombotxtbx);
            Controls.Add(cofnamecombo);
            Controls.Add(amounttxtbx);
            Controls.Add(custidtxtbx);
            Controls.Add(am);
            Controls.Add(nameofcof);
            Controls.Add(typecof);
            Controls.Add(quant);
            Controls.Add(CustID);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bean There, Drank That";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label CustID;
        private Label quant;
        private Label typecof;
        private Label nameofcof;
        private Label am;
        private TextBox custidtxtbx;
        private TextBox amounttxtbx;
        private ComboBox cofnamecombo;
        private ComboBox milktypecombotxtbx;
        private ComboBox Quantcombo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name_of_Coffee;
        private DataGridViewTextBoxColumn Type_of_Coffee;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private Button insbtn;
        private Button editbtn;
        private Button exitbtn;
        private PictureBox pictureBox1;
    }
}
