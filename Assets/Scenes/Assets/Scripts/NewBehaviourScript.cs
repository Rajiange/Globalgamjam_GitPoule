using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject[] pauseObjects;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void quit()
    {
        Application.Quit();
    }
   
   


    //loads inputted level
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}