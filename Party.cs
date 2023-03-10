using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_18_ListViewExample_Final_Breakdown
{
    public class Party : IEnumerable
    {
        string _partyName;
        List<Player> _players = new List<Player>();

        public Party(string partyName)
        {
            _partyName = partyName;
        }

        public string PartyName { get => _partyName; set => _partyName = value; }


        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            _players.Remove(player);
        }

        // Method Modifiers
        // virtual
        // new
        // override

        public override string ToString()
        {
            return $"Party: {_partyName}";
        }

        public IEnumerator GetEnumerator()
        {
            return new PartyEnumerator(ref _players);
        }

        private class PartyEnumerator : IEnumerator
        {
            int index = -1;
            List<Player> players;

            public PartyEnumerator(ref List<Player> partyList)
            {
                players = partyList;
            }

            public object Current => players[index];

            public bool MoveNext()
            {
                // INcrementing by 1;
                index++;

                if(index >= players.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                index = -1;
            }
        } // end internal Class
    } // end class

} // end namespace
