using System;

public class Craps {

    private static Random randomNumber = new Random();

    private enum Status { CONTINUE, WON, LOST }

    private enum DiceNames {
        SNAKE_EYES = 2,
        TREY = 3,
        SEVEN = 7,
        YO_LEVEN = 11,
        BOX_CARS = 12
    }

    public static void Main(string[] args) {

        Status gameStatus = Status.CONTINUE;
        int point = 0;

        int sumOfDices = RollDice();

        switch ((DiceNames)sumOfDices) {
            case DiceNames.SEVEN:
            case DiceNames.YO_LEVEN:
                gameStatus = Status.WON;
                break;
            case DiceNames.SNAKE_EYES:
            case DiceNames.TREY:
            case DiceNames.BOX_CARS:
                gameStatus = Status.LOST;
                break;
            default:
                gameStatus = Status.CONTINUE;
                point = sumOfDices;
                Console.WriteLine("Point is {0}", point);
                break;
        }

        while (gameStatus == Status.CONTINUE) {
            sumOfDices = RollDice();

            if (sumOfDices == point) {
                gameStatus = Status.WON;
            } else {
                if (sumOfDices == (int)DiceNames.SEVEN) {
                    gameStatus = Status.WON;
                }
            }
        }

        if (gameStatus == Status.WON) {
            Console.WriteLine("Player wins.");
        } else {
            Console.WriteLine("Player loses");
        }
    }

    public static int RollDice() {

        int die1 = randomNumber.Next(1, 7);
        int die2 = randomNumber.Next(1, 7);

        int sum = die1 + die2;

        Console.WriteLine("Player rolled {0} + {1} = {2}",
            die1, die2, sum);

        return sum;

    }

}