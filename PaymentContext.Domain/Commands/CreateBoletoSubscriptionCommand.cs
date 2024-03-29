﻿using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscriptionCommand : Notifiable, ICommand
    {



        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
        public string PaymentNumber { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public string PayerDocument { get; set; }
        public string PayerEmail { get; set; }
        public EDocumentType PayerDocumentType { get; set; }



        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }


        public void Validate()
        {
            AddNotifications(new Contract()
                 .Requires()
                 .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter no mínimo 3 catacteres")
                 .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter no mínimo 3 catacteres")
                 .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter no máximo 40 catacteres")
                 .HasMaxLen(LastName, 40, "Name.LastName", "Sobrenome deve conter no máximo 40 catacteres")
                 );
        }

    }
}
