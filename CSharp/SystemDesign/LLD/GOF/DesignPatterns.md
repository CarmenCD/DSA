# Design Patterns

## Behavioral

### Strategy

$\mathsf{\color{orange}Definition: \space}$ Family of alghorithms which encapsulates each behavior and make them interchangeble

$\mathsf{\color{lime}Problem \space statement: \space Implement \space Duck \space Simulation \space game}$

### 1. Initial design / implementation:

### $\mathsf{\color{lightgreen}Solution \space 1 \space - \space Simple \space solution}$

- Superclass -> Duck
- Subclasses
  - -> Mallard duck
  - -> RedHead duck

$\mathsf{\color{#458fff}Initial \space design \space limitations}$

![Solution 1: design and limitations](./Images/DuckSimulationInitial.png "Simple design")

### 2. Avoiding violation of SOLID (L):

### $\mathsf{\color{lightgreen}Solution \space 2 \space - \space Use  \space interfaces \space for \space uncommon \space behaviors}$

- Interfaces
  - -> IFlyable
  - -> IQuack
- Superclass -> Duck
- Subclasses
  - -> Mallard duck
    - -> RedHead duck
  - -> Rubber duck

$\mathsf{\color{#458fff}New \space design \space limitations}$

![Solution 2: design and limitations](./Images/DuckSimulationSol2.png "Simple design")

### 3. Strategy pattern implementation HAS-A (Composition) vs Is-A (Inheritance)

![Solution 2: design and limitations](./Images/DuckSimulationStrategy.png "Simple design")

## Creational

### The Factory pattern
