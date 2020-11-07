
using UnityEngine;
using UnityEngine.UI;

namespace MazeBall
{
    public sealed class DisplayEndGame
    {
        
        private Text _finishGameLabel;

        public DisplayEndGame(Text finishGameLabel)
        {
            _finishGameLabel = finishGameLabel;
            //_finishGameLabel.text = String.Empty;

        }

        public void GameOver(object o, PlayersEventArgs args)
        {
            _finishGameLabel.text = $"Вы проиграли. Вас убил {((GameObject)o).name} {args.Color} цвета";
        }
    }
}