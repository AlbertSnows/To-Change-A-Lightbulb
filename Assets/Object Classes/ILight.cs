using UnityEngine;
using System.Collections;

namespace ToChangeALightBulb {
	public interface ILight {

		void TurnOn();

		void TurnOff();

		// Properties
		float Brightness {
			get;
		}

		bool IsOn {
			get;
		}
	}	
}

