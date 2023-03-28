using System;

public class Checklist : Goal {

    public Checklist(int goalID) : base(goalID) {
        PromptTotalTasks();
        PromptBonus();
    }

    private void PromptTotalTasks(){
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int totalTasks = int.Parse(Console.ReadLine());
        SetTotalTasks(totalTasks);
    }

    private void PromptBonus(){
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());
        SetBonus(bonus);
    }

    public override string GenerateState(){
        string state = base.GenerateState();
        
        state += " -- Currently completed: ";
        state += $"{GetCompletedTasks().ToString()}/{GetTotalTasks().ToString()}";
        
        return state;
    }

}