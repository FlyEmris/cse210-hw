using System;
using System.IO;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        int userPoints = 0;
        int option = 0;

        bool completedSimpleGoal = false;
        List<Goal> listOfGoals = new List<Goal>();



        while(option != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {userPoints} points.");
            Console.WriteLine();
            Console.WriteLine("[1] Create a New Goal");
            Console.WriteLine("[2] List Goals");
            Console.WriteLine("[3] Save Goals");
            Console.WriteLine("[4] Load Goals");
            Console.WriteLine("[5] Record Event");
            Console.WriteLine("[6] Quit");
            Console.WriteLine("Select a choice from the Menu:  ");
            option = int.Parse(Console.ReadLine());
        



        switch (option)
        {
            case 1:
                    Console.Clear();
                    Console.WriteLine("The type of Goals are: ");
                    Console.WriteLine("[1] Simple Goal");
                    Console.WriteLine("[2] Eternal Goal ");
                    Console.WriteLine("[3] Checklist Goal ");
                    Console.Write("Which type of goal would you like to create? ");
                    int goalOption = int.Parse(Console.ReadLine());
                    switch (goalOption)
                    {
                        case 1:
                            Console.Clear();
                            
                            Console.Write("What is the name of your goal? ");
                            string simpleGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string simpleGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount assosiated to this goal? ");
                            int simpleGoalPoints = int.Parse(Console.ReadLine());
                            
                            bool finished = false;
                            SimpleGoal simpleGoal = new(simpleGoalName, simpleGoalDescription, simpleGoalPoints, finished);
                            
                            listOfGoals.Add(simpleGoal);
                            break;

                        case 2:
                            Console.Clear();
                            
                            Console.Write("What is the name of your goal? ");
                            string eternalGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string eternalGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount assosiated to this goal? ");
                            int eternalGoalPoints = int.Parse(Console.ReadLine());
                            
                            EternalGoal eternalGoal = new(eternalGoalName, eternalGoalDescription, eternalGoalPoints);
                        
                            listOfGoals.Add(eternalGoal);
                            break;

                        case 3:
                            Console.Clear();
                            
                            Console.Write("What is the name of your goal? ");
                            string checklistGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string checklistGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount assosiated to this goal? ");
                            int checklistGoalPoints = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int checklistcheckCounter = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplish at that many times? ");
                            int checklistBonusCompleted = int.Parse(Console.ReadLine());
                                                       
                            int checkListCounter = 0;
                            
                            CheckListGoal checklistGoal = new(checklistGoalName, checklistGoalDescription, checklistGoalPoints, checklistcheckCounter, checklistBonusCompleted, checkListCounter);
                            
                            listOfGoals.Add(checklistGoal);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Ah Ah Ah  Thats not a option");
                            break; 
                            
                    }
                    break;



                case 2:
                    Console.Clear();
                    Console.WriteLine("THe goals are: ");
                    Console.WriteLine();

                    int count = 1;
                    foreach (var goal in listOfGoals)
                    {
                        Console.WriteLine(count + ". " + goal.GetInformation());
                        count++;
                    }
                    break;


                case 3:
                    Console.Clear();
                    Console.Write("What is the filename for the goal file? ");
                    string fileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine(userPoints);

                        foreach (var goal in listOfGoals)
                        {
                            outputFile.WriteLine(goal.GetRepresentation());
                        }
                    }
                    break;



                case 4:
                    Console.Clear();
                    Console.Write("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();

                    string[] linesInFile = System.IO.File.ReadAllLines(fileName);

                    string firstLine = linesInFile[0];
                    userPoints = int.Parse(firstLine);

                    List<Goal> tempList = new List<Goal>();
                    for (int i = 0; i < linesInFile.Length; i++)
                    {
                        if (i != 0)
                        {
                            var parts = linesInFile[i].Split(':')[1].Split(',');

                            if (linesInFile[i].StartsWith("SimpleGoal:"))
                            {
                                SimpleGoal simpleGoal = new(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                                tempList.Add(simpleGoal);

                                if (!tempList.Any(goal => goal.GetName()  == simpleGoal.GetName()))
                                {
                                    tempList.Add(simpleGoal);
                                }
                            }

                            else if (linesInFile[i].StartsWith("EternalGoal:"))
                            {
                               EternalGoal eternalGoal = new(parts[0], parts[1], int.Parse(parts[2]));

                                
                                if (!tempList.Any(goal => goal.GetName() == eternalGoal.GetName()))
                                {
                                    tempList.Add(eternalGoal);
                                } 
                            }

                            else if (linesInFile[i].StartsWith("CheckListGoal:"))
                            {
                                CheckListGoal checkListGoal = new(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                                tempList.Add(checkListGoal);
                                
                                if (!tempList.Any(goal => goal.GetName() == checkListGoal.GetName()))
                                {
                                    tempList.Add(checkListGoal);
                                }
                            }
                        }
                    }

                    listOfGoals = tempList;
                    break;



                case 5:
                    Console.Clear();
                    Console.Write("Which is the goal you accomplished? ");
                    int numberToDelete = int.Parse(Console.ReadLine());

                    int indexToDelete = numberToDelete - 1;

                    if (indexToDelete >= 0 && indexToDelete < listOfGoals.Count)
                    {
                        
                        Goal goalToDelete = listOfGoals[indexToDelete];

                        
                        if (goalToDelete is SimpleGoal)
                        {
                            
                            userPoints = ((SimpleGoal)goalToDelete).GetCompleted(userPoints);
                            if (completedSimpleGoal == false)
                            {
                                
                                Console.WriteLine($"Congratulations! You have earned {goalToDelete.GetPoints()} points!");
                                Console.WriteLine($"You now have {userPoints} points.");
                                completedSimpleGoal = true;
                            }

                        }
                        
                        if (goalToDelete is EternalGoal)
                        {
                            userPoints = ((EternalGoal)goalToDelete).GetCompleted(userPoints);
                            Console.WriteLine($"Congratulations! You have earned {goalToDelete.GetPoints()} points!");

                        }
                        
                        if (goalToDelete is CheckListGoal)
                        {
                            userPoints = ((CheckListGoal)goalToDelete).GetCompleted(userPoints);
                            if (!goalToDelete.GetInformation().StartsWith("[X]"))
                            {
                                
                                Console.WriteLine($"Congratulations! You have earned {goalToDelete.GetPoints()} points!");
                                Console.WriteLine($"You now have {userPoints} points.");
                            }
                            else
                            {

                            }

                        }

                        listOfGoals.RemoveAt(indexToDelete);
                        listOfGoals.Insert(indexToDelete, goalToDelete);

                        Console.WriteLine();
                    }
                    break;


                case 6:
                    break;


                default:
                    Console.Clear();
                    Console.WriteLine("Ah ah ah not a correct option.");
                    break;
            }
        }
    }
}