using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmoothView : MonoBehaviour
{
    [SerializeField] private Slider _healthSliderSmooth;
    [SerializeField] private Health _health;
    [SerializeField] private float _smoothChangeSpeed = 20.0f;
    [SerializeField] private bool _byTime;
    [SerializeField] private float _smoothDuration = 0.5f;

    private Coroutine _coroutine;

    public void UpdateHealth()
    {
        StopCoroutine();
        StartCoroutine(_health.GetCurrentHealth(), _byTime);
    }

    public void StartCoroutine(float target, bool byTime)
    {
        _coroutine = StartCoroutine(ChangeHealthSmoothly(target, byTime));
    }

    public void StopCoroutine()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }

    private IEnumerator ChangeHealthSmoothly(float target, bool byTime)
    {
        float speed = _smoothChangeSpeed;

        if (byTime) 
        {
            float distance = Mathf.Abs(_healthSliderSmooth.value - target);
            speed = distance / _smoothDuration;
        }

        while (_healthSliderSmooth.value != target)
        {
            _healthSliderSmooth.value = Mathf.MoveTowards(_healthSliderSmooth.value, target, Time.deltaTime * speed);

            yield return null;
        }
    }
}
