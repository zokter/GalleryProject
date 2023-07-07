using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    /*������� ������ �� ������ �������� ���� � ��������.*/

    [SerializeField] private Vector3 rotationSpeed;
    void Update()
    {
        if(transform.eulerAngles.y > 180)
        {
            rotationSpeed = -rotationSpeed;
            Debug.Log(1 + " " + rotationSpeed);
        }
        transform.Rotate(rotationSpeed);
    }
}
