using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class zoneFin : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Balle")
        {
            Debug.Log("out");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
