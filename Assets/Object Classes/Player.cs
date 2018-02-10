using UnityEngine;
using System.Collections;

namespace ToChangeALightBulb {
	public class Player : MonoBehaviour {

		private Item _heldItem;

		// Constructor
		public Player() {
			
		}

		public Item Interact() {
			return _heldItem;
		}

		public void PickUpItem(Item obj) {
			_heldItem = obj;
		}

		public void DropItem() {
			_heldItem = null;
		}

		// Properties
	}
}