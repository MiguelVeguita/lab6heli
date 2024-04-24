using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaseosa : MonoBehaviour
{
    private Rigidbody soda;
    // Start is called before the first frame update
    void Start()
    {
        soda = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        soda.velocity = new Vector3(soda.velocity.x * 1f, soda.velocity.y * 1f, soda.velocity.z - 1);
    }
}
