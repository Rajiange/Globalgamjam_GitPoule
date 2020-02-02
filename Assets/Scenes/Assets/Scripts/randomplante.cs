using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomplante : MonoBehaviour
{
    public Vector3[] positions;
    private int randomNumber;
    private float timeLeft = 5;
    //public GameObject plant;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, positions.Length);
        timeLeft = 5;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        //Debug.Log("time" + timeLeft);

        if (timeLeft < 0)
        {
            transform.position = positions[randomNumber];
            randomNumber = Random.Range(0, positions.Length);
            timeLeft = 5;
        }
    }
}
