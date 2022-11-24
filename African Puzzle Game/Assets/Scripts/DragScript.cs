using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour
{
    private float startPositionX;
    private float startPositionY;
    private bool isBeingHeld = false;
    public Rigidbody2D  rigidBody;
    ScoreScript scoreScript;
    public GameManager gameManager;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (isBeingHeld == true)
        {
            Vector3 mousePosition;
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            this.gameObject.transform.localPosition = new Vector3(mousePosition.x - startPositionX, mousePosition.y - startPositionY, 0);            
        }        
    }
       

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition;
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            startPositionX = mousePosition.x - this.transform.localPosition.x;
            startPositionY = mousePosition.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
        
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;

        gameManager.PlayerScored(1);
    }

    


}
