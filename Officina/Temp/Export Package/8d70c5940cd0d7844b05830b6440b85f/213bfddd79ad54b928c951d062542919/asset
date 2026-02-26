using UnityEngine;
using Oculus.Interaction; // Fondamentale

public class SlotQuiz : MonoBehaviour
{
    public string IDRichiesto;
    public Transform puntoDiAggancio;
    private bool oggettoPosizionato = false;

    private void OnTriggerStay(Collider other)
    {
        if (oggettoPosizionato) return;

        OggettoQuiz oggetto = other.GetComponentInParent<OggettoQuiz>();

        if (oggetto != null && oggetto.IDOggetto == IDRichiesto)
        {
            Grabbable grabbable = other.GetComponentInParent<Grabbable>();

            if (grabbable != null)
            {
                // MODIFICA QUI:
                // Se SelectingPointsCount è 0, significa che nessuno lo sta afferrando
                if (grabbable.SelectingPointsCount == 0)
                {
                    BloccaOggetto(oggetto.gameObject, grabbable);
                }
            }
        }
    }

    void BloccaOggetto(GameObject obj, Grabbable grabbable)
    {
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        if (rb != null) rb.isKinematic = true;

        // Disabilita il Grabbable per evitare che venga ripreso (opzionale)
        grabbable.enabled = false; 

        obj.transform.position = puntoDiAggancio.position;
        obj.transform.rotation = puntoDiAggancio.rotation;

        oggettoPosizionato = true;
        Debug.Log("Risposta Corretta!");
    }
}