using System;
using System.Collections.Generic;

namespace MVC_Nested_Checkbox_Demo.Models
{
    public class NotificationSettings
    {
        public Dictionary<int, ProjectFollows> ProjectFollows { get; set; }

        public bool UpdatesFromProjectsIlike { get; set; }

        public bool UpdatesFromMovementsImFollowing { get; set; }

        public bool NotificationsAboutProjectsICreate { get; set; }

        public bool Newsletter { get; set; }
    }
}