using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium169";
        public override double halfLife { get; } = 0.353d;
        public override double atomicWeight { get; } = 168.97628d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.45d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium165() }, { 1.0d, new AlphaParticle(7163002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    