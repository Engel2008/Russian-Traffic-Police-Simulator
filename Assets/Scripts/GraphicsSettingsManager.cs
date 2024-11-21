using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicsSettingsManager : MonoBehaviour
{
    public Dropdown qualityDropdown;

  void Start()
{
    if (qualityDropdown != null)
    {
        // Настройка начального значения качества
        qualityDropdown.value = QualitySettings.GetQualityLevel();
        
        // Добавляем слушателя на изменение выбора в выпадающем меню
        qualityDropdown.onValueChanged.AddListener(ChangeQuality);
    }
    else
    {
        Debug.LogWarning("Quality Dropdown не назначен в инспекторе!");
    }
}


    void ChangeQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);
        Debug.Log("Изменено качество на уровень: " + index);
    }
}

