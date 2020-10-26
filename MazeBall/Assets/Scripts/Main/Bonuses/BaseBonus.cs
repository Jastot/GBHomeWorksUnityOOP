using System;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Main.Bonuses
{
    public class BaseBonus : InteractiveObject, IFlay, IFlicker, IEquatable<BaseBonus>,ICloneable
    {
        public int Point;
        public int Health;
        private Material _material;
        private float _lengthFlay;


        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Random.Range(1.0f, 5.0f);
        }

        protected override void Interaction()
        {
            //_view.Display(Point, Health);
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }

        public bool Equals(BaseBonus other)
        {
            return Point == other.Point;
        }
        public object Clone()
        {
            //это то все понятно, но тогда у нас Main(Game Controller) должен
            //передавать координаты и сам клонировать
            //верно?
            return Instantiate(gameObject, transform.position, transform.rotation, transform.parent);
        }
    }
}

