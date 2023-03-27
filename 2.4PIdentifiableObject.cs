using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SwinAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();
        public IdentifiableObject(string[] idents)
        {

            _identifiers.AddRange(idents);
        }

        public string FirstId
        {
            get
            {
                return _identifiers.First(); //using get to read, as _identifiers is private
            }
        }

        public bool AreYou(string id)
        {
            return _identifiers.Contains(id);
        }
        public void AddIdentifier(string identifier)
        {
            _identifiers.Add(identifier.ToLower());
        }
    }
}
