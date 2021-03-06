﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RedStarter.Business.DataContract.Event;
using RedStarter.Database.DataContract.Event;

namespace RedStarter.Business.Managers.Event
{
    public class EventManager : IEventManager
    {
        private readonly IMapper _mapper;
        private readonly IEventRepository _repository;

        public EventManager(IMapper mapper, IEventRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }



        public async Task<bool> CreateEvent(EventCreateDTO dto)
        {
            var rao = _mapper.Map<EventCreateRAO>(dto);

           if(await _repository.CreateEvent(rao))
            return true;

            throw new NotImplementedException();
        }

        public async Task<EventGetListItemsDTO> GetEventById(int id)
        {
            var rao = await _repository.GetEventById(id);
            var dto = _mapper.Map<EventGetListItemsDTO>(rao);

            return dto;
        }

        public async Task<IEnumerable<EventGetListItemsDTO>> GetEvents(int id)
        {
            var rao = await _repository.GetEvents(id);
            var dto = _mapper.Map<IEnumerable<EventGetListItemsDTO>>(rao);

            return dto;
        }
        public async Task<bool> EditEvent(EventUpdateDTO dto)
        {
            var rao = _mapper.Map<EventUpdateRAO>(dto);
            if (await _repository.EditEvent(rao))
                return true;
            throw new NotImplementedException();


        }

        public async Task<bool> DeleteEvent(int id)
        {
            await _repository.DeleteEvent(id);

            return true;

        }

    }
}
