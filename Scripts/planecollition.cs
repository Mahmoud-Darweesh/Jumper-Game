using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class planecollition : MonoBehaviour
{

    public GameObject Player;
    public AudioClip collected;
    public AudioSource AudioSource;
    public AudioClip hit;
    public AudioClip win;
    public AudioClip died;
    public static float startpostionx = 0f;
    public static float startpositiony = 0f;
    float startangle = 0f;
    public static bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        startpostionx = Player.transform.position.x;
        startpositiony = Player.transform.position.y;
        startangle = Player.transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (done)
        {
            
                Player.transform.position = new Vector3(startpostionx, startpositiony, 0f);
                Player.transform.rotation = new Quaternion(0, 0, 0, 0);
                done = false;
            
        }
    }

    public void PlaneTNT()
    {
        Player.GetComponent<Rigidbody2D>().AddForce(new Vector2(-40, 0), ForceMode2D.Impulse);
        Invoke("slowdown",0.3f);
        

    }

    void slowdown()
    {
        Player.GetComponent<Rigidbody2D>().AddForce(new Vector2(40, 0), ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Water")
        {
            //Animator.SetBool("IsDIed", true);
            //done = true;
            //blinck then die

            
            
            Player.transform.position = new Vector3(startpostionx, startpositiony, 0f);
            
            //to die then blink
            done = true;

            AudioSource.clip = died;
            AudioSource.Play();

        }
        else if (collision.gameObject.tag == "Hit")
        {
            Destroy(collision.transform.parent.gameObject);
            Debug.Log("hittttttt");
            AudioSource.clip = hit;
            AudioSource.Play();
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            
            
            Player.transform.position = new Vector3(startpostionx, startpositiony, 0f);
            
            //to die then blink
            done = true;
            AudioSource.clip = died;
            AudioSource.Play();

        }
        else if (collision.gameObject.tag == "Token")
        {
            Destroy(collision.gameObject);
            AudioSource.clip = collected;
            AudioSource.Play();
            Debug.Log("collected");
        }
        else if (collision.gameObject.tag == "Chest")
        {

            //SceneManager.LoadScene(Math.Abs(SceneManager.GetActiveScene().buildIndex - 1));
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            //AudioSource.clip = win;
            //DontDestroyOnLoad(AudioSource);
            //AudioSource.Play();

            if (PlayerPrefs.GetInt("levelR") <= SceneManager.GetActiveScene().buildIndex)
            {
                PlayerPrefs.SetInt("levelR", SceneManager.GetActiveScene().buildIndex + 1);
            }
            SceneManager.LoadScene("LevelSelect");
            Debug.Log("open");
        }
    }
}
