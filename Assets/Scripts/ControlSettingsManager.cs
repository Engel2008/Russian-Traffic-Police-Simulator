using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlSettingsManager : MonoBehaviour
{
    public string currentControlMode; // Текущий режим управления

    // Ссылки на объекты спрайтов
    public Image arrowSprite;
    public Image wheelSprite;
    public Image tiltSprite;

    void Start()
    {
        // Установите начальный режим управления
        SetControlMode("ArrowControls");
    }

    void Update()
    {
        switch (currentControlMode)
        {
            case "ArrowControls":
                HandleArrowControls();
                break;
            case "WheelControls":
                HandleWheelControls();
                break;
            case "TiltControls":
                HandleTiltControls();
                break;
        }
    }

    public void SetControlMode(string mode)
    {
        currentControlMode = mode;
        UpdateControlSprites();
    }

    void UpdateControlSprites()
    {
        // Сбрасываем прозрачность для всех спрайтов
        arrowSprite.color = new Color(1, 1, 1, 0.5f); // Полупрозрачный
        wheelSprite.color = new Color(1, 1, 1, 0.5f);
        tiltSprite.color = new Color(1, 1, 1, 0.5f);

        // Выделяем активный спрайт
        switch (currentControlMode)
        {
            case "ArrowControls":
                arrowSprite.color = new Color(1, 1, 1, 1); // Полная непрозрачность
                break;
            case "WheelControls":
                wheelSprite.color = new Color(1, 1, 1, 1);
                break;
            case "TiltControls":
                tiltSprite.color = new Color(1, 1, 1, 1);
                break;
        }
    }

    void HandleArrowControls()
    {
        Debug.Log("Игрок управляет с помощью стрелок");
    }

    void HandleWheelControls()
    {
        Debug.Log("Игрок управляет с помощью руля");
    }

    void HandleTiltControls()
    {
        Debug.Log("Игрок управляет с помощью наклона");
    }
}
