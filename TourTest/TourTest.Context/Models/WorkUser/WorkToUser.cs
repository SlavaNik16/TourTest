using TourTest.Context.Models.Enums;

namespace TourTest.Context.Models.WorkUser
{
    public static class WorkToUser
    {
        private static User user;

        public static User User
        {
            get
            {
                if (user == null)
                {
                    user = new User()
                    {
                        Id = -1,
                        Surname = "Неавторизованный гость",
                        Name = string.Empty,
                        Patronymic = string.Empty,
                        Role = RoleType.Guest
                    };
                }
                return user;
            }
            set
            {
                user = value;
            }

        }

        public static bool CompareTo(RoleType roleType) => roleType == user.Role;
    }
}
