
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
            sendButton = new Button();
            inputBox = new TextBox();
            chatBox = new TextBox();
            logo = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // sendButton
            // 
            sendButton.BackColor = SystemColors.ActiveCaption;
            sendButton.Location = new Point(1245, 840);
            sendButton.Margin = new Padding(3, 4, 3, 4);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(161, 35);
            sendButton.TabIndex = 0;
            sendButton.Text = "SEND";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += SendMessage;
            // 
            // inputBox
            // 
            inputBox.AccessibleName = "chatBox";
            inputBox.BackColor = SystemColors.ActiveCaption;
            inputBox.Location = new Point(14, 840);
            inputBox.Margin = new Padding(3, 4, 3, 4);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(1223, 27);
            inputBox.TabIndex = 4;
            inputBox.TextChanged += inputBox_TextChanged;
            inputBox.KeyDown += InputBox_KeyDown;
            // 
            // chatBox
            // 
            chatBox.AccessibleName = "inputBox";
            chatBox.BackColor = SystemColors.ActiveCaption;
            chatBox.Location = new Point(430, 88);
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
            // Form1
            // 
            AccessibleName = "Form1";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1446, 915);
            Controls.Add(label1);
            Controls.Add(logo);
            Controls.Add(chatBox);
            Controls.Add(inputBox);
            Controls.Add(sendButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Zamaswasi Cybersecurity AwarenessBot";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
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

        private Button sendButton;
        private TextBox inputBox;
        private TextBox chatBox;
        private PictureBox logo;
        private Label label1;
    }
}
