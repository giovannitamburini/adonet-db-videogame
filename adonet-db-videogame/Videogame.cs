using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_db_videogame
{
    public class Videogame
    {

        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Overview { get; private set; }
        public DateOnly Release_date { get; private set; }
        public DateTime Created_at { get; private set; }
        public DateTime Updated_at { get; private set; }
        public long Software_house_id { get; private set; }

        public Videogame(long id, string name, string overview, DateOnly release_date, DateTime created_at, DateTime updated_at, long software_house_id)
        {
            this.Id = id;
            this.Name = name;
            this.Overview = overview;
            this.Release_date = release_date;
            this.Created_at = created_at;
            this.Updated_at = updated_at;
            this.Software_house_id = software_house_id;
        }
    }
}
