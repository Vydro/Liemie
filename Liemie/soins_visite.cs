//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Liemie
{
    using System;
    using System.Collections.Generic;
    
    public partial class soins_visite
    {
        public int visite { get; set; }
        public int id_categ_soins { get; set; }
        public int id_type_soins { get; set; }
        public int id_soins { get; set; }
        public short prevu { get; set; }
        public short realise { get; set; }
    
        public virtual soins soins { get; set; }
        public virtual visite visite1 { get; set; }
    }
}
