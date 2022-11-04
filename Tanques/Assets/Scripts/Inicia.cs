using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inicia : MonoBehaviour
{
    public GameObject Bienvenido,Juego;
    public Button BtnInicia;


    // Start is called before the first frame update
    void Start()
    {
 
        BtnInicia.onClick.AddListener(()=>iniciar());
    }

public void iniciar()
{
    Bienvenido.SetActive(false);
    Juego.SetActive(true);

 
}


}
