using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DTO
{
    public class PrestamoDTO
    {
        // ToDo: atributos

        private int id;
        private int monto;
        private int montoMasInteres;
        private int montoAtraso;

        // ToDo: propiedades

        public int Id { get => id; set => id = value; }
        public int Monto { get => monto; set => monto = value; }
        public int MontoMasInteres { get => montoMasInteres; set => montoMasInteres = value; }
        public int MontoAtraso { get => montoAtraso; set => montoAtraso = value; }

        static List<PrestamoDTO> datos = new List<PrestamoDTO>()
        {
            new PrestamoDTO {id = 1, monto = 100000},
            new PrestamoDTO {id = 2, monto = 150000},
            new PrestamoDTO {id = 3, monto = 200000}
        };


        // ToDo: métodos
        public static bool Add(PrestamoDTO nuevosDatos)
        {
            try
            {
                datos.Add(nuevosDatos); 

                return true; 
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool RemoveAt(int indice)
        {
            try
            {
                datos.RemoveAt(indice);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
