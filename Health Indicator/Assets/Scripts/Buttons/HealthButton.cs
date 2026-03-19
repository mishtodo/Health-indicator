using UnityEngine.UI;
using UnityEngine;

public abstract class HealthButton : MonoBehaviour
{
    [SerializeField] protected int _healthChangeValue;
    [SerializeField] protected Health _health;
    [SerializeField] protected HealthTextView _healthTextView;
    [SerializeField] protected HealthBarView _healthBarView;
    [SerializeField] protected HealthBarSmoothView _healthBarSmoothView;
    [SerializeField] protected Button _button;
}