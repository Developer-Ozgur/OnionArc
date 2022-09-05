using Core.Persistence.Repositories;

namespace rentACarApp.Core.Domain.Entiyies;

#region Description

//TODO 001.Domain : Create Brand Entity Class

#endregion
public class Brand:Entity
{
    public string Name { get; set; }

    public Brand()
    {
    }

    public Brand(int id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}