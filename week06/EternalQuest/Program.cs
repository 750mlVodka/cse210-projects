class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.DisplayPlayerInfo();

        while (true)
        {
            goalManager.ShowMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "3":
                    goalManager.SaveGoals("goals.txt");
                    break;
                case "4":
                    goalManager.LoadGoals("goals.txt");
                    break;
                case "5":
                    Console.Write("Enter Goal Name to Record Event: ");
                    string goalName = Console.ReadLine();
                    goalManager.RecordGoalEvent(goalName);
                    break;
                case "6":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}