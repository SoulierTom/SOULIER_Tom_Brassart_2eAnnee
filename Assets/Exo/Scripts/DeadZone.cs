using Unity.VisualScripting;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField]
    private int sphereCount = 0;
    [SerializeField]
    private GameObject triggerWin;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destructible"))
        {
            sphereCount++;
            Debug.Log("Sphere Destroyed");

            if (sphereCount == 2)
            {
                Debug.Log("TriggerWin Activate");
                triggerWin.SetActive(true);
            }
        }
    }
}


