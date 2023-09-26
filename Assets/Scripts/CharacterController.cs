using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public float GravityPerSecond = 160.0f;
    public float GroundLevel = 0.0f;
    public float MovementSpeedPersecond = 10.0f;
    void Update()
    {


        //gravity
        Vector3 gravityPosition = transform.position;
        gravityPosition.y -= MovementSpeedPersecond * Time.deltaTime;
        if(gravityPosition.y < GroundLevel) { gravityPosition.y = GroundLevel; }
        transform.position = gravityPosition;

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
