using System;
//using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace Week5ADO_DAL
{
    public class DBConnection
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;
        public string ConnectToDb()
        {
            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                //string conStr = ConfigurationManager.ConnectionStrings["mywork"].ToString();
                sqlConObj.Open();
                return sqlConObj.State.ToString();

            }

            catch (Exception)
            {
                return sqlConObj.State.ToString();

            }

            finally 
            {

                sqlConObj.Close();

            }
        }
        //Assessment table
        public List<string> AssessmentTypes()
        {
            List<string> lstProduct = new List<string>();

            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                sqlCmdObj = new SqlCommand(@"SELECT AssessmentId,Name From [Mini-Project].[dbo].[Assessments]", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();
                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct["AssessmentId"], drProduct["Name"]));

                }

                return lstProduct;
            }

            catch (Exception)
            {
                lstProduct.Add("Something went wrong");
                return lstProduct;

            }
            finally
            {
                sqlConObj.Close();
             }




        }


        //Batch table
        public List<string> BatchDetails()
        {
            List<string> lstProduct = new List<string>();

            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                sqlCmdObj = new SqlCommand(@"SELECT NewBatchID,ModelId,DateOfStart FROM [Mini-Project].[dbo].[Batch]", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();
                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct[" NewBatchID "], drProduct[" ModelId "], drProduct[" DateOfStart "]));

                }

                return lstProduct;
            }

            catch (Exception)
            {
                lstProduct.Add("Something went wrong");
                return lstProduct;

            }
            finally
            {
                sqlConObj.Close();
            }




        }


        //BatchFaculty Table
        public List<string> BatchFacultyDeatils()
        {
            List<string> lstProduct = new List<string>();

            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                sqlCmdObj = new SqlCommand(@"SELECT CourseId,BatchId,FacultyId From [Mini-Project].[dbo].[BatchFaculty]", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();
                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct["CourseId"], drProduct["BatchId"], drProduct["FacultyId"]));

                }

                return lstProduct;
            }

            catch (Exception)
            {
                lstProduct.Add("Something went wrong");
                return lstProduct;

            }
            finally
            {
                sqlConObj.Close();
            }




        }

        //Course table
        public List<string> CourseDetails()
        {
            List<string> lstProduct = new List<string>();

            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                sqlCmdObj = new SqlCommand(@"SELECT CourseId,CourseOwner,CourseTitle,AssessmentId,HoursAssigned,CourseSyllabus From [Mini-Project].[dbo].[Course]", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();
                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct["CourseId"], drProduct["CourseOwner"], drProduct["CourseTitle"], drProduct["AssessmentId"], drProduct["HoursAssigned"], drProduct["CourseSyllabus"]));

                }

                return lstProduct;
            }

            catch (Exception)
            {
                lstProduct.Add("Something went wrong");
                return lstProduct;

            }
            finally
            {
                sqlConObj.Close();
            }




        }


        //course_Faculty table
        public List<string> CourseFacultyDetails()
        {
            List<string> lstProduct = new List<string>();

            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                sqlCmdObj = new SqlCommand(@"SELECT Cid,Pid From [Mini-Project].[dbo].[course_Faculty]", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();
                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct["Cid"], drProduct["Pid"]));

                }

                return lstProduct;
            }

            catch (Exception)
            {
                lstProduct.Add("Something went wrong");
                return lstProduct;

            }
            finally
            {
                sqlConObj.Close();
            }




        }

        //Faculty table
        public List<string> FacultyDetails()
        {
            List<string> lstProduct = new List<string>();

            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                sqlCmdObj = new SqlCommand(@"SELECT Psnumber,EmailId,Name From [Mini-Project].[dbo].[Faculty]", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();
                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct["Psnumber"], drProduct["EmailId"], drProduct["Name"]));

                }

                return lstProduct;
            }

            catch (Exception)
            {
                lstProduct.Add("Something went wrong");
                return lstProduct;

            }
            finally
            {
                sqlConObj.Close();
            }




        }

        //Grader table
        public List<string> GraderDetails()
        {
            List<string> lstProduct = new List<string>();

            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                sqlCmdObj = new SqlCommand(@"SELECT NewBatchId,CourseId,Result From [Mini-Project].[dbo].[Grader]", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();
                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct["NewBatchId"], drProduct["CourseId"], drProduct["Result"]));

                }

                return lstProduct;
            }

            catch (Exception)
            {
                lstProduct.Add("Something went wrong");
                return lstProduct;

            }
            finally
            {
                sqlConObj.Close();
            }




        }

        //Model table
        public List<string> ModelDetails()
        {
            List<string> lstProduct = new List<string>();

            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                sqlCmdObj = new SqlCommand(@"SELECT ModelId,ModelName  From [Mini-Project].[dbo].[Model]", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();
                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct["ModelId"], drProduct["ModelName"]));

                }

                return lstProduct;
            }

            catch (Exception)
            {
                lstProduct.Add("Something went wrong");
                return lstProduct;

            }
            finally
            {
                sqlConObj.Close();
            }




        }

        //Model_course_map table
        public List<string> ModelCourseMapDetails()
        {
            List<string> lstProduct = new List<string>();

            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                sqlCmdObj = new SqlCommand(@"SELECT ModelId,CourseId  From [Mini-Project].[dbo].[Model_course_map]", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();
                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct["ModelId"], drProduct["CourseId"]));

                }

                return lstProduct;
            }

            catch (Exception)
            {
                lstProduct.Add("Something went wrong");
                return lstProduct;

            }
            finally
            {
                sqlConObj.Close();
            }




        }


        //Trainee table
        public List<string> TraineeDetails()
        {
            List<string> lstProduct = new List<string>();

            try
            {
                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["mywork"].ToString());
                sqlCmdObj = new SqlCommand(@"SELECT NewBatchID,EmailId,Tsnumber  From [Mini-Project].[dbo].[Trainee]", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();
                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct["NewBatchID"], drProduct["EmailId"],drProduct["Tsnumber"]));

                }

                return lstProduct;
            }

            catch (Exception)
            {
                lstProduct.Add("Something went wrong");
                return lstProduct;

            }
            finally
            {
                sqlConObj.Close();
            }




        }
    }
}
