using StudentsRepository.Client.Models.ApiContexts;
using StudentsRepository.Client.Models.ApiSets;
using StudentsRepository.Client.Models.Students;

namespace StudentsRepository.Client.Data;

public class ApplicationApiContext : ApiContext
{
    internal ApiSet<Student> Students { get; set; } = default!;
}
