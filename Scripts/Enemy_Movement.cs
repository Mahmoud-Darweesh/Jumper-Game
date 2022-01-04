using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{

    [Range(0, 1f)] [SerializeField] private float SpeedUp = 0.2f;
    [Range(0, 1f)] [SerializeField] private float SpeedDown = 0.5f;
    public GameObject Enemy;
    [SerializeField] private Transform Up;
    [SerializeField] private Transform Down;
    bool up = false;
    //int shake = 0;
    //bool sDone = false;


    // Start is called before the first frame update
    void Start()
    {
        up = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (up == false)
        {
            transform.localPosition = new Vector3 (transform.localPosition.x, (transform.localPosition.y + SpeedUp));
            if (Enemy.transform.position.y >= Up.position.y)
            {
                up = true;
            }
        }

        if (up == true)
        {
            //if (sDone == false)
            //{
              //  switch (shake)
                //{
                  //  case (0):
                    //    transform.localPosition = new Vector3((transform.localPosition.x + 0.5f), transform.localPosition.y);
                      //  shake++;
                        //break;
                    //case (2):
                      //  transform.localPosition = new Vector3((transform.localPosition.x - 1f), transform.localPosition.y);
                        //shake++;
                        //break;
                    //case (4):
                      //  transform.localPosition = new Vector3((transform.localPosition.x + 0.5f), transform.localPosition.y);
                        //sDone = true;
                        //break;
                    //default:
                      //  shake++;
                        //break;
               // }
           // }
            

            //if (sDone == true)
            //{
                transform.localPosition = new Vector3(transform.localPosition.x, (transform.localPosition.y - SpeedDown));
                if (Enemy.transform.position.y <= Down.position.y)
                {
                    up = false;
              //      shake = 0;
                  //   sDone = false;
                }
            //}
        }
            
        
    }
}
