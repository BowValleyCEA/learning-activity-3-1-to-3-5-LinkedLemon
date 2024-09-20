// See https://aka.ms/new-console-template for more information
LearningActivity31();
LearningActivity32();
LearningActivity33();
LearningActivity34();
LearningActivity35();

void LearningActivity31()
{
    Console.WriteLine("would you like to convert c-f or f-c?");

    string convertType = Console.ReadLine();

    if (convertType == "c-f")
    {
        Console.WriteLine("please input a value for the celsius conversion");
        float userCel = float.Parse(Console.ReadLine());
        float output = (float)((userCel * 1.8) + 32);
        Console.WriteLine(userCel + " as fahrenheit is " + output);
    }
    else if (convertType == "f-c")
    {
        Console.WriteLine("please input a value for the fahrenheit conversion");
        float userCel = float.Parse(Console.ReadLine());
        float output = ((userCel - 32) * 5) / 9;
        Console.WriteLine(userCel + " as celsius is " + output);
    }
   }
void LearningActivity32()
{
    string[] nameArray = new string[] { "Ali, Muhammad Moid",
        "Anderson, Canyon",
        "Castro-Gonzalez, Bruno",
        "Coughlin, Shea",
        "Dinh, Hoang Quan",
        "Finley, Cat",
        "Gubert Katlauskas, Ann Victoria",
        "Harrison, Hamish",
        "Hoch, Lukas",
        "Ladan, Lucas",
        "Paxton, Keegan",
        "Quinones Davila, Jose",
        "Scouras, Julianna",
        "Siddiq Rahuman, Ahamed Maahin",
        "Soto Cordovez, Camilo",
        "Vatansever, Emre",
        "Watfa, Mason"
    };
    int[] ageArray = new int[] {};
    string[] wondersOfWorldArray = new string[] { "Great Wall of China", "Chichen Itza", "Petra", "Machu Picchu", "Christ the Redeemer", "Colosseum", "Taj Mahal" };
}
void LearningActivity33()
{
    // Example tic-tac-toe board
    int[,] board = {
            { 1, 2, 0 },
            { 2, 1, 0 },
            { 2, 1, 1 }
        };



    // Check for a winner
    int winner = CheckWinner(board);

    // Print the result
    if (winner == 1)
    {
        Console.WriteLine("X wins!");
    }
    else if (winner == 2)
    {
        Console.WriteLine("O wins!");
    }
    else
    {
        Console.WriteLine("No winner yet or it's a draw.");
    }

    LearningActivity34();
}

static int CheckWinner(int[,] board)
{
    // Check rows and columns
    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
        {
            return board[i, 0]; // Row win
        }
        if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != 0)
        {
            return board[0, i]; // Column win
        }
    }

    // Check diagonals
    if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
    {
        return board[0, 0]; // Main diagonal win
    }
    if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
    {
        return board[0, 2]; // Anti-diagonal win
    }

    // No winner
    return 0;
}


void LearningActivity34()
{
    int number;
    bool success = int.TryParse(Console.ReadLine(), out number); //example code
    while (!success)
    {
        Console.WriteLine("Please enter your age.");
        string input = Console.ReadLine();

        if (int.TryParse(input, out number) && number > 10 && number < 50)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid age. Please enter a whole number between 10 and 50.");
        }
    }
}

void LearningActivity35()
{
    int[] scores = {
    398000, 478500, 561300, 591200, 874300, 879200, 985600, 1049100, 1061700, 1064500,
    1068000, 1090400, 1110100, 1127700, 1138600, 1141800, 1144800, 1158400, 1170500,
    1172100, 1177200, 1190000, 1190200, 1195100, 1218000, 1230100, 1247700, 1249500,
    1259000, 1260700, 1271100, 1272700, 1272800
};

    double average = scores.Average();
    double sumOfSquaresOfDifferences = scores.Select(val => (val - average) * (val - average)).Sum();
    double sd = Math.Sqrt(sumOfSquaresOfDifferences / scores.Length);
    Console.WriteLine(sd);

    //The score itself should be saved as a float just to check for small diffrences in highscore values but displayed as a int for simplicity
}

