using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    /*Двигает камеру вдоль фона в соответствии с направлением прокручивания списка картинок.
     Так же ограничивает максимальную высоту отклонения камеры, в соответствии с видимостью фона на экране.
     */

    [SerializeField] private int maxHeight = 320;
    [SerializeField] private int minHeight = -320;
    [SerializeField] private float moveSpeed;
    private Touch touch;

    [SerializeField] Plane plane;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                if (transform.position.y >= maxHeight && touch.deltaPosition.y < 0 ||
                    transform.position.y <= minHeight && touch.deltaPosition.y > 0)
                {
                    transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y,
                    transform.position.z
                    );
                }
                else
                {
                    transform.position = new Vector3(
                        transform.position.x,
                        transform.position.y - touch.deltaPosition.y * moveSpeed,
                        transform.position.z
                        );
                }
            }
        }
    }
}
