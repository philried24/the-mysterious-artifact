/**********************************************************************************************************

                                          The Mysterious Artifact
                                             by Philipp Riedel
                                                  CSC 240
                                                March 2022
                                                Project #2
                     
ABOUT THE GAME:
As an accomplished archaeologist, you've always been fascinated by the mysteries of the past. So when
rumors begin to circulate about a powerful ancient artifact that could grant unlimited power to its
possessor, you know that you must find it.
But you're not the only one on the trail of this artifact. A ruthless mercenary has also set his sights on
the prize, and he'll stop at nothing to get it before you do.
The race is on to uncover the artifact's location, but it won't be an easy journey. You are sure that you
are in the town where the artifact is, but you do not know the exact location. And when you finally reach
your destination, you'll face your greatest challenge yet. The mercenary will be waiting for you, armed
and dangerous, ready to do whatever it takes to claim the artifact for himself. It's up to you to fight back
and ensure that this powerful artifact doesn't fall into the wrong hands.
Are you ready to take on this perilous adventure and emerge victorious over your rival? The fate of the
artifact, and perhaps even the world, rests in your hands.

WARNING:
This game is an adventure action game and is rated PG.
As such, parental guidance is suggested - some materials may not be suiable for children!

*************************************************************************************************************/

using System;
class MysteriousArtifact
{
    // Game variables declaration
    public static bool haveGemstone;                        // Verify if the player has the gemstone or not.  Defaulted to no/false.
    public static bool haveNote;                            // Verify if the player has the note or not.
    public static int playerHealth;                         // Health of the player
    public static int mercenaryCurrentHealth;               // Set mercenary's health to be maximum at the start of the game.
    public static string[] backpack;                        // set inventory to have 10 items max.
    public static int currentInventoryCount;                // count of the inventory


    /////////////////////
    // RESET GAME DATA //
    /////////////////////
    static void resetGameData()
    {
        // Reset game data before restarting the game
        haveGemstone = false;                   // Verify if the player has the gemstone or not.  Defaulted to no/false.
        haveNote = false;                       // Verify if the player has the note or not.
        playerHealth = 100;                     // Set the player health to 100.
        mercenaryCurrentHealth = 100;           // Set mercenary's health to be maximum at the start of the game.
        backpack = new string[10];              // set inventory to have 10 items max.
        currentInventoryCount = 0;              // reset inventory number of items to zero.
    }

    //////////////////
    // MAIN PROGRAM //
    //////////////////
    public static void Main()
    {
        resetGameData();    // This will does a refresh of the game data.
        theIntroduction();  // This will explain about the game to the player.
        theLibrary();       // This is where your character starts out.
    }

