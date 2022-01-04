# Rail Shooter Game Design

![Unity](/images/rail-shooter.jpg)

| Name:  | Eanna Assault |
| ------ | ------ |
| Player Experience: | Chaos |
| Core Mechanic: | Dodge and shoot |
| Core Game Loop: | Get as far as possible without dying in order to get the highest score possible. Start from the beginning when the you die. |
| Game Theme | You must save your planet, Eanna, from destruction by the bilulu force |


## Features and Requirements: 
(The core for a minimum viable product)
- Player Movement: Horizontal and vertical movement.
- Shooting: Player and enemies can shoot bullets which do damage to opponent. Speed, rate of fire and damage should be tunable.
- Enemy Paths: Enemies should travel on paths. Type of enemies, number of enemies and rate of spawn need to be tunable. Difficulty scaling and randomisation of paths is needed.
- Score: Points are give for killing enemies.
- Camera Rail: Path through the level that the camera follows.
- Menu system: Start menu, pause screen, death screen.

### Stretch Goals - Damage and Shields:
- Player Shield: When damaged, the player's shield depletes. Can be increased by picking up a shield pickup.
- Pickups: Flying over a shield pickup will increase the player's shields.
- Momentary invulnerability: After taking damage, the player cannot take damage again for X time.

### Tech Specs:
- 1920x1080 16:9 aspect ration
- Build to PC, Mac, Web.


### Early Development Priorities
- Establish a simple world
- Solve camera movement
- Get the player moving and avoiding
- Get the player shooting and hitting

![Unity](/images/GameplayTune.jpg)

### How to avoid calling everything a whatevermanager ?

Name it instead: Coordinator, Builder, Writer, Reader, Handler, Container, Protocol, Target, Converter, Controller, View, Factory, Entity, Bucket. 

![Unity](/images/Beat-Chart.jpg)
