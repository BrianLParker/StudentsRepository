// Copyright (c) 2024, Brian Parker. All Rights Reserved.
// GenerateStudents.razor.cs licensed under the MIT License.

using StudentsRepository.Models.Students;
using Tynamix.ObjectFiller;

namespace StudentsRepository.Components;

public class StudentFiller
{
    Filler<Student> studentFiller;
    public StudentFiller()
    {
        this.studentFiller = new Filler<Student>();

        studentFiller.Setup()
            .OnProperty(x => x.Id).IgnoreIt()
            .OnProperty(x => x.FamilyName).Use(new RealNames(NameStyle.FirstName))
            .OnProperty(x => x.GivenName).Use(new RealNames(NameStyle.LastName));
    }

    public Student CreateStudent() => studentFiller.Create();
}