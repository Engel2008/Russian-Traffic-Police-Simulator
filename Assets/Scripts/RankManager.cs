using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankManager : MonoBehaviour
{
    public Text rankText;
    private int currentRankIndex = 0;

    private string[] ranks = {
        "Рядовой полиции", "Младший сержант полиции", "Сержант полиции",
        "Старший сержант полиции", "Старшина полиции", "Прапорщик полиции",
        "Старший прапорщик полиции", "Младший лейтенант полиции", "Лейтенант полиции",
        "Старший лейтенант полиции", "Капитан полиции", "Майор полиции",
        "Подполковник полиции", "Полковник полиции", "Генерал-майор полиции",
        "Генерал-лейтенант полиции", "Генерал-полковник полиции", "Генерал полиции Российской Федерации"
    };

    public Button leftButton;
    public Button rightButton;

    void Start()
    {
        if (rankText == null || leftButton == null || rightButton == null)
        {
            Debug.LogError("Одно из полей не привязано в инспекторе.");
            return;
        }

        UpdateRank();
        leftButton.onClick.AddListener(DemoteRank);
        rightButton.onClick.AddListener(PromoteRank);
    }

    void UpdateRank()
    {
        rankText.text = ranks[currentRankIndex];
    }

    void PromoteRank()
    {
        if (currentRankIndex < ranks.Length - 1)
        {
            currentRankIndex++;
            UpdateRank();
        }
    }

    void DemoteRank()
    {
        if (currentRankIndex > 0)
        {
            currentRankIndex--;
            UpdateRank();
        }
    }
}
