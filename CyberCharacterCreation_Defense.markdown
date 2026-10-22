| System Requirement       | Selected Design Pattern | Category (Creational / Structural / Behavioral) | Relevant File(s) & Class(es)                                                                 |
|--------------------------|-------------------------|------------------------------------------------|-----------------------------------------------------------------------------------------------|
| Global Game State        | Singleton               | Creational                                     | `Game/GameState.cs`                                                                          |
| Entity Generation        | Factory          | Creational                                     | `Factories/CharacterFactory.cs`                                                              |
| Specializations / Subclasses | Decorator           | Structural                                     | `Decorators/CharacterDecorator.cs`, `MercenaryDecorator.cs`, `NetRunnerDecorator.cs`          |
| Inventory Management     | Facade                  | Structural                                     | `Game/InventoryFacade.cs`                                                                    |


# The "Why": Explain how your research led you to choose this specific pattern for the problem. What problems would arise if you used a different route.

1. Singleton Pattern — Global State
The Singleton pattern ensures that only one instance of the world state exists. It stores simulation data, such as the start time and threat level.
Without the Singleton pattern, multiple `GameState` objects could lead to inconsistencies in world data; conversely, manually passing the state object around would result in redundant code. A private constructor prevents external code from creating additional instances.

2. Factory Pattern — Character Creation
The Simple Factory encapsulates all character creation logic within a single class, so the menu code does not need to directly call `new Human()` or `new Synth()`.
Without this factory, the menu code would contain hard-coded object creation logic; adding a new race would require modifying the menu code, violating the "Open Closed Principle." The controller simply needs to send the race name to obtain an abstract `Character` object.

3. Decorator Pattern 
The Decorator pattern allows for the addition of roles and attributes to a character at runtime, without requiring modifications to the original `Human` or `Synth` classes.
Relying on inheritance would lead to a proliferation of subclasses—such as `HumanMercenary`—resulting in an unmanageable number of classes. Furthermore, modifying the base `Character` class to accommodate every new role would violate the "Open-Closed Principle." The Decorator pattern addresses this by wrapping existing character objects, enabling the layering of multiple roles.

4. Facade Pattern — Inventory Management
The Facade pattern provides a simple interface that hides complex inventory storage logic. The `InventoryFacade` encapsulates the storage repository and offers convenient methods such as `QuickAdd` and `PrintAllItems`.
Without the Facade pattern, a controller would have to invoke numerous low-level inventory functions, leading to tight coupling; any change to how inventory is stored would necessitate modifications to the controller code. The Facade pattern effectively conceals these internal implementation details.