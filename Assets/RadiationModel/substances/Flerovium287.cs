using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium287 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium287";
        public override double halfLife { get; } = 0.51d;
        public override double atomicWeight { get; } = 287.18672d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11187002.09), new Copernicium283() } },

        };
    }
}
    
    