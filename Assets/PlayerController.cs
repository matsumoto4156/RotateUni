using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask ground;
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 430.0f;
    float walkForce = 20.0f;
    float maxSpeed = 4.0f;
    bool grounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position,
                                    transform.position - transform.up * 1f,
                                    ground);


        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rigid2D.AddForce(transform.up * jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        else if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float nowSpeed = Mathf.Abs(rigid2D.velocity.x);
        if (maxSpeed > nowSpeed)
        {
            rigid2D.AddForce(new Vector3(walkForce, 0, 0) * key);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key*0.8f, 0.8f, 0.8f);
        }
        animator.speed = nowSpeed / 2.0f;
    }
}
