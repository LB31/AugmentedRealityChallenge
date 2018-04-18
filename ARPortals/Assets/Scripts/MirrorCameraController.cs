using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCameraController : MonoBehaviour {
    public GameObject ARCamera;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // transform.eulerangles = arcamera.transform.eulerangles;
        transform.rotation = Quaternion.LookRotation(ARCamera.transform.forward);
    }
}
