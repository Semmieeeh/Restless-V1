using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatieGun : MonoBehaviour
{
    public Animator controller;
    public AudioSource sound;
    public bool playSound;

   void Start()
   {
       sound.Stop();

   }

   void Update()
   {
       if(Input.GetMouseButtonDown(0))
       {
           controller.SetBool("Rap",true);
       } 
       else if(Input.GetMouseButtonDown(1))
       {
           controller.SetBool("Rap",false);
       }  
       if(Input.GetMouseButtonDown(0))
       {
           playSound = true;
                sound.Play();

       }
       if(Input.GetMouseButtonDown(1))
       {
            playSound = false;
                sound.Stop();

       }  

   }
}
