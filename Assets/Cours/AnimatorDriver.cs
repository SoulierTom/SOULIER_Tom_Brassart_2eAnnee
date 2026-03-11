using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorDriver : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private async void Start()
    {
        await Awaitable.WaitForSecondsAsync(3f);

        _animator.SetTrigger("Switch");
    }

    
}
