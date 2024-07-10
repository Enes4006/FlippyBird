using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 12); // game objeleri 12 saniye sonra yok eder
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }
}
