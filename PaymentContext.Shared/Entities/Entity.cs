﻿using Flunt.Notifications;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable
    {

        public Entity() {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

    }
}
