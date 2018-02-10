using UnityEngine;
using System.Collections;

namespace ToChangeALightBulb {
	public class Bulb : Item, ILight{

		private float _brightness;
		private int _brightnessScale = 5;

		// Constructor
		public Bulb() : base(0, true){
			_brightness = 0.0f;
		}
			
		public override void Interact(Item obj) {
			
		}

		public void TurnOn() {
			
		}

		public void TurnOff() {
			
		}

		// Properties
		public float Brightness {
			get {
				return _brightness;
			}
		}

		public bool IsOn {
			get {
				return _brightness > (0.1f * _brightnessScale);
			}
		}
	}	
}