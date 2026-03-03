using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 initialPosition;
    public Quaternion initialRotation;

    // Awake è chiamato prima di Start: cattura la posizione iniziale al runtime
    void Awake()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    
}
