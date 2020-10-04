using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTextBehaviour : MonoBehaviour
{
    public Text textHolder;

    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPos.z > 0)
        {
            screenPos.z = 0;
            textHolder.transform.position = screenPos;
        }
    }
}
