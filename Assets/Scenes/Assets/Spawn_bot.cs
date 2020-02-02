using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_bot : MonoBehaviour
{
    float timeleft = 10.0f;
    public GameObject Bottedefoin;
    public Vector2 pos;
 
    // Start is called before the first frame update
    void Start()
    {
        pos.x = -10.32f;
        pos.y = -3f;
    }

    // Update is called once per frame
    void Update()
    {
        timeleft = timeleft - Time.deltaTime;
        Debug.Log("time" + timeleft);
        if (timeleft < 0)
        {
            Instantiate(Bottedefoin);
            transform.position = new Vector2(pos.x, pos.y);
            Debug.Log("marche");
            timeleft = 10.0f;
            pos.y += 1f;
        }
    }
}
