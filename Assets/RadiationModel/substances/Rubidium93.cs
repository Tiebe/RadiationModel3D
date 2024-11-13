
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium93";
        public override double halfLife { get; } = 5.84d;
        public override double atomicWeight { get; } = 92.92204d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium93() } },

        };
    }
}
    
    