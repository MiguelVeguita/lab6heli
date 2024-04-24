using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Video;

public class helicontrol : MonoBehaviour
{
    [SerializeField] private Vector3 angulitos;

    [SerializeField] private Quaternion qx = Quaternion.identity;
    [SerializeField] private Quaternion qy = Quaternion.identity;
    [SerializeField] private Quaternion qz = Quaternion.identity;
    [SerializeField] private Quaternion r = Quaternion.identity;

    public int vida;
    private float angulose;
    private float angulocos;

    private Rigidbody rig;
    public float z, y;

    public static event Action<float> vidaheli;
 
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            angulitos = new Vector3(-35, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            angulitos = new Vector3(35, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            angulitos = new Vector3(0, 0, 35);
        }
        if (Input.GetKey(KeyCode.D))
        {
            angulitos = new Vector3(0, 0, -35);
        }
        if (Input.GetKey(KeyCode.N))
        {
            angulitos = new Vector3(0, 0, 0);
        }
    }
    private void FixedUpdate()
    {
       

        angulose = Mathf.Sin(Mathf.Deg2Rad * angulitos.x * 0.5f);
        angulocos = Mathf.Cos(Mathf.Deg2Rad * angulitos.x * 0.5f);
        qx.Set(angulose, 0, 0, angulocos);

        angulose = Mathf.Sin(Mathf.Deg2Rad * angulitos.y * 0.5f);
        angulocos = Mathf.Cos(Mathf.Deg2Rad * angulitos.y * 0.5f);
        qy.Set(0, angulose, 0, angulocos);

        angulose = Mathf.Sin(Mathf.Deg2Rad * angulitos.z * 0.5f);
        angulocos = Mathf.Cos(Mathf.Deg2Rad * angulitos.z * 0.5f);
        qz.Set(0, 0, angulose, angulocos);

        r = qy * qx * qz;
        transform.rotation = r;

        rig.velocity = new Vector3(y * 5, z * 5, rig.velocity.y*0.0000001f) ;


    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        z = context.ReadValue<Vector3>().y;

        y = context.ReadValue<Vector3>().x;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "man")
        {
            vida=vida-1;
         
        }
        if (other.tag == "ban")
        {
            vida = vida - 1;
       
        }
        if (other.tag == "gas")
        {
            vida = vida - 1;
         
        }
        if (other.tag == "basu")
        {
            vida = vida - 1;
         
        }
    }
    public int vidita()
    {
        return vida;
    }

}
