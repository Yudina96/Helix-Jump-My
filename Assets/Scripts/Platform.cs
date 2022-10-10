using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Platform : MonoBehaviour
{
        public GameObject effect;


        private void OnTriggerEnter(Collider other)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            if (other.TryGetComponent(out Player player))
            {
                player.CurrentPlatform = this;
            }
           
        }

       
    }
}


