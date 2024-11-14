using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium141m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 140.91423d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00197), new Promethium141() } },

        };
    }
}
    
    