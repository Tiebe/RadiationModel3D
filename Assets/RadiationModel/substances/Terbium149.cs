
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium149";
        public override double halfLife { get; } = 14824.8d;
        public override double atomicWeight { get; } = 148.92325d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.833d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium149() } },

            { 0.16699999999999998d, new List<RadioactiveSubstance> { new AlphaParticle(), new Europium145() } },

        };
    }
}
    
    