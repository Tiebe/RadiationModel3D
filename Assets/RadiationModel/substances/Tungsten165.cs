using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten165 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten165";
        public override double halfLife { get; } = 5.1d;
        public override double atomicWeight { get; } = 164.95828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6987000.0), new Tantalum165() } },

        };
    }
}
    
    