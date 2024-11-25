using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Helium6 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium6";
        public override double halfLife { get; } = 0.8067d;
        public override double atomicWeight { get; } = 6.01889d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lithium6() }, { 1.0d, new BetaParticle(-1, 1752609.8) } } },

        };
    }
}
    