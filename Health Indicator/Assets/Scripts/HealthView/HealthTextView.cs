using TMPro;
using UnityEngine;

public class HealthTextView : MonoBehaviour
{
    private const char TextParser = '/';

    [SerializeField] private TextMeshProUGUI _healthText;
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
        UpdateHealth(_health.MaxHealth);
    }

    public void UpdateHealth(int currentHealth)
    {
        _healthText.text = currentHealth.ToString() + TextParser + _health.MaxHealth.ToString();
    }
}