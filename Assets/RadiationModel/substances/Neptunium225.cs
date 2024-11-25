using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium225";
        public override double halfLife { get; } = 0.0036d;
        public override double atomicWeight { get; } = 225.03395d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium221() }, { 1.0d, new AlphaParticle(9847002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    