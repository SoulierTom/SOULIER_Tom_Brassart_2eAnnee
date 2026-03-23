using Unity.VisualScripting;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private string speedParameterName;
    [SerializeField]
    [Range(0, 1)]
    private float speedValue;

    [SerializeField]
    private string jumpParameterName;

    [SerializeField]
    private string attackParameterName;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        // Increase Speed by holding Z
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat(speedParameterName, speedValue += 0.3f * Time.deltaTime );
        }

        // Decrease Speed by holding S
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetFloat(speedParameterName, speedValue -= 0.3f * Time.deltaTime);
        }

        // Clamp the speed value between 0 and 1
        if (speedValue <= 0.0f)
        {
            speedValue = 0;
        }

        if (speedValue >= 1.0f)
        {
            speedValue = 1.0f;
        }

        // Jump by pressing Left Click
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Jump");
            animator.SetTrigger(jumpParameterName);

        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            animator.SetTrigger(attackParameterName);
        }

    }
    
}
