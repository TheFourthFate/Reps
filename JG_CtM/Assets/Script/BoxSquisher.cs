using UnityEngine;

public class BoxSquisher : MonoBehaviour
{
    /*
     * Write a script and attach it to a box. 
     * When the player clicks (and holds!) on the box with the mouse, 
     * it should begin to scale down on the *y axis*. 
     * It should not go below 0 scale. When the player is 
     * not clicking on the box, it should return to a scale 
     * of 1 (but not go above it!).
    */

    private void Update()
    {
        // This if statement will be true EVERY frame we hold
        // down the mouse button.
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    // If the scale on the y axis 
                    // is greater than 0,
                    // we can continue to shrink.
                    if (transform.localScale.y > 0)
                    {
                        transform.localScale -= new Vector3(0, 1, 0) * Time.deltaTime;
                    }
                }
            }
        }
        else
        {
            if (transform.localScale.y < 1)
            {
                transform.localScale += new Vector3(0, 1, 0) * Time.deltaTime;
            }
        }
    }
}
