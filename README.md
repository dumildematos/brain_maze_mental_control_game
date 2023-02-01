
Author: Dumilde José de Matos
Project: Brain Maze

Introduction

The project in question is a simple idea, but with the intention of helping people to develop their concentration skills and quality using brain waves.

It is a game where the user is in a maze with the objective to collect some objects. But instead of using an ordinary control, it is used the quality of the attention signal that is emitted by your brain to move through this maze.

Motivation

The development of this project is motivated by the improvement of the cognitive capacity of people through frequent training using brainwave reading, allowing them to reduce the rates of certain symptoms for diseases such as alzaimer, ADHD, schizoaffective 

the aim of the game is not to get the player out of the maze, but to collect as many memories as possible in a short period of time, the more a person plays the easier it will be for them to achieve this goal, while at the same time stimulating the brain waves associated with the meditative state of the brain

How it works

To make this possible it was used the arduino esp32, and a Mindiflex brainwave reading device, where in the arduino it was used two libraries to make the communication possible, the first one is Wifi.h which was used to connect the arduino network and send the data through it. the other library is Brain.h which was used to read and interpret the brainwave data.

This combination of hardware is then used to define the direction in which the player will move, according to the amount of attention his brain generates.

For the AI part was I used depth-first search to generate different maze every time the game starts The script uses the MazeNode class, which represents each cell in the maze. Each MazeNode contains walls and floor as GameObjects. The script removes walls between cells to create the maze paths by calling the RemoveWall(int wallToRemove) method on the MazeNode class.

The script starts by instantiating a grid of MazeNodes in the Unity scene using the mazeSize variable, then it randomly chooses a starting point for the algorithm.
It also creates a random number of memories (game objects) in random positions on the maze and the player is also instantiated in the scene.

It then uses a while loop to move through the grid, building the maze using the depth-first search algorithm. The script keeps track of the current path it is building using a currentPath list, and the nodes that have already been visited using a completedNodes list.

At each step, the script checks the neighboring nodes of the current node. If a neighboring node has not been visited or is not already in the current path, the script adds it to a list of possible next nodes.

Once all possible next nodes have been determined, the script chooses one at random to be the next node in the path, removes the wall between the current node and the next node, and adds the next node to the currentPath list. If there are no possible next nodes, the script backtracks to the previous node in the currentPath list.

The script continues this process until all nodes have been added to the completedNodes list, at which point the maze is complete. The generated maze is a 3D game object which you can interact in your game, and the script is a part of a unity project which uses UnityEngine and Unity related classes, it's not a stand alone code.

And for the gamification part I included the concepts of game elements studied, (dynamics, mechanics, and components)

dynamics: It's included Progression means it's become easier to play when you play it regularly 
mechanics: It's Challenge, the user needs to collect a game object called 'Memories' in a short period of time
components: For each collect, the player gain points.



