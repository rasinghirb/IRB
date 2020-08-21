using IRB.Data;
using IRB.Data.Ennum;
using IRB.Models;
using IRB.ModelsData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.Repository
{
    public class MasterRollRepository
    {
        private SqlConnection con;
        //To Handle connection related activities
        private void connection()
        {
            string connectionString = ConnectionString._DCS; ;
            con = new SqlConnection(connectionString);

        }
        private readonly ApplicationDbContext _dBcontext;
        public MasterRollRepository(ApplicationDbContext Dbcontext)
        {
            _dBcontext = Dbcontext;
        }



        private string message = string.Empty;
        [ViewData]
        //MASTERROLL SECTION//
        public string Title { get; set; }
        //get userlist by joining various table
        public List<MasterRollModel> FindAll()
        {
            connection();
            List<Models.MasterRollModel> EmpList = new List<Models.MasterRollModel>();
            SqlCommand com = new SqlCommand("SptableMasterRollFind1", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            //Bind MasterRollModel generic list using LINQ 
            EmpList = (from DataRow dr in dt.Rows

                       select new MasterRollModel()
                       {
                           PISNo = Convert.ToInt32(dr["PISNo"]),
                           Name = Convert.ToString(dr["Name"]),
                           Rank = (rank)Convert.ToInt32(dr["Rank"]),
                           Coy = (coy)Convert.ToInt32(dr["Coy"]),
                           NextOfKin = Convert.ToString(dr["NextOfKin"]),
                           RelationwithNextofKin = (relationShip)Convert.ToInt32(dr["RelationwithNextofKin"]),
                           Address1 = Convert.ToString(dr["Address1"]),
                           AddressPatelat = (patelat)Convert.ToInt32(dr["AddressPatelat"]),
                           AddressState = (state)Convert.ToInt32(dr["AddressState"]),
                           EmailAdd = Convert.ToString(dr["emailAdd"]),
                           MobileNo = Convert.ToString(dr["MobileNo"]),
                           EmergencyContactNo = Convert.ToString(dr["EmergencyContactNo"]),
                           Education = (education)Convert.ToInt32(dr["Education"]),
                           BloodGroup = (bloodGroup)Convert.ToInt32(dr["BloodGroup"]),
                           DoB = Convert.ToDateTime(dr["DoB"]).Date,
                           Doj = Convert.ToDateTime(dr["Doj"]).Date,
                           Category = (category)Convert.ToInt32(dr["Category"]),
                           Religion = (religion)Convert.ToInt32(dr["Religion"]),
                           MaritialStatus = (martialStatus)Convert.ToInt32(dr["MaritialStatus"]),
                           PlaceofPosting = (placeOfPosting)Convert.ToInt32(dr["PlaceofPosting"]),
                           Status = Convert.ToInt32(dr["Status"]),
                           ImageUrl = Convert.ToString(dr["ImageUrl"]),
                           Wef = Convert.ToDateTime(dr["wef"]).Date,
                           AdharNo = Convert.ToString(dr["AdharNo"]),
                           PanNo = Convert.ToString(dr["PanNo"]),
                           FatherName = Convert.ToString(dr["fatherName"]),

                       }).ToList();
            return EmpList;
        }


        ////To Add new User record    
        public bool Add(MasterRollModel userMR)
        {
            connection();
            SqlCommand cmd = new SqlCommand("SptableMasterRollInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PISNo", userMR.PISNo);
            cmd.Parameters.AddWithValue("@Name", userMR.Name);
            cmd.Parameters.AddWithValue("@Rank", userMR.Rank);
            cmd.Parameters.AddWithValue("@NextofKin", userMR.NextOfKin);
            cmd.Parameters.AddWithValue("@Relation", userMR.RelationwithNextofKin);
            cmd.Parameters.AddWithValue("@Coy", userMR.Coy);
            cmd.Parameters.AddWithValue("@DoB", userMR.DoB);
            cmd.Parameters.AddWithValue("@Address1", userMR.Address1);
            cmd.Parameters.AddWithValue("@Patelat", userMR.AddressPatelat);
            cmd.Parameters.AddWithValue("@State", userMR.AddressState);
            cmd.Parameters.AddWithValue("@Bloodgroup", userMR.BloodGroup);
            cmd.Parameters.AddWithValue("@Doj", userMR.Doj);
            cmd.Parameters.AddWithValue("@MobileNo", userMR.MobileNo);
            cmd.Parameters.AddWithValue("@MaritialStatus", userMR.MaritialStatus);
            cmd.Parameters.AddWithValue("@category", userMR.Category);
            cmd.Parameters.AddWithValue("@Religion", userMR.Religion);
            cmd.Parameters.AddWithValue("@Education", userMR.Education);
            cmd.Parameters.AddWithValue("@Placeofposting", userMR.PlaceofPosting);
            cmd.Parameters.AddWithValue("@EmailAdd", userMR.EmailAdd);
            cmd.Parameters.AddWithValue("@EmergencyContact", userMR.EmergencyContactNo);
            cmd.Parameters.AddWithValue("@url", userMR.ImageUrl);
            cmd.Parameters.AddWithValue("@wef", userMR.Wef);
            cmd.Parameters.AddWithValue("@adharNo", userMR.AdharNo);
            cmd.Parameters.AddWithValue("@panno", userMR.PanNo);
            cmd.Parameters.AddWithValue("@fatherName", userMR.FatherName);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {

                return false;
            }

        }
        ////To Update the records of a particluar employee  
        public bool Update(MasterRollModel userMR)
        {
            connection();
            SqlCommand cmd = new SqlCommand("[SptableMasterRollUpdate]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PISNo", userMR.PISNo);
            cmd.Parameters.AddWithValue("@Name", userMR.Name);
            cmd.Parameters.AddWithValue("@Rank", userMR.Rank);
            cmd.Parameters.AddWithValue("@NextofKin", userMR.NextOfKin);
            cmd.Parameters.AddWithValue("@Relation", userMR);
            cmd.Parameters.AddWithValue("@Coy", userMR.Coy);
            cmd.Parameters.AddWithValue("@DoB", userMR.DoB);
            cmd.Parameters.AddWithValue("@Address1", userMR.Address1);
            cmd.Parameters.AddWithValue("@Patelat", userMR.AddressPatelat);
            cmd.Parameters.AddWithValue("@State", userMR.AddressState);
            cmd.Parameters.AddWithValue("@Bloodgroup", userMR.BloodGroup);
            cmd.Parameters.AddWithValue("@Doj", userMR.Doj);
            cmd.Parameters.AddWithValue("@MobileNo", userMR.MobileNo);
            cmd.Parameters.AddWithValue("@MaritialStatus", userMR.MaritialStatus);
            cmd.Parameters.AddWithValue("@category", userMR.Category);
            cmd.Parameters.AddWithValue("@Religion", userMR.Religion);
            cmd.Parameters.AddWithValue("@Education", userMR.Education);
            cmd.Parameters.AddWithValue("@Placeofposting", userMR.PlaceofPosting);
            cmd.Parameters.AddWithValue("@EmailAdd", userMR.EmailAdd);
            cmd.Parameters.AddWithValue("@EmergencyContact", userMR.EmergencyContactNo);
            cmd.Parameters.AddWithValue("@url", userMR.ImageUrl);
            cmd.Parameters.AddWithValue("@adharNo", userMR.AdharNo);
            cmd.Parameters.AddWithValue("@panno", userMR.PanNo);
            cmd.Parameters.AddWithValue("@fatherName", userMR.FatherName);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {

                return false;
            }

        }

        ////Get the details of a particular User by ID 
        public MasterRollModel FindById(int pisno)
        {
            MasterRollModel user = new MasterRollModel();
            connection();
            SqlCommand cmd = new SqlCommand("[SptableMasterRollFind]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PISNo", pisno);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                user.PISNo = Convert.ToInt32(dr["PISNo"]);
                user.Name = Convert.ToString(dr["Name"]);
                user.Rank = (rank)Convert.ToInt32(dr["Rank"]);
                user.Coy = (coy)Convert.ToInt32(dr["Coy"]);
                user.NextOfKin = Convert.ToString(dr["NextOfKin"]);
                user.RelationwithNextofKin = (relationShip)Convert.ToInt32(dr["RelationwithNextofKin"]);
                user.Address1 = Convert.ToString(dr["Address1"]);
                user.AddressPatelat = (patelat)Convert.ToInt32(dr["AddressPatelat"]);
                user.AddressState = (state)Convert.ToInt32(dr["AddressState"]);
                user.EmailAdd = Convert.ToString(dr["emailAdd"]);
                user.MobileNo = Convert.ToString(dr["MobileNo"]);
                user.EmergencyContactNo = Convert.ToString(dr["EmergencyContactNo"]);
                user.Education = (education)Convert.ToInt32(dr["Education"]);
                user.BloodGroup = (bloodGroup)Convert.ToInt32(dr["BloodGroup"]);
                user.DoB = Convert.ToDateTime(dr["DoB"]).Date;
                user.Doj = Convert.ToDateTime(dr["Doj"]).Date;
                user.Category = (category)Convert.ToInt32(dr["Category"]);
                user.Religion = (religion)Convert.ToInt32(dr["Religion"]);
                user.MaritialStatus = (martialStatus)Convert.ToInt32(dr["MaritialStatus"]);
                user.PlaceofPosting = (placeOfPosting)Convert.ToInt32(dr["PlaceofPosting"]);
                user.Status = Convert.ToInt32(dr["Status"]);
                user.ImageUrl = Convert.ToString(dr["ImageUrl"]);
                user.Wef = Convert.ToDateTime(dr["wef"]).Date;
                user.AdharNo = Convert.ToString(dr["AdharNo"]);
                user.PanNo = Convert.ToString(dr["PanNo"]);
                user.FatherName = Convert.ToString(dr["fatherName"]);

            }
            return user;
        }





        ////To Delete the record on a particular employee  
        //To delete Employee details
        public void Delete(int pisno)
        {

            connection();
            SqlCommand com = new SqlCommand("[SptableMasterRollDelete]", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@PISNo", pisno);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        //Get the details of a particular employee 
        public DataTable GetSPDataTable(int pisno)
        {
            DataTable retVal = new DataTable();
            //string _connectionString = "Enter your connection string here";
            connection();
            SqlCommand cmd = new SqlCommand("[SptableMasterRollFind]", con);
            cmd.Parameters.AddWithValue("@PISNo", pisno);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            try
            {
                con.Open();
                adp.Fill(retVal);
            }
            catch /*(Exception e)*/
            {
                //ex = e;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return retVal;
        }

    }
}
        //END MASTERROLL SECTION//


   
