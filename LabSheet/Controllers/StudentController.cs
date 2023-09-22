using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MVCAPPLICATION.Models;
using NuGet.Protocol.Plugins;
using System;

namespace LabSheet.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddStudent()
        {
            StudentController stdInfo = new StudentController();
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(StudentsModel std)
        {
            string ConnectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Labsheet Database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();

            String Command = "Insert into Students (StudentName,Course,Address) values('" + std.StudentName + "','" + std.Course + "','" + std.Address + "')";
            SqlCommand cmd = new SqlCommand(Command, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
            //return ListStudent();
           // return RedirectToAction("ListStudent");
              return View();
        }

        public IActionResult ListStudent()
        {
            string ConnectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Labsheet Database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();

            String Command = "Select * from Students";
            SqlCommand cmd = new SqlCommand(Command, Connection);
            SqlDataReader sr = cmd.ExecuteReader();
            List<StudentsModel> list = new List<StudentsModel>();
            while (sr.Read())
            {
                StudentsModel std = new StudentsModel();
                std.Id = Convert.ToInt32(sr["Id"]);
                std.StudentName = sr["StudentName"].ToString();
                std.Course = sr["Course"].ToString();
                std.Address = sr["Address"].ToString();
                list.Add(std);
            }
            Connection.Close();

            return View(list);
        }

    }
}