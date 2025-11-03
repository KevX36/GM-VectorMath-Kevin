using UnityEngine;

public class ScalarPosition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        startPos = transform.position;
        transform.position = new Vector3(0, 0, 0);
    }
    public float step;
    private float scalar = 1;
    Vector3 startPos;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            scalar += step;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            scalar -= step;
        }
        transform.position = (startPos * scalar);
    }
}
