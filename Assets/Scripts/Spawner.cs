using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    public float minSpeed;
    public float maxSpeed;
    public float currentSpeed;
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = minSpeed;
        GenerateObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed += Time.deltaTime * 0.1f;
    }
    public void GenerateObstacle()
    {
        GameObject obIns = Instantiate(obstacle, transform.position, transform.rotation);
        obIns.GetComponent<Rigidbody2D>().velocity = Vector2.left * currentSpeed;
        obIns.GetComponent<Obstacle>().spawner = this;
    }    
}
