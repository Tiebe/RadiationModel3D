using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium179";
        public override double halfLife { get; } = 0.23d;
        public override double atomicWeight { get; } = 178.99112d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold175() }, { 1.0d, new AlphaParticle(7727002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    