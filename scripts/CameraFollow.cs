using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    public float cameraDistance = 20f;
    // private Vector3 tempRot;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {}
    void LateUpdate() {
        transform.position = player.transform.position - player.transform.forward * cameraDistance;
        if(Input.GetAxis("Mouse ScrollWheel") != 0) {
            cameraDistance -= Input.GetAxis("Mouse ScrollWheel") * 5;
        }
        transform.LookAt(player.transform.position);
        transform.position = new Vector3 (transform.position.x, transform.position.y + 2, transform.position.z);
    }
}