using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {
    static restart Instance; 
    void Update()
    {
        if (Input.GetKey(KeyCode.KeypadEnter)){
            SceneManager.LoadScene("test");
        }
    }
}