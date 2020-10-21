using System;
using System.Collections.Generic;

namespace ArrayAndStringAssignment
{
    class Program
    {
        public static string Target()
        {
            string[] stringArray = new string[4];
            stringArray[0] = "Kilrah";
            stringArray[1] = "Romulus";
            stringArray[2] = "LV-426";
            stringArray[3] = "Klendathu";

            int targetIndex = 0;
            string targetLocked = "";
            bool userChoice = false;

            while (!userChoice)
            {
                Console.WriteLine("Select the index of the planet to target:  Choices are 1 - 4.");
                targetIndex = Convert.ToInt32(Console.ReadLine());

                switch (targetIndex)
                {
                    case 1:
                        Console.WriteLine("You have targeted " + stringArray[0] + ", home planet of the vicious Kilrathi. Target locked.");
                        targetLocked = stringArray[0];
                        userChoice = true;
                        break;
                    case 2:
                        Console.WriteLine("You have targeted " + stringArray[1] + ", home planet of the treacherous Romulans. Target locked.");
                        targetLocked = stringArray[1];
                        userChoice = true;
                        break;
                    case 3:
                        Console.WriteLine("You have targeted " + stringArray[2] + ", last known location of the deadly xenomorphs. Target locked.");
                        targetLocked = stringArray[2];
                        userChoice = true;
                        break;
                    case 4:
                        Console.WriteLine("You have targeted " + stringArray[3] + ", home world of the merciless Arachnids. Target locked.");
                        targetLocked = stringArray[3];
                        userChoice = true;
                        break;
                    default:
                        Console.WriteLine("Index not recognized.  Space missiles are only authorized for use on certain planets.");
                        break;
                }
            }
            return targetLocked;      
        }

        static int Missile(string targetLocked)
        {
            int[] intArray = new int[4];
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;

            int missileAmount = 0;
            bool missileChoice = false;

            while (!missileChoice)
            {
                Console.WriteLine("Select the number of missiles to fire at " + targetLocked + ". Command authorizes the option of 1 - 4 missiles.");
                missileAmount = Convert.ToInt32(Console.ReadLine());

                switch (missileAmount)
                {
                    case 1:
                        Console.WriteLine("Confirmed. " + intArray[0] + " space missile loaded into space missile launcher.");
                        missileAmount = intArray[0];
                        missileChoice = true;
                        break;
                    case 2:
                        Console.WriteLine("Confirmed. " + intArray[1] + " space missiles loaded into space missile launcher.");
                        missileAmount = intArray[1];
                        missileChoice = true;
                        break;
                    case 3:
                        Console.WriteLine("Confirmed. " + intArray[2] + " space missiles loaded into space missile launcher.");
                        missileAmount = intArray[2];
                        missileChoice = true;
                        break;
                    case 4:
                        Console.WriteLine("Confirmed. " + intArray[3] + " space missiles loaded into space missile launcher.");
                        missileAmount = intArray[3];
                        missileChoice = true;
                        break;
                    default:
                        Console.WriteLine("You have entered an unauthorized value. Command has been notified.");
                        break;
                }
            }
            return missileAmount;
        }

        static void Confirm(string targetLocked, int missileAmount)
        {
            string missileAmountString = Convert.ToString(missileAmount);
            List<string> attackConfirmationList = new List<string>();
            attackConfirmationList.Add(targetLocked);
            attackConfirmationList.Add(missileAmountString);

            bool targetConfirmation = false;
            bool missileConfirmation = false;

            while (!targetConfirmation && !missileConfirmation)
            {
                Console.WriteLine("Configuration complete. Please enter '1' to confirm target.  Please enter '2' to confirm missile quantity.");
                int userConfirmation = Convert.ToInt32(Console.ReadLine());

                switch (userConfirmation)
                {
                    case 1:
                        Console.WriteLine("The current target is " + attackConfirmationList[0] + ". Would you like to change targets? Please enter 'Yes' or 'No'.");
                        string answerOne = Console.ReadLine();
                        if (answerOne == "Yes")
                        {
                            targetLocked = Target();
                            targetConfirmation = true;
                            Console.WriteLine("Would you like to change the amount of missiles to be fired?  Please enter 'Yes' or 'No'.");
                            string answerTwo = Console.ReadLine();
                            if (answerTwo == "Yes")
                            {
                                missileAmount = Missile(targetLocked);
                                missileConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                            else if (answerTwo == "No")
                            {
                                Console.WriteLine("Missile quantity is set.");
                                missileConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input interpreted as a confirmation");
                                missileConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else if (answerOne == "No")
                        {
                            Console.WriteLine("Target is set.");
                            targetConfirmation = true;
                            Console.WriteLine("Would you like to change the amount of missiles to be fired?  Please enter 'Yes' or 'No'.");
                            string answerTwo = Console.ReadLine();
                            if (answerTwo == "Yes")
                            {
                                missileAmount = Missile(targetLocked);
                                missileConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                            else if (answerTwo == "No")
                            {
                                Console.WriteLine("Missile quantity is set.");
                                missileConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input interpreted as a confirmation");
                                missileConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Input interpreted as a confirmation");
                            targetConfirmation = true;
                            Console.WriteLine("Would you like to change the amount of missiles to be fired?  Please enter 'Yes' or 'No'.");
                            string answerTwo = Console.ReadLine();
                            if (answerTwo == "Yes")
                            {
                                Missile(targetLocked);
                                break;
                            }
                            else if (answerTwo == "No")
                            {
                                Console.WriteLine("Missile quantity is set.");
                                missileConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input interpreted as a confirmation");
                                missileConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                        }
                    case 2:
                        Console.WriteLine("The current missile quantity is " + attackConfirmationList[1] + ". Would you like to change space missile amount? Please enter 'Yes' or 'No'.");
                        string answerThree = Console.ReadLine();
                        if (answerThree == "Yes")
                        {
                            missileAmount = Missile(targetLocked);
                            missileConfirmation = true;
                            Console.WriteLine("Missile quantity is set.");
                            missileConfirmation = true;
                            Console.WriteLine("Would you like to change targets? Please enter 'Yes' or 'No'.");
                            string answerFour = Console.ReadLine();
                            if (answerFour == "Yes")
                            {
                                targetLocked = Target();
                                targetConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                            else if (answerFour == "No")
                            {
                                Console.WriteLine("Target is set.");
                                targetConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input interpreted as a confirmation");
                                targetConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else if (answerThree == "No")
                        {
                            Console.WriteLine("Missile quantity is set.");
                            missileConfirmation = true;
                            Console.WriteLine("Would you like to change targets? Please enter 'Yes' or 'No'.");
                            string answerFour = Console.ReadLine();
                            if (answerFour == "Yes")
                            {
                                targetLocked = Target();
                                targetConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                            else if (answerFour == "No")
                            {
                                Console.WriteLine("Target is set.");
                                targetConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input interpreted as a confirmation");
                                targetConfirmation = true;
                                Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                                Console.WriteLine("Have a great day!");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Input interpreted as a confirmation");
                            Console.WriteLine("All parameters set.  The destruction of " + targetLocked + " by " + missileAmount + " space missiles is underway.");
                            Console.WriteLine("Have a great day!");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        Console.WriteLine("Input not accepted.  Command has been notified.");
                        break;
                }
            }
            
        }

        
        static void Main(string[] args)
        {
            string targetLocked = "";
            int missileAmount = 0;
            Console.WriteLine("Space missle command center operational.  Ready for configuration.");
            targetLocked = Target();
            missileAmount = Missile(targetLocked);
            Confirm(targetLocked, missileAmount);
        }

    }
}
