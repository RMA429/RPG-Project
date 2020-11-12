using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target = default;


        // Update is called once per frame
        void LateUpdate() //Late update fixes an issue of the camera moving before the player
        {
            transform.position = target.position;
        }
    }

}