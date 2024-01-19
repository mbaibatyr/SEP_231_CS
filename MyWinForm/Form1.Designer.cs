namespace MyWinForm
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
            this.btConfig = new System.Windows.Forms.Button();
            this.lbConfig = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbParam = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(529, 12);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(145, 23);
            this.btConfig.TabIndex = 0;
            this.btConfig.Text = "Load Config";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbConfig
            // 
            this.lbConfig.FormattingEnabled = true;
            this.lbConfig.ItemHeight = 15;
            this.lbConfig.Location = new System.Drawing.Point(2, 0);
            this.lbConfig.Name = "lbConfig";
            this.lbConfig.Size = new System.Drawing.Size(304, 529);
            this.lbConfig.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbParam
            // 
            this.tbParam.Location = new System.Drawing.Point(405, 63);
            this.tbParam.Name = "tbParam";
            this.tbParam.Size = new System.Drawing.Size(100, 23);
            this.tbParam.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "From Config";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "To Log";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 607);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbParam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbConfig);
            this.Controls.Add(this.btConfig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btConfig;
        private ListBox lbConfig;
        private Button button1;
        private TextBox tbParam;
        private Button button2;
        private Button button3;
    }
}