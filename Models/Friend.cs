using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FriendApp.Models
{
    public class Friend
    {
        public long Id { get; set; }

        [Required]
        public int FriendId { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3,ErrorMessage ="Friend Name Shouldn't be empty")]
        public string FriendName { get; set; }
        [MaxLength(25, ErrorMessage = "Friend's place must not be greater than 25 characters")]
        public string Place { get; set; }

    }
}