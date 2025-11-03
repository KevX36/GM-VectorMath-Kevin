using UnityEngine;

public class Sine1 : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public int axis = 1;
    // Update is called once per frame
    void Update()
    {
        if (axis == 1)
        {
            Vector3 move = transform.position;
            float sin = Mathf.Sin(Time.time);

            move.y = sin * 3;
            transform.position = move;
        }
        if (axis == 2)
        {
            Vector3 move = transform.position;
            float sin = Mathf.Sin(Time.time);

            move.x = sin * 3;
            transform.position = move;
        }
        
    }
}
