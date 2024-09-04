using System;
using Domain.Entities;

namespace Application.Services;

public interface IUserService
{
    public void Add(User user);
    
    public IEnumerable<User> Get();
}
