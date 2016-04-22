using UnityEngine;
using System.Collections;

public class Editor_Position : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 2, 0);

        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0, 2, 0);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(2, 0, 0);

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.position += new Vector3(2, 0, 0);
        }
    }
}
