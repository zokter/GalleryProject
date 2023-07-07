using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitOrintation : MonoBehaviour
{
    /*Задает всценам главного меню, экрана загрузки и галереи исключительно портретную ориентацию.*/

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
}
