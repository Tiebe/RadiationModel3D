using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium263";
        public override double halfLife { get; } = 27.0d;
        public override double atomicWeight { get; } = 263.11499d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.57d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.43d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lawrencium259() }, { 1.0d, new AlphaParticle(9857002.09) } } },

        };
    }
}
    