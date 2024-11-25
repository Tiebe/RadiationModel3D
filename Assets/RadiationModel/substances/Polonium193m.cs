using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium193m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium193m";
        public override double halfLife { get; } = 0.245d;
        public override double atomicWeight { get; } = 192.99117d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead189() }, { 1.0d, new AlphaParticle(8216002.09) }, { 0.67d, new GammaParticle(637000.0, 0.00195) } } },

        };
    }
}
    