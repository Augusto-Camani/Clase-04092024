using System;
using System.Collections;
using System.Reflection.Metadata;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Data;

public class UserRepository : IUserRepository
{
    public static List<User> Users = [];

    public void AddUser(User user){
        Users.Add(user);
    }

    public IEnumerable<User> GetUser(){
        return Users;
    }
}
    