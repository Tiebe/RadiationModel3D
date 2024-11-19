using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin118n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin118n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 117.90494d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0004, 3108100.0), new Tin118() } },

        };
    }
}
    
    