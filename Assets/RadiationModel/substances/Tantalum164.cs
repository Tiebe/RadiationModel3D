using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum164 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum164";
        public override double halfLife { get; } = 14.2d;
        public override double atomicWeight { get; } = 163.95353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8535000.0), new Hafnium164() } },

        };
    }
}
    
    