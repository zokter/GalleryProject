using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagesContainerScreenAppearances : MonoBehaviour
{
    /*Следит за появлением контейнера изображений на экране.
     При появлении вызывает сопрограмму для загрузки соответствующего изображения с сервера.*/
    private Canvas canvas;
    private RectTransform canvasTransform;
    private bool isOnScreen = false;

    private void Start()
    {
        canvas = FindObjectOfType<Canvas>();
        canvasTransform = canvas.GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (!isOnScreen && transform.position.y >= -(canvasTransform.rect.height / 4))
        {
            StartCoroutine(transform.GetChild(0).GetComponent<DownloadPicture>().DowloadPictureFromServer());
            StartCoroutine(transform.GetChild(1).GetComponent<DownloadPicture>().DowloadPictureFromServer());
            isOnScreen = true;
        }
    }
}
