using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class gamemanager : MonoBehaviour
{
    public TextMeshProUGUI puntos,vida;
    public float puntitos,texvida;
    public helicontrol dd;
    // Start is called before the first frame update
    void Start()
    {
        vida.text = "Vida:3";
        puntos.text = "Puntaje:0";
    }

    // Update is called once per frame
    void Update()
    {
        puntitos = puntitos + Time.deltaTime;
        puntos.text = "Puntaje:" + puntitos.ToString("F0");

        texvida= dd.vidita();
        vida.text = "Vida:" + texvida;

        if (texvida <= 0)
        {
            SceneManager.LoadScene("perder");
        }
    }
   
   

}
