using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropPhyics : MonoBehaviour
{
    // Start is called before the first frame update
   


    public Vector3 pos;
    public Vector3 vel;
    public Vector3 accl;
    public float deltaPos = .05F;
    public float jumpSpeed = 1F;
    public float height = 2;
    public float gravity = -.98F;
    void Start()
    {
        //pos = Vector3.zero;
        //vel = Vector3.zero;
        accl = Vector3.zero;
        accl.y = 0;
        pos.y = height;
    }




    // Update is called once per frame
    void Update()
    {

        vel = vel + accl * Time.deltaTime;
        pos = pos + vel * Time.deltaTime;
        if (pos.y <= height)
        {
            pos.y = height;
            accl.y = 0;
        }

        transform.localPosition = pos;

    }

   

}



