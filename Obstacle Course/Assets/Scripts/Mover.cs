using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Cache

    // Variables
    [SerializeField] float playerSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValueRaw = Input.GetAxis("Horizontal");
        float xValue = xValueRaw * playerSpeed * Time.deltaTime;
        float zValueRaw = Input.GetAxis("Vertical");
        float zValue = zValueRaw * playerSpeed * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }
}
