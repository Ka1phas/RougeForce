using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

    private Camera camera;

	// Use this for initialization
	void Start () {
        camera = GetComponent<Camera>();
        if (!isLocalPlayer)
            camera.enabled = false;
	}
}
