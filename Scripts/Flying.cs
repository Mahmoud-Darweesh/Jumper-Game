using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Flying : MonoBehaviour
{

    public Joystick joystick;
    public GameObject Player;
    //public Camera vcam;


    
    [Range(0, 1f)] [SerializeField] private float Speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
       
        var camera = Camera.main;
        var brain = (camera == null) ? null : camera.GetComponent<CinemachineBrain>();
        var vcam = (brain == null) ? null : brain.ActiveVirtualCamera as CinemachineVirtualCamera;
        //transform.localPosition = new Vector3((transform.localPosition.x + Speed*joystick.Horizontal), (transform.localPosition.y + Speed * joystick.Vertical));

        
        if (Input.GetAxisRaw("Horizontal") * Speed == 0 && Input.GetAxisRaw("Vertical") * Speed == 0)
        {
            transform.localPosition = new Vector3((transform.localPosition.x + Speed*(joystick.Horizontal)), (transform.localPosition.y + Speed * (joystick.Vertical)));
        }
        else if (joystick.Horizontal * Speed == 0 && joystick.Vertical * Speed == 0)
        {
            transform.localPosition = new Vector3((transform.localPosition.x + Speed*Input.GetAxisRaw("Horizontal")), (transform.localPosition.y + Speed * Input.GetAxisRaw("Vertical")));
        }

        if (Input.GetKey(KeyCode.Space) || Pressed.Press == true || Input.GetKey(KeyCode.JoystickButton0))
        {
            vcam.m_Lens.OrthographicSize = 10;
        }
        //if (Input.GetKey(KeyCode.Space) || Pressed.Press == false || Input.GetKey(KeyCode.JoystickButton0))
        else
        {
            vcam.m_Lens.OrthographicSize = 5;
            
        }
    }
}
