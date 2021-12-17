using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    UIControll uIControll;
    
    void Start()
    {
        uIControll = FindObjectOfType<UIControll>();
    }
    
    
    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
             uIControll.DecreaseScore();
        }
       
    }
    
}
