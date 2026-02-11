using System.Threading.Tasks;
using UnityEngine;

public class TestFirstClass : MonoBehaviour
{

    [SerializeField]
    private int _testInt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TestAwaitable().Wait();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    async Task TestAwaitable()
    {
        Debug.Log("Start");
        await Awaitable.WaitForSecondsAsync(5);
        Debug.Log("Finish");
    }
}
