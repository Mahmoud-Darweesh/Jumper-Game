using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemovment : MonoBehaviour
{
    

    float startpostionx = 0f;
    float startpositiony = 0f;
    [Range(-50, 50f)] [SerializeField] private float Speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        startpostionx = transform.position.x;
        startpositiony = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //if (planecollition.done)
       // {
            
       //         transform.position = new Vector3(startpostionx, startpositiony, 0f);
                
                
            
       // }
    }

    private void FixedUpdate()
    {
        transform.localPosition = new Vector3((transform.localPosition.x + Speed), (transform.localPosition.y));

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.position = new Vector3(startpostionx, startpositiony, 0f);

        }
    }
}