    //////////////////////
    // THE INTRODUCTION //
    //////////////////////
    static void theIntroduction()
    {
        Console.Clear(); // This will clear the screen and move the cursor to the top-left of the screen
        Console.WriteLine();
        Console.WriteLine("The Mysterious Artifact");
        Console.WriteLine("by Philipp Riedel");
        Console.WriteLine("CSC 240");
        Console.WriteLine("Project #2");
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        Console.WriteLine("INTRODUCTION:");
        Console.WriteLine("As an accomplished archaeologist, you've always been fascinated by the mysteries of the past. So when");
        Console.WriteLine("rumors begin to circulate about a powerful ancient artifact that could grant unlimited power to its");
        Console.WriteLine("possessor, you know that you must find it.");
        Console.WriteLine("But you're not the only one on the trail of this artifact. A ruthless mercenary has also set his sights on");
        Console.WriteLine("the prize, and he'll stop at nothing to get it before you do.");
        Console.WriteLine("The race is on to uncover the artifact's location, but it won't be an easy journey. You are sure that you");
        Console.WriteLine("are in the town where the artifact is, but you do not know the exact location. And when you finally reach");
        Console.WriteLine("your destination, you'll face your greatest challenge yet. The mercenary will be waiting for you, armed");
        Console.WriteLine("and dangerous, ready to do whatever it takes to claim the artifact for himself. It's up to you to fight back");
        Console.WriteLine("and ensure that this powerful artifact doesn't fall into the wrong hands.");
        Console.WriteLine("Are you ready to take on this perilous adventure and emerge victorious over your rival? The fate of the");
        Console.WriteLine("artifact, and perhaps even the world, rests in your hands.");

        Console.WriteLine("\nPossible commands: directions (N,S,E,W,NE,NW,SE,SW), take <item>, I/inventory, attack, and others.");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        Console.WriteLine();

        // Game rating warning //
        Console.WriteLine("WARNING:");
        Console.WriteLine("This game is an adventure action game and is rated PG.");
        Console.WriteLine("As such, parental guidance is suggested - some materials may not be suiable for children!\n");

        // Request for the character's name
        Console.Write("Please provide your character's name: ");
        string characterName = Console.ReadLine();
        Console.WriteLine($"\nWelcome {characterName}!");

        Console.WriteLine($"\n{characterName},");
        Console.WriteLine("You are in an old library in a town named Hillcrest. Because of several studies and puzzles you");
        Console.WriteLine("succeeded, you are certain that the mysterious artifact must be in or near this town. You can feel that");
        Console.WriteLine("your destination is near.");
        Console.WriteLine("Yet, you are not the only one who wants to find the artifact. There is a mercenary who followed you to");
        Console.WriteLine("this town and you know he is ruthless. That is the reason why you want to find the artifact as soon as");
        Console.WriteLine("possible and you start your journey in this old library.");
        Console.WriteLine("\nPress ENTER to start the game");
        Console.ReadLine();
    }


    /////////////////
    // THE LIBRARY //
    /////////////////

    // Describe to the players what the library looks like. //
    static void theLibraryView()
    {
        Console.WriteLine("\n\nThe Library:");
        Console.WriteLine("-----------:");
        Console.WriteLine("You are in the library. There are many old books and artifacts that can show you the way to the artifact");
        Console.WriteLine("you are searching for.\n");
        if (haveNote == false)
        {
            Console.WriteLine("At one of the books about the artifact you are searching for you notice a note. This must be a hint you are thinking.");
        }
        Console.WriteLine("Exits leading to the east, west and south.\n");
    }

    // What the players can do when inside the old library. //
    static void theLibrary()
    {
        theLibraryView();

        while (true)
        {
            Console.Write("\nWhat would you like to do next? ");
            string playerRespond = Console.ReadLine();
            switch (playerRespond)
            {
                case "S":
                case "s":
                case "go south":
                    jacksonsHouse();
                    break;
                case "E":
                case "e":
                case "go east":
                    museum();
                    break;
                case "W":
                case "w":
                case "go west":
                    townHall();
                    break;
                case "take note":
                    if (haveNote == true)
                    {
                        Console.WriteLine("\nYou already have picked up the note.  It is in your inventory!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nYou picked up the note and it read, ''In the south of Jackson's house''");
                        Console.WriteLine("Somebody must have forgotten this note in the hurry. And this someone is probably the mercanary who is following you.");
                        Console.WriteLine("You know where Jackson's house is but are you prepared to face the mercanary?");
                        haveNote = true;
                        backpack[currentInventoryCount] = "note";
                        currentInventoryCount++;
                    }
                    break;
                case "look":
                    theLibraryView();
                    break;
                case "inventory":
                case "I":
                case "i":
                    inventory();
                    break;
                default:
                    Console.WriteLine($"\nSorry, but I do not understand what is ''{playerRespond}''.");
                    break;
            } // end Switch
        } // End While
    } // End theLibrary()


    /////////////////////
    // Jackson's house //
    /////////////////////

    // Describe to the players what Jackson's house looks like //
    static void jacksonsHouseView()
    {
        Console.WriteLine("\n\nJackson's House:");
        Console.WriteLine("---------------:");
        Console.WriteLine("You are in Jackson’s house. You believe that the entrance to a temple is in this house. Jackson is an old");
        Console.WriteLine("man who can barely see and hear. It was easy to get into his giant house without waking him up. After a");
        Console.WriteLine("quick search you found the entrance to the temple in the basement of the house. Unfortunately, the");
        Console.WriteLine("door is open, so another person is in there too. And you have a feeling who that is.");
        Console.WriteLine("Exits leading north-west,north and south (into the temple).");
    }

