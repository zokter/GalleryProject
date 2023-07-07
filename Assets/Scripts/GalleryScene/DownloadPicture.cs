using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadPicture : MonoBehaviour
{
    /*Данный скрипт вызывается объектами содержащими изображениям
     * проверяет наличие уже скачанного спрайта в локальном хранилище 
     * проверка происходит по имени объекта, оно соответствует номеру изображения на сервере.
     * 
     при отсутствии : обращается к загрузчику, который начинает параллельную загрузку изображения с сервера и возвращает перечисление, 
        нужное для вызывающей её сопрограммы, после чего вызывает метод для отображения загруженного спрайта объектом.
     при наличии: вызывает метод для отображения загруженного спрайта объектом.
     */
    [SerializeField] UploadedPicturesDisplay pictureDisplay;
    public IEnumerator DowloadPictureFromServer()
    {
        name = gameObject.name.Replace("(Clone)", "");
        if (UploadedTexturesData.sprites[int.Parse(name) - 1] == null)
        {
            yield return Loader.LoadImages(int.Parse(name));
            pictureDisplay.Upload();
        }
        else
        {
            pictureDisplay.Upload();
        }
    }
}
