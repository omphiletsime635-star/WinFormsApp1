
namespace WinFormsApp1
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
            chatBox = new TextBox();
            logo = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            inputBox = new TextBox();
            sendButton = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // chatBox
            // 
            chatBox.AccessibleName = "inputBox";
            chatBox.BackColor = SystemColors.ActiveCaption;
            chatBox.Location = new Point(434, 88);
            chatBox.Margin = new Padding(3, 4, 3, 4);
            chatBox.MaximumSize = new Size(297, 4);
            chatBox.MinimumSize = new Size(914, 732);
            chatBox.Multiline = true;
            chatBox.Name = "chatBox";
            chatBox.ReadOnly = true;
            chatBox.ScrollBars = ScrollBars.Vertical;
            chatBox.Size = new Size(914, 732);
            chatBox.TabIndex = 5;
            chatBox.TextChanged += chatBox_TextChanged;
            chatBox.KeyDown += InputBox_KeyDown;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(14, 16);
            logo.Margin = new Padding(3, 4, 3, 4);
            logo.Name = "logo";
            logo.Size = new Size(394, 805);
            logo.TabIndex = 6;
            logo.TabStop = false;
            logo.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(793, 41);
            label1.Name = "label1";
            label1.Size = new Size(283, 20);
            label1.TabIndex = 7;
            label1.Text = "ZAMASWASI Cybersecurity AwarenessBot";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(434, 88);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 732);
            tabControl1.TabIndex = 8;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(inputBox);
            tabPage1.Controls.Add(sendButton);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 699);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // inputBox
            // 
            inputBox.AccessibleName = "chatBox";
            inputBox.BackColor = SystemColors.ActiveCaption;
            inputBox.Location = new Point(17, 653);
            inputBox.Margin = new Padding(3, 4, 3, 4);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(706, 27);
            inputBox.TabIndex = 6;
            // 
            // sendButton
            // 
            sendButton.BackColor = SystemColors.ActiveCaption;
            sendButton.Location = new Point(749, 653);
            sendButton.Margin = new Padding(3, 4, 3, 4);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(133, 27);
            sendButton.TabIndex = 5;
            sendButton.Text = "SEND";
            sendButton.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(672, 509);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(672, 509);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(672, 509);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1446, 915);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(logo);
            Controls.Add(chatBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Zamaswasi Cybersecurity AwarenessBot";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #endregion
        private TextBox chatBox;
        private PictureBox logo;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox inputBox;
        private Button sendButton;
    }
}
