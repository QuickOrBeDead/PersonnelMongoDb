﻿namespace PersonnelWebApp.Infrastructure.Model;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

public sealed class Personnel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public bool IsDeleted { get; set; }

    public IList<Vacation> Vacations { get; set; }

    public IList<EntryExitHour> EntryExitHours { get; set; }
}