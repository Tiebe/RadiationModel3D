using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum191m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum191m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 190.96179d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01228), new Platinum191() } },

        };
    }
}
    
    