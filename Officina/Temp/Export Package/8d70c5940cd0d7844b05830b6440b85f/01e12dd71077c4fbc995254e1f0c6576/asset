using UnityEngine;

public class ExplodedEffect : MonoBehaviour
{
    // Salva la scala iniziale dei figli per sicurezza
    private Vector3 initialChildScale;

    void Start()
    {
        // Assumiamo che tutti i cubi siano uguali all'inizio. 
        // Se hai cubi di dimensioni diverse, la logica va leggermente adattata.
        if (transform.childCount > 0)
        {
            initialChildScale = transform.GetChild(0).localScale;
        }
    }

    void Update()
    {
        // Calcola la scala inversa. Se il padre è grande 2x, i figli devono essere 0.5x
        float inverseScale = 1.0f / transform.localScale.x;

        // Applica questa scala a tutti i figli
        foreach (Transform child in transform)
        {
            // Mantiene la dimensione visiva originale indipendentemente dalla scala del padre
            child.localScale = initialChildScale * inverseScale;
        }
    }
}