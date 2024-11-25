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

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten157() }, { 1.0d, new AlphaParticle(8087002.09) } } },

        };
    }
}
    