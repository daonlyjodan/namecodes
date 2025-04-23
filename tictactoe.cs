// This code was done using a tutorial online but regardless i learned stuff from it :)
string[] grid = new string[] {"1","2","3","4","5","6","7","8","9"};
bool isPlayer1Turn = true;
int turns = 0;
while (!Victory() && turns != 9) {
    PrintGrid();
    if (isPlayer1Turn == true) {
        System.Console.WriteLine("Player 1's turn!");
    }
    else {
        System.Console.WriteLine("Player 2's turn!");
    }
    string? choice = Console.ReadLine();

    if (grid.Contains(choice) && choice != "X" && choice != "O") {
        int GridIndex = Convert.ToInt32(choice) - 1;

        if (isPlayer1Turn == true) {
            grid[GridIndex] = "X";
        }
        else {
            grid[GridIndex] = "O";
        }
        turns++;
    }
    isPlayer1Turn = !isPlayer1Turn;
}
if (Victory()) {
    PrintGrid();
    System.Console.WriteLine("You Win!");
}
else {
    PrintGrid();
    System.Console.WriteLine("Tie!");
}

bool Victory() {
    bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
    bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
    bool row3 = grid[7] == grid[8] && grid[8] == grid[9];
    bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
    bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
    bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
    bool diagUp = grid[6] == grid[4] && grid [4] == grid[2];
    bool diagDown = grid[0] == grid[4] && grid[4] == grid[8];

    return row1 || row2 || row3 || col1 || col2 || col3 || diagUp || diagDown;

}

void PrintGrid() {
    for (int i = 0 ; i < 3 ; i++) {
        for (int j = 0 ; j < 3 ; j++) {
            Console.Write(grid[i*3+j] + "|");
        }
        System.Console.WriteLine();
        System.Console.WriteLine("------");
    }
}
