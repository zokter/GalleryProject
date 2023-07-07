using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Loader : MonoBehaviour
{
    /*����� ���������� ��������. � ���� ���������� ������ ����� ����������� ������� ����� ���������.
     ���������� ��������� �������� � ����������� �����, ����������� ���� ���������� ���������.
     ����� ������ ��� ����������� ������ ���������� �� �� "texture" � "sprite".
     */

    [SerializeField] private static string url = "http://data.ikppbb.com/test-task-unity-data/pics/";

    public static IEnumerator LoadImages(int imageIndex)
    {
        UnityWebRequest loader = UnityWebRequestTexture.GetTexture(url + $"{imageIndex}.jpg");
        yield return loader.SendWebRequest();

        UploadedTexturesData.sprites[imageIndex - 1] = TextureToSprite(DownloadHandlerTexture.GetContent(loader));
    }
    public static Sprite TextureToSprite(Texture2D texture)
    {
        Sprite webSprite = Sprite.Create(texture,
           new Rect(0.0f, 0.0f, texture.width, texture.height)
           , new Vector2(0.5f, 0.5f), 100.0f);

        return webSprite;
    }
}
