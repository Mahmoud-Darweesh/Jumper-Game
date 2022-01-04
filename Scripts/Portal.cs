using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    public GameObject Player;
    public Sprite yellow;
    public SpriteRenderer SpriteRenderer;
    public GameObject This_Portal;
    public GameObject Linked_Portal;
    [Range(0, 10f)] [SerializeField] private float Distance = 5f;
    public bool spawnLeft = false;
    public bool GoBack_have_a_working_Portal = true;


    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GoBack_have_a_working_Portal == false)
        {
            SpriteRenderer.sprite = yellow;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && GoBack_have_a_working_Portal == true)
        {
            Teleport();
            Debug.Log("tele");
        }        
    }

    private void Teleport()
    {
        if (spawnLeft == true)
        {
            Player.transform.position = new Vector3(Linked_Portal.transform.position.x - Distance, Linked_Portal.transform.position.y, 0f);
        }
        else if (spawnLeft == false)
        {
            Player.transform.position = new Vector3(Linked_Portal.transform.position.x + Distance, Linked_Portal.transform.position.y, 0f);
        }
        
    }
}
