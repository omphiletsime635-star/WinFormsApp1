using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ChatEngine botEngine;

        // Quiz Variables
        List<QuizQuestion> quizQuestions = new List<QuizQuestion>();
        int currentQuestionIndex = 0;
        int quizScore = 0;

        List<string> activityLog = new List<string>();
        DatabaseHelper db = new DatabaseHelper();

        public Form1()
        {
            InitializeComponent();
            botEngine = new ChatEngine();

            // Load logo if it exists
            string logoPath = Path.Combine(Application.StartupPath, "images", "logo.png");
            if (File.Exists(logoPath))
            {
                logo.Image = Image.FromFile(logoPath);
            }

            // Initial welcome message and play sound
            DisplayWelcomeMessage();

            PlayAudio();
            InitializeQuiz();
            LogActivity("System: Chatbot started and Quiz initialized.");
            LoadTasks();
        }

        private void InitializeQuiz()
        {
            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "1. What should you do if you receive an email asking for your password?",
                Options = new[] { "A) Reply with your password", "B) Delete the email", "C) Report the email as phishing", "D) Ignore it" },
                CorrectAnswerIndex = 2,
                Explanation = "Correct! Reporting phishing emails helps prevent scams and protects others."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "2. True or False: Using the same password for all accounts is safe.",
                Options = new[] { "A) True", "B) False", "C) Only for social media", "D) Only for banking" },
                CorrectAnswerIndex = 1,
                Explanation = "Correct! If one site is breached, attackers will try that password everywhere else (Credential Stuffing)."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "3. What is a common sign of a phishing email?",
                Options = new[] { "A) Good grammar", "B) Urgent language and spelling errors", "C) A personalized greeting", "D) An official logo" },
                CorrectAnswerIndex = 1,
                Explanation = "Correct! Scammers often create a false sense of urgency and make spelling mistakes."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "4. True or False: Public Wi-Fi networks are always secure.",
                Options = new[] { "A) True", "B) False", "C) Only if they have a password", "D) Only in coffee shops" },
                CorrectAnswerIndex = 1,
                Explanation = "Correct! Hackers can intercept data on public Wi-Fi. Use a VPN."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "5. What does 2FA stand for?",
                Options = new[] { "A) Two-Factor Authentication", "B) Two-Faced Admin", "C) Total File Access", "D) Two-File Archive" },
                CorrectAnswerIndex = 0,
                Explanation = "Correct! 2FA adds an extra layer of security beyond just a password."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "6. Which of these is the strongest password?",
                Options = new[] { "A) password123", "B) MyDogName", "C) P@ssw0rd!2024#", "D) 12345678" },
                CorrectAnswerIndex = 2,
                Explanation = "Correct! A mix of uppercase, lowercase, numbers, and symbols is best."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "7. True or False: You should click links in emails to verify if they are real.",
                Options = new[] { "A) True", "B) False", "C) Only from friends", "D) Only from banks" },
                CorrectAnswerIndex = 1,
                Explanation = "Correct! Hover over links first. Never click suspicious links."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "8. What is malware?",
                Options = new[] { "A) Software that improves speed", "B) Malicious software designed to harm", "C) A type of firewall", "D) A secure browser" },
                CorrectAnswerIndex = 1,
                Explanation = "Correct! Malware includes viruses, ransomware, and spyware."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "9. What should you do before disposing of an old computer?",
                Options = new[] { "A) Throw it in the trash", "B) Delete your files", "C) Wipe the hard drive completely", "D) Give it away as is" },
                CorrectAnswerIndex = 2,
                Explanation = "Correct! Simply deleting files doesn't remove them. Wipe the drive."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "10. True or False: Antivirus software is 100% effective against all threats.",
                Options = new[] { "A) True", "B) False", "C) Only if you pay for it", "D) Only on Windows" },
                CorrectAnswerIndex = 1,
                Explanation = "Correct! Antivirus is important, but you still need safe browsing habits."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "11. What is 'shoulder surfing'?",
                Options = new[] { "A) A new extreme sport", "B) Looking over someone's shoulder to steal their PIN or password", "C) A type of firewall", "D) Sending spam emails" },
                CorrectAnswerIndex = 1,
                Explanation = "Correct! Always shield your screen and keypad when in public places."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "12. You get a popup saying all your files are encrypted and you must pay Bitcoin to get them back. What is this?",
                Options = new[] { "A) A standard Windows update", "B) A phishing email", "C) Ransomware", "D) A harmless pop-up ad" },
                CorrectAnswerIndex = 2,
                Explanation = "Correct! Ransomware holds your files hostage. Always keep backups!"
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "13. True or False: If a website has a padlock icon (HTTPS), it means the website is 100% safe and legitimate.",
                Options = new[] { "A) True", "B) False", "C) Only if it's a bank", "D) Only on public Wi-Fi" },
                CorrectAnswerIndex = 1,
                Explanation = "Correct! HTTPS just means the connection is encrypted. Scammers can also get padlocks for their fake websites."
            });

            quizQuestions.Add(new QuizQuestion
            {
                QuestionText = "14. Which of these is the safest thing to post on social media?",
                Options = new[] { "A) Your ID number", "B) A photo of your new pet", "C) Your home address", "D) A photo of your plane ticket" },
                CorrectAnswerIndex = 1,
                Explanation = "Correct! Posting personal info like IDs or travel plans makes you a target for identity theft or break-ins."
            });

            ShowQuestion();
        }

        private void ShowQuestion()
        {
            if (currentQuestionIndex >= quizQuestions.Count)
            {
                lblQuestion.Text = "Quiz Complete!";

                // Hide the radio buttons
                radOptionA.Visible = false; radOptionB.Visible = false;
                radOptionC.Visible = false; radOptionD.Visible = false;
                btnSubmitAnswer.Enabled = false;

                // Show the GIF based on the score
                picResultGif.Visible = true;
                string imagePath = "";

                if (quizScore > 5)
                {
                    lblFeedback.Text = $"Final Score: {quizScore} / {quizQuestions.Count}. Great job! You're a cybersecurity pro!";
                    imagePath = Path.Combine(Application.StartupPath, "images", "win.gif");
                }
                else
                {
                    lblFeedback.Text = $"Final Score: {quizScore} / {quizQuestions.Count}. Keep learning to stay safe online!";
                    imagePath = Path.Combine(Application.StartupPath, "images", "lose.gif");
                }

                // Load the GIF if the file exists
                if (File.Exists(imagePath))
                {
                    picResultGif.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("GIF not found at: " + imagePath);
                }

                return;
            }

            QuizQuestion q = quizQuestions[currentQuestionIndex];
            lblQuestion.Text = q.QuestionText;

            radOptionA.Text = q.Options[0]; radOptionA.Visible = true;
            radOptionB.Text = q.Options[1]; radOptionB.Visible = true;
            radOptionC.Text = q.Options[2]; radOptionC.Visible = true;
            radOptionD.Text = q.Options[3]; radOptionD.Visible = true;

            // Uncheck all radio buttons for the new question
            radOptionA.Checked = false; radOptionB.Checked = false;
            radOptionC.Checked = false; radOptionD.Checked = false;

            // Clear previous feedback and update the score
            lblFeedback.Text = "";
            lblScore.Text = $"Score: {quizScore}";
            btnSubmitAnswer.Text = "Submit Answer";
        }

        private void LogActivity(string action)
        {
            // 1. Create a log entry with the current time (e.g., "[14:35] User started quiz")
            string logEntry = $"[{DateTime.Now:HH:mm}] {action}";

            // 2. Add it to our master list
            activityLog.Add(logEntry);

            // 3. Update the UI ListBox (show only the last 10 so it doesn't get too full)
            lstActivityLog.Items.Clear();
            var recentLogs = activityLog.Skip(Math.Max(0, activityLog.Count - 10)).ToList();

            foreach (var log in recentLogs)
            {
                lstActivityLog.Items.Add(log);
            }
        }

        private void LoadTasks()
        {
            try
            {
                // Get the data from DatabaseHelper
                dgvTasks.DataSource = db.GetAllTasks();
                LogActivity("System: Task list refreshed from database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
        }

        private void DisplayWelcomeMessage()
        {
            chatDisplay.AppendText("Bot: Hello! Welcome to ZAMASWASI Cybersecurity AwarenessBot. I'm here to help you stay safe online. What would you like to know about online safety?\r\n\r\n");
        }

        // Handles the Enter key press in the input box
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMessage(sender, e);
            }
        }

        private void SendMessage(object sender, EventArgs e)
        {
            string question = inputBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(question))
                return;

            // 1. Show the user's message
            chatDisplay.AppendText($"You: {question}\r\n");

            string lowerInput = question.ToLower();

            // --- NLP SIMULATION ROUTING ---

            // Command: Start Quiz
            if (lowerInput.Contains("quiz") || lowerInput.Contains("game") || lowerInput.Contains("test"))
            {
                chatDisplay.AppendText("Bot: Starting the Cybersecurity Quiz for you! Good luck.\r\n\r\n");
                tabControl1.SelectedTab = tabPage3; // Switches to Quiz tab
                LogActivity("User started the Quiz via chat command.");
                inputBox.Clear();
                return;
            }

            // Command: Show Activity Log
            if (lowerInput.Contains("activity log") || lowerInput.Contains("what have you done") || lowerInput.Contains("show log"))
            {
                chatDisplay.AppendText("Bot: Opening the Activity Log. Here is what I've been up to:\r\n\r\n");
                tabControl1.SelectedTab = tabPage4; // Switches to Log tab
                LogActivity("User viewed the Activity Log via chat command.");
                inputBox.Clear();
                return;
            }

            // Command: Task Manager + Smart Task Extraction
            if (lowerInput.Contains("task") || lowerInput.Contains("remind"))
            {
                chatDisplay.AppendText("Bot: Opening the Task Manager for you.\r\n\r\n");
                tabControl1.SelectedTab = tabPage2; // Switches to Task tab

                if (lowerInput.Contains("remind me to"))
                {
                    int startIndex = lowerInput.IndexOf("remind me to") + 13;
                    string extractedTask = question.Substring(startIndex).Trim();
                    txtTaskTitle.Text = extractedTask; // Auto-fills the task title
                    chatDisplay.AppendText($"Bot: I have pre-filled your task: '{extractedTask}'. Please set a date and click Add Task.\r\n\r\n");
                }
                else
                {
                    chatDisplay.AppendText("Bot: You can add your new task here.\r\n\r\n");
                }

                LogActivity("User opened Task Manager via chat command.");
                inputBox.Clear();
                return;
            }

            // --- NORMAL CHATBOT RESPONSE ---
            string answer = botEngine.GetResponse(question);
            chatDisplay.AppendText($"Bot: {answer}\r\n\r\n");
            LogActivity("User chatted with the bot."); // Logs normal chat

            inputBox.Clear();
            inputBox.Focus();
            chatDisplay.SelectionStart = chatDisplay.Text.Length;
            chatDisplay.ScrollToCaret();
        }
        


        private void PlayAudio()
        {
            try
            {
                string audioPath = Path.Combine(Application.StartupPath, "voice", "audio.wav");
                if (File.Exists(audioPath))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(audioPath);
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio could not be played: " + ex.Message);
            }
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("ZAMASWASI Cybersecurity Awareness Bot\n\nI am here to help you learn about online safety, passwords, scams, privacy, and more!",
                            "About ZAMASWASI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Return focus to the input box so the user can type immediately
            inputBox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // When the user clicks the label, automatically place the cursor in the input box
            inputBox.Focus();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            // Left empty intentionally. This is a placeholder for future UI updates.
        }

        private void richChatBox_TextChanged(object sender, EventArgs e)
        {
            // Ensure the chat box always scrolls to the bottom whenever new text is added.
            // This handles the initial welcome message and all bot replies.
            richChatBox.SelectionStart = richChatBox.Text.Length;
            richChatBox.ScrollToCaret();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Left empty intentionally. This is a placeholder for future UI updates.
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Left empty intentionally. This is a placeholder for future UI updates.
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            LogActivity("User submitted a quiz answer.");
            if (btnSubmitAnswer.Text == "Next Question")
            {
                currentQuestionIndex++;
                ShowQuestion();
                return;
            }

            int selectedAnswer = -1;
            if (radOptionA.Checked) selectedAnswer = 0;
            else if (radOptionB.Checked) selectedAnswer = 1;
            else if (radOptionC.Checked) selectedAnswer = 2;
            else if (radOptionD.Checked) selectedAnswer = 3;

            if (selectedAnswer == -1)
            {
                MessageBox.Show("Please select an answer first!");
                return;
            }

            QuizQuestion q = quizQuestions[currentQuestionIndex];
            if (selectedAnswer == q.CorrectAnswerIndex)
            {
                quizScore++;
                lblFeedback.ForeColor = System.Drawing.Color.Green;
                lblFeedback.Text = q.Explanation;
            }
            else
            {
                lblFeedback.ForeColor = System.Drawing.Color.Red;
                lblFeedback.Text = "Incorrect. " + q.Explanation;
            }

            lblScore.Text = $"Score: {quizScore}";
            btnSubmitAnswer.Text = "Next Question";
            LogActivity($"User completed the quiz with a score of {quizScore}.");
        }

        private void picResultGif_Click(object sender, EventArgs e)
        {
            // Ask the user if they are sure
            DialogResult result = MessageBox.Show("Are you sure you want to start the quiz afresh?", "Restart Quiz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Reset the variables
                currentQuestionIndex = 0;
                quizScore = 0;

                // Hide the GIF and reset the button state
                picResultGif.Visible = false;
                btnSubmitAnswer.Enabled = true;

                // Start the quiz again
                ShowQuestion();
            }
        }

        private void btnRestartQuiz_Click(object sender, EventArgs e)
        {
            // Ask the user if they are sure
            DialogResult result = MessageBox.Show("Are you sure you want to start the quiz afresh?", "Restart Quiz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Reset the variables
                currentQuestionIndex = 0;
                quizScore = 0;

                // Hide the GIF and reset the button state
                picResultGif.Visible = false;
                btnSubmitAnswer.Enabled = true;

                // Start the quiz again
                ShowQuestion();
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskTitle.Text))
            {
                MessageBox.Show("Please enter a task title!");
                return;
            }

            try
            {
                DateTime? reminder = dtpReminder.Checked ? dtpReminder.Value : (DateTime?)null;
                db.AddTask(txtTaskTitle.Text, txtTaskDesc.Text, reminder);

                // THIS IS THE LINE THAT LOGS IT
                LogActivity($"Added Task: {txtTaskTitle.Text}");

                MessageBox.Show("Task added successfully!");

                txtTaskTitle.Clear();
                txtTaskDesc.Clear();
                dtpReminder.Checked = false;

                LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding task: " + ex.Message);
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            // Make sure a row is selected
            if (dgvTasks.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the TaskID from the selected row
                    int taskId = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskID"].Value);
                    string taskTitle = dgvTasks.SelectedRows[0].Cells["Title"].Value.ToString();

                    db.UpdateTaskStatus(taskId, true);
                    LogActivity($"Task Completed: {taskTitle}");

                    LoadTasks();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error completing task: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a task from the list first.");
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        int taskId = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskID"].Value);
                        string taskTitle = dgvTasks.SelectedRows[0].Cells["Title"].Value.ToString();

                        db.DeleteTask(taskId);
                        LogActivity($"Task Deleted: {taskTitle}");

                        LoadTasks();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting task: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task from the list first.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




    public class QuizQuestion
    {
        public string QuestionText { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public string Explanation { get; set; }

    }


