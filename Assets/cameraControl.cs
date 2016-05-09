using UnityEngine;
using System.Collections;

public class cameraControl : MonoBehaviour {

    public GameObject player = null;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (Camera.main.transform.position.x < player.transform.position.x)
        {
            Camera.main.transform.position = new Vector3(player.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
        }

	}
}
