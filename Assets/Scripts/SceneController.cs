using UnityEngine;
using UnityEngine.SceneManagement; // Fondamentale per gestire le scene

public class SceneController : MonoBehaviour
{
    public void ResetScene()
{
    // Ottiene l'indice della scena attualmente attiva
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    // Ricarica la scena usando il suo indice
    SceneManager.LoadScene(currentSceneIndex);
}

}
