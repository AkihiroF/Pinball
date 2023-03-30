using TMPro;
using UnityEngine;

namespace _Source
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textCoin;
        private float _countCoins;

        private void Start()
        {
            EventSystem.OnAddingCoins += AddCoin;
            EventSystem.OnRestart += Restart;
            UpdateText();
        }

        private void Restart()
        {
            _countCoins = 0;
            UpdateText();
        }

        private void AddCoin(float count) 
        {
            _countCoins += count;
            UpdateText();
        }

        private void UpdateText()
        {
            textCoin.text = $"Coins = {_countCoins}";
        }
    }
}
