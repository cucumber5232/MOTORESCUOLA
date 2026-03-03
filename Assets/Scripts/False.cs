using UnityEngine;

public class False : MonoBehaviour
{
    string pezzo1;
     
    public GameObject pezzoBuono;

    public GameObject Suono;
    public GameObject Metal;



    void Start()
    {
        pezzo1 = gameObject.tag;
        
    }
    void OnTriggerEnter(Collider other)
    {
        
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null && !rb.isKinematic)
            {
                if (other.gameObject.tag == pezzo1)
                {
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    Guessed();
                }
                else
                {
                    HandleTouch(other.gameObject);
                Suono.SetActive(true);

            }
            Debug.Log($"{other.name} ha isKinematic disattivato.");
            }
        
        
            
    }
    private void HandleTouch(GameObject touched)
    {
        var respawnComp = touched.GetComponent<Respawn>();
       
        Vector3 initialPos = respawnComp.initialPosition;
        Quaternion initialRot = respawnComp.initialRotation;
        touched.transform.position = initialPos;
        touched.transform.rotation = initialRot;
    }
    void Guessed()
    {
        pezzoBuono.SetActive(true);
        Metal.SetActive(true);
    }

}
