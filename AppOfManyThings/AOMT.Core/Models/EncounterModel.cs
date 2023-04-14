using AOMT.Core.Enums;

namespace AOMT.Core.Models
{
    public class EncounterModel 
        // properties are
        // party level, party number, threat level value,
        // threat level, # of monsters,
        // boolean for all monsters same level,
        // selected monsters (which will be a list of Actors)
    {
        public int PartyLevel { get; set; }
        public int PartyNumber { get; set; }
        public ThreatLevel ThreatLevel { get; set; }
        public double ThreatBudget 
        { 
            get
            {
                return PartyNumber * (int)ThreatLevel;
            }

        } 
        public int NumberOfMonsters { get; set; }
        public bool AllMonstersSameLevel { get; set; }
        public List<ActorModel> SelectedMonsters { get; set; }  = new List<ActorModel>();
    }
}