    // What the players can do inside Jackson's house. //
    static void jacksonsHouse()
    {
        jacksonsHouseView();

        while (true)
        {
            Console.Write("\nWhat would you like to do next?");
            string playerRespond = Console.ReadLine();
            switch (playerRespond)
            {
                case "N":
                case "n":
                case "go north":
                    theLibrary();
                    break;
                case "NW":
                case "nw":
                case "go north-west":
                    townHall();
                    break;
                case "S":
                case "s":
                case "go south":
                    temple();
                    break;
                case "look":
                    jacksonsHouseView();
                    break;
                case "inventory":
                case "I":
                case "i":
                    inventory();
                    break;
                default:
                    Console.WriteLine($"\nSorry, but I do not understand what is ''{playerRespond}''.");
                    break;
            }
        }

    }   // End of Jackson's house


    ///////////////////
    // THE TOWN HALL //
    ///////////////////

    // Describe to the players what the town hall looks like. //
    static void townHallView()
    {
        Console.WriteLine("\n\nThe Town hall:");
        Console.WriteLine("-----------:");
        Console.WriteLine("You are in the town hall. There are a few people and the mayor. You heard that the mayor is corrupt");
        Console.WriteLine("and arrogant.");
        Console.Write("Exits leading east and south-east.\n");
    } // End of townHallView()

    // What the players can do when inside the town hall. //
    static void townHall()
    {
        townHallView();
        while (true)
        {
            Console.Write("\nWhat would you like to do next? ");
            string playerRespond = Console.ReadLine();
            switch (playerRespond)
            {
                case "SE":
                case "se":
                case "go south-east":
                    jacksonsHouse();
                    break;
                case "E":
                case "e":
                case "go east":
                    theLibrary();
                    break;
                case "look":
                    townHallView();
                    break;
                case "inventory":
                case "I":
                case "i":
                    inventory();
                    break;
                default:
                    Console.WriteLine($"\nSorry, but I do not understand what is ''{playerRespond}''.");
                    break;
            }
        }
    }   // End of townHall()

    ////////////////
    // THE MUSEUM //
    ////////////////

    // Describe to the players what the museum looks like. //
    static void museumView()
    {
        Console.WriteLine("\n\nThe Museum:");
        Console.WriteLine("-----------:");
        Console.WriteLine("You are in the museum. It appears that a theft occurred recently. There are a lot of police officers.");
        if (haveGemstone == false)
        {
            Console.WriteLine("You notice something sparkling on the ground amid all the activity. As you come closer you");
            Console.WriteLine("notice that this is a powerful gemstone. The thieves must have dropped it in the hurry.");
        }
        Console.WriteLine("Exits leading west.");
    } // End of museumView()

    // What the players can do when inside the museum. //
    static void museum()
    {
        museumView();
        while (true)
        {
            Console.Write("\nWhat would you like to do next? ");
            string playerRespond = Console.ReadLine();
            switch (playerRespond)
            {
                case "W":
                case "w":
                case "go west":
                    theLibrary();
                    break;
                case "take gemstone":
                case "take powerful gemstone":
                case "take stone":
                    if (haveGemstone == true)
                    {
                        Console.WriteLine("\nYou already have picked up the gemstone.  It is in your inventory!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nYou picked up the powerful gemstone: ");
                        Console.WriteLine("The powerful gemstone grants you special abilities, such as invisibility, that can help you in the");
                        Console.WriteLine("fight against the mercenary.");
                        haveGemstone = true;
                        backpack[currentInventoryCount] = "gemstone";
                        currentInventoryCount++;
                    }
                    break;
                case "look":
                    museumView();
                    break;
                case "inventory":
                case "I":
                case "i":
                    inventory();
                    break;
                default:
                    Console.WriteLine($"\nSorry, but I do not understand what is ''{playerRespond}''.");
                    break;
            }
        }
    } // End museum()

