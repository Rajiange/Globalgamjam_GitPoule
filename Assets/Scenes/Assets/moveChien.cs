using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveChien : MonoBehaviour
{
    public Vector2 pos;
    float[] sens = { -0.01f, 0.01f };
    int lol = 1;

    // Start is called before the first frame update
    void Start()
    {
        pos.x = 3.26f;
        pos.y = -4.08f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(pos.x, pos.y);
            pos.x += sens[lol];
        if (pos.x >= 7.5f)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            lol = 0;
        }
        if (pos.x <= -8.00f)
        {

            transform.eulerAngles = new Vector3(0, 0 , 0);
            lol = 1;
        }
    }
}
