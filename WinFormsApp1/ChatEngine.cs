using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp1
{
    internal class ChatEngine
    {
        // Memory variables 
        public string UserName { get; private set; } = "";
        public string FavoriteTopic { get; private set; } = "";
        private string lastTopic = "";

        // Dictionaries for Keyword Recognition and Random Responses 
        private Dictionary<string, List<string>> keywordResponses;
        private Dictionary<string, List<string>> specialResponses;
        private List<string> fallbackResponses;
        private List<string> sentimentKeywords;
        private List<string> followUpKeywords;

        public ChatEngine()
        {
            InitializeResponses();
        }

        private void InitializeResponses()
        {
            // Initialize lists and dictionaries
            keywordResponses = new Dictionary<string, List<string>>();
            specialResponses = new Dictionary<string, List<string>>();

            // Topic: Password 
            keywordResponses.Add("password", new List<string>
            {
                "What is a strong password?\nA strong password is a combination of uppercase and lowercase letters, numbers, and symbols. It should be at least 12 characters long and unique to each account.\r\nHow to prevent issues:\r\n- Use a password manager.\r\n- Enable Two-Factor Authentication (2FA) on all important accounts.\r\n- Never reuse passwords across different sites.\r\nWhat to do if compromised:\r\n- Change the password immediately on all affected accounts.\r\n- Enable 2FA if you haven't already.\r\n- Monitor your accounts for suspicious activity."
            });

            // Topic: Scam 
            keywordResponses.Add("scam", new List<string>
            {
                "What is a scam?\nA scam is a fraudulent scheme designed to trick you into giving away money or personal information. Scammers often create a false sense of urgency or fear to make you act quickly without thinking.\r\nHow to prevent it:\r\n- Never send money to strangers online.\r\n- Be wary of urgent requests for personal information.\r\n- Watch out for spelling errors in emails claiming to be from legitimate companies.\r\n- Research the company or person contacting you before providing any information.\r\nWhat to do if you fell for it:\r\n- Contact your bank immediately to freeze your accounts.\r\n- Report the scam to local authorities (like the SAPS in South Africa) or the SAFPS.\r\n- Change your passwords if you shared any login details."
            });

            // Topic: Privacy
            keywordResponses.Add("privacy", new List<string>
            {
                "What is digital privacy?\nDigital privacy is your ability to control what personal information you share online and who can see it.\r\nHow to prevent issues:\r\n- Review your social media privacy settings regularly.\r\n- Be cautious about what personal information you share online.\r\n- Use a VPN when connecting to public Wi-Fi to protect your data.\r\n- Limit who can see your friend list and personal details on social media.\r\nWhat to do if compromised:\r\n- Lock down your accounts and change your passwords.\r\n- Remove any personal information you can from public view.\n- Be vigilant against phishing attempts that might use your leaked data."
            });

            // Topic: Phishing 
            keywordResponses.Add("phishing", new List<string>
            {
                "What is phishing?\nPhishing is a cyberattack where scammers disguise themselves as trusted organisations to trick you into revealing sensitive data like passwords or credit card numbers.\r\nHow to prevent it:\r\n Check the sender's email address carefully. Phishing emails often have slight misspellings.\r\n- Never click on links in unsolicited emails. Hover over them first to see the real destination.\r\n- Look for generic greetings like 'Dear Customer' instead of your actual name.\r\n- Watch for urgent language like 'Verify now' or 'Account will be closed'.\r\nWhat to do if you fell for it:\r\n- If you entered your password, change it immediately on the legitimate website.\r\n- If you entered financial details, call your bank right away to block your card.\r\n- Report the suspicious email to the company's official support channels."
            });

            // Topic: Cybersecurity
            keywordResponses.Add("cybersecurity", new List<string>
            {
                "What is cybersecurity?\nCybersecurity is the practice of protecting systems, networks, and programs from digital attacks.\r\nHow to prevent issues:\r\n- Keep your software and operating system updated with the latest security patches.\r\n- Use reputable antivirus software and keep it up to date.\r\n- Avoid using public computers for sensitive activities like online banking.\n- Back up your important files regularly to protect against ransomware attacks.\r\nWhat to do if compromised:\r\n- Disconnect your device from the internet to stop the spread.\r\n- Run a full antivirus scan.\r\n- Seek professional IT help if you are unsure how to remove the threat."
            });

            // Topic: Thank you 
            keywordResponses.Add("thank you", new List<string>
            {
                "You're welcome! I'm glad I could help.",
                "No problem! Stay safe online.",
                "Anytime! Let me know if you have more questions about cybersecurity.",
                "You're welcome! Remember to always be cautious online."
            });


            // Special Responses: Greetings
            specialResponses.Add("greeting", new List<string>
            {
                "Hello! What would you like to know about online safety?",
                "Hi there! How can I help you stay safe online?",
                "Hello! I'm here to help with online safety tips.",
                "Hey! What would you like to learn about cybersecurity?"
            });

            // Special Responses: Greetings with Name
            specialResponses.Add("greeting_with_name", new List<string>
            {
                "Hello again, {0}! What would you like to know?",
                "Hi {0}! What can I help you with today?",
                "Welcome back, {0}! How can I assist you with online safety?"
            });

            // Special Responses: Name Introduction
            specialResponses.Add("name_introduction", new List<string>
            {
                "Nice to meet you, {0}! How can I help you stay safe online?",
                "Great to meet you, {0}! What would you like to learn about cybersecurity?",
                "Welcome, {0}! I'm here to help with online safety. What's your question?"
            });

            // Special Responses: Favorite Topic Remembered
            specialResponses.Add("favorite_topic", new List<string>
            {
                "Great! I'll remember that you're interested in {0}.",
                "Got it! I'll keep in mind that you like {0}.",
                "Perfect! I've noted that {0} is your favorite topic."
            });

            // Special Responses: Sentiment Responses
            specialResponses.Add("sentiment", new List<string>
            {
                "It's understandable to feel {0}. Here is some advice: {1}",
                "I understand you're feeling {0}. Let me help with this tip: {1}",
                "It's normal to feel {0}. Here's something that might help: {1}"
            });

            // Special Responses: Follow-up Responses
            specialResponses.Add("followup", new List<string>
            {
                "Here is another tip about {0}: {1}",
                "Here's more information on {0}: {1}",
                "Let me give you another tip about {0}: {1}"
            });

            // Special Responses: No Previous Topic
            specialResponses.Add("no_previous_topic", new List<string>
            {
                "Which topic would you like more information about: passwords, scams, privacy, phishing, or cybersecurity?",
                "I'd love to help! Would you like to know about: passwords, scams, privacy, phishing, or cybersecurity?",
                "Sure! Which would you like to explore: passwords, scams, privacy, phishing, or cybersecurity?"
            });

            // Special Responses: Empty Input
            specialResponses.Add("empty_input", new List<string>
            {
                "Please type a question.",
                "Could you please ask me something?",
                "I'm waiting for your question. What would you like to know?"
            });

            // General Fallbacks 
            fallbackResponses = new List<string>
            {
                "I don't have an answer for that yet. Could you ask about passwords, scams, privacy, or phishing?",
                "I'm still learning. Try asking me for a phishing tip or about online safety.",
                "That's a great question! Try asking about passwords, scams, privacy, phishing, or cybersecurity.",
                "I can help with online safety topics. Which topic interests you: passwords, scams, privacy, or phishing?",
                "I'm not sure I understand. Can you try rephrasing?"
            };

            // Sentiment Keywords 
            sentimentKeywords = new List<string> { "worried", "frustrated", "curious", "scared", "confused", "overwhelmed", "concerned", "anxious" };

            // Follow-up Keywords 
            followUpKeywords = new List<string> { "more", "another tip", "explain", "tell me more", "give me another", "what else", "any other" };
        }

        public string GetResponse(string input)
        {
            // Get the exact question entered by the user
            if (string.IsNullOrWhiteSpace(input))
                return GetRandomSpecialResponse("empty_input");

            string query = input.Trim().ToLowerInvariant();

            // Remember the user's name
            if (query.Contains("my name is"))
            {
                int index = query.IndexOf("my name is") + 10;
                UserName = input.Substring(index).Trim();

                if (string.IsNullOrWhiteSpace(UserName))
                    return GetRandomSpecialResponse("empty_input");

                string nameResponse = GetRandomSpecialResponse("name_introduction");
                return string.Format(nameResponse, UserName);
            }

            // 2. Detect greetings
            if (query == "hi" || query == "hello" ||
                query == "hey" || query.StartsWith("hello ") ||
                query.StartsWith("hi ") || query.StartsWith("hey "))
            {
                if (string.IsNullOrEmpty(UserName))
                    return GetRandomSpecialResponse("greeting");

                string greetingResponse = GetRandomSpecialResponse("greeting_with_name");
                return string.Format(greetingResponse, UserName);
            }

            // 3. Detect the exact topic mentioned in the question
            string topic = DetectTopic(query);

            // 4. Remember the user's favourite topic
            if ((query.Contains("interested in") || query.Contains("i like")) &&
                !string.IsNullOrEmpty(topic))
            {
                FavoriteTopic = topic;
                lastTopic = topic;

                string favoriteResponse = GetRandomSpecialResponse("favorite_topic");
                return string.Format(favoriteResponse, topic);
            }

            // 5. Detect feelings and respond with a relevant tip
            foreach (string sentiment in sentimentKeywords)
            {
                if (query.Contains(sentiment))
                {
                    string sentimentTopic = !string.IsNullOrEmpty(topic)
                        ? topic
                        : (!string.IsNullOrEmpty(lastTopic)
                            ? lastTopic
                            : "cybersecurity");

                    if (!string.IsNullOrEmpty(topic))
                        lastTopic = topic;

                    string tipResponse = GetRandomResponse(sentimentTopic);
                    string sentimentResponse = GetRandomSpecialResponse("sentiment");
                    return string.Format(sentimentResponse, sentiment, tipResponse);
                }
            }

            // Answer follow-up questions using the previous topic
            bool isFollowUp = followUpKeywords.Any(keyword =>
                query.Contains(keyword));

            if (isFollowUp)
            {
                if (!string.IsNullOrEmpty(topic))
                    lastTopic = topic;

                if (!string.IsNullOrEmpty(lastTopic))
                {
                    string tipResponse = GetRandomResponse(lastTopic);
                    string followupResponse = GetRandomSpecialResponse("followup");
                    return string.Format(followupResponse, lastTopic, tipResponse);
                }

                return GetRandomSpecialResponse("no_previous_topic");
            }

            //  Use the identified topic to answer the question
            if (!string.IsNullOrEmpty(topic))
            {
                lastTopic = topic;

                string response = GetRandomResponse(topic);

                if (FavoriteTopic == topic)
                {
                    response = $"Since you're interested in {topic}, {response}";
                }

                return response;
            }

            // Handle questions the chatbot does not recognise
            return GetRandomFallbackResponse();
        }

        private string DetectTopic(string query)
        {
            if (query.Contains("password") || query.Contains("passcode"))
                return "password";

            if (query.Contains("scam") || query.Contains("scammer") ||
                query.Contains("fraud") || query.Contains("cheated"))
                return "scam";

            if (query.Contains("privacy") || query.Contains("private") ||
                query.Contains("personal information"))
                return "privacy";

            if (query.Contains("phishing") || query.Contains("suspicious email") ||
                query.Contains("fake email") || query.Contains("fake link"))
                return "phishing";

            if (query.Contains("cybersecurity") || query.Contains("online safety") ||
                query.Contains("cyber"))

                return "cybersecurity";
            if (query.Contains("thank you") || query.Contains("thanks") || query.Contains("appreciation"))
            {
                return "thank you";
            }

            return "";
        }

        private string GetRandomResponse(string topic)
        {
            if (string.IsNullOrEmpty(topic))
                return GetRandomFallbackResponse();

            string key = topic.ToLowerInvariant();

            if (keywordResponses?.TryGetValue(key, out var responses) == true &&
                responses?.Count > 0)
            {
                return responses[Random.Shared.Next(responses.Count)];
            }

            return GetRandomFallbackResponse();
        }

        private string GetRandomSpecialResponse(string responseType)
        {
            if (specialResponses?.TryGetValue(responseType, out var responses) == true &&
                responses?.Count > 0)
            {
                return responses[Random.Shared.Next(responses.Count)];
            }

            return GetRandomFallbackResponse();
        }

        private string GetRandomFallbackResponse()
        {
            if (fallbackResponses?.Count > 0)
                return fallbackResponses[Random.Shared.Next(fallbackResponses.Count)];

            return "Sorry, I don't have any advice right now.";
        }
    }
}

