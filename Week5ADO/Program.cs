using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5ADO_DAL;


namespace Week5ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection obj = new DBConnection();

            //Assessemnt table
            var result = obj.AssessmentTypes();
            Console.WriteLine("***********Assessment Types***********");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //Batch table
            var result1 = obj.BatchDetails();
            Console.WriteLine("***********Batch Details****************");
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            //BatchFaculty table
            
             var result2 = obj.BatchFacultyDeatils();
            Console.WriteLine("***********Batch and Faculty Mapping***********");
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            //Course table
            
             var result3 = obj.CourseDetails();
            Console.WriteLine("***********Courses Details***********");
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }

            //course_Faculty table

            var result4 = obj.CourseFacultyDetails();
            Console.WriteLine("***********Courses Faculty Details***********");
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }

            //Faculty table

            var result5 = obj.FacultyDetails();
            Console.WriteLine("***********Faculty Details***********");
            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }

            //Grader table

            var result6 = obj.GraderDetails();
            Console.WriteLine("***********Grader Details***********");
            foreach (var item in result6)
            {
                Console.WriteLine(item);
            }

            // Model table

            var result7 = obj.ModelDetails();
            Console.WriteLine("*********** Model Details***********");
            foreach (var item in result7)
            {
                Console.WriteLine(item);
            }

            //Model_course_map  table

            var result8 = obj.ModelCourseMapDetails();
            Console.WriteLine("***********ModelCourseMap Details***********");
            foreach (var item in result8)
            {
                Console.WriteLine(item);
            }

            //Trainee table

            var result9 = obj.TraineeDetails();
            Console.WriteLine("***********Trainee Details***********");
            foreach (var item in result9)
            {
                Console.WriteLine(item);
            }







            /*
            SqlConnection sqlConObj = new SqlConnection();
            // SqlConnection sqlConObj2 = new SqlConnection();
            try
            {
                sqlConObj.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                // sqlConObj2.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlConObj.Open();
                Console.WriteLine(sqlConObj.State);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            finally {
                sqlConObj.Close();

            }*/



        }
    }
}
