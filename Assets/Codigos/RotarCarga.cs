using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarCarga : MonoBehaviour
{

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
    }
}
