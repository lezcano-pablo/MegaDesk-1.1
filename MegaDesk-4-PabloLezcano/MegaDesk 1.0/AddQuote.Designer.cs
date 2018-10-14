namespace MegaDesk_1._0
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.button1 = new System.Windows.Forms.Button();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numerosOpcion = new System.Windows.Forms.ComboBox();
            this.materialOption = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rushOption = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back to the Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(69, 123);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(84, 20);
            this.DepthBox.TabIndex = 2;
            this.DepthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the WIDTH of the desk in inches (24 min, 96 max)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the DEPTH of the desk in inches (12 min, 48 max)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select the number of DRAWERS";
            // 
            // numerosOpcion
            // 
            this.numerosOpcion.FormattingEnabled = true;
            this.numerosOpcion.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numerosOpcion.Location = new System.Drawing.Point(69, 184);
            this.numerosOpcion.Name = "numerosOpcion";
            this.numerosOpcion.Size = new System.Drawing.Size(121, 21);
            this.numerosOpcion.TabIndex = 7;
            // 
            // materialOption
            // 
            this.materialOption.FormattingEnabled = true;
            this.materialOption.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialOption.Location = new System.Drawing.Point(69, 240);
            this.materialOption.Name = "materialOption";
            this.materialOption.Size = new System.Drawing.Size(121, 21);
            this.materialOption.TabIndex = 8;
            this.materialOption.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select the number the MATERIAL";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter your Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 315);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(69, 30);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(210, 20);
            this.NameBox.TabIndex = 15;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(69, 78);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(84, 20);
            this.widthBox.TabIndex = 16;
            this.widthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthBox_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Rush Order";
            // 
            // rushOption
            // 
            this.rushOption.FormattingEnabled = true;
            this.rushOption.Items.AddRange(new object[] {
            "None",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.rushOption.Location = new System.Drawing.Point(69, 301);
            this.rushOption.Name = "rushOption";
            this.rushOption.Size = new System.Drawing.Size(121, 21);
            this.rushOption.TabIndex = 22;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rushOption);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialOption);
            this.Controls.Add(this.numerosOpcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.button1);
            this.Name = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WidthNumberBox;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox numerosOpcion;
        private System.Windows.Forms.ComboBox materialOption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox rushOption;
    }
}