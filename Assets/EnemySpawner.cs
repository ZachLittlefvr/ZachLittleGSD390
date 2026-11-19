using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform player;
    public Rigidbody rb;

    //Static used for the enemyPos to create a global enemyDamage
    public static float enemyDamage;
    //Use serialized field for easy editing of enemy speed
    [SerializeField]
    private float enemySpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Generic for getting the rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = player.position - transform.position;
        dir = dir.normalized;
        rb.AddForce(dir * enemySpeed);

    }
}
