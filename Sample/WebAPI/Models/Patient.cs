namespace WebAPI.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Patient Record
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Gets or sets the Patient name.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Gets or sets the doctors treating the patient
        /// </summary>
        public List<Doctor> Doctors { get; set; }

        /// <summary>
        /// Patient room
        /// </summary>
        public string Room { get; set; }
    }
}