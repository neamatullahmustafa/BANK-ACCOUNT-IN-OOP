
namespace encrypte_1
{
    partial class Form1
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
            this.kay = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.encrypted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // kay
            // 
            this.kay.BackColor = System.Drawing.Color.Maroon;
            this.kay.Location = new System.Drawing.Point(75, 150);
            this.kay.Name = "kay";
            this.kay.Size = new System.Drawing.Size(500, 53);
            this.kay.TabIndex = 0;
            this.kay.TextChanged += new System.EventHandler(this.kay_TextChanged);
            this.kay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kay_KeyPress);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Maroon;
            this.message.Location = new System.Drawing.Point(75, 275);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(900, 53);
            this.message.TabIndex = 1;
            this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
            this.message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.message_KeyPress);
            // 
            // encrypted
            // 
            this.encrypted.BackColor = System.Drawing.Color.Maroon;
            this.encrypted.Location = new System.Drawing.Point(75, 400);
            this.encrypted.Name = "encrypted";
            this.encrypted.Size = new System.Drawing.Size(900, 53);
            this.encrypted.TabIndex = 2;
            this.encrypted.TextChanged += new System.EventHandler(this.encrypted_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "kay :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "message :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "encrypted message :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(940, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(885, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Minimize);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button2_KeyPress);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel1.Location = new System.Drawing.Point(10, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(260, 45);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Encryption App";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encrypted);
            this.Controls.Add(this.message);
            this.Controls.Add(this.kay);
            this.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "encryotion app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kay;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox encrypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

