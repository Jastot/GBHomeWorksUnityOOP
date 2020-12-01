﻿using UnityEngine;
using UnityEngine.UI;

namespace MazeBall
{
    public class RadarObj: MonoBehaviour
    {
        [SerializeField] private Image _ico;

        private void OnValidate()
        {
            _ico = Resources.Load<Image>("MiniMap/RadarObject");
        }

        private void OnDisable()
        {
            Radar.RemoveRadarObject(gameObject);
        }

        private void OnEnable()
        {
            Radar.RegisterRadarObject(gameObject, _ico);
        }
    }
}