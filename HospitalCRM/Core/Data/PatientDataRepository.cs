using Core.Objects.Concrates;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;

namespace Core.Data
{
    public class PatientDataRepository
    {
        private string connection_string = "Server=BASCE; Database= HospitalCRM; Trusted_Connection=True;";

        private SqlConnection connection;

        public PatientDataRepository()
        {
            connection = new SqlConnection(connection_string);
        }

        public ResponseService Create(PatientEntity patient)
        {
            string query = "INSERT INTO HospitalCRM.dbo.Patient VALUES (@fname, @lname, @tck, @bdate, @btype, @gender, @smoke, @alcohol, @email,@phone, @city, @district, @address, @ctime, @active, @deleted, @utime, @dtime)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@fname", patient.Firstname);
            command.Parameters.AddWithValue("@lname", patient.Lastname);
            command.Parameters.AddWithValue("@tck", patient.TCKID);
            command.Parameters.AddWithValue("@bdate", patient.DateofBirth);
            command.Parameters.AddWithValue("@btype", patient.BloodType);
            command.Parameters.AddWithValue("@gender", patient.Gender);
            command.Parameters.AddWithValue("@smoke", patient.Smoke);
            command.Parameters.AddWithValue("@alcohol", patient.Alcohol);
            command.Parameters.AddWithValue("@email", patient.EMailAddress);
            command.Parameters.AddWithValue("@phone", patient.PhoneNumber);
            command.Parameters.AddWithValue("@city", patient.City);
            command.Parameters.AddWithValue("@district", patient.District);
            command.Parameters.AddWithValue("@address", patient.DetailedAddress);
            command.Parameters.AddWithValue("@ctime", patient.CreateTime);
            command.Parameters.AddWithValue("@active", patient.Active);
            command.Parameters.AddWithValue("@deleted", patient.Deleted);
            command.Parameters.Add("@utime", SqlDbType.DateTime).Value = DBNull.Value;
            command.Parameters.Add("@dtime", SqlDbType.DateTime).Value = DBNull.Value;

            ResponseService response = new ResponseService();
            try
            {
                connection.Open();
                int i = command.ExecuteNonQuery();
                response.Code = ResponseServiceCode.Success;
                response.Message = $"{i} Kayıt başarıyla eklendi.";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Code = ResponseServiceCode.Error;
                response.Message = ex.Message;
                response.Detail = ex.StackTrace;
                response.Status = false;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
            return response;
        }

        public void Update(PatientEntity patient)
        {
            string query = "UPDATE HospitalCRM.dbo.Patient SET UpdateTime = @utime WHERE Id=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", patient.Id);
            command.Parameters.AddWithValue("@utime", DateTime.Now);
        }

        public ResponseService Delete(int id)
        {
            string hard_delete_query = "DELETE FROM HospitalCRM.dbo.Patient WHERE Id=@id";
            string soft_delete_query = "UPDATE HospitalCRM.dbo.Patient SET Active = 0, Deleted = 1, DeleteTime = @dtime WHERE Id=@id";
            SqlCommand command = new SqlCommand(soft_delete_query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@dtime", DateTime.Now);

            ResponseService response = new ResponseService();
            try
            {
                connection.Open();
                int count = command.ExecuteNonQuery();
                response.Status = true;
                response.Code = ResponseServiceCode.Success;
                response.Message = $"{count} Kayıt silindi.";
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Code = ResponseServiceCode.Error;
                response.Message = ex.Message;
                response.Detail = ex.StackTrace;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
            return response;
        }

        public PatientEntity ReadOne(int id)
        {
            string query = "SELECT * FROM HospitalCRM.dbo.Patient WHERE Id=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);

            PatientEntity response = new PatientEntity();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        PatientEntity patient = new PatientEntity();
                        patient.Id = reader.GetInt32(0);
                        patient.Firstname = reader[1].ToString();
                        patient.Lastname = reader["Lastname"].ToString();
                        patient.TCKID = reader.GetInt64(3);
                        patient.DateofBirth = reader.GetDateTime(4);
                        patient.BloodType = reader.GetString(5);
                        patient.EMailAddress = reader["EMailAddress"].ToString();
                        patient.PhoneNumber = reader["PhoneNumber"].ToString();
                        patient.DetailedAddress = reader["DetailedAddress"].ToString();
                        patient.City = reader["City"].ToString();
                        patient.District = reader["District"].ToString();
                        patient.Smoke = (bool)reader["Smoke"];
                        patient.Alcohol = (bool)reader["Alcohol"];
                        patient.Gender = reader["Gender"].ToString();
                        patient.Active = (bool)reader["Active"];
                        patient.Deleted = (bool)reader["Deleted"];
                        patient.CreateTime = reader.GetDateTime(14);
                        patient.UpdateTime = reader.GetValue(17) != DBNull.Value ? reader.GetDateTime(17) : (DateTime?)null;
                        if (reader.GetValue(18) != DBNull.Value)
                        {
                            patient.DeleteTime = reader.GetDateTime(18);
                        }
                        else
                        {
                            patient.DeleteTime = null;
                        }
                        response = patient;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            return response;
        }

        public List<PatientEntity> ReadAll()
        {
            string query = "SELECT * FROM HospitalCRM.dbo.Patient WHERE Deleted = 0";
            SqlCommand command = new SqlCommand(query, connection);

            List<PatientEntity> response = new List<PatientEntity>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        PatientEntity patient = new PatientEntity();
                        patient.Id = reader.GetInt32(0);
                        patient.Firstname = reader[1].ToString();
                        patient.Lastname = reader["Lastname"].ToString();
                        patient.TCKID = reader.GetInt64(3);
                        patient.DateofBirth = reader.GetDateTime(4);
                        patient.BloodType = reader.GetString(5);
                        patient.EMailAddress = reader["EMailAddress"].ToString();
                        patient.PhoneNumber = reader["PhoneNumber"].ToString();
                        patient.DetailedAddress = reader["DetailedAddress"].ToString();
                        patient.City = reader["City"].ToString();
                        patient.District = reader["District"].ToString();
                        patient.Smoke = (bool)reader["Smoke"];
                        patient.Alcohol = (bool)reader["Alcohol"];
                        patient.Gender = reader["Gender"].ToString();
                        patient.Active = (bool)reader["Active"];
                        patient.Deleted = (bool)reader["Deleted"];
                        patient.CreateTime = reader.GetDateTime(14);
                        patient.UpdateTime = reader.GetValue(17) != DBNull.Value ? reader.GetDateTime(17) : (DateTime?)null;
                        if (reader.GetValue(18) != DBNull.Value)
                        {
                            patient.DeleteTime = reader.GetDateTime(18);
                        }
                        else
                        {
                            patient.DeleteTime = null;
                        }
                        response.Add(patient);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            return response;
        }
    }
}
