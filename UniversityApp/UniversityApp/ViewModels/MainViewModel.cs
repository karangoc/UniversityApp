﻿namespace UniversityApp.ViewModels
{
    public class MainViewModel
    {
        public CoursesViewModel Courses { get; set; }
        public CourseInstructorsViewModel CourseInstructors { get; set; }
        public MoviesViewModel Movies { get; set; }

        public MainViewModel()
        {
            Courses = new CoursesViewModel();
            CourseInstructors = new CourseInstructorsViewModel();
            //Movies = new MoviesViewModel();
        }
    }
}
