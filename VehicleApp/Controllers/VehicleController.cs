using BusinessLogic;
using DataModels.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVehicles()
        {
            try
            {
                var vehicles = await _vehicleService.GetAllVehiclesAsync();
                return Ok(vehicles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error getting all vehicles: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicleById(int id)
        {
            try
            {
                var vehicle = await _vehicleService.GetVehicleByIdAsync(id);
                if (vehicle == null)
                {
                    return NotFound();
                }
                return Ok(vehicle);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error getting the vehicle: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle(VehicleDTO vehicle)
        {
            try
            {
                if (vehicle == null)
                {
                    return BadRequest("Vehicle data is not valid");
                }

                await _vehicleService.CreateVehicleAsync(vehicle);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error creating the vehicle: " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, VehicleDTO vehicle)
        {
            try
            {
                if (vehicle == null)
                {
                    return BadRequest("Vehicle data is not valid");
                }

                await _vehicleService.UpdateVehicleAsync(id, vehicle);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error updating the vehicle: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            try
            {
                await _vehicleService.DeleteVehicleAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error deleting the vehicle: " + ex.Message);
            }
        }
    }
}
