using System;
using UnityEngine;

public class CellSlider : MonoBehaviour
{
    [SerializeField]  public int           minValue = 0;
    [SerializeField]  public int           maxValue = 10;
    [SerializeField]  public RectTransform backGroundRect;
    [SerializeField]  public RectTransform fillRect;
    [SerializeField]  public GameObject    cellObject;
    [SerializeField]  public Color         enableColor  = new Color(1, 1, 1, 1);
    [SerializeField]  public Color         disableColor = new Color(.25f, .25f, .25f, 1);
    [HideInInspector] public int           value;
    [HideInInspector] public int           lastValue;
    [HideInInspector] public bool          firstLoad;

    //value의 값이 바뀌였을때
    private void Update()
    {
        if (lastValue != value)
        {
            lastValue          = value;
            fillRect.anchorMax = new Vector2((float)value / maxValue, 1);
        }
    }
}