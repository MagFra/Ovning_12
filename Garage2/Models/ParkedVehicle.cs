﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2.Models
{
    public class ParkedVehicle
    {
        [Key]
        [DisplayName("ID")]
        public int ParkedVehicleId { get; set; }


        [DisplayName("Vehicle type")]
        [Required]
        public VehicleTypes VehicleType { get; set; }


        [DisplayName("Registration number")]
        [Required]
        [Remote(action: "IsRegNoAvailable", controller: "ParkedVehicles", ErrorMessage = "Vehicle is already parked in the garage.")]
        [RegularExpression(@"^[A-Za-z]{3}\d{3}$", ErrorMessage = "Registration number must consist of 6 characters, 3 letters followed by 3 digits.")]
        [StringLength(6)]
        public string RegistrationNumber { get; set; } = string.Empty;


        [StringLength(25)]
        [Required]
        public string Make { get; set; } = string.Empty;


        [StringLength(25)]
        [Required]
        public string Model { get; set; } = string.Empty;


        [Range(1930, 3000)]
        public int? Year { get; set; }


        [StringLength(25)]
        public string? Color { get; set; }


        [DisplayName("Number of wheels")]
        [Range(0, 24)]
        public int? NumberOfWheels { get; set; }


        [DisplayName("Time of arrival")]
        public DateTime TimeOfArrival { get; set; }

    }
}
