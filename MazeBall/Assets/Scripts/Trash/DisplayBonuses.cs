using Main;
using UnityEngine;
using UnityEngine.UI;

namespace MazeBall
{
    public sealed class DisplayBonuses: IView
    {
        private Text _text;
        private Image _panel;
        private float _point;
        private int _heath;
        private float _maxPoint = 10;

        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
            _panel = Object.FindObjectOfType<Image>().GetComponent<Image>();
            Debug.Log(_panel);
        }

        public void Display(int value,int Health)
        {
            _point += value; 
            _heath += Health;
            _text.text = $"Здоровье: {_heath}";
            _panel.fillAmount = _point/_maxPoint;
        }



    }
}