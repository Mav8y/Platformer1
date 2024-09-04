using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Died : MonoBehaviour
{
    void Smert()
    {
        Application.LoadLevel(0);
    }
}
