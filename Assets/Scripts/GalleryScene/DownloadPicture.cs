using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadPicture : MonoBehaviour
{
    /*������ ������ ���������� ��������� ����������� ������������
     * ��������� ������� ��� ���������� ������� � ��������� ��������� 
     * �������� ���������� �� ����� �������, ��� ������������� ������ ����������� �� �������.
     * 
     ��� ���������� : ���������� � ����������, ������� �������� ������������ �������� ����������� � ������� � ���������� ������������, 
        ������ ��� ���������� � �����������, ����� ���� �������� ����� ��� ����������� ������������ ������� ��������.
     ��� �������: �������� ����� ��� ����������� ������������ ������� ��������.
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
