using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Dublins.Models
{
    public static class InitializeDb
    {
        public static void Initialize(DublinsContext context)
        {
            if (!context.Admins.Any())
            {
                context.Admins.AddRange(
                    new Admin
                    {
                        Name = "Admin",
                        Password = "1111"
                    });
                context.SaveChanges();
            }

            if (!context.Tickets.Any())
            {
                context.Tickets.AddRange(
                    new Ticket { Company="13Dublins", Name="Gamlet", Row=1, Place=1, Available=true, Date=DateTime.Now},
                    new Ticket { Company = "13Dublins", Name = "Gamlet", Row = 1, Place = 1, Available = true, Date = DateTime.Now },
                    new Ticket { Company = "13Dublins", Name = "Gamlet", Row = 1, Place = 2, Available = true, Date = DateTime.Now },
                    new Ticket { Company = "13Dublins", Name = "Gamlet", Row = 1, Place = 3, Available = true, Date = DateTime.Now },
                    new Ticket { Company = "13Dublins", Name = "Gamlet", Row = 1, Place = 4, Available = true, Date = DateTime.Now },
                    new Ticket { Company = "13Dublins", Name = "Gamlet", Row = 2, Place = 1, Available = true, Date = DateTime.Now },
                    new Ticket { Company = "13Dublins", Name = "Gamlet", Row = 2, Place = 2, Available = true, Date = DateTime.Now },
                    new Ticket { Company = "13Dublins", Name = "Gamlet", Row = 2, Place = 3, Available = true, Date = DateTime.Now },
                    new Ticket { Company = "13Dublins", Name = "Gamlet", Row = 2, Place = 4, Available = true, Date = DateTime.Now }
                    );
                context.SaveChanges();
            }

            if (!context.VideoCategories.Any())
            {
                context.VideoCategories.AddRange(
                    new VideoCategory { Name= "Main"},
                    new VideoCategory { Name= "13 Дублинов"},
                    new VideoCategory { Name= "Балет"},
                    new VideoCategory { Name = "Обзоры" },
                    new VideoCategory { Name = "Digital Scouts" },
                    new VideoCategory { Name = "Клипы" },
                    new VideoCategory { Name = "Скетчи" },
                    new VideoCategory { Name = "Медитации" },
                    new VideoCategory { Name = "Our scripts" }
                    );
                context.SaveChanges();
            }

            if (!context.Videos.Any())
            {
                context.Videos.AddRange(
                    new Video
                    {
                        Name = "Интервью с главой НСТДУ, генеральным директором-художественным руководителем Национальной оперетты Украини - Богданом Струтинским",
                        Date = new DateTime(2019,10,19),
                        Url = "https://www.youtube.com/embed/R-G962nPNwc",
                        VideoCategoryId = 1
                    },
                    new Video
                    {
                        Name = "Интервью с актрисой театра и кино, звездой сериала \"Крепостная\", победительницей шоу \"Танці з зірками\" - Ксенией Мишиной",
                        Date = new DateTime(2020, 03, 04),
                        Url = "https://www.youtube.com/embed/E9Mybqq9rjU",
                        VideoCategoryId = 1
                    },
                    new Video
                    {
                        Name = "Интервью с продюсером компании Кристи Фильмс - Юрием Минзяновым",
                        Date = new DateTime(2019, 04, 26),
                        Url = "https://www.youtube.com/embed/6mY6vjrwekg",
                        VideoCategoryId = 1
                    },
                    new Video
                    {
                        Name = "Інтерв'ю з головой Держкіно - Пилипом Іллєнко",
                        Date = new DateTime(2019, 10, 19),
                        Url = "https://www.youtube.com/embed/_hpSlAKc7xc",
                        VideoCategoryId = 1
                    },
                    new Video
                    {
                        Name = "Інтерв'ю з головою ПАТ НСТУ - Зурабом Аласанією",
                        Date = new DateTime(2019, 10, 19),
                        Url = "https://www.youtube.com/embed/4b5g1C_OsGY",
                        VideoCategoryId = 1
                    },
                    new Video
                    {
                        Name = "Інтерв'ю з виконавчою директоркою Українського культурного фонду - Юлією Федів",
                        Date = new DateTime(2019, 10, 19),
                        Url = "https://www.youtube.com/embed/nzoIsjy9nkQ",
                        VideoCategoryId = 1
                    }
                    );

                context.SaveChanges();
            }

        }
    }
}
