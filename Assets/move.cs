using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    List<Vector3> StageLoc = new List<Vector3>(){
        new Vector3(-2, -2, 0),
        new Vector3(-2, 2, 0),
        new Vector3(2, 2, 0),
        new Vector3(2, -2, 0)};
    Vector3 point;
    Vector3 preRot;
    float time = 0;

    public void Rotate(int num)
    {
        point = StageLoc[num - 1];
        time = 1;
        preRot = transform.eulerAngles;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            transform.RotateAround(point, new Vector3(0, 0, 1), 90 * Time.deltaTime);
            time -= Time.deltaTime;

            if (time <= 0)
            {
                preRot.z += 90;
                transform.eulerAngles = preRot;
                time = 0;
            }
        }
    }
}
