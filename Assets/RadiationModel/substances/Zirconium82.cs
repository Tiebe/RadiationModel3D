using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium82";
        public override double halfLife { get; } = 32.0d;
        public override double atomicWeight { get; } = 81.93171d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4449900.0), new Yttrium82() } },

        };
    }
}
    
    