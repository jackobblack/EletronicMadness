using UnityEngine;
using System.Collections;

public class SpringDestroy : MonoBehaviour{
    
    public SpringJoint myJoint;
    public Rigidbody rb;
    void Start()
    {
        myJoint = GetComponent<SpringJoint>();
        rb = GetComponent<Rigidbody>();
    }

  /*  void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Kolider")
        {
            Destroy(myJoint);
            Debug.Log("Zderzenie");
        }
    }
    */
    void OnTriggerStay(Collider other)
    {
        Destroy(myJoint);

    }

    void Update()
    {
        if (rb.isKinematic == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(1, 0, 0) * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0, 1, 0) * Time.deltaTime;
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                rb.isKinematic = !rb.isKinematic;
            }
        }
    }

}