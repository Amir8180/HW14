using Personels.Models;

namespace Personels
{
    public static class Storage
    {
        public static List<Member> Users { get; set; } = new List<Member>()
        {
            new Member(){Id = 1,Name="Amir",Lastname="Akbarzadeh",NationalCode=2130778569,PhoneNumber=9129217238,BirthDate=DateTime.Now,SignUpDate=DateTime.Now},
            new Member(){Id = 2,Name="Nima",Lastname="Akbari",NationalCode=2130778569,PhoneNumber=9129217238,BirthDate=DateTime.Now,SignUpDate=DateTime.Now},
            new Member(){Id = 3,Name="Mahmoud",Lastname="Akbarzadeh",NationalCode=2130778569,PhoneNumber=9129217238,BirthDate=DateTime.Now,SignUpDate=DateTime.Now}
        };
    }
}
