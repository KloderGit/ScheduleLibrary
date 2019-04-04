using SheduleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit u2 = null;

            using (ApplicationContext db = new ApplicationContext())
            {
                u2 = db.Units.Where(fld => fld.Type == "Вебинар").FirstOrDefault();
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                var u1 = new Unit
                {
                    Comment = "For Cert",
                    Link = Guid.NewGuid(),
                    Price = 11000,
                    Segment = "Cert part",
                    Title = "Attestation с утра",
                    Type = "Семинар",
                    VisitOption = "Открытое"
                };

                u1.Composition = new List<Composition> {
                    new Composition { Order =1, During = TimeSpan.FromHours(8),
                        Topic = new Topic{
                            Comment = "from U1",
                            Title = "Tetst"
                        },
                        Certification = new Certification{
                            Title = "Экзамен",
                            Grades = new List<CertificationGrade>{
                                new CertificationGrade{
                                    Grade = new Grade { Title = "Восьмибальная" }
                                }
                            }
                        }
                    }
                };

                db.Units.Add(u1);


                var sd = new Block() {
                    Comment = "fffffffff",
                    Finish = DateTime.Now,
                    Master = u1,
                    Price = 9090,
                    Start = new DateTime(2019, 4, 3),
                    Title = "Мего блок событий"
                };

                db.Blocks.Add(sd);

                db.SaveChanges();
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                u2.Segment = "FFFFFFFFFFFFFFFFFFFFFFFOOOOOO";

                db.Update(u2);
                //db.SaveChanges();

                //InsertOrUpdate(db, u2);
            }

            
        }

        public static void InsertOrUpdate(ApplicationContext context, Unit blog)
        {
            var existingBlog = context.Units.Find(blog.Guid);
            if (existingBlog == null)
            {
                context.Add(blog);
            }
            else
            {
                context.Entry(existingBlog).CurrentValues.SetValues(blog);
            }

            context.SaveChanges();
        }
    }
}
