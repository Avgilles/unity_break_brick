using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquette : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        Vector3 mouvement = new Vector3(h, 0f, 0f);
        //transform.position += Vector3.right * Time.deltaTime * speed;
        transform.Translate(mouvement * Time.deltaTime  * speed);
    }
}
