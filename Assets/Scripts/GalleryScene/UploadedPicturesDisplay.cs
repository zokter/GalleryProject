using UnityEngine;

public class UploadedPicturesDisplay : MonoBehaviour
{
    /*Метод для отображения загруженного спрайта объектом*/
    public void Upload()
    {
        if (UploadedTexturesData.sprites[int.Parse(name) - 1] != null)
        {
            GetComponent<UnityEngine.UI.Image>().sprite = UploadedTexturesData.sprites[int.Parse(name) - 1];
            GetComponent<UnityEngine.UI.Image>().color = new Color(255, 255, 255, 255);
        }
    }
}
