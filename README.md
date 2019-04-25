# Turtlebot Robot for Unity - URDF file

* Copy the project "Turtlebot-Unity-URDF"

## Importing to Unity

* Create an empty project in Unity

* In "*Assets Store*" look for "*ROS#*" and import it to your project

* In Unity menu "*Edit*" -> "*Project Settings*" -> "*Player*". 

* In "*Inspector*" tab select "*Other settings*" and change the "*Scripting Runtime Version*" to ".NET 4.x Equivalent"

* Unity will restart

* Create a URDF file inside "Assets" and copy all the files that are inside this project "Turtlebot-Unity-URDF"

* In Unity menu "*GameObject*" -> "*3D Object*" -> "*URDF Model (Import)*" and choose **turtlebotT2i.urdf** that are inside URDF folder created before

* Ignore Missing Asset and Continue URDF Import 

## Result
After those steps, you should have:
![alt text](https://raw.githubusercontent.com/mirellameelo/Turtlebot-Unity-URDF/edit/master/images/6_unity.png)


#### Observation:
When I tried to add anything else in the scene, the robot started to be unstable. 
I'm not sure, but I think it is because of some configuration in Unity Physics Engine. 
This instability also happened with the Shadow Hand [(tutorial here)](https://github.com/siemens/ros-sharp/wiki/User_Inst_ShadowHand), and 
because of that, I don't think the problem is in the model. Still waiting for some answer about that 
[here](https://github.com/siemens/ros-sharp/issues/194). 
