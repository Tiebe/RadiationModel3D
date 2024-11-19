using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium171m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium171m";
        public override double halfLife { get; } = 1.47d;
        public override double atomicWeight { get; } = 170.97182d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.54d, new List<RadioactiveSubstance> { new AlphaParticle(7177002.09), new Rhenium167() } },

        };
    }
}
    
    