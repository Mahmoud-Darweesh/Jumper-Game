using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye_Movement : MonoBehaviour
{
    [Range(0, 1f)] [SerializeField] private float SpeedLeft = 0.2f;
    [Range(0, 1f)] [SerializeField] private float SpeedRight = 0.5f;
    public GameObject Enemy;
    [SerializeField] private Transform left;
    [SerializeField] private Transform right;
    [SerializeField] private GameObject up;
    bool Left = false;


    // Start is called before the first frame update
    void Start()
    {
        Left = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Left == false)
        {
            transform.localPosition = new Vector3((transform.localPosition.x - SpeedLeft), transform.localPosition.y);
            if (Enemy.transform.position.x <= left.position.x)
            {
                Left = true;
            }
        }

        if (Left == true)
        {
            transform.localPosition = new Vector3((transform.localPosition.x + SpeedRight), transform.localPosition.y);
            if (Enemy.transform.position.x >= right.position.x)
            {
                Left = false;
                
               
            }
            
        }


    }
}
