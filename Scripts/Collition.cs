using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collition : MonoBehaviour
{
    public GameObject Player;
    public Animator Animator;
    public AudioClip collected;
    public AudioClip died;
    public AudioClip hit;
    public AudioClip win;
    public AudioSource AudioSource;
    public static bool done = false;
    public static float startpostionx = 0f;
    public static float startpositiony = 0f;
    float startangle = 0f;
    string level;
    
    
    private void Start()
    {
        startpostionx = Player.transform.position.x;
        startpositiony = Player.transform.position.y;
        startangle = Player.transform.rotation.z;
    }

    

    private void Update()
    {
        if (!(Animator.GetBool("IsDIed")) && done)
        {
            if (Animator.GetCurrentAnimatorStateInfo(0).IsTag("2"))
            {
                Player.transform.position = new Vector3(startpostionx, startpositiony, 0f);
                Player.transform.rotation = new Quaternion(0,0,0,0);
                done = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Water")
        {
            //Animator.SetBool("IsDIed", true);
            //done = true;
            //blinck then die

            Animator.SetBool("IsDIed", true);
            if (!(Animator.GetCurrentAnimatorStateInfo(0).IsTag("1")))
            {
                Player.transform.position = new Vector3(startpostionx, startpositiony, 0f);
            }
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
            Animator.SetBool("IsDIed", true);
            if (!(Animator.GetCurrentAnimatorStateInfo(0).IsTag("1")))
            {
              Player.transform.position = new Vector3(startpostionx, startpositiony, 0f);
            }
            //to die then blink
            done = true;
            AudioSource.clip = died;
            AudioSource.Play();

        }
        else if (collision.gameObject.tag == "cheackpoint")
        {
            startpostionx = collision.gameObject.transform.localPosition.x;
            startpositiony = collision.gameObject.transform.localPosition.y;

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
