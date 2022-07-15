# CSD228-HW5 Monster Slayer
##  Introduction
In this exercise we are going to simulate a turn based game. There are 3 types of classes that define the characters of the game. Character, Enemy, and concrete monster and warrior classes.

## The core logic
A character is an abstract class which means it cannot be instantiated. However, a lot of common functionalities of a character are defined in this class. The same concept applies to the Enemy class. An enemy is an abstract class that extends the functionality of a character, but it cannot be instantiated either.

In this game, a character cannot attack just any other character. Warriors can only attack Enemies and Enemies can only attack warriors. Furthermore, the level of the subject character should be less than or equal to the attacker. This logic is defined in the override of the attack method in every concrete class of Enemy and Character.

The warrior class will increment the experience of the warrior with each attack and with every other increment (when exp is a multiple of 3), it will increment the level of the warrior.

## Instructions
Simply follow the TODO comments in each file. The file `Program.cs` is the main entry of the program with a main method in it. Simply run it in VS Code. After successful execution, you should be able to see the EXACT output as below.

```
Warrior is attacking a Lizard from EARTH
Lizard is attacking a Warrior
Warrior is attacking a Lizard from EARTH
Jason is leveling up!
New level : 2
Cannot attack
Warrior is attacking a Lizard from EARTH
you_shall_perish.mp3
Lizard is dead
Monster is attacking a Warrior
Warrior is attacking a Skeleton from OUTWORLD
Jason is leveling up!
New level : 3
Cannot attack
Warrior is attacking a Skeleton from OUTWORLD
Warrior is attacking a Skeleton from OUTWORLD
you_shall_perish.mp3
Skeleton is dead
Jason is leveling up!
New level : 4
Warrior is attacking a Monster from UNDERWORLD
Cannot attack
Warrior is attacking a Monster from UNDERWORLD
Jason is leveling up!
New level : 5
Warrior is attacking a Monster from UNDERWORLD
you_shall_perish.mp3
Monster is dead
```

## Note
Make sure you understand every aspect of this program. Some of the main concepts in this exercise are, abstraction and polymorphism.