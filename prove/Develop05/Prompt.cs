using System;

public class Prompt{
    
    ListGoal listGoal = new ListGoal();

    public void run(){
        Console.Clear();

        string menu = "Menu options\n";
        menu += "1. Create New Goal\n";
        menu += "2. List Goals\n";
        menu += "3. Save Goals\n";
        menu += "4. Load Goals\n";
        menu += "5. Record Event\n";
        menu += "6. Quit\n";
        menu += "Select a choice from the menu: ";

        int maxIterations = 10;
        string input = "";
        for (int i = 0; i < maxIterations; i++){
            Console.Write(menu);
            input = Console.ReadLine();
            if (input == "6"){
                break;
            }

            switch(input) {
                case "1":
                    listGoal.CreateNewGoal();
                    Console.Clear();
                    break;
                case "2":
                    listGoal.DisplayGoalStates();
                    break;
                case "3":
                    listGoal.SaveGoals();
                    break;
                case "4":
                    listGoal.LoadGoals();           
                    break;
                case "5":
                    listGoal.RecordEvent();
                    break;
            }
        }
    }

    
    public void Interface4Simple(){

    }

    public void Interface4Eternal(){

    }

    public void Interface4Checklist(){

    }



}