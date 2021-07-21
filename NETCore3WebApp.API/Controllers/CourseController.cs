using Microsoft.AspNetCore.Mvc;
using NETCore3WebApp.Business;


namespace NETCore3WebApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseManager _entityManager;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(MyEntityController));

        public CourseController(ICourseManager entityManager)
        {
            _entityManager = entityManager;
        }

        [HttpGet("{id}")]
        public Domain.Course Get(int id)
        {
            log.Debug("MyController Get Method");
            return _entityManager.GetCourse(id);
        }
    }
}
