﻿namespace EventBus.Message.Events
{
    public class IntegrationBaseEvent
    {
        public Guid Id { get; private set; }

        public DateTime CreationDate { get; private set; }

        public IntegrationBaseEvent(Guid id, DateTime creationDate)
        {
            Id = id;
            CreationDate = creationDate;
        }

        public IntegrationBaseEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }
    }
}