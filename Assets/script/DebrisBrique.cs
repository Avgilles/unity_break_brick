using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisBrique : MonoBehaviour
{
    public float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 motion = new Vector3(Random.Range(-1f, 1f), 1f, 0f);
        GetComponent<Rigidbody>().AddForce(motion * force);
    }
   
    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
