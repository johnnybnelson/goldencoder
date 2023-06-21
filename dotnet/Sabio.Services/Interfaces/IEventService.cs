﻿using Sabio.Models;
using Sabio.Models.Domain.Events;
using Sabio.Models.Requests.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabio.Services.Interfaces
{
    public interface IEventService
    {

        Paged<Event> Feeds(int pageIndex, int pageSize);

        int Add(EventAddRequest newFriend, int UserId);

        void Update(EventUpdateRequest existingFriend, int UserId);

    }
}