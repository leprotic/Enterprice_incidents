//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enterprice_incidents.Ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incident
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Incident()
        {
            this.Incidents_History = new HashSet<Incidents_History>();
            this.Worker_incident = new HashSet<Worker_incident>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdType { get; set; }
        public string IncidentName { get; set; }
        public string Description { get; set; }
    
        public virtual Incident_Type Incident_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidents_History> Incidents_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Worker_incident> Worker_incident { get; set; }
    }
}
