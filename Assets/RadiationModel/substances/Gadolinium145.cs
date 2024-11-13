
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium145";
        public override double halfLife { get; } = 1380.0d;
        public override double atomicWeight { get; } = 144.92171d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium145() } },

        };
    }
}
    
    