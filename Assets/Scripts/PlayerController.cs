using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // for encapsulation. Public means that other scripts can modify the variable
    // Serialized and private means it can be modified in the inspector, but is only used in the script
    [SerializeField]
    private float vehicleSpeed;

    [SerializeField]
    private float turnSpeed;

    [SerializeField]
    private float horizontalInput;
    [SerializeField]
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * turnSpeed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * verticalInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);    
    }
}
