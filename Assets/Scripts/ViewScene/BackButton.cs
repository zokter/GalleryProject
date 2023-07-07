using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    /*������ �� ������� �� ������� ���������� �������� �������� �� ����� �������, �� ��������� ������� ���������� �������.*/

    [SerializeField] GameObject sceneFadeContainer;
    private SceneFade fade;

    private void Awake()
    {
        fade = sceneFadeContainer.GetComponent<SceneFade>();
    }

    public void ToPreviousScene()
    {
        fade.FadeToLevel(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
