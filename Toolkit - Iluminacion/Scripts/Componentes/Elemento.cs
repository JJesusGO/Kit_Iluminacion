using UnityEngine;
using System.Collections;


namespace Iluminacion {
    public class Elemento : MonoBehaviour
    {

        [Header("Direccion")]
        [SerializeField]
        private bool mirarCamara = false;
        [SerializeField]
        private bool holdY = false;

        private void Update(){
            if (mirarCamara && ManagerAplicacion.GetInstancia().GetCamara() != null) {
                transform.LookAt(ManagerAplicacion.GetInstancia().GetCamara().transform);
                if (holdY)
                    transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            }
        }

        public void AccionSetActivo(bool activo)
        {
            gameObject.SetActive(activo);
        }

    }
}


