using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullScreenPictureView : MonoBehaviour
{
    /*Проверяет загружена ли картинка на которую нажали, и если нет, то загружает её с сервера, добавляя в локальное хранилище.
     если же была, то отображает её.
     */
    void Start()
    {
        if(UploadedTexturesData.sprites[PictureToViewBuffer.numberOfPicture] == null){
            StartCoroutine(DowloadPictureFromServer());
        }
        else
        {
            UploadPicture();
        }
    }

    private IEnumerator DowloadPictureFromServer()
    {
        yield return Loader.LoadImages(PictureToViewBuffer.numberOfPicture + 1);
        UploadPicture();
    }

    private void UploadPicture()
    {
        GetComponent<UnityEngine.UI.Image>().sprite = UploadedTexturesData.sprites[PictureToViewBuffer.numberOfPicture];
    }
}
