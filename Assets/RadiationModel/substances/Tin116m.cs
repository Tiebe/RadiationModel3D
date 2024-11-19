using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin116m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin116m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 115.90428d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00052, 2365980.0), new Tin116() } },

        };
    }
}
    
    