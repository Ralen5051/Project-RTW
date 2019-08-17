using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace gameGlobals
{
    [System.Serializable]
    public struct dialogueData
    {
        public string ID;
        public string Name;
        [TextArea(3,10)]
        public string Dialogue;
        public string[] responseID;
    }
   

}
