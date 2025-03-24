namespace SchoolLibrary
{
    partial class user
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sourceBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİadeEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblControl = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Button();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.txtIdstudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceBookToolStripMenuItem,
            this.kitapVerToolStripMenuItem,
            this.kitapİadeEtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sourceBookToolStripMenuItem
            // 
            this.sourceBookToolStripMenuItem.Name = "sourceBookToolStripMenuItem";
            this.sourceBookToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.sourceBookToolStripMenuItem.Text = "Source Book";
            this.sourceBookToolStripMenuItem.Click += new System.EventHandler(this.sourceBookToolStripMenuItem_Click);
            // 
            // kitapVerToolStripMenuItem
            // 
            this.kitapVerToolStripMenuItem.Name = "kitapVerToolStripMenuItem";
            this.kitapVerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.kitapVerToolStripMenuItem.Text = "Kitap Ver";
            this.kitapVerToolStripMenuItem.Click += new System.EventHandler(this.kitapVerToolStripMenuItem_Click);
            // 
            // kitapİadeEtToolStripMenuItem
            // 
            this.kitapİadeEtToolStripMenuItem.Name = "kitapİadeEtToolStripMenuItem";
            this.kitapİadeEtToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.kitapİadeEtToolStripMenuItem.Text = "Kitap iade et";
            this.kitapİadeEtToolStripMenuItem.Click += new System.EventHandler(this.kitapİadeEtToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblControl);
            this.groupBox1.Controls.Add(this.btnControl);
            this.groupBox1.Controls.Add(this.txtControl);
            this.groupBox1.Location = new System.Drawing.Point(39, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(85, 31);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(30, 13);
            this.lblControl.TabIndex = 2;
            this.lblControl.Text = "İsbn ";
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(103, 85);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(75, 23);
            this.btnControl.TabIndex = 1;
            this.btnControl.Text = "Control";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(88, 47);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(100, 20);
            this.txtControl.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.Id);
            this.groupBox2.Controls.Add(this.txtIdstudent);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(325, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 197);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 197);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "İsbn ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kitabı ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(85, 69);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 4;
            this.Id.Text = "Id";
            // 
            // txtIdstudent
            // 
            this.txtIdstudent.Location = new System.Drawing.Point(88, 85);
            this.txtIdstudent.Name = "txtIdstudent";
            this.txtIdstudent.Size = new System.Drawing.Size(100, 20);
            this.txtIdstudent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsbn ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kitabı ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sourceBookToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtIdstudent;
        private System.Windows.Forms.ToolStripMenuItem kitapVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİadeEtToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
    }
}