//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Passenger_Tickets
    {
        public int ID_PassengerTicket { get; set; }
        public int Passenger_ID { get; set; }
        public int Ticket_Id { get; set; }
    
        public virtual Passengers Passengers { private get; set; }
        public virtual Tickets Tickets { private get; set; }
    }
}
