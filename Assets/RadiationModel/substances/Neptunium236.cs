
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium236";
        public override double halfLife { get; } = 4828213656000.0d;
        public override double atomicWeight { get; } = 236.04657d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.863d, new List<RadioactiveSubstance> { new Uranium236() } },

            { 0.135d, new List<RadioactiveSubstance> { new BetaParticle(), new Plutonium236() } },

            { 0.0016d, new List<RadioactiveSubstance> { new AlphaParticle(), new Protactinium232() } },

        };
    }
}
    
    