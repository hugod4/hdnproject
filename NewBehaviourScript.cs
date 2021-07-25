using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//codigo de interação com o mouse
public class Botao : MonoBehaviour
{
    bool mouseDentroDoObjeto;
    public string nomeDaCena = "cena";

    void Start()
    {
        mouseDentroDoObjeto = false;
    }

    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(nomeDaCena);
            }
        }
    }

    void OnMouseEnter()
    {
        mouseDentroDoObjeto = true;
    }

    void OnMouseExit()
    {
        mouseDentroDoObjeto = false;
    }
}
