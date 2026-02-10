// menu system and saving of points
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    {
        Console.Clear();
        string menuChoice;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            if (!new[] { "1", "2", "3", "4", "5", "6" }.Contains(menuChoice))
            {
                Console.WriteLine("Please enter a valid number (1-6)");
            }

            if (menuChoice == "1")
            {
                CreateGoal();
            }
            else if (menuChoice == "2")
            {
                ListGoalDetails();
            }
            else if (menuChoice == "3")
            {
                SaveGoals();
            }
            else if (menuChoice == "4")
            {
                LoadGoals();
            }
            else if (menuChoice == "5")
            {
                RecordEvent();
            }
            else
            {
                break;
            }

        } while (menuChoice != "6");
    }

    public void DisplayPlayerInfo()
    // Displays the players current score.
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public string ListGoalNames()
    // Lists the names of each of the goals.
    {
        foreach (Goal g in _goals)
        {
            return $"{g}: ";
        }
        return "";
    }

    public void ListGoalDetails()
    // Lists the details of each goal (including the checkbox of whether it is complete).
    {
        int count = 0;

        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals)
        {
            count++;
            Console.WriteLine($"{count}. {goal.GetDetailString()}");
        }
    }
    public void CreateGoal()
    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        string userGoal;

        Console.WriteLine("\nThe types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        userGoal = Console.ReadLine();

        Console.Write("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("\nWhat is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("\nHow many points do you want associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (userGoal == "1")
        {
            SimpleGoal s1 = new SimpleGoal(name, description, points);
            _goals.Add(s1);
        }

        else if (userGoal == "2")
        {
            EternalGoal e1 = new EternalGoal(name, description, points);
            _goals.Add(e1);
        }

        else if (userGoal == "3")
        {
            Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("\nWhat is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal c1 = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(c1);
        }

    }

    public void RecordEvent()
    // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    {
        
    }

    public void SaveGoals()
    // Saves the list of goals to a file.
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal g in _goals)
            {
                outputFile.Write(ListGoalNames());
                outputFile.Write(g.GetStringRepresentation());
            }
            
        }
    }
    
    public void LoadGoals()
    // Loads the list of goals from a file.
    {

    }
}