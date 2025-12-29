# 3D-Ball-Control-Game-using-C# README
This project contains a modular set of C# scripts for a physics-based "Ball Roller" game in Unity. It includes player movement, camera tracking, level progression, and respawn mechanics.
## Core Scripts Overview
### Player & Movement
•	PlayerBallController.cs: The heart of the player movement. It captures keyboard/controller input (Horizontal and Vertical) and applies a constant force to a Rigidbody component.
•	RespawnOnFall.cs: Monitors the player's height. If the player falls off the platform (Y-position below -5), it resets their position to a designated spawnPoint and kills all physical momentum.
### Environment & Game Flow
•	FinishTrigger.cs: Handles the end-of-level logic.
o	If it's a middle level, it automatically loads the next scene in the Build Settings.
o	If it's the isLastLevel, it triggers a Win UI panel and pauses the game.
•	RestartGame.cs: A simple utility script, typically linked to a UI button, that resets the Time.scale and reloads the first scene (index 0).
### Camera System
•	CameraFollow.cs: A smooth-damping camera script. It maintains a specific offset from the player and uses SmoothDamp to prevent jittery movement, while always keeping the player in sight using LookAt.
________________________________________
## Setup Instructions
### Player Setup
1.	Create a Sphere in your scene.
2.	Add a Rigidbody component to the sphere.
3.	Attach the PlayerBallController and RespawnOnFall scripts.
4.	Create an empty GameObject in your scene called "SpawnPoint" and assign it to the spawnPoint slot in the RespawnOnFall script.
5.	Tag the Sphere as "Player" in the Inspector (required for the Finish Trigger to work).
### Camera Setup
1.	Select your Main Camera.
2.	Attach the CameraFollow script.
3.	Drag your Player Sphere into the Target field.
### Level Completion Setup
1.	Create a GameObject (like a Cube) at the end of your level.
2.	Set its Collider to Is Trigger.
3.	Attach the FinishTrigger script.
4.	If it is the final level of your game, check the Is Last Level box and assign a UI Panel to the Win Panel slot.
________________________________________
## Technical Details
### PlayerBallController
•	Logic Type: Physics (FixedUpdate)
•	Key Requirement: Requires a Rigidbody component on the same GameObject
### FinishTrigger
•	Logic Type: Trigger (OnTriggerEnter)
•	Key Requirement: The colliding object must have the "Player" Tag
### CameraFollow
•	Logic Type: Interpolation (LateUpdate)
•	Key Requirement: Requires a Transform assigned to the "target" field
### RespawnOnFall
•	Logic Type: Boundary Check
•	Key Requirement: Triggered when the object's Y-position is less than -5


Script	Logic Type	Key Requirement
PlayerBallController	Physics (FixedUpdate)	Requires a Rigidbody
FinishTrigger	Trigger (OnTriggerEnter)	Player must have the "Player" Tag
CameraFollow	Interpolation (LateUpdate)	Requires a Transform target
RespawnOnFall	Boundary Check	Triggered at $Y < -5$

## Controls
•	Move: WASD or Arrow Keys (Uses Unity's Input.GetAxis system).
•	Restart: Triggered via UI Button linked to RestartGame.Restart().

