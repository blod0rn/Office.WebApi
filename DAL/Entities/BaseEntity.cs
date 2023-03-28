using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Office.Web.DAL.Entities
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

    }
}