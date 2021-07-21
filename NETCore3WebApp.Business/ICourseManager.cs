using System;
using System.Collections.Generic;
using System.Text;

namespace NETCore3WebApp.Business
{
    public interface ICourseManager
    {
        Domain.Course GetCourse(int id);        
    }
}
