using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindControll : MonoBehaviour
{
    public Animator Animator1, Animator2;
    public int Wind;
  
    public void StartWind ()
    {
       
        if(Wind == 0)
        {
            Wind = 1;
        }
        else
        {
            Wind = 0;
        }
    }
    
    private void FixedUpdate()
    {
        Animator1.SetInteger("Wind", Wind);
        Animator2.SetInteger("Wind", Wind);
    }

}
