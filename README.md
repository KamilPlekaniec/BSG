# Battleship game
> A simulation between two computer players in the popular game "Battleship".

## Table of Contents
* [General Info](#general-informations)
* [Technologies Used](#technologies-used)
* [Setup](#setup)
* [Usage](#usage)
* [Acknowledgements](#acknowledgements)


## General Informations
- The aim of the exercise was a simulation between two players. 
- I decided that the best solution will be a console app.
- Coordinates define row and column number on the board. They also determine the location of the shot.
- GameBoard is the standard 10x10 fields board.
- A field is a single place on the board which is defined by row and column.
- Field can have a status of enum description which is the single sign represented by the fields type.
- There are five types of ships which are based on the abstract ship class. All of the ships have different name, size and field type.
- The ships are randomly placed vertically or horizontally each time.
- The ships cannot cross the board boundaries.
- The ships cannot overlap.
- ShotBoard records the players' shots.
- Each player randomly shoot and the opponent is informed about a hit or a miss.
- The game will continue until all of one player's ships have sunk.


## Technologies Used
- Console app C# .NET Core - version 3.1


## Setup
Clone the repository or download zip package. Then open in Visual Studio 2019.


## Usage
Enter your nickname and look how it works.


## Acknowledgements
- This project was based on tutorial (https://www.exceptionnotfound.net/modeling-battleship-in-csharp-introduction-and-strategies/).