```mermaid

---
title: AnimalKingdom
---

classDiagram

Dog<|--Animal
Cat<|--Animal
Bee<|--Animal
Bat<|--Animal
IMammal<|..Dog
IMammal<|..Cat
IMammal<|..Bat
ICanFly<|..Bat
ICanFly<|..Bee