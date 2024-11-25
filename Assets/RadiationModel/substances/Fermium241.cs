using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium241";
        public override double halfLife { get; } = 0.00073d;
        public override double atomicWeight { get; } = 241.07431d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium237() }, { 1.0d, new AlphaParticle(9877002.09) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium241() } } },

        };
    }
}
    