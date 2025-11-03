using UnityEngine;

public class Sine1 : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.position;
        float sin = Mathf.Sin(Time.time);
        
        move.y = sin * 3;
        transform.position = move;
    }
}
