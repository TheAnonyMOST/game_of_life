---
title: "The Game of Life"
author: "Justin M"
student_number: "#******7199"
student_email: "jtmorton1@student.fullsail.edu"
course: "Project and Portfolio I: Computer Science - Online"
course_term: "C202201-02"
instructor: "Robert M"
date_started: "03 Jan 2022"
---
# **Conway’s The Game of Life**

![Banner](https://github.com/TheAnonyMOST/game_of_life/blob/main/assets/title.png?raw=true)

This is the repository for my implementation of [John Horton Conway’s The Game of Life.](https://en.wikipedia.org/wiki/Conway's_Game_of_Life)

This will be updated as I progress through the project.



> The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970. It is a zero-player game, meaning that its evolution is determined by its initial state, requiring no further input. One interacts with the Game of Life by creating an initial configuration and observing how it evolves. It is Turing complete and can simulate a universal constructor or any other Turing machine.





## Requirements

### BASIC REQUIREMENTS

1. **Turned in to FSO on time.** Please zip up (No RAR or other compression formats, please!) your entire solution including any GIT files and folders and attach the zipped file to this FSO page. You do not need to delete any project files before zipping. Also, if you have added any custom features to the program not listed below, and you would like them to be considered in the grading process, then please create a ReadMe.txt file that explains the features and how to use them. Please attach the ReadMe.txt file to the project before zipping. **If you miss the due date you can still turn in the assignment but you will get docked -10 points for it being late!**
2. **Use Visual Studio version control (Git)**. You will be required to use version control to receive full points for this assignment. Version control with Git is discussed in a video lecture. **You will be docked -20 points if you don't use Git!**

### BASIC FEATURES

1. Render Conway’s Game of Life in a .NET application

   . A grid should be rendered representing the individual cells. Cells can be turned on and off by clicking on them with the mouse. Once a group of cells are turned on and the game runs they should live or die according the 4 rules of the game.

   1. Living cells with less than 2 living neighbors die in the next generation.
   2. Living cells with more than 3 living neighbors die in the next generation.
   3. Living cells with 2 or 3 living neighbors live in the next generation.
   4. Dead cells with exactly 3 living neighbors live in the next generation.

2. **Start, Pause and Next menu items and tool strip buttons**. The game should start running by clicking on a Start menu item or a tool strip button. The game should be pause by clicking on a Pause menu item or a tool strip button. If currently paused, the game can be advanced 1 generation by clicking on a Next menu item or a tool strip button.

3. **Randomizing the universe.** The current universe can be randomly populated from time or from a seed variable. The user should be able to edit the seed variable through a dialog box. Randomizing should occur when a menu item is clicked on.

4. **Emptying the universe.** The universe should be emptied of all living cells through a New or Clear menu item.

5. **Saving the current universe to a text file.** The current state and size of the universe should be able to be saved in [PlainText](http://www.conwaylife.com/wiki/Plaintext) file format. The file name should be chosen by the user with a save file dialog box.

6. **Opening a previously saved universe.** A previously saved [PlainText](http://www.conwaylife.com/wiki/Plaintext) file should be able to be read in and assigned to the current universe. Opening should also resize the current universe to match the size of the file being read.

7. **Show the current generation.** The current generation should be able to be displayed in a status strip.

8. **Show the current number of living cells**. The current number of living cells should be displayed in a status strip.

9. **Controlling how many milliseconds between new generations.** The number of milliseconds between new generations should be adjustable through a dialog box.

10. **Controlling the current size of the universe.** The width and height of the current universe should be able to be chosen through a modal dialog box.

11. **Displaying the neighbor count in each cell.** Render the neighbor count for each individual cell. The user should be able to toggle this feature on and off using the View menu.

12. **View Menu Items.** Implement a View Menu that toggles the grid on an off, toggles the neighbor count display and toggles the heads up display (if the heads up is implemented as an advanced feature.)

### ADVANCED FEATURES

1. **FREE 5 POINTS.**
2. **Game Colors.** The user should be able to select individual colors for the grid, the background and living cells through a modal dialog box.
3. **Universe boundary behavior.** The user should choose how the game is going to treat the edges of the universe. The two basic options would be toroidal (the edges wrap around to the other side) or finite (cells outside the universe are considered dead.)
4. **Context sensitive menu**. Implement a `ContextMenuStrip` that allows the user to change various options in the application.
5. **Heads up display.** A heads up display that indicates current generation, cell count, boundary type, universe size and any other information you wish to display. The user should be able to toggle this display on and off through a View menu and a context sensitive menu (if one is implemented as an advanced feature.)
6. **Settings.** When universe size, timer interval and color options are changed by the user they should persist even after the program has been closed and then opened again. Also, the user should have two menu items Reset and Reload. Reload will revert back to the last saved settings and Reset will return the applications default settings for these values.

## Minimum Requirements for Milestone

1. Render Conway’s Game of Life in a .NET application

   . A grid should be rendered representing the individual cells. Cells can be turned on and off by clicking on them with the mouse. Once a group of cells are turned on and the game runs they should live or die according the 4 rules of the game.

   1. Living cells with less than 2 living neighbors die in the next generation.
   2. Living cells with more than 3 living neighbors die in the next generation.
   3. Living cells with 2 or 3 living neighbors live in the next generation.
   4. Dead cells with exactly 3 living neighbors live in the next generation.

2. **Start, Pause and Next menu items**. The game should start running by clicking on a Start menu item. The game should be pause by clicking on a Pause menu item. If currently paused, the game can be advanced 1 generation by clicking on a Next menu item.

3. **Emptying the universe.** The universe should be emptied of all living cells through a New or Clear menu item.



## Rubric

|                                                              | Poor                                                        | Fair                                                         | Good                                                         | Excellent                                                   |
| :----------------------------------------------------------- | :---------------------------------------------------------- | :----------------------------------------------------------- | :----------------------------------------------------------- | :---------------------------------------------------------- |
| Basic Requirements60 Points                                  | None or few of the  basic requirements  are met.20 Points   | Some of the basic  requirements are met.40 Points            | Most of the basic  requirements are met.50 Points            | All of the basic  requirements are met.60 Points            |
| Advanced Features30 Points                                   | None of the  advanced features were implemented. 0 Points   | At least 2 of the  advanced features  were implemented.10 Points | At least 4 of the  advanced features  were implemented. 20 Points | All of the  advanced features  were  implemented. 30 Points |
| Readability - Is the code logically organized?5 Points       | The code is poorly organized and difficult to read.0 Points | The code is somewhat organized and can be read if one understands what it is suppose to do.2 Points | The code is mostly organized and generally readable.4 Points | The code is fully organized and easy to read.5 Points       |
| Documentation -  Are fields, methods and properties commented?5 Points | There is little or no commenting.0 Points                   | There is some  commenting.2 Points                           | The code is mostly  commented.4 Points                       | The code is  completely  commented. 5 Points                |

