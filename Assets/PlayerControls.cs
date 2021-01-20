using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
	public Vector2 speed = new Vector2();
	
	public Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);

         if(Input.GetKeyDown(KeyCode.Mouse0))
           {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
 
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
    }
}
