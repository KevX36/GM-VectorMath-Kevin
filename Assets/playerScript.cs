using UnityEngine;
using UnityEngine.Rendering;

public class playerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Pos = transform.position;
        forward.transform.position = Vector3.forward;
    }
    Vector3 Pos;
    public GameObject forward;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Pos.y++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Pos.y--;
        }
        transform.position = Pos;
    }
}
