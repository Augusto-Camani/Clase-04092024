using System;
using System.Collections;
using Domain.Entities;

namespace Domain.Interfaces;

public interface IUserRepository
{

    public void AddUser(User user);
    public IEnumerable<User> GetUser();
}

