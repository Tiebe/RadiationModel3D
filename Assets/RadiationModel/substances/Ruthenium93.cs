
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium93";
        public override double halfLife { get; } = 59.7d;
        public override double atomicWeight { get; } = 92.9171d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium93() } },

        };
    }
}
    
    