using PropertyManagmentSystem.Application.DTOs;
using PropertyManagmentSystem.Application.Interfaces;
using PropertyManagmentSystem.Application.Requests;
using PropertyManagmentSystem.Domains;
using PropertyManagmentSystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagmentSystem.Application.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly BuildingRepository _buildingRepo;
        private readonly RoomRepository _roomRepo;

        public BuildingService(BuildingRepository buildingRepo, RoomRepository roomRepo)
        {
            _buildingRepo = buildingRepo;
            _roomRepo = roomRepo;
        }

        public BuildingDto GetBuildingById(int id)
        {
            var b = _buildingRepo.GetById(id);
            return b == null ? null : MapBuilding(b);
        }

        public IEnumerable<BuildingDto> GetAllBuildings()
            => _buildingRepo.GetAll().Select(MapBuilding);

        public void AddBuilding(CreateBuildingRequest request)
        {
            var building = new Building(
                _buildingRepo.GetNextAvailableId(),
                request.District,
                request.Address,
                request.FloorsCount,
                request.CommandantPhone);

            _buildingRepo.Add(building);
        }

        public void UpdateBuilding(UpdateBuildingRequest request)
        {
            var building = _buildingRepo.GetById(request.BuildingId);
            building.ChangeDistrict(request.District);
            building.ChangeCommandantPhone(request.CommandantPhone);
            _buildingRepo.Update(building);
        }

        public void DeleteBuilding(int id)
            => _buildingRepo.Delete(id);

        public RoomDto GetRoomById(int id)
            => MapRoom(_roomRepo.GetById(id));

        public IEnumerable<RoomDto> GetRoomsByBuildingId(int buildingId)
            => _roomRepo.GetRoomsByBuildingId(buildingId).Select(MapRoom);

        public void AddRoomToBuilding(int buildingId, AddRoomRequest request)
        {
            var room = new Room(
                _roomRepo.GetNextAvailableId(),
                request.RoomNumber,
                request.Area,
                request.FloorNumber,
                request.FinishingType,
                request.HasPhone);

            _roomRepo.Add(room);
        }

        public void UpdateRoom(UpdateRoomRequest request)
        {
            var room = _roomRepo.GetById(request.RoomId);
            room.UpdateFinishing(request.FinishingType);
            _roomRepo.Update(room);
        }

        public void RemoveRoomFromBuilding(int roomId)
            => _roomRepo.Delete(roomId);

        public IEnumerable<RoomDto> GetAvailableRooms()
            => _roomRepo.GetAvailableRooms().Select(MapRoom);

        public IEnumerable<RoomDto> GetRentedRooms()
            => _roomRepo.GetRentedRooms().Select(MapRoom);

        public decimal GetBuildingOccupancyRate(int buildingId)
            => _buildingRepo.GetById(buildingId).GetOccupancyRate();

        public decimal GetTotalRentedArea(int buildingId)
            => _buildingRepo.GetById(buildingId).GetTotalRentedArea();

        private BuildingDto MapBuilding(Building b) => new BuildingDto
        {
            Id = b.Id,
            District = b.District,
            Address = b.Address,
            FloorsCount = b.FloorsCount,
            CommandantPhone = b.CommandantPhone,
            TotalRooms = b.TotalRooms,
            AvailableRooms = b.AvailableRooms,
            OccupancyRate = b.GetOccupancyRate()
        };

        private RoomDto MapRoom(Room r) => new RoomDto
        {
            Id = r.Id,
            BuildingId = r.BuildingId,
            RoomNumber = r.RoomNumber,
            Area = r.Area,
            FloorNumber = r.FloorNumber,
            FinishingType = r.FinishingType,
            HasPhone = r.HasPhone,
            IsRented = r.IsRented,
            CurrentAgreementId = r.CurrentAgreementId
        };
    }

}
