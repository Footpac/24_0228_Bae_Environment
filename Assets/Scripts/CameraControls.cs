using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    private Vector2 worldPos;
    public float mouseX;
    public float mouseY;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*while (Input.GetKeyDown(KeyCode.Q))
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y);
            Camera.main.transform.
        }*/
    }

    private void LateUpdate()
    {
        worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseY = worldPos.y;
        mouseX = worldPos.x;
        /*if (Mathf.Abs(worldPos.x) >= 7.5)
        {
            while (worldPos.x <= -7.5) 
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - speed, 0, -10);
                if world
            }
        } */
    }
}
