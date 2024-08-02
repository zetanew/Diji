using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diji.Models
{
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Ensure auto-increment is enabled
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        // Navigation property for one-to-many relationship
        public ICollection<Job> Jobs { get; set; } = new List<Job>();
    }

    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Ensure auto-increment is enabled
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public int Categorized { get; set; }
        public int ScannedDocs { get; set; }
        public int ScannedPlans { get; set; }
        public int ParcelIndexCreated { get; set; }
        public int ScannedDocsIndexed { get; set; }
        public int Smarted { get; set; }
        public int RulerIndexed { get; set; }
        public int Archived { get; set; }
        public int Physical { get; set; }

        [ForeignKey("State")]
        public int StateId { get; set; }

        // Navigation property for the related State
        public required State State { get; set; } // required because every job must have a state
    }
}