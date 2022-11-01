using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCoures.Entities
{
    public interface ISubjects
    {
        void AddSubjects(string[] subject);
        string GetSubjects();
    }
}
