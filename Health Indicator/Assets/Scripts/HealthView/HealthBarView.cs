using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : HealthView
{
    [SerializeField] private Slider _healthSlider;

    private void Start()
    {
        _healthSlider.maxValue = _health.Max;
        _healthSlider.minValue = 0;
        UpdateHealth(_health.Max);
    }

    public override void UpdateHealth(int currentHealth)
    {
        _healthSlider.value = currentHealth;
    }
}