using System;

class CastleDefence
{
    static void Main()
    {

        Console.WriteLine("You're the new commander right? What's your name?");
        string name = Console.ReadLine();

        Console.WriteLine("\nCommander " + name + " Our castle is under siege attack and the enemy is attacking in many different ways. You need to find solutions against their attacks. ");

        int totalScore = 0;


        Console.WriteLine("\nCommander " + name + " The enemy is attacking with siege weapons. What is your decision ?");
        Console.WriteLine("\na) Counterattack with our own siege weapons \nb) Shoot siege weapon users with our archers \nc) Raise your shields and hide behind the castle walls");
        string answer1 = Console.ReadLine();
        if (answer1 == "a")
            totalScore += 15;
        else if (answer1 == "b")
            totalScore += 10;
        else if (answer1 == "c")
            totalScore += 5;

        Console.WriteLine("\nCommander " + name + " Enemy archers take aim at our soldiers What is your decision ?");
        Console.WriteLine("\na) Raise your shields and intercept their arrows \nb) Charge straight towards their archers \nc) May our archers respond in kind");
        string answer2 = Console.ReadLine();
        if (answer2 == "a")
            totalScore += 10;
        else if (answer2 == "b")
            totalScore += 0;
        else if (answer2 == "c")
            totalScore += 5;

        Console.WriteLine("\nCommander " + name + " The enemy is putting ladders against the castle walls and trying to climb What is your decision ?");
        Console.WriteLine("\na) Shoot the enemy trying to climb the stairs \nb) Run straight to the wall and knock down the ladders \nc) Let's wait on the wall with our soldiers and fight the enemy ");
        string answer3 = Console.ReadLine();
        if (answer3 == "a")
            totalScore += 5;
        else if (answer3 == "b")
            totalScore += 15;
        else if (answer3 == "c")
            totalScore += 0;
        Console.WriteLine("\nCommander " + name + " The enemy is trying to break our castle gate with a battering ram. What is your decision ?");
        Console.WriteLine("\na) Stand behind the castle gate and try to hold the gate \nb) Shoot the battering ram with siege weapons \nc) Open the gate and attack the enemy before the battering ram hits the gate");
        string answer4 = Console.ReadLine();
        if (answer4 == "a")
            totalScore += 15;
        else if (answer4 == "b")
            totalScore += 10;
        else if (answer4 == "c")
            totalScore += 5;
        Console.WriteLine("\nCommander" + name + "The enemy started to enter the castle. What is your decision ?");
        Console.WriteLine("\na)All soldiers out of the castle and let's try to move the battle outside the castle \nb) Gather all the soldiers in the center of the castle and try to defeat them all together from one area \nc)Our troops should split up and intervene in separate places where the enemy is attacking.");
        string answer5 = Console.ReadLine();
        if (answer5 == "a")
            totalScore += 5;
        else if (answer5 == "b")
            totalScore += 10;
        else if (answer5 == "c")
            totalScore += 15;


        if (totalScore >= 60)
        {
            Console.WriteLine("Commander " + name + " Thanks to your excellent choices, we won the war with almost no casualties and no damage to our castle. I congratulate you sir.");
        }
        else if (totalScore >= 40)
        {
            Console.WriteLine("Commander " + name + " We lost many soldiers and our castle suffered a lot of damage, but we still managed to defeat the enemy because of your decisions.");
        }
        else if (totalScore >= 20)
        {
            Console.WriteLine("Commander " + name + " Your decisions failed, we lost the war and our castle was captured. Now our lives are at the mercy of our enemies.");
        }
        else if (totalScore >= 0)
        {
            Console.WriteLine("You said meaningless answers and words and lost the whole war. You are the worst commander I have ever seen in my life. I hope I see our enemies take your head.");
        }

    }
}
