using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMoveLeft : MonoBehaviour
{

    public GameObject backgroundObj;

    private float objSpeed;
    private float moveRange;

    private Vector3 originPosition;
    private GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        originPosition = obj.transform.position;
        moveRange = backgroundObj.GetComponent<BackgroundMoveToLeft>().moveRange;
        objSpeed = backgroundObj.GetComponent<BackgroundMoveToLeft>().objSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(-1 * objSpeed * Time.deltaTime, 0, 0);
        if (Vector3.Distance(obj.transform.position, originPosition) > moveRange)
        {
            obj.transform.position = originPosition;
        }
    }
}
