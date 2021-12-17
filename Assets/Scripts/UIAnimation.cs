using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnimation : MonoBehaviour
{
    public void TextAnim()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.1f).setLoopPingPong();
    }
}
