
using orientacaoObjeto.NotificationContext;
using orientacaoObjeto.SharedContext;

namespace orientacaoObjeto.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;
            if (Course == null)
            {
                AddNotification(new Notification("Course", "Curso inválido"));
            }
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}