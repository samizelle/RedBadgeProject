﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Food
{
    public interface IFoodManager
    {
        Task<bool> CreateFood(FoodCreateDTO dto);
        Task<IEnumerable<FoodGetListItemsDTO>> GetFoods(int identityClaimNum);
        Task<FoodGetListItemsDTO> GetFoodById(int id);
        Task<bool> EditFood(FoodUpdateDTO dto);
        Task<bool> DeleteFood(int id);
    }
}
