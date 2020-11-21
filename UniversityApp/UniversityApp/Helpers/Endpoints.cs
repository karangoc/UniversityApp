﻿namespace UniversityApp.Helpers
{
    public class Endpoints
    {
        #region Courses
        public static string GET_COURSES = "api/Courses/GetCourses/";
        public static string GET_COURSE = "api/Courses/GetCourse/";
        public static string GET_COURSE_BY_STUDENT = "api/Courses/GetCoursesByStudentId/";
        public static string GET_COURSE_BY_INSTRUCTOR = "api/Courses/GetCoursesByInstructorId/";
        public static string POST_COURSES = "api/Courses/";
        public static string PUT_COURSES = "api/Courses/";
        public static string DELETE_COURSES = "api/Courses/"; 
        #endregion

        public static string GET_COURSE_INSTRUCTORS = "/api/CourseInstructors/";
    }
}
