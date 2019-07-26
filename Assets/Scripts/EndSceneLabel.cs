using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneLabel : MonoBehaviour
{

    public Text textScore;

    // Start is called before the first frame update
    void Start()
    {
        textScore.text = "Score: " + PlayerPrefs.GetInt("score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
