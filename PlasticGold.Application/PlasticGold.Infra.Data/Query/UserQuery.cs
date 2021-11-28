
namespace PlasticGold.Infra.Data.Query
{
    public class UserQuery
    {
        public static string UserExistQuery 
            => "select * from \"UserData\" where \"Email\" = @email";


        public static string InsertNewUser
            => @" INSERT INTO  ""AccreditationUser"" 
                   (""Name"",
                    ""LastName"",
                    ""ContactPhone"",
                    ""NumberOfAddress"",
                    ""Complement"",
                    ""Neighborhood"",
                    ""City"",
                    ""State"",
                    ""PostalCode"",        
                    ""Job"")
                VALUES (@Name,
                    @LastName,
                    @ContactPhone,
                    @NumberOfAddress,
                    @Complement,
                    @Neighborhood,
                    @City,
                    @State,
                    @PostalCode,        
                    @Job)";

    }
}
