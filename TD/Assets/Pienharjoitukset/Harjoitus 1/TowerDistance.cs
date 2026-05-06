using TMPro;
using UnityEngine;

namespace Pienharjoitukset
{
    public class TowerDistance : MonoBehaviour
    {
        public Transform tower;
        public Transform enemy;
        public TextMeshProUGUI distanceText;

        void Update()
        {
            float distance = Vector3.Distance(tower.position, enemy.position);

            distanceText.text = "Vihollisen etäisyys tornista: " + distance.ToString("F2");
        }
    }
}
