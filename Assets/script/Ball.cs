using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public Vector3 deplacement = new Vector3(10, 10, 10);
    public int nbrBriques = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // deplacement = transform.Translate(deplacement * Time.deltaTime);
        GetComponent<Rigidbody>().velocity = deplacement;

    }

    void OnCollisionEnter(Collision collision){
        deplacement = Vector3.Reflect(deplacement, collision.contacts[0].normal);

        if (collision.gameObject.tag == "Brique")
        {
            Destroy(collision.gameObject);
            nbrBriques = nbrBriques - 1;
            if(nbrBriques == 0)
            {
                Debug.Log("victory");
                SceneManager.LoadScene("Victoire");
            }
        }
    }
}
