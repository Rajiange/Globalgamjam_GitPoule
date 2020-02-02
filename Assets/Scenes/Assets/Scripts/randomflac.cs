using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomflac : MonoBehaviour
{
    public Vector3[] positions;
    private int randomNumber;
    private float timeLeft = 4;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, positions.Length);

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            transform.position = positions[randomNumber];
            randomNumber = Random.Range(0, positions.Length);
            timeLeft = 4;
        }
    }
}
