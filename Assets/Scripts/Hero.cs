using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : Entity
{
    public Hero hero;
    [SerializeField] private float speed = 3f; // скорость передвижения
    [SerializeField] private int lives = 5; // количество жизней
    [SerializeField] private float jumpForce = 10f; // сила прыжка
    [SerializeField] private bool isGrounded = false;

    private Rigidbody2D rb;
    private Animator anim;
    public Text text;
    private Text myText;
    private SpriteRenderer sprite;

   // public static Hero Instance { get; set; }

    private States State
    {
        get
        {
            return (States)anim.GetInteger("state");
        }
        set
        {
            anim.SetInteger("state", (int)value);
        }
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    public void FixedUpdate()
    {
        CheckGround();
    }

    public void Update()
    {
        if (isGrounded)
        {
            State = States.test_animation;
        }
        if (Input.GetButton("Horizontal"))
        {
            Run();
        }
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }
    private void Run()
    {
        if (isGrounded)
        {
            State = States.Run;
        }
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0.0f;
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.9f);
        isGrounded = collider.Length > 1;
        if (!isGrounded)
        {
            State = States.Jump;
        }
    }
    public override void GetDamage()
    {
        lives--;
        Debug.Log(lives);
        if (lives < 1)
        {
            Die();
        }
    }
    public void Die()
    {
        if(lives < 1)
        {
            Application.LoadLevel(0);
        }
    }
}

public enum States
{
    test_animation,
    Run,
    Jump
}