using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgr : MonoBehaviour
{
    public static UIMgr inst;
    public void Awake()
    {
        inst = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Text speedLabel;
    public Text speedText;
    public Text boostLabel;
    public Text boostText;
    public Text healthLabel;
    public Text healthText;
    public PhysicsAndInput player;
   

    //PhysicsAndInput test = playerObject.GetComponent<PhysicsAndInput>();

    //GameObject player = Player;
    // Update is called once per frame
    void Update()
    {
        
        
        speedText.text = (player.vel.magnitude).ToString(); 
        //boostText.text = ().ToString(); 
        //healthText.text = ().ToString(); 
    }
}
