using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWoW
{
    /// <summary>
    /// Represents a playable character in World of Warcraft.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// This <see cref="Character"/>'s name.
        /// </summary>
        public string Name { get; set; }
        // TODO Add docs for all of these properties.
        public DateTime LastModifiedDate { get; set; }
        public string Realm { get; set; }
        public string BattleGroup { get; set; }
        public int Class { get; set; }
        public int Race { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public int AchievementPoints { get; set; }
        public string Thumbnail { get; set; }
        public string CalcClass { get; set; }
        public int TotalHonorableKills { get; set; }
    }
}
