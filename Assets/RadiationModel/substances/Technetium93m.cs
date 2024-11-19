using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium93m";
        public override double halfLife { get; } = 2610.0d;
        public override double atomicWeight { get; } = 92.91067d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.774d, new List<RadioactiveSubstance> { new GammaParticle((391800.0, 0.00316)), new Technetium93() } },
            { 0.226d, new List<RadioactiveSubstance> { new BetaParticle(1, 3592780.0), new Molybdenum93() } },

        };
    }
}
    
    