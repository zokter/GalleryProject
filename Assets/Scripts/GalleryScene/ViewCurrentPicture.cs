using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ViewCurrentPicture : MonoBehaviour
{
    /* �� ������� �� �������� �������� �������� �������� �� ����� ���������. 
     ���������� ����� �������� �� ������� ������ ��� ����������� �������� � �� ����� ���������.
     */
    [SerializeField] GameObject sceneFadeContainer;
    private SceneFade fade;

    private void Awake()
    {
        fade = FindObjectOfType<SceneFade>();
    }

    public void ViewCurrentBtn()
    {
        PictureToViewBuffer.numberOfPicture = int.Parse(name) - 1;
        fade.FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
