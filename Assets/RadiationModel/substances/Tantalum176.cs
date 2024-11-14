using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum176 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum176";
        public override double halfLife { get; } = 29124.0d;
        public override double atomicWeight { get; } = 175.94485d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3206400.0), new Hafnium176() } },

        };
    }
}
    
    