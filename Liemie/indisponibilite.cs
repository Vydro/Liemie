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
    
    public partial class indisponibilite
    {
        public int infirmiere { get; set; }
        public System.DateTime date_debut { get; set; }
        public System.DateTime date_fin { get; set; }
        public Nullable<System.TimeSpan> heure_deb { get; set; }
        public Nullable<System.TimeSpan> heure_fin { get; set; }
        public int categorie { get; set; }
    
        public virtual categorie_indisponibilite categorie_indisponibilite { get; set; }
        public virtual infirmiere infirmiere1 { get; set; }
    }
}