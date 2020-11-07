using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag : MonoBehaviour
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

    IEnumerator Coroutine(float sec)
    {
        onF = 1;
        yield return new WaitForSeconds(sec);
        onF = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && onF == 0) 
        {
            other.gameObject.GetComponent<PlayerController>().Stop(1.5f);
            GM.Rotate(number);
            StartCoroutine("Coroutine", 1.5f);
        }
    }
}
