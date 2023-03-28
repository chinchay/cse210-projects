using System;

public class ListGoal{

    private List<Goal> _listGoal = new List<Goal>();
    private int _goalID = 0;

    public void CreateNewGoal(){
        string text = "The types of Goals are:\n";
        text += "  1. Simple Goal\n";
        text += "  2. Eternal Goal\n";
        text += "  3. Checklist Goal\n";
        text += "Which type of goal would you like to create? ";
        Console.Write(text);
        string goalType = Console.ReadLine();
        
        Goal goal;
        _goalID += 1;

        switch(goalType){
            case "1":
                goal = new Simple(_goalID);
                break;
            case "2":
                goal = new Eternal(_goalID);
                break;
            case "3":
                goal = new Checklist(_goalID);
                break;
            default:
                goal = new Simple(_goalID);
                break;
        }

        _listGoal.Add(goal);
    }

    public void DisplayGoalStates(){

        foreach( Goal goal in _listGoal ){
            Console.WriteLine(goal.GenerateState());
        }

        ShowPoints();
    }

    public void ShowPoints(){
        int points = 0;
        foreach( Goal goal in _listGoal ){
            points += goal.GetCurrentPoints();
        }
        Console.WriteLine($"You have {points.ToString()} points.\n");
    }

    public void RecordEvent(){
        Console.WriteLine("The goals are:");
        foreach( Goal goal in _listGoal ){
            Console.WriteLine(goal.GenerateShortState());
        }

        Console.Write("Which goal did you accomplish? ");
        int goalAccomplished = int.Parse(Console.ReadLine()) - 1;

        _listGoal[goalAccomplished].RecordEvent();
        string text = "";
        text  = "Congratulations! You have earned ";
        text += _listGoal[goalAccomplished].GetPointsPerEvent().ToString();
        text += " points!";
        Console.WriteLine(text);
        
        ShowPoints();
    }

    private string PromptFileName(){
        Console.WriteLine("What is the file name for the goal file? ");
        return Console.ReadLine();
    }

    public void SaveGoals(){
        string filename = PromptFileName();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Goal goal in _listGoal){
                
                outputFile.WriteLine($"{goal.GetGoalID()},");
                outputFile.WriteLine($"{goal.GetName()},");
                outputFile.WriteLine($"{goal.GetDescription()},");
                outputFile.WriteLine($"{goal.GetIsComplete()},");
                outputFile.WriteLine($"{goal.GetPointsPerEvent()},");
                outputFile.WriteLine($"{goal.GetCurrentPoints()},");
                outputFile.WriteLine($"{goal.GetTotalTasks()},");
                outputFile.WriteLine($"{goal.GetCompletedTasks()},");
                outputFile.WriteLine($"{goal.GetBonus()},");
                
            }
        }

    }

    public void LoadGoals(){
        string filename = PromptFileName();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            int goalID         = int.Parse(parts[0]);
            string name        = parts[1];
            string description = parts[2];
            bool isComplete    = Convert.ToBoolean(parts[3]);
            int pointsPerEvent = int.Parse(parts[4]);
            int currentPoints  = int.Parse(parts[5]);
            int totalTasks     = int.Parse(parts[6]);
            int completedTasks = int.Parse(parts[7]);
            int bonus          = int.Parse(parts[8]);
        }       



    }
}