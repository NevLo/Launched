using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public class Boosts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public PhysicsAndInput player;



    // Update is called once per frame
    void Update()
    {
        //player.vel.x = -5;
        
    }

    void onCollisionEnter(Collision collision) {
        player.vel.x = -5;
        Debug.Log("BOOSTS");
        Debug.Log("Player collided with" + collision.collider.gameObject.name);
    }
}
