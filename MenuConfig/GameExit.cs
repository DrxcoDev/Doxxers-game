using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Este método se llama cuando se presiona el botón
    public void SalirDelJuego()
    {
        // Salir del juego
        Application.Quit();

        // Esto es útil solo en el editor de Unity para detener la reproducción
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
