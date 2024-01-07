using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButonYap : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject button;

    void Start()
    {
        button = this.gameObject;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            
            Ray ray = Camera.main.ScreenPointToRay(touch.position);

            
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                
                if (touch.phase == TouchPhase.Began && hit.collider.gameObject == gameObject)
                {
                    unityEvent.Invoke();
                }
            }
        }
    }
}
