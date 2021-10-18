using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 deplacement = new Vector3(10, 10, 10);
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

    void OnCollisionEnter(Collision reflet){
        deplacement = Vector3.Reflect(deplacement, reflet.contacts[0].normal);
    }
}
