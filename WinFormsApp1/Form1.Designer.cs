
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
            components = new System.ComponentModel.Container();
            richChatBox = new TextBox();
            logo = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chatDisplay = new RichTextBox();
            inputBox = new TextBox();
            sendButton = new Button();
            tabPage2 = new TabPage();
            btnDeleteTask = new Button();
            btnCompleteTask = new Button();
            dgvTasks = new DataGridView();
            btnAddTask = new Button();
            dtpReminder = new DateTimePicker();
            label5 = new Label();
            txtTaskDesc = new TextBox();
            label4 = new Label();
            txtTaskTitle = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            picResultGif = new PictureBox();
            btnRestartQuiz = new Button();
            lblFeedback = new Label();
            lblScore = new Label();
            btnSubmitAnswer = new Button();
            radOptionD = new RadioButton();
            radOptionC = new RadioButton();
            radOptionB = new RadioButton();
            radOptionA = new RadioButton();
            lblQuestion = new Label();
            tabPage4 = new TabPage();
            lstActivityLog = new ListBox();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picResultGif).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // richChatBox
            // 
            richChatBox.AccessibleName = "inputBox";
            richChatBox.BackColor = SystemColors.ActiveCaption;
            richChatBox.Location = new Point(434, 88);
            richChatBox.Margin = new Padding(3, 4, 3, 4);
            richChatBox.MaximumSize = new Size(297, 4);
            richChatBox.MinimumSize = new Size(914, 732);
            richChatBox.Multiline = true;
            richChatBox.Name = "richChatBox";
            richChatBox.ReadOnly = true;
            richChatBox.ScrollBars = ScrollBars.Vertical;
            richChatBox.Size = new Size(914, 732);
            richChatBox.TabIndex = 5;
            richChatBox.TextChanged += richChatBox_TextChanged;
            richChatBox.KeyDown += InputBox_KeyDown;
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
            tabPage1.Controls.Add(chatDisplay);
            tabPage1.Controls.Add(inputBox);
            tabPage1.Controls.Add(sendButton);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 699);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ChatBot";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // chatDisplay
            // 
            chatDisplay.Location = new Point(17, 39);
            chatDisplay.Name = "chatDisplay";
            chatDisplay.ReadOnly = true;
            chatDisplay.ScrollBars = RichTextBoxScrollBars.Vertical;
            chatDisplay.Size = new Size(865, 574);
            chatDisplay.TabIndex = 7;
            chatDisplay.Text = "";
            // 
            // inputBox
            // 
            inputBox.AccessibleName = "richChatBox";
            inputBox.BackColor = SystemColors.ActiveCaption;
            inputBox.Location = new Point(17, 653);
            inputBox.Margin = new Padding(3, 4, 3, 4);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(706, 27);
            inputBox.TabIndex = 6;
            inputBox.KeyDown += InputBox_KeyDown;
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
            sendButton.Click += SendMessage;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteTask);
            tabPage2.Controls.Add(btnCompleteTask);
            tabPage2.Controls.Add(dgvTasks);
            tabPage2.Controls.Add(btnAddTask);
            tabPage2.Controls.Add(dtpReminder);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtTaskDesc);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtTaskTitle);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 699);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Task Manager ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(721, 389);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(103, 29);
            btnDeleteTask.TabIndex = 9;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.Location = new Point(542, 389);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(134, 29);
            btnCompleteTask.TabIndex = 8;
            btnCompleteTask.Text = "Mark Completed";
            btnCompleteTask.UseVisualStyleBackColor = true;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(503, 14);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(382, 329);
            dgvTasks.TabIndex = 7;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(30, 477);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(94, 29);
            btnAddTask.TabIndex = 6;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dtpReminder
            // 
            dtpReminder.Location = new Point(160, 386);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.ShowCheckBox = true;
            dtpReminder.Size = new Size(250, 27);
            dtpReminder.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 393);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 4;
            label5.Text = "Reminder Date";
            // 
            // txtTaskDesc
            // 
            txtTaskDesc.Location = new Point(160, 78);
            txtTaskDesc.Multiline = true;
            txtTaskDesc.Name = "txtTaskDesc";
            txtTaskDesc.Size = new Size(267, 246);
            txtTaskDesc.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 78);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 2;
            label4.Text = "Description";
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(160, 14);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(125, 27);
            txtTaskTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 21);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Task Title";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(picResultGif);
            tabPage3.Controls.Add(btnRestartQuiz);
            tabPage3.Controls.Add(lblFeedback);
            tabPage3.Controls.Add(lblScore);
            tabPage3.Controls.Add(btnSubmitAnswer);
            tabPage3.Controls.Add(radOptionD);
            tabPage3.Controls.Add(radOptionC);
            tabPage3.Controls.Add(radOptionB);
            tabPage3.Controls.Add(radOptionA);
            tabPage3.Controls.Add(lblQuestion);
            tabPage3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(906, 699);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cyber Quiz";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // picResultGif
            // 
            picResultGif.Location = new Point(29, 437);
            picResultGif.Name = "picResultGif";
            picResultGif.Size = new Size(214, 200);
            picResultGif.SizeMode = PictureBoxSizeMode.Zoom;
            picResultGif.TabIndex = 9;
            picResultGif.TabStop = false;
            picResultGif.Visible = false;
            picResultGif.Click += picResultGif_Click;
            // 
            // btnRestartQuiz
            // 
            btnRestartQuiz.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnRestartQuiz.Location = new Point(22, 643);
            btnRestartQuiz.Name = "btnRestartQuiz";
            btnRestartQuiz.Size = new Size(130, 36);
            btnRestartQuiz.TabIndex = 8;
            btnRestartQuiz.Text = "Restart Quiz";
            btnRestartQuiz.UseVisualStyleBackColor = true;
            btnRestartQuiz.Click += btnRestartQuiz_Click;
            // 
            // lblFeedback
            // 
            lblFeedback.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblFeedback.ForeColor = SystemColors.ControlDarkDark;
            lblFeedback.Location = new Point(29, 358);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(700, 72);
            lblFeedback.TabIndex = 7;
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblScore.Location = new Point(393, 652);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(86, 36);
            lblScore.TabIndex = 6;
            lblScore.Text = "Score: 0";
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSubmitAnswer.Location = new Point(188, 643);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(148, 36);
            btnSubmitAnswer.TabIndex = 5;
            btnSubmitAnswer.Text = "Submit Answer";
            btnSubmitAnswer.UseVisualStyleBackColor = true;
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // radOptionD
            // 
            radOptionD.AutoSize = true;
            radOptionD.Location = new Point(29, 321);
            radOptionD.Name = "radOptionD";
            radOptionD.Size = new Size(17, 16);
            radOptionD.TabIndex = 4;
            radOptionD.UseVisualStyleBackColor = true;
            // 
            // radOptionC
            // 
            radOptionC.AutoSize = true;
            radOptionC.Location = new Point(29, 272);
            radOptionC.Name = "radOptionC";
            radOptionC.Size = new Size(17, 16);
            radOptionC.TabIndex = 3;
            radOptionC.UseVisualStyleBackColor = true;
            // 
            // radOptionB
            // 
            radOptionB.AutoSize = true;
            radOptionB.Location = new Point(29, 228);
            radOptionB.Name = "radOptionB";
            radOptionB.Size = new Size(17, 16);
            radOptionB.TabIndex = 2;
            radOptionB.UseVisualStyleBackColor = true;
            // 
            // radOptionA
            // 
            radOptionA.AutoSize = true;
            radOptionA.Checked = true;
            radOptionA.Location = new Point(29, 178);
            radOptionA.Name = "radOptionA";
            radOptionA.Size = new Size(17, 16);
            radOptionA.TabIndex = 1;
            radOptionA.TabStop = true;
            radOptionA.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblQuestion.Location = new Point(22, 22);
            lblQuestion.MaximumSize = new Size(700, 700);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(700, 137);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question will appear here...";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lstActivityLog);
            tabPage4.Controls.Add(label3);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(906, 699);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Activity Log";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstActivityLog
            // 
            lstActivityLog.FormattingEnabled = true;
            lstActivityLog.Location = new Point(42, 102);
            lstActivityLog.Name = "lstActivityLog";
            lstActivityLog.Size = new Size(810, 544);
            lstActivityLog.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(130, 60);
            label3.TabIndex = 0;
            label3.Text = "Recent Bot Actions:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            Controls.Add(richChatBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Zamaswasi Cybersecurity AwarenessBot";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picResultGif).EndInit();
            tabPage4.ResumeLayout(false);
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
        private TextBox richChatBox;
        private PictureBox logo;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox inputBox;
        private Button sendButton;
        private Label lblQuestion;
        private RadioButton radOptionD;
        private RadioButton radOptionC;
        private RadioButton radOptionB;
        private RadioButton radOptionA;
        private Button btnSubmitAnswer;
        private Label lblScore;
        private Label lblFeedback;
        private Button btnRestartQuiz;
        private PictureBox picResultGif;
        private ListBox lstActivityLog;
        private Label label3;
        private TextBox txtTaskTitle;
        private Label label2;
        private DateTimePicker dtpReminder;
        private Label label5;
        private TextBox txtTaskDesc;
        private Label label4;
        private DataGridView dgvTasks;
        private Button btnAddTask;
        private Button btnCompleteTask;
        private Button btnDeleteTask;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox chatDisplay;
    }
}
