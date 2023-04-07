using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAndRespawn : MonoBehaviour
{
    //Scripts
    public GenerateBackground genBack;
    public GenerateGround genGround;

    // Start is called before the first frame update
    void Awake()
    {
        //Get spawner scripts
        genBack = FindObjectOfType<GenerateBackground>();
        genGround = FindObjectOfType<GenerateGround>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When destroyed, spawn in a new one
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            if (this.CompareTag("Ground"))
            {
                genGround.GenerateTile();
            }
            if (this.CompareTag("Background"))
            {
                genBack.GenerateBG();
            }
            Destroy(gameObject, 5f);
        }
    }
}
