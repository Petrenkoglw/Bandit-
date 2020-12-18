namespace One_HandedBandit
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.rotate1 = new System.Windows.Forms.Timer(this.components);
            this.rotate2 = new System.Windows.Forms.Timer(this.components);
            this.rotate3 = new System.Windows.Forms.Timer(this.components);
            this.stop1 = new System.Windows.Forms.Timer(this.components);
            this.stop2 = new System.Windows.Forms.Timer(this.components);
            this.stop3 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.balanceBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.button, "button");
            this.button.Name = "button";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // n1
            // 
            resources.ApplyResources(this.n1, "n1");
            this.n1.BackColor = System.Drawing.Color.Firebrick;
            this.n1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n1.ForeColor = System.Drawing.Color.Gainsboro;
            this.n1.Name = "n1";
            this.n1.Click += new System.EventHandler(this.label1_Click);
            // 
            // n2
            // 
            resources.ApplyResources(this.n2, "n2");
            this.n2.BackColor = System.Drawing.Color.Firebrick;
            this.n2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n2.ForeColor = System.Drawing.Color.Gainsboro;
            this.n2.Name = "n2";
            this.n2.Click += new System.EventHandler(this.label2_Click);
            // 
            // n3
            // 
            resources.ApplyResources(this.n3, "n3");
            this.n3.BackColor = System.Drawing.Color.Firebrick;
            this.n3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n3.ForeColor = System.Drawing.Color.Gainsboro;
            this.n3.Name = "n3";
            this.n3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rotate1
            // 
            this.rotate1.Interval = 15;
            this.rotate1.Tick += new System.EventHandler(this.rotate1_Tick);
            // 
            // rotate2
            // 
            this.rotate2.Interval = 30;
            this.rotate2.Tick += new System.EventHandler(this.rotate2_Tick);
            // 
            // rotate3
            // 
            this.rotate3.Interval = 40;
            this.rotate3.Tick += new System.EventHandler(this.rotate3_Tick);
            // 
            // stop1
            // 
            this.stop1.Interval = 2000;
            this.stop1.Tick += new System.EventHandler(this.stop1_Tick);
            // 
            // stop2
            // 
            this.stop2.Interval = 3450;
            this.stop2.Tick += new System.EventHandler(this.stop2_Tick);
            // 
            // stop3
            // 
            this.stop3.Interval = 4200;
            this.stop3.Tick += new System.EventHandler(this.stop3_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // balanceBox
            // 
            resources.ApplyResources(this.balanceBox, "balanceBox");
            this.balanceBox.BackColor = System.Drawing.Color.Black;
            this.balanceBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balanceBox.Name = "balanceBox";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.button);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Timer rotate1;
        private System.Windows.Forms.Timer rotate2;
        private System.Windows.Forms.Timer rotate3;
        private System.Windows.Forms.Timer stop1;
        private System.Windows.Forms.Timer stop2;
        private System.Windows.Forms.Timer stop3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label balanceBox;
    }
}

