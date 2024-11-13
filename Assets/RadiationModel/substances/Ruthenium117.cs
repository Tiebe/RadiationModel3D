
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium117";
        public override double halfLife { get; } = 0.151d;
        public override double atomicWeight { get; } = 116.93613d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium117() } },

        };
    }
}
    
    