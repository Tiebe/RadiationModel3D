using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium61m : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium61m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 60.98255d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01033, 120000.0), new Titanium61() } },

        };
    }
}
    
    