
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium89";
        public override double halfLife { get; } = 282096.0d;
        public override double atomicWeight { get; } = 88.90888d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium89() } },

        };
    }
}
    
    