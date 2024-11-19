using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium86m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium86m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 85.94627d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00082, 1520000.0), new Technetium86() } },

        };
    }
}
    
    