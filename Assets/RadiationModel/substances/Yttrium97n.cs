
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium97n : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium97n";
        public override double halfLife { get; } = 0.142d;
        public override double atomicWeight { get; } = 96.92207d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.948d, new List<RadioactiveSubstance> { new GammaParticle(), new Yttrium97() } },

            { 0.052000000000000005d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium97() } },

        };
    }
}
    
    