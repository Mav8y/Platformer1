using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationTransition : MonoBehaviour
{
    public string nextLocation; // �������� ��������� ����� (�������), ���� �� ������ �������

    private void OnMouseDown()
    {
        SceneManager.LoadScene(nextLocation); // ��������� �� ��������� �������
    }
}