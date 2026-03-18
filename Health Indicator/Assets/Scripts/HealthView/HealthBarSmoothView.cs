using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmoothView : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private Health _health;
    [SerializeField] private float _smoothDuration = 0.5f;

    private Coroutine _coroutine;

    private void OnEnable()
    {
        _health.Changed += UpdateHealth;
    }

    private void OnDisable()
    {
        _health.Changed -= UpdateHealth;
    }

    private void Start()
    {
        _healthSlider.maxValue = _health.MaxHealth;
        _healthSlider.minValue = 0;
        UpdateHealth(_health.MaxHealth);
    }

    public void UpdateHealth(int currentHealth)
    {
        StopCoroutine();
        StartCoroutine(currentHealth);
    }

    public void StartCoroutine(float target)
    {
        _coroutine = StartCoroutine(ChangeHealthSmoothly(target));
    }

    public void StopCoroutine()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }

    private IEnumerator ChangeHealthSmoothly(float target)
    {
        float distance = Mathf.Abs(_healthSlider.value - target);
        float speed = distance / _smoothDuration;

        while (_healthSlider.value != target)
        {
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, target, Time.deltaTime * speed);

            yield return null;
        }
    }
}