
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium117";
        public override double halfLife { get; } = 2592.0d;
        public override double atomicWeight { get; } = 116.90452d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin117() } },

        };
    }
}
    
    