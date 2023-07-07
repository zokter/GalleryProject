using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour
{
    /*Задает сцене автоматическую ориентацию.*/
    void Start()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
    }
}
