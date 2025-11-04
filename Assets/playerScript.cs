using TMPro;
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
    public GameObject DotText;
    
    private float playerDotEnemyDir;
    // Update is called once per frame
    void Update()
    {
        enemyDir = (enemy.transform.position - transform.position).normalized;

        
        

        
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Pos.z++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Pos.z--;
        }
        transform.position = Pos;
        playerDotEnemyDir = Vector3.Dot(transform.forward, enemyDir);
        DotText.GetComponent<TextMeshProUGUI>().text = $"Dot: {playerDotEnemyDir}";
    }
}
