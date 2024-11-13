
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium86";
        public override double halfLife { get; } = 0.055d;
        public override double atomicWeight { get; } = 85.94464d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum86() } },

        };
    }
}
    
    