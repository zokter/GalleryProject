using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    /*Кнопка по нажатию на которую вызывается анимация перехода на сцену галереи, по окончании которой вызывается переход.*/

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
