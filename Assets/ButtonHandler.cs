using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Aqu� puedes colocar cualquier l�gica que desees que ocurra cuando se presione el bot�n
        SceneManager.LoadScene("Untitled"); // Cambia "GameScene" por el nombre de tu escena
    }
}

