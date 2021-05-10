using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class PhysicsAndInput : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
 

    public Vector3 pos;
    public Vector3 vel;
    public Vector3 accl;
    public float deltaPos = .05F;
    public float jumpSpeed = 1F;
    
    public float gravity = -.98F;
    private bool hasJumped;
    private bool useGravity = true;
    public float turnSpeed = 5f;
    
    void Start()
    {
        pos = Vector3.zero;
        vel = Vector3.zero;
        accl = Vector3.zero;
        accl.y = 0;
        pos.y = 0;
        hasJumped = false;
    }




    // Update is called once per frame
    void Update()
    {
        getInputs();

        vel = vel + accl * Time.deltaTime;
        pos = pos + vel * Time.deltaTime;
        if (accl.y == 0)
        {
            hasJumped = false;
        }
        if (pos.y <= 0 && useGravity)
        {
            pos.y = 0;
            accl.y = 0;
        }        

        transform.localPosition = pos;

    }

    void getInputs()
    {
        if (Input.GetKey(KeyCode.D))
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (Input.GetKey(KeyCode.Q))
            Application.Quit();
        if (Input.GetKey("d"))
            pos.z += deltaPos;
        if (Input.GetKey("a"))
            pos.z -= deltaPos;
        if (Input.GetKey("s"))
            pos.x += deltaPos;
        if (Input.GetKey("w"))
            pos.x -= deltaPos;
        if (Input.GetKey(KeyCode.Space) && !hasJumped)
        {
            vel.y = jumpSpeed;
            accl.y = gravity;
            audioSource.Play();
            hasJumped = true;
        }
    }
}



