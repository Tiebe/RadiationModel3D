using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium249";
        public override double halfLife { get; } = 0.0381d;
        public override double atomicWeight { get; } = 249.08781d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium245() }, { 1.0d, new AlphaParticle(10197002.09) } } },
            { 0.0023d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    