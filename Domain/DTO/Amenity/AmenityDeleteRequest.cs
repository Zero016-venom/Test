﻿namespace Domain.DTO.Amenity;

public class AmenityDeleteRequest
{
    public Guid Id { get; set; }
    public Guid? DeletedBy { get; set; }
    public DateTimeOffset? DeletedTime { get; set; }
}