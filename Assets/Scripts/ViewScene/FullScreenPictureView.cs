using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullScreenPictureView : MonoBehaviour
{
    /*��������� ��������� �� �������� �� ������� ������, � ���� ���, �� ��������� � � �������, �������� � ��������� ���������.
     ���� �� ����, �� ���������� �.
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
