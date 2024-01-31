using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    // Nombre de la escena a la que quieres cambiar
    public string nombreDeLaNuevaEscena;

    // Método que será llamado cuando se haga clic en el botón
    public void CambiarEscena()
    {
        // Verificar si el nombre de la escena no está vacío
        if (!string.IsNullOrEmpty(nombreDeLaNuevaEscena))
        {
            // Cambiar a la nueva escena
            SceneManager.LoadScene(nombreDeLaNuevaEscena);
        }
        else
        {
            Debug.LogError("El nombre de la nueva escena no está configurado.");
        }
    }
}
