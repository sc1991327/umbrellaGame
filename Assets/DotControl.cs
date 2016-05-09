using UnityEngine;
using System.Collections;

public class DotControl : MonoBehaviour {

    public GameObject startAnchor = null;
    public GameObject endAnchor = null;

    private Vector3 spos;
    private float cameraPrePosX;

	// Use this for initialization
	void Start () {

        spos = transform.position;
        cameraPrePosX = Camera.main.transform.position.x;

	}
	
	// Update is called once per frame
	void Update () {

        if (cameraPrePosX > Camera.main.transform.position.x)
        {
            PlayRestart();
        }
        cameraPrePosX = Camera.main.transform.position.x;

        if (transform.position.x < endAnchor.transform.position.x)
        {
            transform.position = new Vector3(startAnchor.transform.position.x + Random.value * 2 - 1, transform.position.y);
        }

	}

    public void PlayRestart()
    {
        transform.position = spos;
    }
}
