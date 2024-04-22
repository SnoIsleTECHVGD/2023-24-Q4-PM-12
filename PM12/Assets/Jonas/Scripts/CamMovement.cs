using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject characterLocation;
    public Vector2 maxDistance;

    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        Vector2 distanceFromCharacter = transform.position - characterLocation.transform.position;
        if (distanceFromCharacter.x > maxDistance.x) transform.position = new Vector3(transform.position.x - (distanceFromCharacter.x - maxDistance.x), transform.position.y, transform.position.z);
        if (distanceFromCharacter.x < -maxDistance.x) transform.position = new Vector3(transform.position.x - (distanceFromCharacter.x + maxDistance.x), transform.position.y, transform.position.z);
        if (distanceFromCharacter.y > maxDistance.y) transform.position = new Vector3(transform.position.x, transform.position.y - (distanceFromCharacter.y - maxDistance.y), transform.position.z);
        if (distanceFromCharacter.y < -maxDistance.y) transform.position = new Vector3(transform.position.x, transform.position.y - (distanceFromCharacter.y + maxDistance.y), transform.position.z);
    }
}

