using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private Health _health;

    public void UpdateHealth()
    {
        _healthSlider.value = _health.GetCurrentHealth();
    }
}
