
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon199m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon199m";
        public override double halfLife { get; } = 0.31d;
        public override double atomicWeight { get; } = 198.99856d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Polonium195() } },

        };
    }
}
    
    