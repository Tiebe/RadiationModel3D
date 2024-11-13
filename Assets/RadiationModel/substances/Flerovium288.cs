
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium288 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium288";
        public override double halfLife { get; } = 0.653d;
        public override double atomicWeight { get; } = 288.18778d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Copernicium284() } },

        };
    }
}
    
    