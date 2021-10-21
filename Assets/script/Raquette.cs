using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquette : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    public float clampX = 10f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -clampX, clampX);
        transform.position = pos;
        transform.Translate(Vector3.right * h * Time.deltaTime * speed);


        // Vector3 mouvement = new Vector3(pos.x, 0f, 0f);

        //transform.position = pos * h;

        //float v = Input.GetAxis("Vertical");

        //transform.position += Vector3.right * Time.deltaTime * speed;

        //Debug.Log(mouvement);
    }
}
