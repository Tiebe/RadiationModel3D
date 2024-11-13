
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine129 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine129";
        public override double halfLife { get; } = 509329205280000.0d;
        public override double atomicWeight { get; } = 128.90498d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon129() } },

        };
    }
}
    
    