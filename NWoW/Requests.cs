using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWoW
{
    /// <summary>
    /// Class that exposes methods to retrieve various objects from Blizzard's web API.
    /// </summary>
    public static class Requests
    {
        #region "Constants"

        // TODO The URL prefix should be configurable by the user, so they can select their region, etc.
        private const string API_URL_PREFIX = "http://us.battle.net/";
        private const string API_URL_CHARACTERS = API_URL_PREFIX + "api/wow/character/";

        #endregion

        // TODO Should server be an enum or similar?
        /// <summary>
        /// Returns a <see cref="Character"/> object, provided that a Character
        /// exists on the provided server with the provided name.
        /// </summary>
        /// <param name="strServer">The server that the character belongs on.</param>
        /// <param name="strCharacterName">The name of the character.</param>
        /// <returns>TODO Fill this in.</returns>
        public static Character GetCharacter(string strServer, string strCharacterName)
        {
            Contract.Requires(!string.IsNullOrEmpty(strServer));
            Contract.Requires(!string.IsNullOrEmpty(strCharacterName));

            return Web.GetSerializedJSONObject<Character>(API_URL_CHARACTERS + strServer + "/" + strCharacterName);
        }
    }
}
