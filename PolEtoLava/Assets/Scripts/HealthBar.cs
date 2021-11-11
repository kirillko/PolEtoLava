using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _target;
    [SerializeField] private Image _render;
    public GameObject loseMessage;
    private void OnEnable()
    {
        _target.OnHealthChange += UpdateValue;
    }
    private void OnDisable()
    {
        _target.OnHealthChange -= UpdateValue;
    }
    public void UpdateValue(float value)
    {
        if(_target == null) return;
        _render.fillAmount -= value;
        if(_render.fillAmount == 0f) 
        {
            Time.timeScale = 0;
            loseMessage.SetActive(true);
        }
    }
}
