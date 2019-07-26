using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveLeft : MonoBehaviour
{

    public GameObject objBackground;
    public float resetDistance;

    private GameObject obj;
    private float objSpeed;

    private Camera cam;
    private float camWidth, camHeight;

    private Vector3 deltaVector;

    // Start is called before the first frame update

    void Start()
    {
        obj = gameObject;
        obj.transform.Translate(0, Random.Range(-1.7f, 3.5f), 0);

        objSpeed = objBackground.GetComponent<BackgroundMoveToLeft>().objSpeed;

        cam = Camera.main;
        camHeight = cam.orthographicSize * 2.0f;
        camWidth = camHeight * cam.aspect;

        deltaVector = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(-1 * objSpeed * Time.deltaTime, 0, 0);
        if (obj.transform.position.x < cam.transform.position.x - (1.0f + resetDistance) * camWidth * 0.5f)
        {
            // Reset pipe
            obj.transform.position = Vector3.Scale(obj.transform.position, deltaVector);
            obj.transform.Translate(camWidth * (1.0f + resetDistance * 2), Random.Range(-1.7f, 3.5f), 0);
        }
    }
    
}
