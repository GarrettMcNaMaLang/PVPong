using UnityEngine;
[RequireComponent(typeof(Camera))]
public class PlayerScript : MonoBehaviour
{

    public GameObject ballPrefab;
    Camera playerCamera;
    
    public GameObject ballHoldPosition;

    public GameObject ballSpawner;

    public void Awake()
    {
        playerCamera = GetComponent<Camera>();

        ballHoldPosition.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
