using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBackground : MonoBehaviour
{
    //Prefabs
    public GameObject background;

    public Transform spawnPoint;
    void Start()
    {
        //Spawn initial backgrounds
        for (int i = 0; i < 2; i++)
        {
            GenerateBG();
        }
    }
    public void GenerateBG()
    {
        //Generate background tiles
        GameObject instance = Instantiate(background, spawnPoint.position, Quaternion.identity);
        spawnPoint = instance.transform.GetChild(0).transform;
    }
}
