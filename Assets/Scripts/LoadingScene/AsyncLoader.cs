using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AsyncLoader : MonoBehaviour
{

    /*—крипт вызываетс€ на экране загрузки. 
     ѕо “.«. нужно было "на 2-3 секунды по€вл€етс€ сцена «агрузки с прогресс-баром и процентами загрузки."
     2-3 секунды при нормальной скорости интернета как раз достаточно дл€ загрузки нескольких изображений с сервера.

     «агружает изображени€ с сервера и отображает полоску загрузки, котора€ зависит от колличества скаченных изображений.
     ѕри загрузке добавл€ет изображени€ в локальное хранилище из которого в последствии происходит загрузка изображений дл€ отображени€. 
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
