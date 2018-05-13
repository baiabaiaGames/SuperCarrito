using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "GameEvent", menuName = "Event", order = 0)]
public class GameEvent : ScriptableObject {

    List<GameEventListener> listeners = new List<GameEventListener> ();

    public void Register (GameEventListener l) {
        listeners.Add (l);
    }

    public void UnRegister (GameEventListener l) {
        listeners.Remove (l);
    }

    public void Raise (GameEventListener l) {
        for (int i = 0; i < listeners.Count; i++) {
            listeners[i].Response ();
        }
    }

}