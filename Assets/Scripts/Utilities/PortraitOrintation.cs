using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitOrintation : MonoBehaviour
{
    /*������ ������� �������� ����, ������ �������� � ������� ������������� ���������� ����������.*/

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
}
