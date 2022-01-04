using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{

    public GameObject Player;
    public Collider2D collider;
    public GameObject up;
    public GameObject land;
    [Range(0, 1f)] [SerializeField] private float SpeedUp = 0.2f;
    bool notup = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (notup == false)
        {
            Player.transform.position = new Vector3(Player.transform.position.x, (Player.transform.position.y + SpeedUp));
            //Player.transform.position = new Vector3(Player.transform.position.x, (up.transform.position.y));


            if (Player.transform.position.y >= up.transform.position.y)
            {
                notup = true;
                Player.transform.position = new Vector3(Player.transform.position.x, (land.transform.position.y));
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Player.transform.position.y > collider.transform.position.y && notup == true)
            {

            }
            else
            {
                
                notup = false;
                
            }
        }
    }
}
