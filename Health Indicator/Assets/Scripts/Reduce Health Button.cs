using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReduceHealthButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private Slider _healthSliderSmooth;
    [SerializeField] private Health _health;
    [SerializeField] private int _reduceValue = 10;
    [SerializeField] private float _smoothDecreaseDuration = 1.0f;

    private Coroutine _coroutine;

    private void Start()
    {
        //UpdateHealth();
    }

    private void Update()
    {
        _healthSliderSmooth.value = Mathf.MoveTowards(_healthSliderSmooth.value, _health.GetCurrentHealth(), _reduceValue * Time.deltaTime);
    }

    public void ReduceHealth()
    {
        _health.TakeDamage(_reduceValue);
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        _healthText.text = _health.GetCurrentHealth().ToString() + "/" + _health.GetMaxHealth().ToString();
        _healthSlider.value = _health.GetCurrentHealth();
        //StartCoroutine(_health.GetCurrentHealth());
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
        float previousValue = _healthSliderSmooth.value;
        float elapsedTime = 0f;

        while (elapsedTime < _smoothDecreaseDuration)
        {
            elapsedTime += Time.deltaTime;
            _healthSliderSmooth.value = Mathf.Lerp(previousValue, target, elapsedTime / _smoothDecreaseDuration);

            yield return null;
        }
    }
}
