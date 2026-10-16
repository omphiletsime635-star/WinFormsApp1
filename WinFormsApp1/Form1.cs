using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ChatEngine botEngine;

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
        }

        private void DisplayWelcomeMessage()
        {
            chatBox.AppendText("Bot: Hello! Welcome to ZAMASWASI Cybersecurity AwarenessBot. I'm here to help you stay safe online. What would you like to know about online safety?\r\n\r\n");
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

            chatBox.AppendText($"You: {question}\r\n");

            // Pass the actual question to ChatEngine
            // The ChatEngine now returns multi-paragraph strings using \n\n
            string answer = botEngine.GetResponse(question);

            chatBox.AppendText($"Bot: {answer}\r\n\r\n");

            inputBox.Clear();
            inputBox.Focus();

            // Scroll to the very bottom so the user sees the new message
            chatBox.SelectionStart = chatBox.Text.Length;
            chatBox.ScrollToCaret();
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

        private void chatBox_TextChanged(object sender, EventArgs e)
        {
            // Ensure the chat box always scrolls to the bottom whenever new text is added.
            // This handles the initial welcome message and all bot replies.
            chatBox.SelectionStart = chatBox.Text.Length;
            chatBox.ScrollToCaret();
        }
    }
}

