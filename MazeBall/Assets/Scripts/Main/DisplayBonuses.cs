using UnityEngine;
using UnityEngine.UI;

namespace Main
{
    public sealed class DisplayBonuses: IView
    {
        private Text _text;
        private Image _panel;
        private float _point;
        private int _heath;
        private float _maxPoint;
        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
            _panel = Object.FindObjectOfType<Image>().GetComponent<Image>();
            Debug.Log(_panel);
            _maxPoint = MainProgram.MaxPoint;
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