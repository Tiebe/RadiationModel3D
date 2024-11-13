
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum93m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum93m";
        public override double halfLife { get; } = 24660.0d;
        public override double atomicWeight { get; } = 92.90941d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9987999999999999d, new List<RadioactiveSubstance> { new GammaParticle(), new Molybdenum93() } },

            { 0.0012d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium93() } },

        };
    }
}
    
    