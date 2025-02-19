﻿using Domain.DTO.Amenity;

namespace Domain.Services.IServices.IAmenity;

public interface IAmenityGetService
{
    Task<List<AmenityResponse>> GetAllAmenities();
    Task<AmenityResponse?> GetAmenityById(Guid? amenityId);
}