using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LOGINMANAGER : MonoBehaviour
{
    //Cuando el usuario presione el boton BtnAceptar
    //Debe escribirse un mensaje en la consola
    //Si el texto del InputPassword coincide
    //con una contraseña predefinida por ustedes
    //escribir "Access Granted"
    //Sino, escribir "Access Denied"
    // Start is called before the first frame update

    public Text HolderContraseña;
    public string contraseña;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    public void login ()
    {
        if (HolderContraseña.text==contraseña)
        {
            Debug.Log("Access Granted");
        }       
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
