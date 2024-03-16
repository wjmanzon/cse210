// Represents a goal that can be either completed or not.
public class SimpleGoal: Goal { 
     bool _status; // Tracks whether the goal has been completed.

    // Constructor initializes a simple goal with basic information and completion status.
    public SimpleGoal(string name, string description, int points, bool status = false)
        : base(name, description, points) {
        _status = status; // Set the initial completion status.
    }

    // Calculate the score for the goal based on its completion status.
    public override int CalculateScore() {
        // If the goal is completed, return the points. Otherwise, return 0.
        return _status ? _pointsPer : 0;
    }

    // Mark the goal as completed.
    public override void Complete() {
        _status = true; // Set the status to true to indicate completion.
    }

    // Generate and return information about the goal.
    public override string GetInfo() {
        // Return a string showing the completion status, name, and description of the goal.
        return $"[{(_status ? "X" : " ")}] {_name}: {_description}";
    }

    // Serialize the goal's details into a string format.
    public override string Serialize() {
        // Format the goal's properties for serialization, using '1' for completed and '0' for not completed.
        return $"SimpleGoal:|{_name}|{_description}|{_pointsPer}|{(_status ? "1" : "0")}";
    }
}
