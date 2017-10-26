using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        /* transform.position is the position in the scene where the attached object is
           We calculate the difference in position as an offset, then when each frame 
           is updated we change the camera position so it remains relative to the 
           player object
        */
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
