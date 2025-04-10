using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
    }
    public void start()
    {
        bool quit = true;
        while (quit)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a Choice from the menu: ");
            string menu = Console.ReadLine();
            Console.WriteLine("");
            switch (menu)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    quit = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"you have {_score} points \n");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetShortName()}");
            
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine("");
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();
        Console.Write("what is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("what is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("what is the amount associated whit this goal? ");
        string goalAmount = Console.ReadLine();
        switch (goalChoice)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalAmount);
                _goals.Add(simpleGoal);
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalAmount);
                _goals.Add(eternalGoal);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string targetInput = Console.ReadLine();
                int target = int.Parse(targetInput);
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonusInput = Console.ReadLine();
                int bonus = int.Parse(bonusInput);
                ChecklistGoal checklistGoal = new ChecklistGoal(target, bonus, goalName, goalDescription, goalAmount);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal you accomplish? ");
        string choiceInput = Console.ReadLine();
        int choice = int.Parse(choiceInput);
        _goals[choice - 1].RecordEvent();
        _score = _score + int.Parse(_goals[choice - 1].GetPoints());
    }
    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] goals = System.IO.File.ReadAllLines(filename);

        foreach (string line in goals)
        {
            string[] goalLine = line.Split(",");
            
            if (goalLine.Count() == 1)
            {
                _score = int.Parse(goalLine[0]);
            }
            else
            {
                string name = goalLine[0];
                string description = goalLine[1];
                string points = goalLine[2];

                if (goalLine.Count() == 3)
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (goalLine.Count() == 4)
                {
                    bool isComplete = bool.Parse(goalLine[3]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    simpleGoal.SetIsComplete(isComplete);
                    _goals.Add(simpleGoal);
                }
                else if (goalLine.Count() == 5)
                {
                    int target = int.Parse(goalLine[3]);
                    int bonus = int.Parse(goalLine[4]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(target, bonus, name, description, points);
                    _goals.Add(checklistGoal);
                }   
            }            
        }
    }
}