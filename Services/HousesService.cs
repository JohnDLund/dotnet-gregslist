using System;
using System.Collections.Generic;
using gregslist_api.Models;
using gregslist_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace gregslist_api.Services
{
  public class HousesService
  {
    private readonly HousesRepository _repo;

    public HousesService(HousesRepository repo)
    {
      _repo = repo;
    }

    public IEnumerable<House> Get()
    {
      return _repo.Get();
    }

    public IEnumerable<House> Get(string userId)
    {
      return _repo.Get(userId);
    }

    public House GetById(int id)
    {
      House foundHouse = _repo.GetById(id);
      if (foundHouse == null)
      {
        throw new Exception("Invalid house Id");
      }
      return foundHouse;
    }
    public House Create(House newHouse)
    {
      return _repo.Create(newHouse);
    }

    public string Delete(string userId, int id)
    {
      GetById(id);
      bool delorted = _repo.Delete(userId, id);
      if (!delorted)
      {
        throw new Exception("Oops ALL BERRIES You are not the owner of this house");
      }
      return "Delorted!";
    }

    public House Update(House updatedHouse)
    {
      House foundHouse = GetById(updatedHouse.Id);
      updatedHouse.Level = updatedHouse.Level != 0 ? updatedHouse.Level : foundHouse.Level;
      updatedHouse.Year = updatedHouse.Year != 0 ? updatedHouse.Year : foundHouse.Year;
      updatedHouse.Price = updatedHouse.Price != 0 ? updatedHouse.Price : foundHouse.Price;
      updatedHouse.ImgUrl = updatedHouse.ImgUrl != null ? updatedHouse.ImgUrl : foundHouse.ImgUrl;
      bool updated = _repo.Update(updatedHouse);
      if (!updated)
      {
        throw new Exception("Oops ALL BERRIES You are not the owner of this house");
      }
      return updatedHouse;
    }
  }
}