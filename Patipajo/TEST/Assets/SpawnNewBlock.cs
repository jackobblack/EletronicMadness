using UnityEngine;
using System.Collections;

public class SpawnNewBlock : MonoBehaviour {
    private Rigidbody rb;
    private SpringJoint myJoint;
    // ScriptName otherScript;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        myJoint = GetComponent<SpringJoint>();
        rb.isKinematic = true;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.End))
        {
            myJoint.breakForce = 5;
            rb.isKinematic = false;
            myJoint = gameObject.AddComponent<SpringJoint>();
            myJoint.breakForce = 5;
            myJoint.breakTorque = 5;
            Destroy(this);
        }
    }
}
