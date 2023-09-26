using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public float MovementSpeedPersecond = 10f;
    void Update()
    {
         
        if (Input.GetKey(KeyCode.W)) // Up
        {
            Vector3 characterPosition = transform.position;
            characterPosition.y += MovementSpeedPersecond * Time.deltaTime;
            transform.position = characterPosition;
        }
        if (Input.GetKey(KeyCode.S)) // Down
        {
            Vector3 characterPosition = transform.position;
            characterPosition.y -= MovementSpeedPersecond * Time.deltaTime;
            transform.position = characterPosition;
        }
        if (Input.GetKey(KeyCode.A)) // Left
        {
            Vector3 characterPosition = transform.position;
            characterPosition.x -= MovementSpeedPersecond * Time.deltaTime;
            transform.position = characterPosition;
        }
        if (Input.GetKey(KeyCode.D)) // Right
        {
            Vector3 characterPosition = transform.position;
            characterPosition.x += MovementSpeedPersecond * Time.deltaTime;
            transform.position = characterPosition;
        }
    }
}
