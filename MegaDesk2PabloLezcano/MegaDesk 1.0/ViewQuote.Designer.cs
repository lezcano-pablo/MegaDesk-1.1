namespace MegaDesk_1._0
{
    partial class ViewQuote
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
            this.nameReceived = new System.Windows.Forms.TextBox();
            this.widthReceived = new System.Windows.Forms.TextBox();
            this.depthReceived = new System.Windows.Forms.TextBox();
            this.drawerReceived = new System.Windows.Forms.TextBox();
            this.materialReceived = new System.Windows.Forms.TextBox();
            this.rushReceived = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameReceived
            // 
            this.nameReceived.Location = new System.Drawing.Point(45, 35);
            this.nameReceived.Name = "nameReceived";
            this.nameReceived.Size = new System.Drawing.Size(217, 20);
            this.nameReceived.TabIndex = 0;
            // 
            // widthReceived
            // 
            this.widthReceived.Location = new System.Drawing.Point(45, 95);
            this.widthReceived.Name = "widthReceived";
            this.widthReceived.Size = new System.Drawing.Size(217, 20);
            this.widthReceived.TabIndex = 1;
            // 
            // depthReceived
            // 
            this.depthReceived.Location = new System.Drawing.Point(45, 143);
            this.depthReceived.Name = "depthReceived";
            this.depthReceived.Size = new System.Drawing.Size(217, 20);
            this.depthReceived.TabIndex = 2;
            // 
            // drawerReceived
            // 
            this.drawerReceived.Location = new System.Drawing.Point(45, 190);
            this.drawerReceived.Name = "drawerReceived";
            this.drawerReceived.Size = new System.Drawing.Size(217, 20);
            this.drawerReceived.TabIndex = 3;
            // 
            // materialReceived
            // 
            this.materialReceived.Location = new System.Drawing.Point(45, 241);
            this.materialReceived.Name = "materialReceived";
            this.materialReceived.Size = new System.Drawing.Size(217, 20);
            this.materialReceived.TabIndex = 4;
            // 
            // rushReceived
            // 
            this.rushReceived.Location = new System.Drawing.Point(45, 294);
            this.rushReceived.Name = "rushReceived";
            this.rushReceived.Size = new System.Drawing.Size(217, 20);
            this.rushReceived.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "WIDTH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DEPTH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "NUMBER OF DRAWERS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MATERIAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "RUSH ORDER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rushReceived);
            this.Controls.Add(this.materialReceived);
            this.Controls.Add(this.drawerReceived);
            this.Controls.Add(this.depthReceived);
            this.Controls.Add(this.widthReceived);
            this.Controls.Add(this.nameReceived);
            this.Name = "ViewQuote";
            this.Text = "ViewQuote";
            this.Load += new System.EventHandler(this.ViewQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameReceived;
        private System.Windows.Forms.TextBox widthReceived;
        private System.Windows.Forms.TextBox depthReceived;
        private System.Windows.Forms.TextBox drawerReceived;
        private System.Windows.Forms.TextBox materialReceived;
        private System.Windows.Forms.TextBox rushReceived;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}