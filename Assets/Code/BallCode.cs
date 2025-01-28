using UnityEngine;
using TMPro;
public class BallCode : MonoBehaviour
{

    int score = 0;
    public TextMeshProUGUI scoreText;
    private Vector3 originalScale;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(200, -200));
        
        scoreText.text = "Score: 0";
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Brick")){
            Destroy(other.gameObject);
            score += 10;
            scoreText.text = "Score: " + score;
        }
        if(other.gameObject.CompareTag("Brick 2.0")){
            Destroy(other.gameObject);
            score += 20;
            scoreText.text = "Score: " + score;
        }
        if(other.gameObject.CompareTag("Bottom")){
            score -= 15;
            scoreText.text = "Score: " + score;
            transform.localScale = originalScale * 0.7f;
        }

    }
    
}
