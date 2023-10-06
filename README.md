# IMTC505-Lab2
 

 ## Part 1 - Simple Drone App

 Controls are as follows:
 1. Move Drone: Push the right thumb stick in any direction to move the drone.
 ```
The right analog stick is used for primary actions relating to movement in most video games.
Since main focus of this application is to control the drone, the right analog stick was used
```
 2. Change translation to rotation: You can press the right thumb stick to toggle between translation and rotation mode.
```
Pressing the right thumb stick (to toggle rotation and translation) is not the most intuitively discoverable 
features by the user. However, once user is used to this method, they do not have to move their fingers to 
another button freeing up the button for another functionality and reducing the time for the task.
```
 3. Rotate Drone:  Moving thumb stick left or right will rotate the drone in anti-clockwise and clockwise direction respectively.
 ```
Once in rotation mode, using the right thumb stick is pretty intuitive for the user to rotate the drone
```
 4. Move Player: Push the left thumb stick in any direction to move the player.
```
Since right thumb stick is already bound to drone movement, we use the left thumbstick to move the player 
camera.
```
 5. Toggle Laser: To toggle laser on and off, press the right index trigger button.
```
To turn laser on and off, the right index trigger is used. Using two buttons to turn laser on and off is 
inefficient use of the controller buttons. Trigger buttons are usually used for secondary action 
while ABXY buttons are used for primary actions but it can vary depending on user preferences.
```
 ## Part 2 - Train Hands Interaction Scene

 Added Behaviors:
 1. Button 1: Pressing the button will play a soundtrack
 2. Button 2: Adjusts the train scene scale based on the soundtrack's status: increases when playing, decreases when not.