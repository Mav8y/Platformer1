using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : Entity
{
    public Transform camereControl;
    public Transform player;
    private Vector3 pos;
    private void Awake()
    {
        if(!player)
        {
            player = FindObjectOfType<Hero>().transform;
        }
    }
    private void Update()
    {
        pos = player.position;
        pos.z = -5f;
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
        try
        {
            if (player == false)
            {
                camereControl.gameObject.SetActive(false);
            }
        }
        catch
        {
            Debug.Log("Ok");
        }
    }
}
