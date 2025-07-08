using SharedGolfClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GolfCompanion.Services
{
    public class CourseInfoService
    {
        private readonly HttpClient _httpClient;
        GolfCourse Course = new GolfCourse();

        public CourseInfoService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<GolfCourse> GetCourseInfoAsync(int courseId)
        {
            var url = $"http://localhost:5189/api/golfcourse/{courseId}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            if(response.IsSuccessStatusCode)
            {
                Course = await response.Content.ReadFromJsonAsync<GolfCourse>();
            }
            return Course;
        }

    }
}
