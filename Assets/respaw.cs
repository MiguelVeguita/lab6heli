using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respaw : MonoBehaviour
{
    public GameObject banana, manzana, gaseosa, basura;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ban", 3);
        Invoke("man", 4);
        Invoke("gas", 7);
        Invoke("tacho", 9);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ban()
    {
        Invoke("ban", 3);
        Vector3 posiban = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(banana, posiban, transform.rotation);
    }
    void man()
    {
        Invoke("man", 4);
        Vector3 posiban = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(manzana, posiban, transform.rotation);
    }
    void gas()
    {
        Invoke("gas", 7);
        Vector3 posiban = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(gaseosa, posiban, transform.rotation);
    }
    void tacho()
    {
        Invoke("tacho", 9);
        Vector3 posiban = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(basura, posiban, transform.rotation);
    }
}
