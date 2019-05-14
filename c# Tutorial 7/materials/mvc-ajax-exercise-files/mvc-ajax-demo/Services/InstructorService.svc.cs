using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using mvc_ajax_demo.Models;
using System.Collections.Generic;

namespace mvc_ajax_demo.Services
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class InstructorService
    {
        [OperationContract]
        public List<InstructorDTO> GetInstructorNames()
        {
            var repository = new InstructorRepository();
            var names =
                     from i in repository.FindAll()
                     select new InstructorDTO
                     {
                         ID = i.ID,
                         Name = i.Name
                     };
            return names.ToList();
        }

        [OperationContract]
        public Instructor GetInstructorDetails(int id)
        {
            var repository = new InstructorRepository();
            var instructor = repository.FindByID(id);
            return instructor;
        }
    }
}
