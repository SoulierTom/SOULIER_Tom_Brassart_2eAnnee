using UnityEngine;
using System.Threading.Tasks;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _bombRenderer;

    [SerializeField]
    private Sprite _explosionSprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _ = Countdown();
    }

    private async Task Countdown()
    {
        await Awaitable.WaitForSecondsAsync(1);
        _ = Explosion();
    }

    private async Task Explosion()
    {
        _bombRenderer.enabled = false;
        await Awaitable.WaitForSecondsAsync(0.1f);
        _bombRenderer.sprite = _explosionSprite;
        _bombRenderer.enabled = true;
        await Awaitable.WaitForSecondsAsync(0.25f);
        _bombRenderer.enabled = false;
    }
}
