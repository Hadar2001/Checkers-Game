# Checkers-Game

A C# WinForms application that implements a classic Checkers (Damka) game.  
The project allows users to play a standard two-player game or challenge a basic AI opponent.

## Features

- Classic Checkers rules and movement
- Multiple board sizes: 6x6, 8x8, 10x10
- Play against another player or versus the computer
- Visual user interface built with Windows Forms
- Real-time highlighting of valid moves
- Turn-based logic with score tracking
- Fully object-oriented design with clear separation between game logic and UI

## Project Structure

```
CheckersGameProject/
├── GameLogic/          # Core game classes (Game, GameBoard, Move, Player, etc.)
├── UserInterface/      # UI Forms (FormGameBoard, FormSettings)
├── Images/             # Piece images (not included in repository)
├── Program.cs          # Entry point
├── App.config          # Application configuration
├── CheckersGameProject.csproj
```

## How to Run

1. Open `CheckersGame.sln` in Visual Studio.
2. Build and run the project (`F5`).

> Make sure to include piece images in the `Images/` folder for full functionality.

## Requirements

- .NET Framework 4.8 (or compatible)
- Visual Studio 2019 or later

## License

This project is open-source and available under the [MIT License](https://opensource.org/licenses/MIT).