    ////////////////
    // THE TEMPLE //
    ////////////////

    // Describe to the players what the temple looks like. //
    static void templeView()
    {
        Random rand = new Random();
        int damageFromTraps = rand.Next(0, 15);

        playerHealth = playerHealth - damageFromTraps; // this gives the game random difficulty

        Console.WriteLine("\n\nThe Temple:");
        Console.WriteLine("-----------:");
        Console.WriteLine("You can barely see a thing inside the temple. You have a flashlight with you, so you are going deeper");
        Console.WriteLine("into the temple. It is like a maze down there. Fortunately, because of your whole research you know the");
        Console.WriteLine("way pretty good. Nonetheless there are different traps integrated you must avoid to not get hurt and to");
        Console.WriteLine("damage your health. ");
        if (damageFromTraps == 0)
        {
            Console.WriteLine("But you were lucky! The traps didn't damage your health.");
        }
        else
        {
            Console.WriteLine($"Unfortunately you got hurt! The traps damaged your health by {damageFromTraps}.");
            Console.WriteLine($"Your health is now at {playerHealth}.");
        }
        Console.WriteLine("After a while of searching and avoiding traps, you are finally at the destination of");
        Console.WriteLine("your whole journey. The artifact lies on an altar in the middle of a big room. But your joy does not");
        Console.WriteLine("maintain long because you see a light on the right side of the room, and you have a slight idea who that");
        Console.WriteLine("could be…");

    } // End of templeView()

    // What the player can do when inside the temple. //
    static void temple()
    {
        templeView();

        Console.WriteLine("\nThe final battle for the artifact is about to begin!\n");
        Console.WriteLine($"Your currrent health: {playerHealth} out of {100}");

        Console.WriteLine($"The mercenary's current health: {mercenaryCurrentHealth} out of {100}");

        if (haveGemstone == true)
            Console.WriteLine("\nYou are also carrying the powerful gemstone. That will help against the attacks of the mercenary.\n");

        Console.WriteLine("\nFor each attack you must decide if you want to attack on the right or the left side of the mercenary.\n");
        Console.WriteLine("Just type in 'left' or 'right'.\n");
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine("You surprised the mercenary durinng his search and therefore you can attack first.\n");

        // Run the battle scene
        theBattle();
    }  // End of temple()


