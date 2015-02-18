using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    using System.Collections;
    using System.Runtime.Remoting.Messaging;

    public static class ObjectCreator
    {
        public static IEnumerable<Name> GetDoctorNames()
        {
            var names = new List<Name>
            {
                new Name { First = "Doogie", Last = "Howser" },
                new Name { First = "Leonard", Middle = "Bones", Last = "McCoy" },
                new Name { First = "Hawkeye", Last = "Piece" },
                new Name { First = "Abraham", Middle ="Van", Last = "Helsing" },
                new Name { First = "Victor", Last = "Frankenstein" },
                new Name { First = "Hannibal", Last = "Lecter" },
                new Name { First = "John",  Last = "DoLittle" },
                new Name { First = "Henry", Last = "Jekyll" },
                 new Name { First = "Dr", Last = "House" }
                };

            return names;
        }

        public static IEnumerable<Name> GetPatientNames()
        {
            var patients = new List<Name>
                               {
                                   new Name { First = "Bugs", Last = "Bunny"},
                                   new Name { First = "Daffy",  Last = "Duck" },
                                   new Name { First = "Porky", Last = "Pig" },
                                   new Name { First = "Pepe", Middle = "Le", Last = "Pew" },
                                   new Name { First = "Marvin", Last = "Martin" },
                                   new Name { First = "Foghorn", Last = "Leghorn" },
                                   new Name { First = "Speedy", Last = "Gonzales" },
                                   new Name { First = "Elmer", Last = "Fudd" },
                                   new Name { First = "Tasmanian", Last = "Devil" }
                               };
            return patients;
        }

        public static IEnumerable<Speciality> GetSpecialities()
        {
            var speciliates = new List<Speciality>
                                  {
                                      Speciality.Gastroenterologist,
                                      Speciality.General,
                                      Speciality.Herbalist,
                                      Speciality.Podiatrist,
                                      Speciality.Surgeon,
                                      Speciality.pharmacist
                                  };

            return speciliates;
        }

        public static IEnumerable<Doctor> GetDoctors()
        {
            var doctors =
                Enumerable.Range(0, 10)
                    .Select(i => new Doctor
                                    {
                                        Id = i,
                                        Name = GetDoctorNames().GetRandom(),
                                        Specialties = new List<Speciality> { GetSpecialities().GetRandom() }
                                    });
            return doctors;
        }

        public static IEnumerable<string> GetRooms()
        {
            var rooms = Enumerable.Range(0, 10).Select(i => string.Format("{0}{1}", i * 3, i));
            return rooms;
        }

        public static IEnumerable<Patient> GetPatients()
        {
            var patients =
                Enumerable.Range(0, 10)
                    .Select(
                        i =>
                        new Patient
                            {
                                Doctors = new List<Doctor> { GetDoctors().GetRandom(), GetDoctors().GetRandom() },
                                Name = GetPatientNames().GetRandom(),
                                Room = GetRooms().GetRandom()
                            });
            return patients;
        }
    }
}