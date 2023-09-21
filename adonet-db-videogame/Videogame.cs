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
        public DateTime Release_date { get; private set; }
        public long Software_house_id { get; private set; }

        public Videogame(long id, string name, string overview, DateTime release_date, long software_house_id)
        {
            this.Id = id;
            this.Name = name;
            this.Overview = overview;
            this.Release_date = release_date;
            this.Software_house_id = software_house_id;
        }

        public override string ToString()
        {
            return $"id: {Id} - nome: {Name} - overview: {Overview} - release date: {Release_date} - software house id: {Software_house_id}";
        }
    }
}
