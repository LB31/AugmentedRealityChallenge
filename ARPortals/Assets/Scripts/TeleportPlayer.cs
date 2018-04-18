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
        if(other.name == "ARCamera") {
            digitalWorld.layer = 0;
            gameObject.SetActive(false);
        }
        
        Debug.Log("Triggered", other.gameObject);
     }
    


}
