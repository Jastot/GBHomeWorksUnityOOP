using UnityEngine;

namespace Main.Bonuses
{


    public sealed class SpeedBonus : BaseBonus
    {
        public float Speed;
        private Player.Player _player;
        //не особо мне нравится такая муть.
        //Можно попросить Вас объяснить как лучше сделать
        //просто есть сборка Main. к ней подключены все остальные.
        //НО. сейчас я бонусами общаюсь с игроком напрямую,обходя Main.
        //в теории, это не особо верно...
        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player.Player>();
            _player.Speed += Speed;
            _view.Display(Point, Health);
        }
    }
}