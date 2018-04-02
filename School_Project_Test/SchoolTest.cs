using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Assignment1
{
    [TestClass]
    public class SchoolTest
    {

        #region Testing Course class
        [TestMethod]
        public void AddSection_WithInvalidSection_ShouldThrowInvalidSection()
        {
            //arrange
            Course aCourse = new Course("COMP123", "Programming 2");
            Section aSection = new Section();

            try { 
                aCourse.AddSection(aSection);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Course.SectionIsNotValidMessage);
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void AddSectionV2_WithValidSection_ShouldNotThrowError()
        {
            //arrange
            Course aCourse = new Course("COMP123", "Programming 2");
            
            try
            {
                aCourse.AddSection(SemesterPeriod.FALL, "Test123", "Test");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Course.SectionIsNotValidMessage);
                return;
            }

            //Assert.Fail();
        }

        [TestMethod]
        public void AddSection_WithValidSectionAlreadyAssignedToAnotherCourse_ShouldThrowSectionAlreadyAssigned()
        {
            //arrange
            Course aCourse = new Course("COMP123", "Programming 2");
            Section aSection = new Section(aCourse, SemesterPeriod.FALL)
            {
                SectionId = "006",
                Name = "Test"
            };

            Course bCourse = new Course("COMP100", "Programming 1");

            try
            {
                bCourse.AddSection(aSection);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Course.SectionAlreadyAssignedMessage);
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void AddSection_WithValidSection_ShouldNotThrowError()
        {
            //arrange
            Course aCourse = new Course("COMP123", "Programming 2");
            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            try
            {
                aCourse.AddSection(aSection);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Course.SectionAlreadyAssignedMessage);
                return;
            }

            //Assert.Fail();
        }

        [TestMethod]
        public void AddSection_WithValidSectionAndCourseSectionsFull_ShouldThrowIndexOutOfRange()
        {
            //arrange
            Course aCourse = new Course("COMP123", "Programming 2");

            Section[] sections = new Section[25];
            for (int i = 0; i < 25; i++)
            {
                sections[i] = new Section()
                {
                    SectionId = "0" + i,
                    Name = "Test"
                };
            }

            try
            {
                for (int i = 0; i < 25; i++)
                {
                    aCourse.AddSection(sections[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "Index was outside the bounds of the array.");
                return;
            }

            Assert.Fail();
        }
        [TestMethod]
        public void NoOfEvaluations_WithValidSectionAlreadyAssignedToCourse_ShouldThrowSectionAlreadyAssigned()
        {
            //arrange
            Course aCourse = new Course("COMP123", "Programming 2")
            {
                NoOfEvaluations = 5
            };
            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            aCourse.AddSection(aSection);
            
            try
            {
                aCourse.NoOfEvaluations = 20;
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Course.SectionAlreadyAssignedMessage);
                return;
            }

            Assert.Fail();
        
        }

        [TestMethod]
        public void NoOfEvaluations_WithNoSectionsAssigned_ShouldNotThrowError()
        {
            //arrange
            Course aCourse = new Course("COMP123", "Programming 2");

            try
            {
                aCourse.NoOfEvaluations = 20;
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Course.SectionAlreadyAssignedMessage);
                return;
            }

            //Assert.Fail();

        }

        #endregion

        #region Testing Section Class

        [TestMethod]
        public void AddStudent_WithSectionNotAssignedToCourse_ShouldThrowSectionNotAssignedToCourse()
        {
            //arrange
            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            Person aStudent = new Person();

            try
            {
                aSection.AddStudent(aStudent);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Section.SectionNotAssignedToCourse);
                return;
            }

            Assert.Fail();

        }

        [TestMethod]
        public void AddStudent_WithSectionAssignedToCourse_ShouldNotThrowError()
        {
            //arrange

            Course aCourse = new Course();

            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            aCourse.AddSection(aSection);

            Person aStudent = new Person();

            try
            {
                aSection.AddStudent(aStudent);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Section.SectionNotAssignedToCourse);
                return;
            }

            //Assert.Fail();

        }

        [TestMethod]
        public void AddStudent_WithSectionFull_ShouldThrowSectionIsFull()
        {
            //arrange

            Course aCourse = new Course("Test123", "A test name");

            Section aSection = new Section(aCourse, 0, SemesterPeriod.FALL)
            {
                SectionId = "006",
                Name = "Test"
            };

            Person aStudent = new Person();

            try
            {
                aSection.AddStudent(aStudent);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Section.SectionIsFull);
                return;
            }

            Assert.Fail();

        }

        [TestMethod]
        public void AddStudent_WithSectionNotFull_ShouldNotThrowError()
        {
            //arrange

            Course aCourse = new Course("Test123", "A test name");

            Section aSection = new Section(aCourse, 20, SemesterPeriod.FALL)
            {
                SectionId = "006",
                Name = "Test"
            };

            Person aStudent = new Person();

            try
            {
                aSection.AddStudent(aStudent);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Section.SectionIsFull);
                return;
            }

            //Assert.Fail();

        }

        [TestMethod]
        public void DefineEvaluation_WithCorrectEvaluationAndNoOfEvaluationsIsZero_ShouldThrowNoOfEvaluationsIsZero()
        {
            //arrange

            Course aCourse = new Course("Test123", "A test name");

            Section aSection = new Section(aCourse, 20, SemesterPeriod.FALL)
            {
                SectionId = "006",
                Name = "Test"
            };

            Person aStudent = new Person();

            aSection.AddStudent(aStudent);

            try
            {
                aSection.DefineEvaluation(5, EvaluationType.ASSIGNMENT,5,.3);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Section.NoOfEvaluationsIsZero);
                return;
            }

            Assert.Fail();

        }

        [TestMethod]
        public void DefineEvaluation_WithCorrectEvaluationAndNoOfEvaluations_ShouldNotThrowError()
        {
            //arrange

            int evaluationNo = 1;
            int noOfEvaluations = 3;

            Course aCourse = new Course("Test123", "A test name")
            {
                NoOfEvaluations = noOfEvaluations
            };

            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            aCourse.AddSection(aSection);

            Person aStudent = new Person();

            aSection.AddStudent(aStudent);


            try
            {
                aSection.DefineEvaluation(evaluationNo, EvaluationType.ASSIGNMENT, 5, .3);
            }
            catch (IndexOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "Index was outside the bounds of the array.");
                return;
            }

            //Assert.Fail();

        }

        [TestMethod]
        public void DefineEvaluation_WithCorrectEvaluationAndNoOfEvaluationsLessThanEvaluationNo_ShouldThrowIndexOutOfRange()
        {
            //arrange
            int evaluationNo = 5;
            int noOfEvaluations = 3;

            Course aCourse = new Course("Test123", "A test name")
            {
                NoOfEvaluations = noOfEvaluations
            };

            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            aCourse.AddSection(aSection);

            Person aStudent = new Person();

            aSection.AddStudent(aStudent);


            try
            {
                aSection.DefineEvaluation(evaluationNo, EvaluationType.ASSIGNMENT, 5, .3);
            }
            catch (IndexOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "Index was outside the bounds of the array.");
                return;
            }

            Assert.Fail();

        }

        [TestMethod]
        public void AddStudentMark_StudentNotAssignedToSection_ShouldThrowStudentNotInSection()
        {
            //arrange
            int evaluationNo = 1;
            int noOfEvaluations = 5;

            Course aCourse = new Course("Test123", "A test name")
            {
                NoOfEvaluations = noOfEvaluations
            };

            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            aCourse.AddSection(aSection);

            Person aStudent = new Person();
            Person bStudent = new Person();

            aSection.AddStudent(aStudent);
            aSection.DefineEvaluation(evaluationNo, EvaluationType.ASSIGNMENT, 5, .3);


            try
            {
                aSection.AddStudentMark(1, bStudent, 2);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Section.StudentIsNotInSection);
                return;
            }

            Assert.Fail();

        }

        [TestMethod]
        public void AddStudentMark_StudentAssignedToSection_ShouldNotThrowError()
        {
            //arrange
            int evaluationNo = 1;
            int noOfEvaluations = 5;

            Course aCourse = new Course("Test123", "A test name")
            {
                NoOfEvaluations = noOfEvaluations
            };

            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            aCourse.AddSection(aSection);

            Person aStudent = new Person();

            aSection.AddStudent(aStudent);
            aSection.DefineEvaluation(evaluationNo, EvaluationType.ASSIGNMENT, 5, .3);


            try
            {
                aSection.AddStudentMark(1, aStudent, 2);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Section.StudentIsNotInSection);
                return;
            }

            //Assert.Fail();
        }

        [TestMethod]
        public void AddStudentMark_MarkHigherThanMaxPoints_ShouldThrowPointsHigherThanMaxPoints()
        {
            //arrange
            int evaluationNo = 1;
            int noOfEvaluations = 5;
            int maxPoints = 5;
            int points = 10;

            Course aCourse = new Course("Test123", "A test name")
            {
                NoOfEvaluations = noOfEvaluations
            };

            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            aCourse.AddSection(aSection);

            Person aStudent = new Person();

            aSection.AddStudent(aStudent);
            aSection.DefineEvaluation(evaluationNo, EvaluationType.ASSIGNMENT, maxPoints, .3);


            try
            {
                aSection.AddStudentMark(1, aStudent, points);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Section.PointsHigherThanMaxPoints);
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void AddStudentMark_MarkLessThanMaxPoints_ShouldNotThrowError()
        {
            //arrange
            int evaluationNo = 1;
            int noOfEvaluations = 5;
            int maxPoints = 10;
            int points = 5;

            Course aCourse = new Course("Test123", "A test name")
            {
                NoOfEvaluations = noOfEvaluations
            };

            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            aCourse.AddSection(aSection);

            Person aStudent = new Person();

            aSection.AddStudent(aStudent);
            aSection.DefineEvaluation(evaluationNo, EvaluationType.ASSIGNMENT, maxPoints, .3);


            try
            {
                aSection.AddStudentMark(1, aStudent, points);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Section.PointsHigherThanMaxPoints);
                return;
            }

            //Assert.Fail();
        }
        [TestMethod]
        public void FinalMarksInfo_StudentAndMarksCreated_ShouldNotThrowError()
        {
            //arrange
            int evaluationNo = 1;
            int noOfEvaluations = 5;
            int maxPoints = 10;
            int points = 5;

            Course aCourse = new Course("Test123", "A test name")
            {
                NoOfEvaluations = noOfEvaluations
            };

            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            aCourse.AddSection(aSection);

            Person aStudent = new Person();

            aSection.AddStudent(aStudent);
            aSection.DefineEvaluation(evaluationNo, EvaluationType.ASSIGNMENT, maxPoints, .3);

            aSection.AddStudentMark(1, aStudent, points);

            try
            {
                aSection.FinalMarksInfo();

            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Random error");
                return;
            }

            //Assert.Fail();
        }

        [TestMethod]
        public void MaxNumberOfStudents_ValidNumber_ShouldNotThrowError()
        {
            //arrange
            int maxNoOfStudents = 1;
            
            
                try
                {
                    Section aSection = new Section()
                    {
                        MaxNumberOfStudents = maxNoOfStudents
                    };
                }
                catch (Exception ex)
                {
                    StringAssert.Contains(ex.Message, Evaluation.TypeValidNumber);
                    return;
                }
            
            //Assert.Fail();
        }

        [TestMethod]
        public void MaxNumberOfStudents_InvalidNumber_ShouldThrowTypeValidNumber()
        {
            //arrange
            int maxNoOfStudents = -1;


            try
            {
                Section aSection = new Section()
                {
                    MaxNumberOfStudents = maxNoOfStudents
                };
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Evaluation.TypeValidNumber);
                return;
            }

            //Assert.Fail();
        }

        #endregion

        #region Test CourseManager Class
        [TestMethod]
        public void ExportCourses_WithValidFileName_ShouldNotThrowError()
        {
            string fileName = "test.txt";

            CourseManager courseManager = new CourseManager();
            try
            {
                courseManager.ExportCourses(fileName, ';');
            }
            catch(Exception ex)
            {
                StringAssert.Contains(ex.Message, CourseManager.FailToSaveData);
                return;
            }
            //Assert.Fail();
        }

        
        [TestMethod]
        public void ImportCourses_WithInvalidFileName_ShouldThrowFailToReadTheFile()
        {
            //the file AdditionalCourses.txt must be in the same folder of the the
            //test compilation
            string fileName = "InvalidFileName.txt";

            CourseManager courseManager = new CourseManager();
            try
            {
                courseManager.ImportCourses(fileName, ',');
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Fail to read the file");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void ImportCourses_WithValidFileName_ShouldNotThrowError()
        {
            //the file AdditionalCourses.txt must be in the same folder of the the
            //test compilation
            string fileName = "AdditionalCourses.txt";

            CourseManager courseManager = new CourseManager();
            try
            {
                courseManager.ImportCourses(fileName, ',');
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Fail to read the file");
                return;
            }
            //Assert.Fail();
        }

        [TestMethod]
        public void SaveSchoolInfo_WithNoParameters_ShouldNotThrowError()
        {
            //the file user.dat must be in the same folder of the the
            //test compilation
            CourseManager courseManager = new CourseManager();
            try
            {
                courseManager.SaveSchoolInfo();
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Random error");
                return;
            }
            //Assert.Fail();
        }

        [TestMethod]
        public void LoadSchool_WithValidFileName_ShouldNotThrowError()
        {
            //the file user.dat must be in the same folder of the the
            //test compilation

            string fileName = "user.dat";
            CourseManager courseManager = new CourseManager();
            try
            {
                courseManager.LoadSchool(fileName);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Random error");
                return;
            }
            //Assert.Fail();
        }

        [TestMethod]
        public void LoadSchool_WithInvalidFileName_ShouldNotThrowError()
        {
            //the file user.dat must be in the same folder of the the
            //test compilation

            string fileName = "wrongFile.dat";
            CourseManager courseManager = new CourseManager();
            try
            {
                courseManager.LoadSchool(fileName);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, CourseManager.FailToOpenTheFile);
                return;
            }
            Assert.Fail();
        }

        #endregion

        #region Test Evaluation Class
        [TestMethod]
        public void CalcWeightAchived_WithValidNumbers_ShouldNotThrowError()
        {
            int maxPoints = 10;
            double weight = 0.5;
            int points = 8;
            Evaluation evaluation = new Evaluation(EvaluationType.TEST, maxPoints, weight);
            try
            {
                evaluation.CalcWeightAchived(points, maxPoints, weight);
            }
            catch(Exception ex)
            {
                StringAssert.Contains(ex.Message, "A random error");
                return;
            }
            //Assert.Fail();
        }

        [TestMethod]
        public void MaxPoints_WithInvalidParameter_ShouldThrowTypeValidNumber()
        {
            int maxPoints = 0;
            try
            {
                Evaluation evaluation = new Evaluation()
                {
                    MaxPoints = maxPoints
                };
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Evaluation.TypeValidNumber);
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void MaxPoints_WithValidParameter_ShouldNotThrowError()
        {
            int maxPoints = 10;
            try
            {
                Evaluation evaluation = new Evaluation()
                {
                    MaxPoints = maxPoints
                };
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Evaluation.TypeValidNumber);
                return;
            }
            //Assert.Fail();
        }

        [TestMethod]
        public void Weight_WithInvalidParameter_ShouldThrowTypeValidNumber()
        {
            int weight = 0;
            try
            {
                Evaluation evaluation = new Evaluation()
                {
                    EvaluationWeight = weight
                };
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Evaluation.TypeValidNumber);
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void Weight_WithValidParameter_ShouldNotThrowError()
        {
            int weight = 10;
            try
            {
                Evaluation evaluation = new Evaluation()
                {
                    EvaluationWeight = weight
                };
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Evaluation.TypeValidNumber);
                return;
            }
            //Assert.Fail();
        }

        [TestMethod]
        public void Points_WithValidParameter_ShouldNotThrowError()
        {
            int points = 10;
            try
            {
                Evaluation evaluation = new Evaluation()
                {
                    Points = points
                };
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Evaluation.TypeValidNumber);
                return;
            }
            //Assert.Fail();
        }

        [TestMethod]
        public void Points_WithInvalidParameter_ShouldThrowTypeValidNumber()
        {
            int points = -1;
            try
            {
                Evaluation evaluation = new Evaluation()
                {
                    Points = points
                };
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, Evaluation.TypeValidNumber);
                return;
            }
            Assert.Fail();
        }

        #endregion

        #region Test Enrolment Class

        [TestMethod]
        public void CalculateFinalGrade_StudentAndMarksCreated_ShouldNotThrowError()
        {
            //arrange
            int evaluationNo = 1;
            int noOfEvaluations = 5;
            int maxPoints = 10;
            int points = 5;

            Course aCourse = new Course("Test123", "A test name")
            {
                NoOfEvaluations = noOfEvaluations
            };

            Section aSection = new Section()
            {
                SectionId = "006",
                Name = "Test"
            };

            aCourse.AddSection(aSection);

            Person aStudent = new Person();

            aSection.AddStudent(aStudent);
            aSection.DefineEvaluation(evaluationNo, EvaluationType.ASSIGNMENT, maxPoints, .3);

            aSection.AddStudentMark(1, aStudent, points);
            Enrolment enrolment = new Enrolment(aSection, aStudent, 5);

            try
            {
                enrolment.CalculateFinalGrade();

            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Random error");
                return;
            }

            //Assert.Fail();
        }

        #endregion
    }
}
