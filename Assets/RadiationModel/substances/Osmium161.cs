using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium161";
        public override double halfLife { get; } = 0.00064d;
        public override double atomicWeight { get; } = 160.98905d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8085047.4), new Tungsten157() } },

        };
    }
}
    
    