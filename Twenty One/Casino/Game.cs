using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game
    {
        // next two lines instantiate the player list 
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
       public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play();// States that any class inheriting this class must implement this method

        public virtual void ListPlayers() //adding keyword virtual makes it a virtual method, gets inherited, but can be overridden
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
