using System;
using System.Linq;
using EntityLevelup.DataAccess.EntityFramework;
using EntityLevelup.Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                using(var teamCtx = new TeamContext())
                {
                    Person me = new Person() {
                        Firstname = args.Length > 0 ? args[0] : "Chris",
                        Lastname = args.Length > 1 ? args[1] : "White",
                        Age = args.Length > 2 && !String.IsNullOrEmpty(args[2]) ? Convert.ToInt32(args[2]) : 32
                    };

                    var personInDb = teamCtx.Person.FirstOrDefault(T=> T.Firstname == me.Firstname && T.Lastname == me.Lastname && T.Age == me.Age);

                    var teamName = args.Length > 3 ? args[3] : "Team Ace";
                    Team ace = new Team() {
                        TeamName = teamName
                    };

                    var teamInDb = teamCtx.Team.FirstOrDefault(T=> T.TeamName == teamName);
                    me = personInDb ?? me;
                    ace = teamInDb ?? ace;

                    TeamAllocation teamAlloc = new TeamAllocation();
                    teamAlloc.Team = ace;
                    teamAlloc.Person = me;

                    var teamAllocInDb = teamCtx.TeamAllocation.FirstOrDefault(T=> T.Team == ace && T.Person == me);
                    
                    // Determin if we need to update or insert
                    if (personInDb != null) {
                        teamCtx.Attach(me);
                    }
                    else {
                        teamCtx.Add(me);
                    }

                    // Determin if we need to update or insert
                    if (teamInDb != null) {
                        teamCtx.Team.Attach(ace);
                    }
                    else {
                        teamCtx.Team.Add(ace);
                    }

                    // Determin if we need to update or insert
                    if (teamAllocInDb != null) {
                        teamCtx.TeamAllocation.Attach(teamAllocInDb);
                    }
                    else {
                        teamCtx.TeamAllocation.Add(teamAlloc);
                    }
                    
                    teamCtx.SaveChanges();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
