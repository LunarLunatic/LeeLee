//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace QuizTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaration of variables
            int choice;
            int userInputValue;
            int CORRECT_ANSWER = 3;
            int WRONG_ANSWER = 1;
            int INVALID = 0;
            int BONUS_POINT = 1;
            bool all_correct = true;
            int points = 0;

            Console.WriteLine("Game theory is the study of mathematical models of strategic interaction among rational decision-makers. It has applications in all fields of social science, as well as in logic, systems science, and computer science.");
            Console.WriteLine("");
            //Question1: Multiple choice
            Console.WriteLine("1.Logic and game-theory come together in a different way in the research on computational social choice, which deals with the design of voting or auction systems, or other mechanisms for collective decision making as traditionally studied in the social sciences, under constraints on efficient computation, as studied in theoretical computer science and logic. Which one of these games applies logic when winning ?");
            Console.WriteLine("");
            Console.WriteLine("1)Chess 2)Pachinko 3)Roulette 4)Flappy Bird");
            Console.WriteLine("Answer : ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1)
                    points = points + CORRECT_ANSWER;
                else if (choice == 2 || choice == 3 || choice == 4)
                {
                    all_correct = false;
                    points = points + WRONG_ANSWER;
                }
            }
            else
            {
                all_correct = false;
                points = points + INVALID;
            }
            Console.WriteLine("");
            Console.WriteLine("The Centipede game and how it applies to economics");
            Console.WriteLine("");
            Console.WriteLine("Some key points to how this game applies to economics is:" +
                "The centipede game is a game in which two players alternate to take a share of an ever-increasing sum of money." +
                " It is an innovative approach to the conflict between self-interest and mutual benefit." +
                " Studies show that only a very small percentage of subjects chose to pass the stash to increase the quantity of their stash.");
            Console.WriteLine("");
            Console.WriteLine("Understanding Centipede Game");
            Console.WriteLine("");
            Console.WriteLine("As an example, consider the following version of the centipede game involving two players, Jack and Jill. The game starts with a total $2 payoff. Jack goes first, and has to decide if he should take the payoff or pass If he takes, then he gets $2 and Jill gets $0, but if he passes, the decision to take or pass now must be made by Jill. The payoff is now increased by $2 to $4; if Jill takes, she gets $3 and Jack gets $1, but if she passes, Jack gets to decide whether to take or pass. If she passes, the payoff is increased by $2 to $6; if Jack takes, he would get $4, and Jill would get $2. If he passes and Jill takes, the payoff increases by $2 to $8, and Jack would get $3 while Jill got $5. The game continues in this vein for a total of 100 rounds. If both players always choose to pass, they each receive a payoff of $50 at the end of the game.");
            //Question2: Numeric type
            Console.WriteLine("\n2.Assuming Jack and Jill are at round 30. What would be the payoff at this round?");
            Console.Write("Answer : ");
            if (int.TryParse(Console.ReadLine(), out userInputValue))
            {
                //check if user entered correct answr
                if (userInputValue == 60)
                    //Add 3 points
                    points = points + CORRECT_ANSWER;
                else if (userInputValue < 0)
                {
                    //Add 1 points
                    points = points + WRONG_ANSWER;
                    all_correct = false;
                }
            }
            else
            {
                all_correct = false;
                points = points + INVALID;
            }
            Console.WriteLine("");
            Console.WriteLine("The Prisoners Dilemma is a great example of how game theory works in all fields of social sciences, logic, economics and when making a decision that they think benefit one party but end up making there choices an equilibrium");
            Console.WriteLine("");
            //Question3: Multiple choice
            Console.WriteLine("The Prisoners Dilema");
            Console.WriteLine("Two members of a criminal gang are arrested and imprisoned. Each prisoner is in solitary confinement with no means of communicating with the other. The prosecutors lack sufficient evidence to convict the pair on the principal charge, but they have enough to convict both on a lesser charge. Simultaneously, the prosecutors offer each prisoner a bargain. Each prisoner is given the opportunity either to betray the other by testifying that the other committed the crime, or to cooperate with the other by remaining silent. The possible outcomes are:");
            Console.WriteLine("If Adam and Barry each betray the other, each of them serves two years in prison");
            Console.WriteLine("If Adam betrays Barry but Barry remains silent, Adam will be set free and Barry will serve three years in prison (and vice versa)");
            Console.WriteLine("If Adam and Barry both remain silent, both of them will serve only one year in prison (on the lesser charge)");
            Console.WriteLine("");
            Console.WriteLine("\n\n3.Which scenario do you think both criminals would most benefit or end up? (draw a 2x2 box if needed)");
            Console.WriteLine("");
            Console.WriteLine("1){0,-20} 2){1,-20} 3){2,-20} 4){3,-20}", "Scenario 1: Both deny and get 1 year", "Scenario 2: Adam is free for confessing, Barry gets 3 years for denying", "Scenario 3: Barry is free for confessing, Adam gets 3 years for denying", "Scenario 4: Both confess and get 2 year");
            Console.WriteLine("Answer : ");
            //Check if user choice is valid
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                //check if user entered correct answr
                if (choice == 4)
                    //Add 3 points
                    points = points + CORRECT_ANSWER;
                //valid choice but incorrect answer
                else if (choice == 1 || choice == 2 || choice == 3)
                {
                    //set boolean to false
                    all_correct = false;
                    //Add 1 points
                    points = points + WRONG_ANSWER;
                }
            }
            else
            {
                all_correct = false;
                points = points + INVALID;
            }

            Console.WriteLine("");
            Console.WriteLine("The Nash Equilibrium in ");
            Console.WriteLine("In economics and game theory a stable state of a system involving the interaction of different participants, in which no participant can gain by a unilateral change of strategy if the strategies of the others remain unchanged.");
            Console.WriteLine("");
            Console.WriteLine("An established firm and a newcomer to the market of fixed size have to choose the appearance for a product. Each firm can choose between two different appearances for the product; call them X and Y. The established producer prefers the newcomer's product to look different from its own (so that its customers will not be tempted to buy the newcomer's product) while the newcomer prefers that the products look alike.");
            Console.WriteLine("");
            Console.WriteLine("(X,X) Firm 2 can increase its payoff from 1 to 2 by choosing the action Y rather than the action X.");
            Console.WriteLine("(X,Y) Firm 1 can increase its payoff from 1 to 2 by choosing the action Y rather than the action X.");
            Console.WriteLine("(Y,X) Firm 1 can increase its payoff from 1 to 2 by choosing the action X rather than the action Y.");
            Console.WriteLine("(Y,Y) Firm 2 can increase its payoff from 1 to 2 by choosing the action X rather than the action Y.");
            Console.WriteLine("");
            Console.WriteLine("4.which choices are equilibriums in this example?");
            Console.WriteLine("1)(X,X) 2)(Y,X) 3)(Y,Y) 4)(X,Y)");
            Console.WriteLine("");
            Console.WriteLine("Answer : ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1 || choice == 3)
                    points = points + CORRECT_ANSWER;
                else if (choice == 2 || choice == 4)
                {
                    all_correct = false;
                    points = points + WRONG_ANSWER;
                }
            }
            else
            {
                all_correct = false;
                points = points + INVALID;
            }

            if (all_correct)
                Console.WriteLine("\nTotal points scored : {0} ", points + BONUS_POINT);
            else
                Console.WriteLine("\nTotal points scored : {0} ", points);

            Console.ReadKey();

        }
    }
}