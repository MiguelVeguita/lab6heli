using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manzanita : MonoBehaviour
{
    private Rigidbody man;
    // Start is called before the first frame update
    void Start()
    {
        man = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        man.velocity = new Vector3(man.velocity.x * 1f , man.velocity.y*1f, man.velocity.z-1);
    }
}
