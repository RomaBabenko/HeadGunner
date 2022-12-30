using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
     
    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
          Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
         transform.up = direction;
        }
    }
}

