using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium162";
        public override double halfLife { get; } = 0.00206d;
        public override double atomicWeight { get; } = 161.98443d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten158() }, { 1.0d, new AlphaParticle(7787002.09) } } },

        };
    }
}
    