# Sliding Tile Puzzle Game

A console-based puzzle game written in C# where you solve a sliding tile puzzle by moving numbered tiles into the correct position.

## Game Description

This is a classic sliding tile puzzle game where:
- You have a grid of numbered tiles with one empty space
- Move adjacent tiles into the empty space
- Goal is to arrange all tiles in numerical order
- Three difficulty levels available: 3x3, 4x4, and 5x5

## Features

✨ Three difficulty levels (Easy, Medium, Hard)  
✨ Move counter to track your progress  
✨ Automatic puzzle shuffling for unique games  
✨ Input validation and user-friendly interface  
✨ Victory celebration when puzzle is solved

## Requirements

- .NET 6.0 or higher
- C# compatible environment

## How to Run

1. Navigate to the project directory:  
```bash
cd KamaniIsStupid
```

2. Build the project:  
```bash
dotnet build
```

3. Run the game:  
```bash
dotnet run
```

## How to Play

1. Start the game and select your difficulty level (1, 2, or 3)  
2. View the puzzle grid with numbered tiles  
3. Enter the number of the tile you want to move  
4. The tile must be adjacent (up, down, left, right) to the empty space  
5. Continue moving tiles until all numbers are in order (1-8 for 3x3, 1-15 for 4x4, etc.)  
6. Type 'q' to quit at any time

## Example Gameplay

```
╔═══════════════════════════════╗
║     SLIDING TILE PUZZLE GAME  ║
╚═══════════════════════════════╝

  [01] [02] [03]
  [04] [05] [06]
  [07] [08] [ ]

Moves: 5

Enter the number of the tile you want to move (or 'q' to quit):
```

## Game Mechanics

- **Valid Moves**: Only tiles adjacent to the empty space can be moved
- **Shuffling**: The puzzle is randomly shuffled 100 times to ensure a solvable state
- **Move Counter**: Tracks how many moves you've made
- **Win Condition**: All tiles arranged in numerical order with empty space at the end

## Tips for Solving

- Start by solving the top row first
- Then work on the left column
- Once those are correct, the remaining tiles are usually easier
- Look for patterns and try not to disturb already-solved sections

Enjoy the game! 🎮