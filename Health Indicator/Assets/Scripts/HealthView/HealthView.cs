using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] protected Health _health;

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
        UpdateHealth(_health.Max);
    }

    public virtual void UpdateHealth(int currentHealth) { }
}
