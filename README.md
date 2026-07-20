Console RPG Framework

A turn-based RPG framework built with C# and .NET Console Application.

This project was created to improve my understanding of object-oriented programming, software architecture, debugging, and building a complete application from scratch.

Features
Turn-based battle system
Character selection
AI opponent selection
State Machine based game flow
Character inventory system
Item-based attack and defense
Health and damage calculation system
Extensible character system
Modular project structure
Characters
Witcher
Assassin
Iron Heart
Witch
Nether Blade
Ash
Technologies
C#
.NET
Object-Oriented Programming (OOP)
Dependency Injection (constructor injection)
Collections (List, Dictionary)
Enums
Interfaces
State Machine
Async/Await (Task-based delays)
Git & GitHub
Current Status

Current version includes:

Character selection
AI selection
Turn-based battle
Inventory display
Item system
Health & Damage calculation
Replay system
Game flow management
Major architectural refactoring (static removal, dependency injection)

The project recently went through a full refactoring pass focused on removing unnecessary static coupling and introducing explicit dependency injection between components.

Project Goals

This project is being developed as a learning project to practice software engineering concepts before moving to Unity development.

Current focus:

Cleaner architecture
Better separation of responsibilities
Reducing static dependencies
Applying SOLID principles where appropriate
Architecture Notes

One of the main goals of this project was learning when static is appropriate and when it isn't, rather than avoiding or using it blindly.

Refactored from static to instance-based (constructor-injected via GameData):

Player, AI — hold mutable, per-game state (selected character)
UserInput — holds mutable user input state
CurrentFlow — holds the current state machine flow, which changes during gameplay
Characters.freeCharacters — mutable list that changes between rounds
StateMachine — orchestrates game states via constructor-injected dependencies

Intentionally kept static:

AppInterface — stateless, only displays information based on parameters it receives
Characters.characters, Items.items — fixed, unchanging reference data
Inventory — stateless display logic
GenerateRandomIndex — stateless calculation; the Random instance has no game-meaningful state worth isolating per game

The general rule applied throughout: static itself isn't the problem — static mutable, shared, game-relevant state is. A class with no fields, or with fields that never change, can safely stay static.

State Machine Design

The game flow is driven by a Dictionary<Flow, IState>, where each game state (AppStartState, MainMenuState, CharacterSelectState, BattleState, QuitState) implements a shared IState interface:

csharp
interface IState
{
    void Run(GameData data);
}

This replaced an earlier switch statement that called static methods with mismatched signatures across different classes. Using a shared interface and a dictionary keyed by the Flow enum removed the need for a long switch/case block and made adding new states straightforward.

Dependency Flow

All game state that needs to persist and be shared across states lives in a single GameData object, built once in Main() and passed down through the call chain:

Main() → new GameData(player, ai, userInput, characters, currentFlow)
       → StateMachine.Machine(gameData)
           → states[currentFlow].Run(gameData)

No game state class reaches for global/static data anymore — everything a state needs is passed in explicitly through GameData.

What I Learned

During this project I practiced:

Object-Oriented Programming
State Machine design (interface + dictionary based dispatch)
Dependency Injection (constructor injection) as an alternative to static coupling
Recognizing the real problem with static (shared mutable state, not static itself)
Software refactoring, incrementally and without breaking the build
Responsibility separation (SRP mindset)
Debugging NullReferenceException and logic bugs
Finding and fixing subtle bugs caused by static field initialization order
Async/Await vs. Thread.Sleep (non-blocking delays with Task.Delay)
Battle system design
Project organization
Git branching and merge workflow
Building a medium-sized project from scratch
Future Improvements
Clean up remaining naming inconsistencies and typos
Simplify Attack/Defend method signatures (currently take redundant parameters)
Apply design patterns where appropriate
Improve scalability
Author

Hossein
