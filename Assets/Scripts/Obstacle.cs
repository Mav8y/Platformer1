using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Entity
{
    public Hero hero;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        try
        {
            hero = GameObject.Find("Hero").GetComponent<Hero>();
            if (collision.gameObject == hero.gameObject)
            {
                try
                {
                    hero.GetDamage();
                }
                catch
                {
                    Debug.Log("a");
                }
            }
        }
        catch
        {
            Debug.Log("b");
        }
    }
}