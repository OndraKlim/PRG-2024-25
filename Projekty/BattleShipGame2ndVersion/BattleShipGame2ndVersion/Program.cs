using System;

class BattleshipGame
{
    // Constants for game settings
    const int gridSize = 10; // Size of the game grid (10x10)
    const char emptyCell = '.'; // Represents an empty cell
    const char shipCell = 'S'; // Represents a ship part
    const char hitCell = 'X'; // Represents a hit on a ship
    const char missCell = 'O'; // Represents a missed shot

    // Define the ships and their sizes
    static readonly int[] shipSizes = { 5, 4, 3, 2, 1 }; // Sizes for Aircraft Carrier, Battleship, Cruiser, Submarine, and Destroyer

    // Statistics
    static int playerShots = 0;
    static int playerHits = 0;
    static int computerShots = 0;
    static int computerHits = 0;

    static void Main(string[] args)
    {
        // Initialize game grids
        char[,] playerGrid = new char[gridSize, gridSize];
        char[,] computerGrid = new char[gridSize, gridSize];
        char[,] computerView = new char[gridSize, gridSize]; // What the player sees of the computer's grid

        // Initialize grids with empty cells
        InitializeGrid(playerGrid);
        InitializeGrid(computerGrid);
        InitializeGrid(computerView);

        // Place ships
        Console.WriteLine("Place your ships on the grid.");
        PlacePlayerShips(playerGrid);
        PlaceComputerShips(computerGrid);

        // Select difficulty
        int difficulty = SelectDifficulty();

        // Game loop
        bool gameOver = false;
        while (!gameOver)
        {
            // Player's turn
            Console.Clear();
            Console.WriteLine("Your grid:");
            PrintGrid(playerGrid);

            Console.WriteLine("Computer's grid (your view):");
            PrintGrid(computerView);

            Console.WriteLine("Enter coordinates to fire (e.g., A5):");
            string playerShot = Console.ReadLine();
            if (ProcessPlayerShot(playerShot, computerGrid, computerView))
            {
                Console.WriteLine("Hit!");
            }
            else
            {
                Console.WriteLine("Miss.");
            }

            if (CheckAllShipsSunk(computerGrid))
            {
                Console.WriteLine("You win!");
                gameOver = true;
                break;
            }

            // Computer's turn
            Console.WriteLine("Computer is taking a shot...");
            ComputerTurn(playerGrid, difficulty);

            if (CheckAllShipsSunk(playerGrid))
            {
                Console.WriteLine("Computer wins!");
                gameOver = true;
            }
        }

        // Show summary
        ShowGameSummary();
    }

