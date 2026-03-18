using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private Health _health;

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
        _healthSlider.value = currentHealth;
    }
}