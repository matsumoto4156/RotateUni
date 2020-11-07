using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachThings : MonoBehaviour
{
    public string toTag;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator KandD(float sec)
    {
        yield return new WaitForSeconds(sec);
        this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "touch")
        {
            this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        }
    }

    public void Fall(float sec)
    {
        StartCoroutine("KandD", sec);
    }
}
