using UnityEngine;
using System.Collections;

public class GroundControl : MonoBehaviour {

    public GameObject manage;

    private ManageControl manageControl;

	// Use this for initialization
	void Start () {

        manageControl = manage.GetComponent<ManageControl>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        manageControl.ShowEndPage();
    }

}
