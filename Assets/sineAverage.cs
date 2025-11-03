using UnityEngine;

public class sineAverage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject YCube;
    public GameObject XCube;
    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.position;
        Vector3 moveX = XCube.transform.position;
        Vector3 moveY = YCube.transform.position;
        move.x = moveX.x;
        move.y = moveY.y;
        transform.position = move;
    }
}
