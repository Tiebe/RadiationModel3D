using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium289m : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium289m";
        public override double halfLife { get; } = 1.1d;
        public override double atomicWeight { get; } = 289.19133d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11725047.4), new Copernicium285() } },

        };
    }
}
    
    