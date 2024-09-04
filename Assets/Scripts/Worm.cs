using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : Entity
{
    public Hero hero;
    [SerializeField] private int lives = 3;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        try
        {
            hero = GameObject.Find("Hero").GetComponent<Hero>();
            lives--;
            Debug.Log("У червя " + lives);
            if (lives < 1)
            {
                Die();
            }
            if (collision.gameObject == hero.gameObject)
            {
                hero.GetDamage();
            }
            return;
        }
        catch
        {
            Debug.Log("a");
        }
    }
}
