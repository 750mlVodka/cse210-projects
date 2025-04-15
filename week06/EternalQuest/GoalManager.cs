



public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
        for (int i = 0; i < _goals.Count; i++)
        {
            var goal = _goals[i];
            string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";
            string details = goal is ChecklistGoal checklistGoal ? $"{goal.GetDetailsString()}" : $"{goal.GetDetailsString()}";
            Console.WriteLine($"{i + 1}. {completionStatus} {details}");
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal );
    }

    public void RecordGoalEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetStringRepresentation().Contains(goalName))
            {
                goal.RecordEvent();
                _score += goal.GetPoints();
                Console.WriteLine($"Event recorded for: {goalName}. Current score: {_score}");
                return;
            }
        }
        Console.WriteLine("Name Goal not found.");
    }

    public void SaveGoals(string filePath)
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Score: {_score}");

                foreach (var goal in _goals)
                {
                    string goalType = goal.GetType().Name;
                    string goalComponents = string.Join(", ", goal.GetStringRepresentation(), goal.GetDetailsString());
                    string goalData = goal.GetStringRepresentation();
                    string goalDetails = goal.GetDetailsString();
                    writer.WriteLine($"{goalType}, {goalComponents}, {goalData}, {goalDetails}");
                }
            }
            Console.WriteLine($"Goals saved to {filePath}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                }
            }
        }
    }

    public void ShowMenu()
    {
        Console.WriteLine($"\nYou have {_score} points.");

        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("     1. Create New Goal");
        Console.WriteLine("     2. List Goals");
        Console.WriteLine("     3. Save Goals");
        Console.WriteLine("     4. Load Goals");
        Console.WriteLine("     5. Record Event");
        Console.WriteLine("     6. Quit");
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.Write("Wich goal type do you want to create?");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}