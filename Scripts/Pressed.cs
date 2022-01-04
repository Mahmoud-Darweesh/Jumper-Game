using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pressed : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public static bool Press;
    bool down;
    // Start is called before the first frame update
    void Start()
    {
        down = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (down == false)
        {
            Press = true;
            down = true;
            
        }
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Press = false;
        down = false;
    }
}
