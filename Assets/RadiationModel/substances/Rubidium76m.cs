using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium76m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium76m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 75.93541d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00391), new Rubidium76() } },

        };
    }
}
    
    