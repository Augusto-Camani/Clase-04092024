using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void Add(User user)
    {
        _userRepository.AddUser(user);
    }

    public IEnumerable<User> Get()
    {
        return _userRepository.GetUser();
    }
}
