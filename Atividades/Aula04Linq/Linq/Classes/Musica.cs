using System;
using System.Collections.Generic;
using System.Text;

namespace Linq.Classes
{
    public class Musica
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public int GeneroId { get; set; }

        public int AutorId { get; set; }
        public int AlbumID { get; set; }
    }
}
