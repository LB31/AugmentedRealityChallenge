using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour {
    public GameObject digitalWorld;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   
    void OnTriggerEnter(Collider other)
     {
        digitalWorld.layer = 0;
        Debug.Log("Triggered");
     }
    


}
