using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject _camera;
    private const float CameraRotationSpeed = 100; //Degrees per Second
    private const float MovementSpeed = 3; //Units per Seconds
    // Start is called before the first frame update
    void Start()
    {
        Vector2 position = transform.position;
        Debug.Log($"Start Position: {position}");
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
        ProcessCamera();

    }
    private void ProcessMovement()
    {  Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
            movement += Vector2.up;

        if (Input.GetKey(KeyCode.S))
            movement += Vector2.down;

        if (Input.GetKey(KeyCode.D))
            movement += Vector2.right;

        if (Input.GetKey(KeyCode.A))
            movement += Vector2.left;
        movement = movement.normalized;

        if (Input.GetKey(KeyCode.LeftControl))
            movement *= 2;


        movement *= MovementSpeed * Time.deltaTime;
        movement = movement.Rotate(_camera.transform.rotation.eulerAngles.z);

        Vector2 position = transform.position;
        position += movement;
        transform.position = position;
    }
    private void ProcessCamera()
    {
        float rotation = 0;
        if (Input.GetKey(KeyCode.Q))
        rotation +=1;
        if (Input.GetKey(KeyCode.E))
            rotation -= 1;

        rotation *= CameraRotationSpeed * Time.deltaTime;
        rotation += _camera.transform.rotation.eulerAngles.z;
        _camera.transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
}
