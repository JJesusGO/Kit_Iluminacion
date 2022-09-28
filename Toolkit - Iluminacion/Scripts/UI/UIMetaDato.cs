using UnityEngine;
using System.Collections;
using TMPro;

namespace Iluminacion{

    [RequireComponent(typeof(TextMeshProUGUI))]
    public class UIMetaDato : MonoBehaviour{

        [Header("Configuración")]
        [SerializeField]
        private string metanombre = "";
        [SerializeField]
        private string formato = "{0}";

        private TextMeshProUGUI uitexto = null;

        private void Awake(){
            uitexto = GetComponent<TextMeshProUGUI>();        
        }

        private void Update(){

             string valor = ManagerAplicacion.GetInstancia().GetMetadato(metanombre);
             uitexto.text = string.Format(formato, valor);
                
        }
              
      
    }

}

