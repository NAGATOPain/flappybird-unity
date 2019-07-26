using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEventHandle : MonoBehaviour
{

    GameObject bird;

    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            // Bird flies
            bird.GetComponent<BirdMovements>().Fly();
        }
    }
}
