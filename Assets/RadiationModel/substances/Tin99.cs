
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin99 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin99";
        public override double halfLife { get; } = 0.024d;
        public override double atomicWeight { get; } = 98.94849d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium99() } },

        };
    }
}
    
    