// Abstract class representing a generic goal.
public abstract class Goal { 
    protected string _name; // Name of the goal.
    protected string _description; // Description of the goal.
    protected int _pointsPer; // Points earned per completion of the goal.

    // Constructor to set basic properties of the goal.
    public Goal(string name, string description, int pointsPer) {
        _name = name;
        _description = description;
        _pointsPer = pointsPer; // Assign initial values.
    }
    
    // Method to calculate the score for the goal. Implementation must be provided in derived classes.
    public abstract int CalculateScore();

    // Method to mark the goal as completed. Implementation varies in derived classes.
    public abstract void Complete();

    // Method to get information about the goal. Derived classes define the specific format.
    public abstract string GetInfo();

    // Method to serialize the goal's data into a string. Specific format is defined in derived classes.
    public abstract string Serialize();
}
