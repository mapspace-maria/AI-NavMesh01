# AI-NavMesh01

The challenge for this assignment was to update an existing project to add a FirstPersonCharacter who will move around the NavMesh.

Steps for first person:
1. Ensure the NavMesh is in place so the player and enemies can move around
2. Add the FirstPersonPlayer, adjust the camara and the controller.
3. Create the playercontroller script to make the player move arounf the scene. 
4 Test it! 

Then we've to make the enemies follow the player along it's movements.

Steps for enemies:
1. Add the script to chase the player
2. Ensure the enemies only move along the navmesh
3. Test it!

Later, we've to make certaine differences on the vanigation behavior for each of the enemies. This is what I've done.

Steps for navmesh:
1. There are 3 different areas for the navigation: Walkable, Corridor and Pool(I add this one myself)
2. Assign each area to different enemies (see img of enemies properties to see the distribution)
3. On the inspector NavMesh agent of each of the enemies I've change their properties refering to speed, radius, stop. (see img of enemies properties to see the distribution)
4. Also the dimension of each enemy is different so the collider too.
5. Test it!

The final result is a first person game where the enemimes chase the player on a different nav behavior and pattern 
