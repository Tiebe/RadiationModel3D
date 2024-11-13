
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium97m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium97m";
        public override double halfLife { get; } = 7871040.0d;
        public override double atomicWeight { get; } = 96.90647d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9606d, new List<RadioactiveSubstance> { new GammaParticle(), new Technetium97() } },

            { 0.0394d, new List<RadioactiveSubstance> { new Molybdenum97() } },

        };
    }
}
    
    