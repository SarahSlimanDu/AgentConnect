
using Domain.Core.Abstractions;

namespace Domain.Entities
{
    public sealed class User : BaseEntity<Guid>, ISoftDeletableEntity
    {
        private User(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        private User()
        {
        }
        public  string  FirstName { get; private set; }

        /// <summary>
        /// Gets the user last name.
        /// </summary>
        public  string LastName { get; private set; }

        /// <summary>
        /// Gets the user full name.
        /// </summary>
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        /// Gets the user email.
        /// </summary>
        public string Email { get; private set; }

        public DateTime? DeletedOn { get; }

        public bool Deleted { get; }

        public static User Create(string firstName, string lastName, string email)
        {
            var user = new User(firstName, lastName, email);

            return user;
        }
    }
}
