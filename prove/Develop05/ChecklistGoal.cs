public class ChecklistGoal: Goal {
    int _timesCompleted; 
    int _timesToComplete;

    // Constructor for a checklist goal.
    public ChecklistGoal(string name, string description, int pointsPer, int timesToComplete, int timesCompleted = 0)
        : base(name, description, pointsPer) {
        // Initialize how many times the goal has been completed and needs to be completed.
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
    }

    // Calculate the score based on completions.
    public override int CalculateScore() {
        // Multiply the number of completions by points per completion.
        return _timesCompleted * _pointsPer;
    }

    // Mark the goal as completed once more.
    public override void Complete() {
        // Increase the completion count.
        _timesCompleted++;
    }

    public override string GetInfo() {
        // Decide if the goal is completed (X) or not (space).
        string status = _timesCompleted >= _timesToComplete ? "X" : " ";
        
        // Combine the goal's name and description.
        string nameAndDesc = _name + ": " + _description;
        
        // Show how much of the goal is completed.
        string progress = " -- Currently completed: " + _timesCompleted + "/" + _timesToComplete;
        
        // Choose "time" or "times" based on the goal count.
        string timesText = _timesToComplete == 1 ? "time" : "times";
        
        // Put everything into one string.
        return $"[{status}] {nameAndDesc}{progress} {timesText}";
    }

    public override string Serialize() {
        // Create a string to save the goal with its details.
        // It formats the goal's properties with '|' separators for easy parsing later.
        return $"ChecklistGoal:|{_name}|{_description}|{_pointsPer}|{_timesToComplete}|{_timesCompleted}";
    }
}