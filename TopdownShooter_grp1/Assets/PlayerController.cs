using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    float speed = 0.05f;

    int hp = 3;

    public AsteroidGenerator ass;
    public Text gameOverText;
    public Button restartButton;

    public AudioClip explosionAudio;
    AudioSource speaker;

    public Image healthBar;

    // Use this for initialization
    void Start()
    {
        speaker = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        float yMovement = Input.GetAxisRaw("Vertical");

        Vector3 toMove = new Vector3(speed * xMovement, speed * yMovement);

        this.transform.Translate(toMove);

        if (this.transform.position.x > 3 || this.transform.position.x < -3)
        {
            this.transform.Translate(new Vector3(-speed * xMovement, 0));
        }

        if (this.transform.position.y > 5 || this.transform.position.y < -5)
        {
            this.transform.Translate(new Vector3(0, -speed * yMovement));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "asteroid")
        {

            Destroy(other.gameObject);
            speaker.PlayOneShot(explosionAudio);

            hp -= 1;
            
            healthBar.rectTransform.sizeDelta = new Vector3(100 * hp, 20);

            if (hp <= 0)
            {
                Debug.Log("GAME OVER MAN, GAME OVER");

                gameOverText.gameObject.SetActive(true);
                restartButton.gameObject.SetActive(true);

                ass.gameObject.SetActive(false);
                this.gameObject.SetActive(false);
            }

        }

    }

}
