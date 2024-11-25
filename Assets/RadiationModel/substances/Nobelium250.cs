using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium250";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 250.08757d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium246() }, { 1.0d, new AlphaParticle(9976002.09) } } },

        };
    }
}
    