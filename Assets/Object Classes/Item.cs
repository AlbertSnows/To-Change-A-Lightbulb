using UnityEngine;
using System.Collections;

namespace ToChangeALightBulb {
	public abstract class Item : MonoBehaviour{

		protected int _itemId;
		protected bool _canPickUp;

		public Item(int id, bool pickUp) {
			_itemId = id;
			_canPickUp = pickUp;
		}

		public abstract void Interact(Item obj);

		public bool IsSameItem(int id) {
			return _itemId == id;
		}

		// Properties
		public bool CanPickUp {
			get {
				return _canPickUp;
			}
		}
	}	
}
