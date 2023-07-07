using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GalleryGridBuilder : MonoBehaviour
{
    /* Размещает на канвасе контейнеры, каждый из которых в последствии содержит 2 изображения,
     * таким образом формируя 2 колонки по 33 изображения.
     После размещения всех контейнеров принудительно обновляет экран для срабатывания Content Size Fitter,
     он позволяет получить высоту прокручиваемой панели, а как следствие выставить её позицию для просмотра изображений начиная с 1-го*/

    [SerializeField] private GameObject ImagesContainer;
    [SerializeField] private GameObject Image;

    private void Awake()
    {
        int imagesIndex = 1;

        for(int i = 0; i <= 32; i++)
        {
            GameObject containerPref = ImagesContainer;
            containerPref.name = i.ToString();

            GameObject container = Instantiate(containerPref, this.transform);

            MakeImage(container.transform, imagesIndex);
            imagesIndex++;

            MakeImage(container.transform, imagesIndex);
            imagesIndex++;
        }

    }

    private void Start()
    {
        Canvas.ForceUpdateCanvases();
        RectTransform rectTransform = GetComponent<RectTransform>();
        transform.position = new Vector3(transform.position.x, 
             -rectTransform.sizeDelta.y * 2, transform.position.z);
    }

    private void MakeImage(Transform parent, int index)
    {
            GameObject image = Image;
            image.name = index.ToString();
            Instantiate(image, parent);
    }
}
