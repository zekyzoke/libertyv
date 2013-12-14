﻿/*
 
    LibertyV - Viewer/Editor for RAGE Package File version 7
    Copyright (C) 2013  koolk <koolkdev at gmail.com>
   
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
  
    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
   
    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibertyV.Rage.Resources.Types.Game
{
    class D3DBaseTexture : ClassTypeInfo
    {
        public static D3DBaseTexture TypeInfo;
        public static void Initialize() { TypeInfo = new D3DBaseTexture(); }
        protected D3DBaseTexture()
            : base("D3DBaseTexture")
        {
            // TODO: Bitfields and enums. Fuck me.
            AddMember("Unknown1", "Dword");
            AddMember("Unknown2", "Dword");
            AddMember("Unknown3", "Dword");
            AddMember("Unknown4", "Dword");
            AddMember("Unknown5", "Dword");
            AddMember("Unknown6", "Dword");
            AddMember("Unknown7", "Dword");
            AddMember("Unknown8", "Dword");
            AddMember("Unknown9", "Dword");
            AddMember("Unknown10", "Dword");
            AddMember("Unknown11", "Dword");
            AddMember("Unknown12", "Dword");
            AddMember("Unknown13", "Dword");
        }
    }
}
