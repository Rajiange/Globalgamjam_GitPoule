using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botteappeat : MonoBehaviour
{
    float timeleft = 5.0f;
    public GameObject bot2;
    // Start is called before the first frame update
    void Start()
    {
        bot2 = GameObject.FindWithTag("bot2");
        bot2.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        timeleft = timeleft - Time.deltaTime;
        bot2 = GameObject.FindWithTag("bot2");

        Debug.Log("time" + timeleft);
        if (timeleft < 0)
        {
            bot2.gameObject.SetActive(true);
            timeleft = 5.0f;
        }
        bot2.gameObject.SetActive(true);

    }
}
