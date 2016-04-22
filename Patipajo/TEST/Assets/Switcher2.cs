using UnityEngine;
using System.Collections;

public class Switcher2 : MonoBehaviour
{
    private MeshRenderer mr;
    // Use this for initialization
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            mr.enabled = false;
        }
        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            mr.enabled = true;
        }

    }
}
