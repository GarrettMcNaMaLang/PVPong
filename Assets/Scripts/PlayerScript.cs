using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using UnityEngine.AI;

//[RequireComponent(typeof(Camera))]
public class PlayerScript : MonoBehaviour
{

    public GameObject ballPrefab;
    CinemachineVirtualCamera playerCamera;
    
    public GameObject ballHoldPosition;

    public GameObject ballSpawner;

    public Rigidbody rb;

    Vector2 movementVec, lookingVec;

    public float playerSpeed, lookingSensitivity = 0.1f, pitchLimit = 85f;

    private float currPitch = 0f;

    public float CurrPitch
    {
        get {return currPitch;}

        set {currPitch = Mathf.Clamp(value,-pitchLimit, pitchLimit);}
    }

    

    public void Awake()
    {
        playerCamera = GetComponentInChildren<CinemachineVirtualCamera>();

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
        Vector2 lookInput = new Vector2(lookingVec.x * lookingSensitivity, lookingVec.y * lookingSensitivity);

        CurrPitch -= lookInput.y;

        playerCamera.transform.localRotation = Quaternion.Euler(CurrPitch,0f, 0f);

        rb.transform.Rotate(Vector3.up * lookInput.x);
    }

   public void Move(InputAction.CallbackContext context)
    {
        //Debug.Log("Moving");
        movementVec = context.action.ReadValue<Vector2>();
    }


    public void Look(InputAction.CallbackContext context)
    {
        Debug.Log("Looking");
       lookingVec = context.action.ReadValue<Vector2>();
    }


}
