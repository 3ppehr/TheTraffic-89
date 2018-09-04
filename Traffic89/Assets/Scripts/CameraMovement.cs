using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;
    Vector3 lastPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed * (Mathf.Sqrt(transform.position.y / 100) + 1));
        Vector3 velocity = (this.transform.position - lastPos);

    }
}
