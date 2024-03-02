using System;

// Defines a reflection activity, a type of mindfulness exercise focused on introspection.
public class ReflectionActivity : MindfulnessActivity
{
    // Holds different scenarios for the user to reflect on.
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // Contains questions to guide deeper reflection on each scenario.
    private string[] _reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Sets the activity's name in the constructor.
    public ReflectionActivity()
    {
        _activityName = "Reflection";
    }

    // Customizes the activity's start process with reflection-specific steps.
    public override void StartActivity()
    {
        base.StartActivity(); // Calls the base method for common setup tasks.
        
        // Sets the end time for the activity based on its duration.
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        Console.WriteLine("This activity will help you reflect on times of strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Thread.Sleep(5000); // Pause for a moment before proceeding.

        Random rand = new Random(); // Used to randomly select a reflection prompt.

        // Loop to keep the reflection activity going until the end time.
        while (DateTime.Now < endTime)
        {
            // Randomly select and display a prompt.
            string prompt = _prompts[rand.Next(_prompts.Length)];
            Console.WriteLine(prompt);
            Console.WriteLine();
            Countdown(3); // Give the user a short pause to think about the prompt.

            // Define an end time for reflecting on the selected prompt.
            DateTime questionsEndTime = DateTime.Now.AddSeconds(_duration);
            
            // Loop to ask reflection questions for the current prompt.
            while (DateTime.Now < questionsEndTime)
            {
                foreach (var question in _reflectionQuestions)
                {
                    Console.WriteLine(question);
                    Console.WriteLine();
                    Countdown(5); // Pause for the user to think about their answer.
                    
                    if (DateTime.Now >= questionsEndTime) // Check if it's time to move on.
                        break;
                }
            }

            if (DateTime.Now >= endTime) // Check if the overall activity time has elapsed.
                break;
        }

        EndActivity(); // Call the base method to conclude the activity.
    }
}
