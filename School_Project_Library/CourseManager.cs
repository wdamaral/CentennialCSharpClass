using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment1
{
    public class CourseManager
    {
        private Course[] courses;
        private int numberOfCourses;

        public CourseManager()
        {
            this.courses = new Course[100];
        }

        public Course[] Courses
        {
            get { return courses; }
        }

        public int NumberOfCourses
        {
            get { return numberOfCourses; }
        }

        public void AddCourse(Course course)
        {
            this.courses[numberOfCourses++] = course;
        }

        public void ExportCourses(string fileName, char delimiter)
        {
            FileStream fileOut = null;
            StreamWriter writer;
            try
            {
                fileOut = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(fileOut);
                for (int i = 0; i < numberOfCourses; i++)
                {
                    string line = string.Format("{0}{1}{2}{3}{4}{5}{6}", courses[i].CourseCode, delimiter, courses[i].Name, delimiter,
                                                courses[i].Description, delimiter, courses[i].NoOfEvaluations);
                    writer.WriteLine(line);
                }
                writer.Close();
                fileOut.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Fail to save the data.");
            }
            finally
            {
                if (fileOut != null)
                {
                    fileOut.Close();
                }
            }
        }

        public void ImportCourses(string fileName, char delimiter)
        {
            FileStream fileIn = null;
            StreamReader reader;
            string ex;
            bool error;
            int itemsAdded = 0;
            int totalItems = 0;
            string fullLine;

            try
            {
                fileIn = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fileIn);

                while((fullLine = reader.ReadLine()) != null)
                {
                    ++totalItems;
                    error = false;

                    string[] fullLineSplit = fullLine.Split(delimiter);
                    if (fullLineSplit.Length != 4)
                    {
                        ex = String.Format("Invalid number of fields in record {0}", totalItems);
                        Console.WriteLine(ex);
                        error = true;
                    }
                    else
                    {
                        for (int j = 0; j < numberOfCourses; j++)
                        {
                            if (fullLineSplit[0] == courses[j].CourseCode)
                            {
                                ex = String.Format("Course code in record {0} is in use", totalItems);
                                Console.WriteLine(ex);
                                error = true;
                            }
                        }

                        int noOfEvaluations;
                        bool isNumber = int.TryParse(fullLineSplit[3], out noOfEvaluations);

                        if (!isNumber)
                        {
                            ex = String.Format("Number of evaluations in record {0} is not in correct format.", totalItems);
                            Console.WriteLine(ex);
                            error = true;
                        }

                        if (!error)
                        {
                            Course courseToAdd = new Course()
                            {
                                CourseCode = fullLineSplit[0],
                                Name = fullLineSplit[1],
                                Description = fullLineSplit[2],
                                NoOfEvaluations = int.Parse(fullLineSplit[3])
                            };
                            AddCourse(courseToAdd);
                            itemsAdded++;
                        }

                    }
                }
                
                reader.Close();
                fileIn.Close();
            }
            catch (IOException)
            {
                ex = String.Format("Fail to read the file {0}", fileName);
                throw new Exception(ex);
            }
            finally
            {
                if (fileIn != null)
                {
                    fileIn.Close();
                }
                Console.WriteLine("{0} records processed, {1} courses added", totalItems, itemsAdded);
            }
        }

        public void SaveSchoolInfo()
        {
            const string FILE_NAME = "user.dat";

            BinaryFormatter binFormatter = new BinaryFormatter();
            FileStream fileOut = new FileStream(FILE_NAME, FileMode.Create, FileAccess.Write);
            binFormatter.Serialize(fileOut, courses);
            fileOut.Close();
        }

        public void LoadSchool(string fileName)
        {
            int i = 0;
            BinaryFormatter binFormat = new BinaryFormatter();
            FileStream fileIn = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            courses = (Course[])binFormat.Deserialize(fileIn);

            while(courses[i] != null)
            {
                i++;
            }
            this.numberOfCourses = i;
            fileIn.Close();
        }
    }
}
