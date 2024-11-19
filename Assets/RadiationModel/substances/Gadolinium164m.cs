using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium164m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 163.93709d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1095799.99998, 0.00113)), new Gadolinium164() } },

        };
    }
}
    
    