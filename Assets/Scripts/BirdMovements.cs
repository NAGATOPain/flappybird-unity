using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdMovements : MonoBehaviour
{

    public float jumpForce;
    public Text textScore;

    public AudioSource scoreSound;
    public AudioSource hitSound;
    public AudioSource flySound;

    private GameObject obj;
    private Rigidbody2D rg;

    private Vector2 forceVector;
    private Vector2 zeroForce;
    
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        rg = obj.GetComponent<Rigidbody2D>();
        
        forceVector = new Vector2(0, jumpForce);
        zeroForce = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fly()
    {
        flySound.Play();
        rg.velocity = zeroForce;
        rg.AddForce(forceVector, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Game over
        hitSound.Play();
        PlayerPrefs.SetInt("score", int.Parse(textScore.text));
        SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        scoreSound.Play();
        textScore.text = (int.Parse(textScore.text) + 1).ToString();
    }
}
