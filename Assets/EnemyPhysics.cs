using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class EnemyPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;


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
        //accl = Vector3.zero;
        //accl.y = 0;
        //pos.y = height;
    }




    // Update is called once per frame
    void Update()
    {
        if (Mathf.Floor(pos.z) == 2) {
            vel.z = 1;
        }
        if (Mathf.Floor(pos.z) == 5.57) {
            vel.z = -1;
        }
        
        getInputs();

        vel = vel + accl * Time.deltaTime;
        pos = pos + vel * Time.deltaTime;
        if (pos.y <= height)
        {
            pos.y = height;
            accl.y = 0;
        }

        transform.localPosition = pos;

    }

    void getInputs()
    {
        if (Input.GetKey(KeyCode.Q))
            Application.Quit();

        if (Input.GetKey(KeyCode.LeftArrow))
            //pos.x -= deltaPos;
        if (Input.GetKey(KeyCode.RightArrow))
            //pos.x += deltaPos;
        if (Input.GetKey(KeyCode.UpArrow))
            //pos.z += deltaPos;
        if (Input.GetKey(KeyCode.DownArrow))
            //pos.z -= deltaPos;
        if (Input.GetKey(KeyCode.Space))
        {
            //vel.y = jumpSpeed;
            //accl.y = gravity;
            //audioSource.Play();
        }
    }

}



