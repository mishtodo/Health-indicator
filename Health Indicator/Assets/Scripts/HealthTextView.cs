using TMPro;
using UnityEngine;

public class HealthTextView : MonoBehaviour
{
    private const char TextParser = '/';

    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private Health _health;

    public void UpdateHealth()
    {
        _healthText.text = _health.GetCurrentHealth().ToString() + TextParser + _health.GetMaxHealth().ToString();
    }
}