using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin124q : RadioactiveSubstance
    {
        public override string name { get; } = "Tin124q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 123.91017d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00027, 4552400.0), new Tin124() } },

        };
    }
}
    
    