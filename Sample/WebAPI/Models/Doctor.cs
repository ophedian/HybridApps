namespace WebAPI.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The doctor.
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Doctor"/> class.
        /// </summary>
        public Doctor()
        {
            this.Specialties = new List<Speciality>();
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Gets or sets the Doctor's specialties.
        /// </summary>
        public List<Speciality> Specialties { get; set; }
    }
}