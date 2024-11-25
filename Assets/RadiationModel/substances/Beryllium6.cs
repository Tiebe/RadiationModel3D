using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium6 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium6";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 6.01973d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Helium4() }, { 1.0d, new ProtonParticle() } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new AlphaParticle(1879960209.03) } } },

        };
    }
}
    