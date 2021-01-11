using System;
using System.Collections.Generic;
using System.Text;

namespace DreamWedds.CommonLayer.Infrastructure.Security
{
    public class TaskSecurityProvider : ITaskSecurityProvider
    {
        public IEnumerable<ValidSecurityTask> ListAvailableTasks(int? userId = null)
        {
            throw new NotImplementedException();
        }

        public bool HasAccessTo(ApplicationTask applicationTask)
        {
            throw new NotImplementedException();
        }

        public bool HasAccessTo(ApplicationTask applicationTask, ApplicationTaskAccessLevel level)
        {
            throw new NotImplementedException();
        }

        public bool UserHasAccessTo(int userId, ApplicationTask applicationTask)
        {
            throw new NotImplementedException();
        }
    }
}
