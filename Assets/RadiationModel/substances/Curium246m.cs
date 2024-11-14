using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium246m : RadioactiveSubstance
    {
        public override string name { get; } = "Curium246m";
        public override double halfLife { get; } = 1.12d;
        public override double atomicWeight { get; } = 246.06849d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00105), new Curium246() } },

        };
    }
}
    
    