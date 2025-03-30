using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField]
    private float vehicleSpeed;

    private float lifeTimer = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTimer);
        vehicleSpeed = Random.Range(20, 60);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
    }
}
