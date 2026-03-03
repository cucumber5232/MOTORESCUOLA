using UnityEngine;

public class SoundDecay : MonoBehaviour
{
    float time;

    public GameObject This;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        if(time >= 0.5f)
        {
            time = 0;
            This.SetActive(false);
        }

    }
}
