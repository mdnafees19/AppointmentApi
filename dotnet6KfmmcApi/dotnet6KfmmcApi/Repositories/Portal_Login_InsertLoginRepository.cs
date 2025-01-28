using dotnet6KfmmcApi.Controllers;
using dotnet6KfmmcApi.Entities;
using KfmmcAppointmentApi.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace KfmmcAppointmentApi.Repositories
{
    public class Portal_Login_InsertLoginRepository
    {
        private readonly string _connectionString;

        public Portal_Login_InsertLoginRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public async Task<IEnumerable<Portal_Login_InsertLogin>> Portal_Login_InsertLogin( string nat_id)
        {
            var Portal_Login_InsertLogin = new List<Portal_Login_InsertLogin>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand("Portal_Login_InsertLogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nationalID", nat_id);
                    
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Portal_Login_InsertLogin.Add(new Portal_Login_InsertLogin
                            {
                                nat_id = reader.IsDBNull(0) ? null : reader.GetString(0),
                                auth_code = reader.IsDBNull(1) ? null : reader.GetString(1),
                                mobile = reader.IsDBNull(2) ? null : reader.GetString(2),
                                status = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Sms = reader.IsDBNull(4) ? null : reader.GetString(4)

                            });
                        }
                    }
                }
            }
            return Portal_Login_InsertLogin;
        }

        public async Task<IEnumerable<Portal_Mobile_InsertCode>> Portal_Mobile_InsertCode(string nat_id, string newMobile)
        {
            var _Portal_Mobile_InsertCode = new List<Portal_Mobile_InsertCode>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand("Portal_Mobile_InsertCode", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nationalID", nat_id);
                    command.Parameters.AddWithValue("@newMobile", newMobile);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            _Portal_Mobile_InsertCode.Add(new Portal_Mobile_InsertCode
                            {
                                nat_id = reader.IsDBNull(0) ? null : reader.GetString(0),
                                auth_code = reader.IsDBNull(1) ? null : reader.GetString(1),
                                mobile = reader.IsDBNull(2) ? null : reader.GetString(2),
                                status = reader.IsDBNull(3) ? null : reader.GetInt32(3),
                                Sms = reader.IsDBNull(4) ? null : reader.GetString(4)
                                
                            });
                        }
                    }
                }
            }
            return _Portal_Mobile_InsertCode;
        }

        public async Task<IEnumerable<Portal_TemporaryMobile_InsertRequest>> Portal_TemporaryMobile_InsertRequest(string nat_id, string oldMobile, string newMobile)
        {
            var _Portal_TemporaryMobile_InsertRequest = new List<Portal_TemporaryMobile_InsertRequest>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand("Portal_TemporaryMobile_InsertRequest", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nationalID", nat_id);
                    command.Parameters.AddWithValue("@oldMobile", oldMobile);
                    command.Parameters.AddWithValue("@newMobile", newMobile);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            _Portal_TemporaryMobile_InsertRequest.Add(new Portal_TemporaryMobile_InsertRequest
                            {
                                nat_id = reader.IsDBNull(0) ? null : reader.GetString(0),
                                auth_code = reader.IsDBNull(1) ? null : reader.GetString(1),
                                mobile = reader.IsDBNull(2) ? null : reader.GetString(2),
                                status = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Sms = reader.IsDBNull(4) ? null : reader.GetString(4)

                            });
                        }
                    }
                }
            }
            return _Portal_TemporaryMobile_InsertRequest;
        }

      
    }
    

}
