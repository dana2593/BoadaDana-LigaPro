using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BoadaDana_LigaPro.Models
{
    public class Equipo
    {
        [Key]

        [Required]

        [MaxLength]

        [DisplayName("Nombre del equipo")]

        public int Id { get; set; }

        [Range(0, 20)]

        public string Nombre { get; set; }

        [Range(0, 20)]

        public int PartidosJugados { get; set; }

        [Range(0, 100)]

        public int PartidosGanados { get; set; }

        [Range(0, 100)]

        public int PartidosEmpatados { get; set; }

        [Range(0, 100)]

        public int PartidosPerdidos { get; set; }

        public int Puntos

        {

            get

            {

                int puntos = PartidosGanados * 3 + PartidosEmpatados;

                return puntos;

            }

        }

    }
}
