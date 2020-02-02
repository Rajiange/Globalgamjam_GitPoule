using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottedefoin : MonoBehaviour
{
    float timeleft = 5.0f;
    public GameObject Bottedefoins;
    public Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos.x = -10.32f;
        pos.y = -4f;
    }

    // Update is called once per frame
    void Update()
    {
        timeleft = timeleft - Time.deltaTime;
        //Debug.Log("time" + timeleft);
        if (timeleft < 0)
        {
            //Instantiate(Bottedefoins);
            transform.position = new Vector2(pos.x, pos.y);
            if (pos.y >= 3.8f)
                Application.Quit();
            //Debug.Log("marche");
            timeleft = 5.0f;
            pos.y += 0.5f;
        }
    }
}
