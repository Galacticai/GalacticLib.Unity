using UnityEngine;

namespace GalacticLib.Unity.Space2D {
    public class Billboard : MonoBehaviour {
        public Transform Camera;

        private void LateUpdate() {
            transform.LookAt(transform.position + Camera.forward);
        }
    }
}