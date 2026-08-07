# Layers

The project has been refactored to more closely match traditional C# development using each project as a layer.

### Remember: Layers can ONLY point down.

- Api
- Bot
    - Application
        - Data
            - Core
                - Primitives
---
### Notes: 

I put `Data` above `Core` because I wasn't sure what all it entailed. If it just handles data internally without interfacing with the data base then it is good as is. However, if the `Data` layer is meant to ineract with a data base through some framework it will need to be moved above application some where. 

`Api` and `Bot` are currently sibling layers. I assumed that they would be the outtermost layers because they would interact with some external (not strictly .NET) framework. 