using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public string next; 
    GameObject player;
    void Start()
    {
        player = GameObject.Find("PlayerObject");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log((player.transform.position - transform.position).magnitude);
        if ((player.transform.position - transform.position).magnitude < 5)
        {
            SceneManager.LoadScene(next);
        }
    }

}