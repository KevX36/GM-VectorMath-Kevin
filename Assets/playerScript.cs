using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class playerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Pos = transform.position;
        forward.transform.position = Pos + Vector3.forward;
        
    }
    Vector3 Pos;
    public GameObject forward;
    public GameObject enemy;
    Vector3 enemyDir;
    public float playerDotEnemyDir;
    // Update is called once per frame
    void Update()
    {
        playerDotEnemyDir = 0;
        enemyDir = enemy.transform.position;
        if (Input.GetKeyDown(KeyCode.W))
        {
            Pos.z++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Pos.z--;
        }
        transform.position = Pos;
    }
}
