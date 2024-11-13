
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum189 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum189";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 188.96569d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tungsten189() } },

        };
    }
}
    
    