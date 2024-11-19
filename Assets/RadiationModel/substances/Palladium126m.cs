using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium126m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium126m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 125.94657d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00061, 2020000.0), new Palladium126() } },

        };
    }
}
    
    