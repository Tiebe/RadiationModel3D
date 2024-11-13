
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium102";
        public override double halfLife { get; } = 0.36d;
        public override double atomicWeight { get; } = 101.93433d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium102() } },

        };
    }
}
    
    