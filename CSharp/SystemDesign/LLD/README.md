# Design Patterns

## Behavioral

### Strategy

#### <b style="color:orange">Definition: </b>Family of alghorithms which encapsulates each behavior and make them interchangeble

Problem statement: Implement Duck Simulation game

#### 1. Initial design / implementation:

There are n types of duck and each type of duck is a duck ==>

<b style="color:lightgreen">Solution 1 - Simple solution</b>

- Superclass -> Duck
- Subclasses
  - -> Mallard duck
    - -> RedHead duck

<b style="color:#458fff">Initial design limitations</b>
[Solution 1: design and limitations](./Images/DuckSimulationInitial.png "Simple design")

#### 2. Avoiding violation of SOLID (L):

<b style="color:lightgreen">Solution 2 - Use interfaces for uncommon behaviors</b>

- Interfaces
  - -> IFlyable
  - -> IQuack
- Superclass -> Duck
- Subclasses
  - -> Mallard duck
    - -> RedHead duck
  - -> Rubber duck

<b style="color:#458fff">New design limitations</b>
![Solution 2: design and limitations](./GOF/Images/DuckSimulationSol2.png "Simple design")

#### 3. Strategy pattern implementation HAS-A (Composition) vs Is-A (Inheritance)

![Solution 2: design and limitations](./GOF/Images/DuckSimulationStrategy.png "Simple design")

## Creational
