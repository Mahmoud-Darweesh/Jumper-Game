# Jumper-Game
A nice game to play and challenge you friends with!

# Demo:

Read the description of the game in itch.io to understand the controls.

https://mahmouddarwish.itch.io/jumper-game

## The Introduction:
  I wanted to make a game that I could play with my friends so I decided to make something that resembled one of my favourite games, Mario.

## The Design:

  I started sketching ideas for a level in my notebook until I landed on one that I really enjoyed. This was one of the first projects where I learned how to take an idea from paper to the screen.
  
  ##### The Sketch:
  
  ![Paper to level](https://user-images.githubusercontent.com/95291720/148129048-af0c4d6e-92a4-46ba-bd7c-f490889cafd4.jpg)

  ##### The Level:
  
  ![Level 2](https://user-images.githubusercontent.com/95291720/148129091-f76deff9-99f2-4baf-906a-624cf39101f5.PNG)

## The Challenges:
	
  One of my friends played the game on his phone but wanted to use a controller so I had to find a way to take in the input of the controller without having to delete the mobile joystick because some of my other friends played on the mobile. 

## The Solution:

Here I check if there is any movement from the controller, if there is I disable the joystick but if there is movement from the joystick I disable the controller.

```
if (Input.GetAxisRaw("Horizontal") * rSpeed == 0)
{
    horizontalMove = joystick.Horizontal * rSpeed;
}
else if (joystick.Horizontal * rSpeed == 0)
{
    horizontalMove = Input.GetAxisRaw("Horizontal") * rSpeed;
}
```

## Mobile Support: 

![Mobile 1](https://user-images.githubusercontent.com/95291720/148129890-9598ed90-21ab-44af-89fb-61dbecf21bfa.jpeg)

## The Levels: 

  There are 11 levels in total each with a unique obstacle to reach the chest.
  
  #### Tutorials:
  
  These tutorials help the player understand the controles.
  
  ![Tutorial](https://user-images.githubusercontent.com/95291720/148129633-7dc72d76-c222-4e6e-b14b-549faeab979d.PNG)
  
  ![Tutorial 2](https://user-images.githubusercontent.com/95291720/148129638-7c91ea01-322f-488e-9427-b8f97fca40a3.PNG)
  
  #### Level 3:
  
  ![Level 5](https://user-images.githubusercontent.com/95291720/148130571-7e94b0e6-079b-481b-b97d-80db8de2fd5b.PNG)
  
   #### Level 4:
   
   ![Level 6](https://user-images.githubusercontent.com/95291720/148130626-9f2de01c-c165-4ee6-b0e4-381e1e576351.PNG)

   #### Level 5:
   
   ![Level 7](https://user-images.githubusercontent.com/95291720/148130695-a90eed8b-cd12-4f43-95da-700b7f75c19b.PNG)

   #### Level 6:
   
   ![Level 2](https://user-images.githubusercontent.com/95291720/148130754-69c7d710-29fc-40b9-b447-52a9f7ce10fe.PNG)

   #### Level 7:
   
   ![Level 1](https://user-images.githubusercontent.com/95291720/148130804-fb68cc1d-d649-4496-a864-00967de16787.PNG)
   
   ![Level 1 5](https://user-images.githubusercontent.com/95291720/148130826-c4b421ad-e0a2-4597-8044-567b8f555f62.PNG)
   
   #### Level 8:
   
   ![Level 8](https://user-images.githubusercontent.com/95291720/148130863-57aa5ced-d0af-4664-9f4b-59f414f1cb38.PNG)
      
   #### Level 9:
   
   ![Level 9](https://user-images.githubusercontent.com/95291720/148130935-d6b18c07-fe7b-4354-ad7e-af698141a42c.PNG)

   #### Level 10:
   
   ![Level 10](https://user-images.githubusercontent.com/95291720/148131061-90cc041e-05ea-4775-a351-2ff94e46c412.PNG)
   
   #### Level 11:
   
   ![Level 11](https://user-images.githubusercontent.com/95291720/148131091-9f5aeadd-4ea1-4e70-a13a-d1b1b8372b76.PNG) 
