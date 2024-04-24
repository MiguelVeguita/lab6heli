using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basu : MonoBehaviour
{
    private Rigidbody basur;
    // Start is called before the first frame update
    void Start()
    {
        basur = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        basur.velocity = new Vector3(basur.velocity.x * 1f, basur.velocity.y * 1f, basur.velocity.z - 1);
    }
}
