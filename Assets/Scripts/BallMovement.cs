using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    
    private Rigidbody r;
    public Text scoreText;
    public Text winText; 
    private int score;

    void Start()
    {
        r = GetComponent<Rigidbody>();
        score = 0;
        SetScore(score);
    }

  void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        r.AddForce(movement * 10);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Capsule"))
        {
            other.gameObject.SetActive(false);
            score = score + 2;
            SetScore(score);
        }

        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            score = score + 5;
            SetScore(score);
        }

        if(score == 28)
        {
            winText.text = "You win";
            Invoke("Restart", 2f);
        }
    }

    void SetScore (int s)
    {
        scoreText.text = "Score: " + s.ToString();
    }

    void Restart()
    {
        SceneManager.LoadScene("Game");
    }

}
