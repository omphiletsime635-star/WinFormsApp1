ZAMASWASI Cybersecurity AwarenessBot
 
Overview
 
This project is a comprehensive chatbot application designed to help users learn about online safety, cybersecurity, passwords, scams, privacy, phishing, and related topics. Built with C# and Windows Forms, the application features a multi-tab interface that offers an interactive chat, a database-driven task manager, an educational mini-game, and an activity tracker.
 
Features
* Interactive Chatbot: Recognizes keywords like "password," "scam," "privacy," "phishing," and "cybersecurity" to provide detailed information.
* NLP Simulation: The chatbot recognizes different ways users phrase commands. Typing "start quiz," "add task," or "show log" will automatically navigate the user to the relevant tab.
* Task Manager (Database Integration): Users can add cybersecurity-related tasks with optional reminders. Tasks are securely saved to a MySQL database and can be marked as completed or deleted.
* Cybersecurity Mini-Game (Quiz): A 14-question multiple-choice quiz that tests the user's knowledge. It provides immediate feedback with explanations, tracks the user's score, and displays celebratory or encouraging GIFs at the end.
* Activity Log: A built-in tracker that records system and user actions (e.g., tasks added, quizzes completed, chat interactions) with timestamps.
* Chatbot Memory: Remembers the user's name and favorite topic during the conversation to provide personalized replies.
* UI Enhancements: Plays a welcome audio file on startup, displays a logo, features a scrollable chat history, and uses a tabbed layout for easy navigation. 
How It Works
 
The application is divided into several core components:
 
1. Chat Logic (ChatEngine.cs)
* Uses dictionaries to store questions and answers related to various cybersecurity topics.
* Recognizes user greetings, topics, and sentiment keywords to generate appropriate responses.
* Maintains context to give personalized, follow-up replies. 
2. Database & Task Management (DatabaseHelper.cs & Form1.cs)
* Connects to a local MySQL database (via XAMPP) to handle CRUD (Create, Read, Update, Delete) operations for user tasks.
* Uses a DataGridView to display tasks dynamically from the database. 
3. Quiz Engine (Form1.cs)
* Utilizes a custom QuizQuestion class to store question text, options, correct answers, and explanations.
* Tracks the currentQuestionIndex and quizScore to dynamically update the UI and load appropriate result GIFs. 
4. User Interface (Form1.cs)
* Manages the TabControl interface.
* Uses string manipulation to detect user intent (NLP) and route them to the correct tab (Chatbot, Task Manager, Quiz, or Log).
* Handles the activity logging system, ensuring only the last 10 actions are displayed to keep the UI clean. 
How to Use
1. Prerequisites: Ensure you have XAMPP installed and running (start Apache and MySQL) so the Task Manager can connect to the database.
2. Run the application. You will see a welcome message from the chatbot in the ChatBot tab.
3. Type questions about online safety into the input box and press Enter. Try introducing yourself ("My name is [YourName]").
4. Chat Commands: Type "play a game" to start the quiz, or "what have you done" to view the activity log.
5. Navigate to the Task Manager tab to add new cybersecurity tasks, set reminder dates, and manage your to-do list.
6. Navigate to the Cyber Quiz tab to test your knowledge and see your final score with a GIF.
7. Navigate to the Activity Log tab to see a history of recent actions taken in the app. 
What I Learned
* How to create a multi-tabbed Windows Forms application.
* How to integrate a C# application with a MySQL database using the MySql.Data NuGet package.
* How to use DataGridViews to display and manage database records.
* How to implement basic Natural Language Processing (NLP) simulation using string manipulation and keyword detection.
* How to dynamically update UI elements (like showing/hiding GIFs based on quiz scores).
* Managing state (scores, current questions, activity logs) across different application tabs.
* How to use Git and GitHub for version control and project backup. 
Files
* ChatEngine.cs: Contains the chatbot logic, NLP keyword matching, and knowledge base.
* DatabaseHelper.cs: Handles the connection string and SQL queries for the MySQL database.
* Form1.cs: Handles the UI, tab routing, quiz logic, and activity logging.
* images/logo.png: The logo image displayed in the app.
* images/win.gif & images/lose.gif: The GIFs displayed at the end of the quiz.
* voice/audio.wav: The welcome audio file played when the app starts. 
Notes
* This application is a prototype for learning purposes and is not intended for professional cybersecurity advice.
* The database requires XAMPP (MySQL) to be running in the background. If XAMPP is off, the Task Manager will display a connection error.
* The bot uses random selection to vary responses for a more natural chat experience.

---

Thanks for checking out my Cybersecurity AwarenessBot! I hope it helps you understand more about staying safe online.
