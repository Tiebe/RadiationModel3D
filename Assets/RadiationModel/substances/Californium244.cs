using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium244";
        public override double halfLife { get; } = 1164.0d;
        public override double atomicWeight { get; } = 244.066d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium240() }, { 1.0d, new AlphaParticle(8350902.09) } } },

        };
    }
}
    