# IMTC505-Lab2
 

 ## Part 1 - Simple Drone App

### A. Testing other apk
1. APK 1:

    Drone rotation is bound to - Right Stick
    Player Movement is bound to - Left Stick
    
    Translation is bound to - Index Trigger and Middle Trigger buttons:
    1. Pressing both index trigger makes the drone go forward
    2. Pressing both middle trigger makes the drone go backward
    3. Pressing the index and trigger on the right controller makes the drone go right 
    4. Pressing the index and trigger on the left controller makes the drone go left 
    
    Lazer is bound to - A (to turn on) and B (to turn off)

2. APK 2:

    Drone movement is bound to - Right Stick
    
    Player Movement is bound to - Left Stick
    
    Lazer is bound to - Right Index Trigger (to turn on) and Left Index Trigger (to turn off)
    
    Could not figure out how to make the drone turn left/right.

3. APK 3:

    Drone movement is bound to - Right Stick
    
    Player Movement is bound to - Left Stick
    
    Lazer is bound to - A (to turn on) and B (to turn off)
    
    Drone can be turned right using right index trigger and turned left using left trigger index

### B. Documentation of Control Scheme:

 1.Drone Translation: Push the right thumb stick in any direction to move the drone.
 ```
The right analog stick is used for primary actions relating to movement in most video games.
Since main focus of this application is to control the drone, the right analog stick was bound to drone movement.
```
 2. Change translation to rotation mode: You can press the right thumb stick to toggle between translation and rotation mode.
```
While not immediately intuitive, pressing the right thumbstick to toggle rotation and translation becomes efficient once the user is accustomed to it, minimizing finger movement and optimizing controller usage.
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