using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana : MonoBehaviour
{
    private Rigidbody bana;
    // Start is called before the first frame update
    void Start()
    {
        bana = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        bana.velocity = new Vector3(bana.velocity.x * 1f, bana.velocity.y * 1f, bana.velocity.z - 1);
    }
}
