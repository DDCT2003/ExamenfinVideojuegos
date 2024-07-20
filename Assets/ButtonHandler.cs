using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Aquí puedes colocar cualquier lógica que desees que ocurra cuando se presione el botón
        SceneManager.LoadScene("Untitled"); // Cambia "GameScene" por el nombre de tu escena
    }
}

