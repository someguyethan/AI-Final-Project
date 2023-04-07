using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Camera cam;
    void Update()
    {
        cam.transform.position = new Vector3(player.transform.position.x,
                                             cam.transform.position.y,
                                             cam.transform.position.z);
    }
}
