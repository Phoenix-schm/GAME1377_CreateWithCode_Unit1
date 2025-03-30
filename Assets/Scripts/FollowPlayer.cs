using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = cameraOffset.position;
    }
}
