﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Nether.Data.PlayerManagement;

namespace Nether.Web.Features.PlayerManagement
{
    public class PlayerGetResponseModel
    {
        public PlayerEntry Player { get; set; }

        public static PlayerGetResponseModel FromPlayer(Player player)
        {
            return new PlayerGetResponseModel
            {
                Player = new PlayerEntry { Gamertag = player.Gamertag, Country = player.Country, CustomTag = player.CustomTag, PlayerImage = player.PlayerImage }
            };
        }

        public class PlayerEntry
        {
            /// <summary>
            /// Player gamertag
            /// </summary>
            public string Gamertag { get; set; }

            /// <summary>
            /// Country code
            /// </summary>
            public string Country { get; set; }

            /// <summary>
            /// Custom tag
            /// </summary>
            public string CustomTag { get; set; }

            // TO DO The Player Image get/set needs to be implemented
            //note: it might be better to have a separate call streaming out the picture
            public byte[] PlayerImage { get; set; }
        }
    }
}
