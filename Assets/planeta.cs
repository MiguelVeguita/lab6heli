using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class planeta : MonoBehaviour
{
    [SerializeField] private float angulo;
    [SerializeField] private Quaternion a = Quaternion.identity;

    private float anguloseno;
    private float angulocos;
    void Start()
    {
        Debug.Log(Mathf.Sin(90));
    }

    // Update is called once per frame
    void Update()
    {

        angulo = angulo + -(Time.deltaTime*15);
    }
    private void FixedUpdate()
    {
        anguloseno = Mathf.Sin(Mathf.Deg2Rad * angulo * 0.5f);
        angulocos= Mathf.Cos(Mathf.Deg2Rad * angulo * 0.5f);
        a.Set(anguloseno, 0, 0, angulocos);

        transform.rotation=a;
    }
}
