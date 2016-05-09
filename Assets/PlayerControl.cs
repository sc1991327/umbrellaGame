using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    //public float collisionAddForceRate = 5;
    public float collisionAddVelocity = 6;

    public float MinDragValue = 0.1f;
    public float MaxDragValue = 10.0f;

    private Rigidbody rb;

    private bool isTouch = false;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

        float temp = Input.GetAxis("Jump");
        bool tempTouch = false;
        if (temp > 0)
            tempTouch = true;

        if (tempTouch == true && isTouch == false)
        {
            rb.drag = rb.drag > 1 ? MinDragValue : MaxDragValue;
            Debug.Log("Drag Value: " + rb.drag);
        }
        isTouch = tempTouch;
	}

    void OnCollisionEnter(Collision collision)
    {
        //rb.AddForce(Vector3.up * collisionAddForceRate);
        rb.velocity = new Vector3(rb.velocity.x, 6, rb.velocity.z);
    }

    void OnCollisionStay(Collision collision)
    {
        
    }

    void OnCollisionExit(Collision collision)
    {

    }
}