    // The battle //
    static void theBattle()
    {
        Random rand = new Random();
        int maxDamage = 15;
        int mercenaryDamage;
        int playerDamage = 0;
        string playerRespond;
        bool gameOver = false;

        while (!gameOver)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("It's your turn.\n");
            Console.WriteLine("Type in 'left' or 'right'.\n");

            bool help1 = true;
            while (help1 == true)
            {
                playerRespond = Console.ReadLine();
                if (playerRespond == "left")
                {
                    playerDamage = rand.Next(0, maxDamage - 4); // the left side is the weak side of the mercenary
                    help1 = false;
                }
                else if (playerRespond == "right")
                {
                    playerDamage = rand.Next(0, maxDamage);
                    help1 = false;
                }
                else
                {
                    Console.WriteLine($"\nSorry, but I do not understand what is '{playerRespond}'.\n");
                    Console.WriteLine("Type in 'left' or 'right'.\n");
                }
            }
            mercenaryCurrentHealth = mercenaryCurrentHealth - playerDamage;
            if (mercenaryCurrentHealth <= 0)
            {
                Console.WriteLine($"\nYou did {playerDamage} damage to the mercenary.");
                gameOver = true;
                conclusionWin();
            }

            if (playerDamage > 0)
            {
                Console.WriteLine($"\nYou did {playerDamage} damage to the mercenary.");
                Console.WriteLine($"The mercenary's health is now {mercenaryCurrentHealth}.\n");
            }
            else
            {
                Console.WriteLine("\nUuups. You totally missed your enemy.\n");
            }


            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("\nPress Enter key for the mercenary's turn to attack! ");
            playerRespond = Console.ReadLine();


            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.WriteLine("It is the mercenary's turn.. ");

            if (haveGemstone == true)
            {
                mercenaryDamage = rand.Next(0, maxDamage - 8);
            }
            else
            {
                mercenaryDamage = rand.Next(0, maxDamage);

            }
            playerHealth = playerHealth - mercenaryDamage;
            if (playerHealth <= 0)
            {
                gameOver = true;
                conclusionLost();
            }
            if (mercenaryDamage == 0)
                Console.WriteLine("\nYou are lucky. The mercenary totally missed you.\n");    // This was added for additional dialog.
            else
            {
                Console.Write($"He hit you and your health is going down by: {mercenaryDamage} \n");
                Console.WriteLine($"Your current health is now {playerHealth}.\n");
            }

        }
    } // theBattle

    // Conclusion - LOST //
    static void conclusionLost()
    {
        Console.WriteLine("\n\nAs you battle the mercenary, it becomes clear that the enemy is more skilled and better equipped for ");
        Console.WriteLine("combat. Your attacks are parried or easily avoided, while the mercenary lands strikes with deadly");
        Console.WriteLine("precision. As the fight wears on, you begin to tire and make mistakes, leaving yourself open to the");
        Console.WriteLine("mercenary's counterattacks. You start to feel the weight of your exhaustion and realize that you");
        Console.WriteLine("underestimated the mercenary's combat abilities. It becomes clear that the mercenary's training and");
        Console.WriteLine("experience have given them an advantage in this fight, and you may need to find a different strategy to win. \n");
        Console.WriteLine("\n\nSorry, you have lost.\n");

        restartOption();
    } // End of conclusionLost()

    // Conclusion - WIN //
    static void conclusionWin()
    {
        Console.WriteLine("\nAs you battle the mercenary, it becomes clear that you have the upper hand. Your attacks are precise");
        Console.WriteLine("and calculated, catching the mercenary off guard, and leaving them with no openings to counterattack.");
        Console.WriteLine("As the fight wears on, your confidence grows, and you begin to predict the mercenary's moves before");
        Console.WriteLine("they even happen. Your superior combat skills, combined with the powerful gemstone (if found), gives");
        Console.WriteLine("you a significant advantage in this fight. It becomes clear that your training and knowledge have given");
        Console.WriteLine("you the upper hand in this fight, and you can sense the victory over your enemy.");
        Console.WriteLine("\n\nCongratulations, you won!\n");

        restartOption();
    } // End of conclusionWin()


    /////////////
    // RESTART //
    /////////////
    static void restartOption()
    {
        string playerReady, playerRespond;

        Console.Write("\nWould you like to restart this game? ");
        playerRespond = Console.ReadLine();
        if ((playerRespond == "Y") || (playerRespond == "y") || (playerRespond == "yes") || (playerRespond == "YES"))
        {
            Console.WriteLine("\n\nPlease press the Enter key to restart the game! ");
            playerReady = Console.ReadLine();
            // Run the Main program
            Main();
        }
        else
        {
            Console.Write("\nThank you for playing the Mysterious Artifact!");
            gameCredits();
        }
    }

    //////////////////////
    // End game credits //
    //////////////////////
    static void gameCredits()
    {
        Console.WriteLine("\n\n===============================================================================");
        Console.WriteLine("     The Mysterious Artifact");
        Console.WriteLine("     Designed and developed by Philipp Riedel");
        Console.WriteLine("     for CSC 240, Project #2");
        Console.WriteLine("     Copyright © 2023");
        Console.WriteLine("===============================================================================\n\n");
        Environment.Exit(1); // Safely exit the program
    }

    //////////////////////////////////////////
    //            INVENTORY                 //
    // The players can see their inventory. //
    //////////////////////////////////////////
    static void inventory()
    {
        if (currentInventoryCount == 0)
            Console.WriteLine("\nYou currently are not carrying any items.\n");
        else
        {
            Console.WriteLine("\nCurrently you are carrying the folllowing items:\n");
            for (int counter = 0; counter < currentInventoryCount; counter++)
            {
                Console.WriteLine($"{counter + 1}: {backpack[counter]}");
            }
        }
    } // End of inventory()
} //End of MysteriousArtifact class