using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationsHandler : MonoBehaviour {
    public GameObject text;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (gameObject.GetComponent<BoxCollider>().enabled == true)
        {
            text.SetActive(false);
        }

    }

}
