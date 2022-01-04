using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changer : MonoBehaviour
{

    public GameObject plane;
    public GameObject character;
    public GameObject cam;
    public GameObject delete;
    //public GameObject enable;
    [Range(0, 10f)] [SerializeField] private float Distance = 5f;
    public bool spawnLeft = false;
    public bool GoBack_have_a_working_Changer = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

       
        //enable.SetActive(true);
        delete.SetActive(false);

        if (collision.tag == "Player")
        {
            if (plane.active)
            {
                plane.SetActive(false);

                if (spawnLeft == true)
                {
                    character.transform.position = new Vector3(transform.position.x - Distance, transform.position.y, 0f);
                    Collition.startpostionx = transform.position.x - Distance;
                    Collition.startpositiony = transform.position.y;
                }
                else if (spawnLeft == false)
                {
                    character.transform.position = new Vector3(transform.position.x + Distance, transform.position.y, 0f);
                    Collition.startpostionx = transform.position.x + Distance;
                    Collition.startpositiony = transform.position.y;
                }
                character.SetActive(true);
                cam.SetActive(true);
            }
            else if (character.active)
            {
                character.SetActive(false);
                cam.SetActive(false);
                if (spawnLeft == true)
                {
                    plane.transform.position = new Vector3(transform.position.x - Distance, transform.position.y, 0f);
                    planecollition.startpostionx = transform.position.x - Distance;
                    planecollition.startpositiony = transform.position.y;
                }
                else if (spawnLeft == false)
                {
                    plane.transform.position = new Vector3(transform.position.x + Distance, transform.position.y, 0f);
                    planecollition.startpostionx = transform.position.x + Distance;
                    planecollition.startpositiony = transform.position.y;
                }
                plane.SetActive(true);
            }
        }
        if (GoBack_have_a_working_Changer == false)
        {
            Destroy(gameObject.GetComponent<changer>());
            Destroy(gameObject.GetComponent<SpriteRenderer>());
            Destroy(gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
