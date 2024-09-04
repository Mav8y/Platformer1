using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationTransition : MonoBehaviour
{
    public string nextLocation; // Название следующей сцены (локации), куда вы хотите перейти

    private void OnMouseDown()
    {
        SceneManager.LoadScene(nextLocation); // Переходим на следующую локацию
    }
}