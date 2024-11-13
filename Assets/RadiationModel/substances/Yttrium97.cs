
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium97";
        public override double halfLife { get; } = 3.75d;
        public override double atomicWeight { get; } = 96.91829d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium97() } },

        };
    }
}
    
    