
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium107";
        public override double halfLife { get; } = 0.0335d;
        public override double atomicWeight { get; } = 106.95494d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium107() } },

        };
    }
}
    
    