# Purple Lilacs
V0.5

To view this README with proper formatting, please visit the GitHub: https://github.com/Abdullahshk69/PurpleLilacs/blob/main/README.md

> A simple, relaxing 2D platforming game where you play as a Lamb in Wolf's Clothing, collecting flowers with your adopted wolf child.

## Features
### Currently implemented

**Custom Art** (sprites shown below, other sprites are free to use assets found online)

![Walking animation for player sprite](https://media.discordapp.net/attachments/1167883668837118023/1180576527323234374/ezgif.com-resize.gif?ex=657dec92&is=656b7792&hm=68488db0c310ca53304411c7d79c1afda210d1394ca01593113d752755a053c8&=)
![Idle animation for player sprite](https://media.discordapp.net/attachments/1167883668837118023/1180576526903824485/ezgif.com-resize_1.gif?ex=657dec92&is=656b7792&hm=c5b7c624e1d7a5099682072a4d4c4b9affd11478d18b2c109005e13b718e6b95&=)
![Jumping animation for player sprite](https://media.discordapp.net/attachments/1167883668837118023/1180576526551494756/ezgif.com-resize_2.gif?ex=657dec91&is=656b7791&hm=35e78528c2ac8952c09389ec3f1ef3e4baaca83fd1c717f53fc2e76ade5cf1d6&=)
![Thorn bush sprite](https://media.discordapp.net/attachments/1167883668837118023/1180578252369166466/28_Nov_2023_PL_-_Thorn_Bushes_scaled_2x_pngcrushed.png?ex=657dee2d&is=656b792d&hm=7e547debc9c2500c0c70cf7b48066f942fb577bc693ce9250583359fc7ef4870&=&format=webp&quality=lossless)
![Dandelion sprite](https://media.discordapp.net/attachments/1167883668837118023/1173755974784397415/13_Nov_2023_Purple_Lilacs_-_DandelionBigger.png?ex=6577916f&is=65651c6f&hm=01c23d347d3d9dd6f6ed542fdbbead4ad749cd4fa48f472e29532bae8d07c75d&=&format=webp&quality=lossless)
![Lilac sprite](https://media.discordapp.net/attachments/1167883668837118023/1173756087963504640/13_Nov_2023_Purple_Lilacs_-_LilacBigger.png?ex=6577918a&is=65651c8a&hm=ca7378148a70e327e82a82ac35039e2201145126557c1bd55121f279c2ae7b09&=&format=webp&quality=lossless)

> [!NOTE]
> More art will be made if there is enough time

**Movement, Jumping, and Pickup System**

![GIF that depicts that demonstrates movement and pickup](https://media.discordapp.net/attachments/1167883655541162189/1180587858743013478/ezgif.com-video-to-gif.gif?ex=657df71f&is=656b821f&hm=fc6449060f0b706437dab0dcf25894ec74e344ff61a8aa4b98e02ac661413b5b&=)

**Thorn Bushes (Obstacle), Death, Respawn, and Checkpoints**

![GIF that depicts dying mechanic](https://media.discordapp.net/attachments/1167883655541162189/1180588658080895097/ezgif.com-video-to-gif_1.gif?ex=657df7de&is=656b82de&hm=5d9b0a318f7915e15ba21c9e1129e25e1020e3d9e526ef780dc6f943b9b19052&=)

**Room-by-room Camera: Camera transitions between rooms, inside a room it will follow a player**

![GIF that depicts camera mechanic](https://media.discordapp.net/attachments/1167883655541162189/1180589036893651134/ezgif.com-video-to-gif_2.gif?ex=657df838&is=656b8338&hm=710ca70f921dbd322390ac1b53fcf7c10eb62c4983ad2cced4f6302e6117edb7&=)

**Moving and Breakable Platforms**

![GIF that depicts dynamic platform mechanic](https://cdn.discordapp.com/attachments/1167883655541162189/1180593752386052126/ezgif.com-optimize_3.gif?ex=657dfc9c&is=656b879c&hm=2eeef06f23b98eaba33997e58a8586e768b480179dc9f0cb5a359e3e7a542c90&)

**Progression (to next level, next level is a wip so there's only blank space)**

![GIF that depicts a shot of finishing the level](https://media.discordapp.net/attachments/1167883655541162189/1180589909900283954/ezgif.com-video-to-gif_4.gif?ex=657df908&is=656b8408&hm=21c213c4123a505bb270a5ae5827900b2aab7458f476dc7d2a35176d7e7459fd&=)

### Planned implementation
(things marked with ? may or may not be done)

- Menu UI
- Flower Amount Display
- Cutscenes/Cinematics? - Important for narrative, but right now we are focusing on mechanics and gameplay so this may or may not be implemented
- Destructible Objects? - To add challenge to the game, but not overly important (we have enough mechanics to make a game work)
- Pushable Objects
- Wolf Child (AI NPC)? - May be too complicated for the amount of time allotted for the project

## Obstacles
Here are some issues/bugs we faced during implementation of this project:

- Working on separate devices: We faced some issues with trying to work remotely from one another. File transfer was impossible due to Unity constantly getting confused which version of the editor we were workign with. We fixed it by using an in-built feature and a cloud storage provided by Unity.
- Breakable platforms: It was quite challenging to implement these. Had to learn and understand how co-routines work.
- Sprites: Had to figure out how to add multiple child gameObjects because our player  is not a perfect square sprite.
- Setting up camera: It was a little difficult due to needing to create contraints and keep the camera within that constraint.
- General Bugs: Slight errors and needed fixes that are too minor to be detailed.
- Camera is buggy when a player respawns. It resnaps onto the player. There is little to be done as the camera has to follow the player.

## Adjustments Made From Original Plan
- Shortened game from 3 sections/arcs to 1 in order to prevent burnout (as we only have a month to do this, more or less)

Originally, the game was supposed to consist of three arcs (prologue, climax, epilogue), but seeing both our schedules and the closing deadline, we think that it'd be a wiser decision to downsize and simplify the game as to focus on the quality.
