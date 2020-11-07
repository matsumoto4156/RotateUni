using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("GameScene");
        }

    }


    public void Rotate(int num)
    {
        foreach (GameObject st
            in GameObject.FindGameObjectsWithTag(Stage[num - 1]))
        {
            if (st.GetComponent<move>() != null)
                st.GetComponent<move>().Rotate(num);
            else if (st.GetComponent<attachThings>() != null)
                st.GetComponent<attachThings>().Fall(1.0f);
        }
    }
}
