using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHCC.classes
{
    /// <summary>
    /// Character Skill
    /// </summary>
    public class Skill
    {
        /// <summary>
        /// Skill Name
        /// </summary>
        public string name;

        /// <summary>
        /// Skill description
        /// </summary>
        public string description;

        /// <summary>
        /// Value for getting skill back
        /// </summary>
        public int reload;

        /// <summary>
        /// cost of skill
        /// </summary>
        public int cost;


        /// <summary>
        /// if skill can be purchased
        /// </summary>
        public bool purchaseable = false;
    }
}
