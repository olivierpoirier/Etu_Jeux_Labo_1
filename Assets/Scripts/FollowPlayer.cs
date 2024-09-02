using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0,5,-7);


    // Start is called before the first frame update
    void Start()
    {
        
    }



    void LateUpdate()
    {
        //Makes the camera follow the player with a offset
        transform.position = player.transform.position + offset;
    }
}
