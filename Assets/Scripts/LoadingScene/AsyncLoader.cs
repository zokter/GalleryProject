using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AsyncLoader : MonoBehaviour
{

    /*������ ���������� �� ������ ��������. 
     �� �.�. ����� ���� "�� 2-3 ������� ���������� ����� �������� � ��������-����� � ���������� ��������."
     2-3 ������� ��� ���������� �������� ��������� ��� ��� ���������� ��� �������� ���������� ����������� � �������.

     ��������� ����������� � ������� � ���������� ������� ��������, ������� ������� �� ����������� ��������� �����������.
     ��� �������� ��������� ����������� � ��������� ��������� �� �������� � ����������� ���������� �������� ����������� ��� �����������. 
     */

    [SerializeField] private Slider loadingSlider;

    [SerializeField] private TextMeshProUGUI loadingPercentage;

    [SerializeField] GameObject sceneFadeContainer;

    private SceneFade fade;

    private const int NUMBER_OF_PRELOADED_PICTURES = 4;

    private void Awake()
    {
        fade = sceneFadeContainer.GetComponent<SceneFade>();
    }

    public void Start()
    {
        StartCoroutine(LoadLevelASync());
    }
    IEnumerator LoadLevelASync()
    {
        for(int i = 1; i <= NUMBER_OF_PRELOADED_PICTURES; i++)
        {
            yield return Loader.LoadImages(i);

            loadingSlider.value = Mathf.Clamp01((float)i / 4);
            loadingPercentage.text = $"{((float)i / 4) * 100}%";
        }

        fade.FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
