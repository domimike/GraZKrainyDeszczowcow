using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;

    private bool atEdge;
    public Transform edgeCheck;

    private Animator animEnemy;
    // Start is called before the first frame update
    void Start()
    {
        animEnemy = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

        atEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);

        if (hittingWall || !atEdge)
            moveRight = !moveRight;
        
        animEnemy.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

        if (moveRight)
        {
            transform.localScale = new Vector3(0.17043f, 0.17043f, 0.17043f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(-0.17043f, 0.17043f, 0.17043f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlayerPlatformerController>())
        {
            animEnemy.SetBool("Colliding", true);
        }
        else
        {
            animEnemy.SetBool("Colliding", false);
        }
    }
}
