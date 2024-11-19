using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum177q : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum177q";
        public override double halfLife { get; } = 0.00013d;
        public override double atomicWeight { get; } = 176.94948d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00027, 4656000.0), new Tantalum177() } },

        };
    }
}
    
    