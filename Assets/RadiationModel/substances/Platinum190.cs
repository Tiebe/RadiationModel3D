using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum190 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum190";
        public override double halfLife { get; } = 1.5683792209372223e+19d;
        public override double atomicWeight { get; } = 189.95995d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium186() }, { 1.0d, new AlphaParticle(4290502.09) } } },

        };
    }
}
    