using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour
{
    /*������ ����� �������������� ����������.*/
    void Start()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
    }
}
