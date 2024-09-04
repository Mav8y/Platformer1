using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            Application.LoadLevel(2);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
