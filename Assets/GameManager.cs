using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<string> Stage = new List<string>() { "Stage1", "Stage2", "Stage3", "Stage4" };

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Rotate(int num)
    {
        foreach (GameObject st
            in GameObject.FindGameObjectsWithTag(Stage[num - 1]))
        {
            st.GetComponent<move>().Rotate(num);
        }
    }
}
