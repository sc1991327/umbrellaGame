using UnityEngine;
using System.Collections;

public class DynamicControl : MonoBehaviour {

    public GameObject startAnchor = null;
    public GameObject endAnchor = null;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < endAnchor.transform.position.x)
        {
            transform.position = new Vector3(startAnchor.transform.position.x + Random.value * 2 - 1, transform.position.y);
        }

	}
}
