# ZAMASWASI Cybersecurity AwarenessBot

## Overview
This project is a simple chatbot application designed to help users learn about online safety, cybersecurity, passwords, scams, privacy, phishing, and related topics. The chatbot is built with C# and Windows Forms, offering a friendly and interactive way for users to ask questions and get practical advice.

## Features
- Recognizes keywords like "password," "scam," "privacy," "phishing," and "cybersecurity" to provide detailed information.
- Remembers the user's name and favorite topic during the conversation.
- Provides tips and follow-up information based on user input and sentiments.
- Offers greeting messages and polite responses.
- Plays a welcome audio file when the app starts.
- Displays a logo and an About window if the user clicks the logo.
- Scrolls automatically to show the most recent chat messages.

## How It Works
The chatbot logic is implemented in the `ChatEngine` class:
- It uses dictionaries to store questions and answers related to various topics.
- It recognizes user greetings, topics, and sentiment keywords to generate responses.
- The chat remembers some conversation context to give personalized replies.
- If it doesn’t recognize the user’s question, it suggests topics or asks for clarification.

The Windows Forms app (`Form1`) handles the user interface:
- Displays the ongoing conversation between the user and the bot.
- Receives user input and passes it to the `ChatEngine` to get an answer.
- Plays the audio and shows the logo on startup.
- Handles events like pressing Enter, clicking the logo, and updating the chat box.

## How to Use
1. Run the application.
2. You will see a displayed welcome message from the chatbot.
3. Type your questions about online safety into the input box.
4. Press Enter to send your question.
5. The chatbot will reply with helpful information.
6. You can introduce yourself by typing "My name is [YourName]" and the bot will remember you.
7. Ask about topics like passwords, scams, privacy, phishing, or cybersecurity for detailed advice.
8. Click the logo image to view information about the chatbot.

## What I Learned
- How to create a chatbot that understands keywords and context.
- How to use Windows Forms to build a simple user interface.
- Using dictionaries and lists to store and retrieve responses.
- Managing user input and handling events like keyboard presses and clicks.
- Playing audio and loading images dynamically in an app.

## Files
- `ChatEngine.cs`: Contains the chatbot logic and knowledge base.
- `Form1.cs`: Handles the UI and user interaction.
- `images/logo.png`: The logo image displayed in the app (make sure to have this if you want the logo to show).
- `voice/audio.wav`: The welcome audio file played when the app starts (optional).

## Notes
- This application is a prototype for learning purposes and not intended for professional cybersecurity advice.
- Empty or unrecognized inputs will trigger polite prompts from the bot to help guide the conversation.
- The bot uses random selection to vary responses for a more natural chat experience.

---

Thanks for checking out my Cybersecurity AwarenessBot! I hope it helps you understand more about staying safe online.
