using UnityEngine;
using UnityEngine.UI;

public abstract class HealthViewSlider : HealthView
{
    [SerializeField] protected Slider _healthSlider;

    protected override void Start()
    {
        _healthSlider.maxValue = _health.Max;
        _healthSlider.minValue = 0;
        UpdateHealth(_health.Max);
    }
}