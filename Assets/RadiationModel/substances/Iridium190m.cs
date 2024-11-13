
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium190m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium190m";
        public override double halfLife { get; } = 4032.0d;
        public override double atomicWeight { get; } = 189.96057d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Iridium190() } },

        };
    }
}
    
    