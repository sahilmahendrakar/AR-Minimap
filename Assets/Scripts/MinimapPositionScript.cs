using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapPositionScript : MonoBehaviour
{

    public Camera camera;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.transform.position + offset;
    }
}
