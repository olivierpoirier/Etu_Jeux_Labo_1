using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    private bool isVehicleIgnited = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void IsGoingForward() {
        if (Input.GetKeyDown(KeyCode.W)) {
            isVehicleIgnited = true;
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            isVehicleIgnited = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        IsGoingForward();
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Makes the vehicle stop doing everything if one key is pressed
        if(isVehicleIgnited){
            //Moves the vehicle forward based on vertical input
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            
            //Moves the vehicle based on horizontal input
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }

    }
}
