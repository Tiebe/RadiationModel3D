
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

            { 0.774d, new List<RadioactiveSubstance> { new GammaParticle(), new Technetium93() } },

            { 0.226d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum93() } },

        };
    }
}
    
    