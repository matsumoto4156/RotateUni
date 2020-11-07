using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onceFlag : MonoBehaviour
{
    public int number;
    GameManager GM;
    int onF = 0;

    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && onF == 0)
        {
            other.gameObject.GetComponent<PlayerController>().Stop(1.5f);
            GM.Rotate(number);
            onF = 1;
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
}
