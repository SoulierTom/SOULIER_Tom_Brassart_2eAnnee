using UnityEngine;
using TMPro;
using UnityEngine.Animations;

public class SphereAmountUI : MonoBehaviour
{
    
    [SerializeField]
    private TextMeshProUGUI _textMeshProUGUI;

    [SerializeField]
    private LookAtConstraint _lookAtReference;

    static int _sphereCount = 0;

    private void Update()
    {
        _sphereCount = _lookAtReference.sourceCount;
        _textMeshProUGUI.text = "Sphere amount : " + _sphereCount;
    }
}
