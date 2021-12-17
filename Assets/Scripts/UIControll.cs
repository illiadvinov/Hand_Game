using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIControll : MonoBehaviour
{
    ClickerControll clickerControll;
    TMP_Text score;
    [SerializeField] Material green;
    [SerializeField] Material red;
    [SerializeField] int tries = 20;

    private void Start()
    {
        clickerControll = FindObjectOfType<ClickerControll>();
        score = GetComponent<TMP_Text>();
        score.text = tries.ToString();
    }

    public void DecreaseScore()
    {
        
        LeanTween.scale(gameObject, new Vector3(1.5f, 1.5f, 0), 0.5f).setEasePunch();
        tries -= 1;
        if(tries <= 0)
        {
            green.color = new Color (0, .7f, .64f, 1f) * 5;
        }
        score.text = tries.ToString();
        

    }
    public void DecreaseScore(int multiplier)
    {
        tries -= 1;
        LeanTween.scale(gameObject, new Vector3(2f, 2f, 1f), 0.3f).setEasePunch();
        score.text = tries.ToString();
        

    }

    
    
}