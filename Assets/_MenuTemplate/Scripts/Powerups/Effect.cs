using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Powerups {
	public class Effect {
		public float lenght;
		public UnityAction action;
		public UnityAction endAction;

		public Effect (float lenght, UnityAction action, UnityAction endAction) {
			this.lenght = lenght;
			this.action = action;
			this.endAction = endAction;
		}
	}
}