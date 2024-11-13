
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium97";
        public override double halfLife { get; } = 0.432d;
        public override double atomicWeight { get; } = 96.92638d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium97() } },

        };
    }
}
    
    