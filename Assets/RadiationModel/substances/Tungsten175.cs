
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten175 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten175";
        public override double halfLife { get; } = 2112.0d;
        public override double atomicWeight { get; } = 174.94672d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum175() } },

        };
    }
}
    
    