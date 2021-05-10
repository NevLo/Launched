using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource),typeof(Component))]
public class EnemyPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;


    public Vector3 pos;
    public Vector3 vel;
    public Vector3 accl;
    public GameObject player;
    public float deltaPos = .01F;
    public float jumpSpeed = 1F;
    public float height = 2;
    public float gravity = -.98F;
    void Start()
    {
        //pos = new Vector3(0,0,0);
        pos = transform.localPosition;
        accl.y = gravity;
        player = GameObject.Find("PlayerObject");
        //vel = Vector3.zero;
        //accl = Vector3.zero;
        //accl.y = 0;
        //pos.y = height;

    }




    // Update is called once per frame
    void Update()
    {


        float dist = getDistFromPlayer();

        if (dist <= 5)
        {
            var playerpos = player.transform.position;
            pos = Vector3.MoveTowards(transform.position, playerpos, deltaPos);
            //Debug.Log(dist);
            

            //vel = vel + accl * Time.deltaTime;
            //pos = pos + vel * Time.deltaTime;
            transform.localPosition = pos;

        }
    }
    float getDistFromPlayer()
    {
        var playerpos = player.transform.position;
        return (playerpos - pos).magnitude;
    }

}



