using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler : MonoBehaviour
    {
		public GameObject Fire;
        public string Name;

        void OnEnable()
        {


        }

        public void SetDownState()
        {
            CrossPlatformInputManager.SetButtonDown(Name);
			Fire.SetActive (true);

        }


        public void SetUpState()
        {
            CrossPlatformInputManager.SetButtonUp(Name);
			Fire.SetActive (false);
        }


        public void SetAxisPositiveState()
        {
            CrossPlatformInputManager.SetAxisPositive(Name);
        }


        public void SetAxisNeutralState()
        {
            CrossPlatformInputManager.SetAxisZero(Name);
        }


        public void SetAxisNegativeState()
        {
            CrossPlatformInputManager.SetAxisNegative(Name);
        }

        public void Update()
        {

        }
    }
}
