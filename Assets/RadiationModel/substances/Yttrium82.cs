
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium82";
        public override double halfLife { get; } = 8.3d;
        public override double atomicWeight { get; } = 81.92693d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium82() } },

        };
    }
}
    
    