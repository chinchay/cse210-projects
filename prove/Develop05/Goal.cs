using System;

public class Goal{
    private int _goalID;

    private string _name;
    private string _description;

    private bool _isComplete;
    private int _pointsPerEvent = 0;
    private int _currentPoints = 0;
    private int _totalTasks = 1;
    private int _completedTasks = 0;
    private int _bonus = 0;

    public Goal(int goalID){
        _goalID = goalID;
        PromptName();
        PromptDescription();
        PromptPointsPerEvent();
    }

    public void SetName(string name){_name = name;}
    public void SetDescription(string description){_description = description;}
    public void SetPointsPerEvent(int pointsPerEvent){ _pointsPerEvent = pointsPerEvent;}
    public void SetTotalTasks(int totalTasks){ _totalTasks = totalTasks;}
    public void SetBonus(int bonus){_bonus = bonus;}
    public int GetGoalID(){return _goalID;}
    public string GetName(){return _name;}
    public string GetDescription(){return _description;}
    public bool GetIsComplete(){return _isComplete;}
    public int GetPointsPerEvent(){return _pointsPerEvent;}
    public int GetCurrentPoints(){return _currentPoints;}
    public int GetTotalTasks(){return _totalTasks;}
    public int GetCompletedTasks(){return _completedTasks;}
    public int GetBonus(){return _bonus;}


    private void PromptName(){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        SetName(name);
    }

    private void PromptDescription(){
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        SetDescription(description);
    }

    private void PromptPointsPerEvent(){
        Console.Write("What is the amount of points associated with this goal? ");
        int pointsPerEvent = int.Parse(Console.ReadLine());
        SetPointsPerEvent(pointsPerEvent);
    }

    public virtual string GenerateState(){

        string state = "";
        state += _goalID.ToString() + ". ";
        state += "[";

        if (_isComplete){
            state += "X";
        }else{
            state += " ";
        }
        
        state += $"] {GetName()} ({GetDescription()})";

        return state;
    }

    public virtual string GenerateShortState(){

        string state = "";
        state += _goalID.ToString() + ". ";
        state += $"{GetName()} ({GetDescription()})";

        return state;
    }    

    public virtual void RecordEvent(){
        _currentPoints  += _pointsPerEvent;
        _completedTasks += 1;
        _isComplete = (_completedTasks == _totalTasks);
        if (_isComplete){
            _currentPoints += _bonus;
        }
    }


}