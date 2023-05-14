using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private Button[] _shopButtons;

    private void Start()
    {
        if (_gameData.tutorial)
            DeactivateShopButtons();
        else
            ActivateShopButtons();
    }

    private void ActivateShopButtons()
    {
        foreach (var button in _shopButtons)
        {
            button.gameObject.SetActive(true);
        }
    }

    private void DeactivateShopButtons()
    {
        foreach (var button in _shopButtons)
        {
            button.gameObject.SetActive(false);
        }
    }
}