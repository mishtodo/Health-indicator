using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private Health _health;

    private void Start()
    {
        _healthSlider.maxValue = _health.GetMaxHealth();
        _healthSlider.minValue = 0;
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        _healthSlider.value = _health.GetCurrentHealth();
    }
}