    // Initialize the game grid with empty cells
    static void InitializeGrid(char[,] grid)
    {
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                grid[i, j] = emptyCell;
            }
        }
    }

    // Print the game grid to the console
    static void PrintGrid(char[,] grid)
    {
        Console.Write("  ");
        for (char c = 'A'; c < 'A' + gridSize; c++)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < gridSize; i++)
        {
            Console.Write((i + 1).ToString().PadLeft(2) + " ");
            for (int j = 0; j < gridSize; j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Allow the player to place their ships manually
    static void PlacePlayerShips(char[,] grid)
    {
        for (int shipIndex = 0; shipIndex < shipSizes.Length; shipIndex++)
        {
            int shipSize = shipSizes[shipIndex];
            bool placed = false;

            while (!placed)
            {
                Console.WriteLine($"Placing a ship of size {shipSize}.");
                Console.WriteLine("Enter starting coordinates (e.g., A1) and direction (H/V):");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                string start = parts[0];
                char direction = char.ToUpper(parts[1][0]);

                int startRow = int.Parse(start.Substring(1)) - 1;
                int startCol = start[0] - 'A';

                if (CanPlaceShip(grid, startRow, startCol, shipSize, direction))
                {
                    PlaceShip(grid, startRow, startCol, shipSize, direction);
                    placed = true;
                }
                else
                {
                    Console.WriteLine("Invalid position. Try again.");
                }
            }
        }
    }

    // Place ships randomly for the computer
    static void PlaceComputerShips(char[,] grid)
    {
        Random random = new Random();

        for (int shipIndex = 0; shipIndex < shipSizes.Length; shipIndex++)
        {
            int shipSize = shipSizes[shipIndex];
            bool placed = false;

            while (!placed)
            {
                int row = random.Next(0, gridSize);
                int col = random.Next(0, gridSize);
                bool horizontal = random.Next(0, 2) == 0;
                char direction = horizontal ? 'H' : 'V';

                if (CanPlaceShip(grid, row, col, shipSize, direction))
                {
                    PlaceShip(grid, row, col, shipSize, direction);
                    placed = true;
                }
            }
        }
    }

    // Check if a ship can be placed at the given position
    static bool CanPlaceShip(char[,] grid, int startRow, int startCol, int size, char direction)
    {
        if (direction == 'H')
        {
            if (startCol + size > gridSize) return false;

            for (int i = 0; i < size; i++)
            {
                if (grid[startRow, startCol + i] != emptyCell) return false;
            }
        }
        else if (direction == 'V')
        {
            if (startRow + size > gridSize) return false;

            for (int i = 0; i < size; i++)
            {
                if (grid[startRow + i, startCol] != emptyCell) return false;
            }
        }
        return true;
    }

    // Place a ship on the grid
    static void PlaceShip(char[,] grid, int startRow, int startCol, int size, char direction)
    {
        for (int i = 0; i < size; i++)
        {
            if (direction == 'H')
            {
                grid[startRow, startCol + i] = shipCell;
            }
            else if (direction == 'V')
            {
                grid[startRow + i, startCol] = shipCell;
            }
        }
    }

    // Process a player's shot and update the grid
    static bool ProcessPlayerShot(string input, char[,] targetGrid, char[,] viewGrid)
    {
        int col = input[0] - 'A';
        int row = int.Parse(input.Substring(1)) - 1;

        playerShots++;
        if (targetGrid[row, col] == shipCell)
        {
            targetGrid[row, col] = hitCell;
            viewGrid[row, col] = hitCell;
            playerHits++;
            return true;
        }
        else
        {
            viewGrid[row, col] = missCell;
            return false;
        }
    }

    // Computer's turn with difficulty
    static void ComputerTurn(char[,] playerGrid, int difficulty)
    {
        Random random = new Random();
        int row, col;
        bool validShot = false;

        while (!validShot)
        {
            switch (difficulty)
            {
                case 1: // Easy - random shots
                    row = random.Next(0, gridSize);
                    col = random.Next(0, gridSize);
                    break;
                case 2: // Medium - smarter guesses
                    row = random.Next(0, gridSize / 2);
                    col = random.Next(0, gridSize / 2);
                    break;
                case 3: // Hard - targeted and strategic shots
                    row = random.Next(gridSize / 2, gridSize);
                    col = random.Next(gridSize / 2, gridSize);
                    break;
                default:
                    row = random.Next(0, gridSize);
                    col = random.Next(0, gridSize);
                    break;
            }

            if (playerGrid[row, col] != hitCell && playerGrid[row, col] != missCell)
            {
                validShot = true;

                computerShots++;
                if (playerGrid[row, col] == shipCell)
                {
                    playerGrid[row, col] = hitCell;
                    computerHits++;
                    Console.WriteLine($"Computer hit your ship at {ConvertToCoordinates(row, col)}!");
                }
                else
                {
                    playerGrid[row, col] = missCell;
                    Console.WriteLine($"Computer missed at {ConvertToCoordinates(row, col)}.");
                }
            }
        }
    }

    // Check if all ships are sunk
    static bool CheckAllShipsSunk(char[,] grid)
    {
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                if (grid[i, j] == shipCell)
                {
                    return false;
                }
            }
        }
        return true;
    }

    // Convert grid coordinates to string (e.g., A1)
    static string ConvertToCoordinates(int row, int col)
    {
        return $"{(char)('A' + col)}{row + 1}";
    }

    // Show game summary
    static void ShowGameSummary()
    {
        Console.WriteLine("Game Over!");
        Console.WriteLine($"Your shots: {playerShots}, Hits: {playerHits}");
        Console.WriteLine($"Computer's shots: {computerShots}, Hits: {computerHits}");
    }

    // Select game difficulty
    static int SelectDifficulty()
    {
        Console.WriteLine("Select difficulty:");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Hard");
        int difficulty;
        while (!int.TryParse(Console.ReadLine(), out difficulty) || difficulty < 1 || difficulty > 3)
        {
            Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
        }
        return difficulty;
    }
}


