using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Camera))]
public class PlayerScript : MonoBehaviour
{

    public GameObject ballPrefab;
    Camera playerCamera;
    
    public GameObject ballHoldPosition;

    public GameObject ballSpawner;

    public Rigidbody rb;

    Vector2 movementVec;

    public float playerSpeed;

    public void Awake()
    {
        playerCamera = GetComponent<Camera>();

        rb = GetComponent<Rigidbody>();

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

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(movementVec.x * playerSpeed, 0f, movementVec.y * playerSpeed);

        
    }

   public void Move(InputAction.CallbackContext context)
    {
        Debug.Log("Moving");
        movementVec = context.action.ReadValue<Vector2>();
    }

    public void Look(InputAction.CallbackContext context)
    {
        Debug.Log("Looking");
        context.action.ReadValue<Vector2>();
    }


}
