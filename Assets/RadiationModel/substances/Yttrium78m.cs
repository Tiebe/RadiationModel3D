
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium78m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium78m";
        public override double halfLife { get; } = 5.8d;
        public override double atomicWeight { get; } = 77.94399d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium78() } },

        };
    }
}
    
    