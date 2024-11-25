using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oganesson294 : RadioactiveSubstance
    {
        public override string name { get; } = "Oganesson294";
        public override double halfLife { get; } = 0.00058d;
        public override double atomicWeight { get; } = 294.21398d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Livermorium290() }, { 1.0d, new AlphaParticle(12887002.09) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    