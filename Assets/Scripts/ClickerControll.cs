using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerControll : MonoBehaviour
{
    int counter = 0;
    float timePressedDown = 0f;
    float timePressedUp = 0f; 

    UIControll uIControll;

    void Start()
    {
        uIControll = GetComponent<UIControll>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if( counter > 0) timePressedUp = timePressedDown;
            timePressedDown = Time.time;
            isClicked();
            counter += 1;

            SpeedControl();
        }
    }


    private void isClicked()
    {
        GetComponent<Animator>().SetTrigger("clicked");
    }

    private void SpeedControl()
    {
        if (timePressedDown - timePressedUp < .5)
        {
            float animationSpeed = (Mathf.Pow((timePressedDown - timePressedUp), -1 )) / 100f;
            if((GetComponent<Animator>().speed +=  animationSpeed) > 3f)
            {
                GetComponent<Animator>().speed -=  animationSpeed;
            }
            else
            {
                  GetComponent<Animator>().speed +=  animationSpeed;
            }
           
            
            //if (counter % 10 == 0) multiplier *= 10;

        }
        else
        {
            GetComponent<Animator>().speed = 1;
        }

    }
}
