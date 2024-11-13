
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium117";
        public override double halfLife { get; } = 9010.8d;
        public override double atomicWeight { get; } = 116.90723d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium117() } },

        };
    }
}
    
    