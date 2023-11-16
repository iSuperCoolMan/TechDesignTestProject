using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider2D))]
public class ShowButtonObject : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private float _hideTime;

    private float _timeLeft = 0;

    private void OnMouseDown()
    {
        _button.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (_button.gameObject.activeInHierarchy)
        {
            if (_timeLeft < _hideTime)
            {
                _timeLeft += Time.deltaTime;
            }
            else
            {
                _button.gameObject.SetActive(false);
                _timeLeft = 0;
            }
        }
    }
}
