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
        private Dictionary<string, string> differenceResponses;

        public ChatEngine()
        {
            InitializeResponses();
        }

        private void InitializeResponses()
        {

            // Initialize the difference responses
            differenceResponses = new Dictionary<string, string>();

            differenceResponses.Add("password_scam", "A password is a string of characters used to verify identity and secure access to an account, while a scam is a deceptive scheme designed to trick you into giving away money or information. An example of a password is your 12-character login code, whereas an example of a scam is a fake email claiming you won a lottery. To avoid password issues, use a password manager and never reuse passwords; to avoid scams, never send money to strangers and verify the source. If your password is compromised, change it immediately and enable 2FA. If you fall for a scam, contact your bank immediately to freeze your accounts and report it to the SAFPS or SAPS.");

            differenceResponses.Add("password_privacy", "Passwords act as the digital lock protecting your account, while privacy is your ability to control what personal information you share and who can see it. An example of a password is a secure login, whereas an example of privacy is setting your social media profile to 'friends only.' To avoid password issues, create complex, unique credentials; to avoid privacy breaches, regularly review your account settings and limit what you post. If your password is compromised, reset it on all accounts. If your privacy is breached, lock down your accounts, remove sensitive information from public view, and change your passwords.");

            differenceResponses.Add("password_phishing", "A password is the key that grants access, while phishing is a cyberattack where scammers use fake messages to steal that key from you. An example of a password is a unique passphrase, while an example of phishing is an email pretending to be your bank asking you to 'verify' your login details. To avoid password issues, never share them with anyone; to avoid phishing, check sender addresses carefully and hover over links before clicking. If your password is compromised, change it instantly. If you fall for phishing, change your password on the legitimate site immediately, contact your bank if financial details were shared, and report the email.");

            differenceResponses.Add("password_cybersecurity", "A password is just one specific authentication tool, whereas cybersecurity is the broad practice of protecting your entire system, network, and devices from all digital attacks. An example of a password is your login credential, while an example of cybersecurity is using antivirus software and installing security patches. To avoid password issues, enable Two-Factor Authentication (2FA). To maintain good cybersecurity, keep your operating system updated, use firewalls, and back up your data regularly. If your password is compromised, change it. If your overall cybersecurity is breached (like a virus), disconnect from the internet, run a full antivirus scan, and seek professional IT help.");

            differenceResponses.Add("scam_privacy", "A scam is an active fraudulent attempt to steal your money or data, while privacy is the passive control you have over who can see your personal information. An example of a scam is a fake invoice demanding urgent payment, whereas an example of privacy is hiding your phone number from public directories. To avoid scams, be highly skeptical of urgent requests; to maintain privacy, be careful what you post online. If you fall for a scam, contact your bank to block transactions and report the fraud. If your privacy is compromised, lock down your accounts, change your passwords, and remove personal data from public websites.");

            differenceResponses.Add("scam_phishing", "A scam is the overarching goal of defrauding someone (like a fake investment), while phishing is the specific method or delivery tool (like a fake email link) used to execute that scam. An example of a scam is a romance scam on social media, while an example of phishing is a text message claiming to be from a delivery company asking for a fee. To avoid scams, research the company or person before engaging; to avoid phishing, never click links in unsolicited messages. If you fall for a scam, contact your bank and local authorities. If you fall for phishing, change your credentials immediately and scan your device for malware.");

            differenceResponses.Add("scam_cybersecurity", "A scam is a psychological operation relying on human deception to get you to hand over assets, whereas cybersecurity is the technical defense used to protect your devices and networks from malicious software. An example of a scam is someone pretending to be a charity to get donations, while an example of cybersecurity is a firewall blocking an unauthorized connection. To avoid scams, trust your instincts and verify identities. To maintain cybersecurity, keep your software patched and use reputable antivirus tools. If you fall for a scam, report it to the authorities. If your cybersecurity is breached, disconnect your device from the internet and run a scan.");

            differenceResponses.Add("privacy_phishing", "Privacy is your right to keep personal data out of the public eye, while phishing is a malicious attempt to trick you into revealing that data. An example of privacy is setting a password on your smartphone, whereas an example of phishing is a fake login page designed to capture your credentials. To maintain privacy, audit your social media settings regularly. To avoid phishing, always verify the URL of a website before entering your password. If your privacy is breached, lock down your settings and remove exposed data. If you fall for phishing, change your password immediately and enable 2FA.");

            differenceResponses.Add("privacy_cybersecurity", "Privacy is about controlling who has access to your information, while cybersecurity is about protecting the systems that hold that information from being hacked. An example of privacy is deciding not to share your ID number online, while an example of cybersecurity is using a VPN on public Wi-Fi to encrypt your data. To maintain privacy, limit what you share and use private browsing modes. To maintain cybersecurity, use strong, unique passwords and keep your software updated. If your privacy is compromised, restrict your account visibility. If your cybersecurity is compromised, change all your passwords, disconnect from the internet, and monitor accounts for suspicious activity.");

            differenceResponses.Add("phishing_cybersecurity", "Phishing is a specific, human-focused attack method (deception via email/text), whereas cybersecurity is the overall technical defense system (firewalls, antivirus, updates) used against all types of attacks. An example of phishing is a scammer pretending to be your boss asking for gift cards. An example of cybersecurity is using multi-factor authentication across all accounts. To avoid phishing, scrutinize the sender's email address and never click suspicious links. To maintain cybersecurity, keep your devices updated. If you fall for phishing, report the message and change your passwords. If cybersecurity is breached, disconnect the device and run a full system scan.");

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

            // Check if the user is asking for a difference/comparison
            if (query.Contains("difference") || query.Contains("compare") || query.Contains("vs"))
            {
                string comparisonResult = CheckForDifference(query);
                if (!string.IsNullOrEmpty(comparisonResult))
                {
                    return comparisonResult;
                }
            }

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

            // Detect greetings
            if (query == "hi" || query == "hello" ||
                query == "hey" || query.StartsWith("hello ") ||
                query.StartsWith("hi ") || query.StartsWith("hey "))
            {
                if (string.IsNullOrEmpty(UserName))
                    return GetRandomSpecialResponse("greeting");

                string greetingResponse = GetRandomSpecialResponse("greeting_with_name");
                return string.Format(greetingResponse, UserName);
            }

            // Detect the exact topic mentioned in the question
            string topic = DetectTopic(query);

            // Remember the user's favourite topic
            if ((query.Contains("interested in") || query.Contains("i like")) &&
                !string.IsNullOrEmpty(topic))
            {
                FavoriteTopic = topic;
                lastTopic = topic;

                string favoriteResponse = GetRandomSpecialResponse("favorite_topic");
                return string.Format(favoriteResponse, topic);
            }

            // Detect feelings and respond with a relevant tip
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


        private string CheckForDifference(string query)
        {
            bool hasPassword = query.Contains("password") || query.Contains("passcode");
            bool hasScam = query.Contains("scam") || query.Contains("fraud");
            bool hasPrivacy = query.Contains("privacy") || query.Contains("private");
            bool hasPhishing = query.Contains("phishing") || query.Contains("fake email");
            bool hasCyber = query.Contains("cybersecurity") || query.Contains("cyber");

            // Find the pairs
            if (hasPassword && hasScam) return differenceResponses["password_scam"];
            if (hasPassword && hasPrivacy) return differenceResponses["password_privacy"];
            if (hasPassword && hasPhishing) return differenceResponses["password_phishing"];
            if (hasPassword && hasCyber) return differenceResponses["password_cybersecurity"];

            if (hasScam && hasPrivacy) return differenceResponses["scam_privacy"];
            if (hasScam && hasPhishing) return differenceResponses["scam_phishing"];
            if (hasScam && hasCyber) return differenceResponses["scam_cybersecurity"];

            if (hasPrivacy && hasPhishing) return differenceResponses["privacy_phishing"];
            if (hasPrivacy && hasCyber) return differenceResponses["privacy_cybersecurity"];

            if (hasPhishing && hasCyber) return differenceResponses["phishing_cybersecurity"];

            return ""; // Return empty if it can't find two topics
        }
    }
}
    

