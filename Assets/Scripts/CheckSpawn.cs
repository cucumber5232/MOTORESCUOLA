using UnityEngine;

public class CheckSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] activeTorches = new GameObject[17];

    public GameObject Corretto;


    // Update is called once per frame
    void Update()
    {
        if (AllActive())
        {
            // Tutti e 6 gli oggetti sono attivi; eseguire l'azione desiderata qui.
            Debug.Log("Tutti e 6 gli oggetti sono attivi.");

            Corretto.SetActive(true);
        }
    }

    // Restituisce true solo se l'array contiene esattamente 6 elementi
    // e tutti i GameObject sono non-null e attivi nella gerarchia.
    public bool AllActive()
    {
        if (activeTorches == null || activeTorches.Length != 17)
            return false;

        for (int i = 0; i < activeTorches.Length; i++)
        {
            GameObject go = activeTorches[i];
            if (go == null || !go.activeInHierarchy)
                return false;
        }

        return true;
    }
}
