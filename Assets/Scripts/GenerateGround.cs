using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGround : MonoBehaviour
{
    //Prefabs
    public GameObject groundTile1;
    public GameObject groundTile2;
    public GameObject groundTile3;
    public GameObject groundTile4;
    public GameObject groundTile5;
    public GameObject groundTile6;
    public GameObject groundTile7;
    public GameObject groundTile8;
    public GameObject groundTile9;
    public GameObject groundTile10;
    public GameObject spikeTile1;
    public GameObject spikeTile2;
    public GameObject spikeTile3;
    
    public Transform spawnPoint;

    public int spikeTimer;
    public int frequency;
    void Start()
    {
        //Create initial ground tiles
        for (int i = 0; i < 20; i++)
        {
            GenerateTile();
        }
        spikeTimer = frequency;
    }
    public void GenerateTile()
    {
        if (spikeTimer > 0)
        {
            //Spawn a ground tile
            int temp;
            temp = Random.Range(1, 11);
            switch (temp)
            {//Random ground tile
                case 1:
                    GameObject instance1 = Instantiate(groundTile1, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance1.transform.GetChild(0).transform;
                    break;
                case 2:
                    GameObject instance2 = Instantiate(groundTile2, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance2.transform.GetChild(0).transform;
                    break;
                case 3:
                    GameObject instance3 = Instantiate(groundTile3, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance3.transform.GetChild(0).transform;
                    break;
                case 4:
                    GameObject instance4 = Instantiate(groundTile4, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance4.transform.GetChild(0).transform;
                    break;
                case 5:
                    GameObject instance5 = Instantiate(groundTile5, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance5.transform.GetChild(0).transform;
                    break;
                case 6:
                    GameObject instance6 = Instantiate(groundTile6, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance6.transform.GetChild(0).transform;
                    break;
                case 7:
                    GameObject instance7 = Instantiate(groundTile7, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance7.transform.GetChild(0).transform;
                    break;
                case 8:
                    GameObject instance8 = Instantiate(groundTile8, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance8.transform.GetChild(0).transform;
                    break;
                case 9:
                    GameObject instance9 = Instantiate(groundTile9, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance9.transform.GetChild(0).transform;
                    break;
                case 10:
                    GameObject instance10 = Instantiate(groundTile10, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance10.transform.GetChild(0).transform;
                    break;
            }
            spikeTimer--;
        }
        else if (spikeTimer == 0)
        {
            //Spawn a spike tile instead
            int temp;
            temp = Random.Range(1,4);
            switch(temp)
            {//Random length of spikes
                case 1:
                    GameObject instance1 = Instantiate(spikeTile1, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance1.transform.GetChild(0).transform;
                    spikeTimer = frequency;
                    break;
                case 2:
                    GameObject instance2 = Instantiate(spikeTile2, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance2.transform.GetChild(0).transform;
                    spikeTimer = frequency;
                    break;
                case 3:
                    GameObject instance3 = Instantiate(spikeTile3, spawnPoint.position, Quaternion.identity);
                    spawnPoint = instance3.transform.GetChild(0).transform;
                    spikeTimer = frequency;
                    break;
            }
        }
    }
}
