using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium49";
        public override double halfLife { get; } = 3430.8d;
        public override double atomicWeight { get; } = 48.95001d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium49() }, { 1.0d, new BetaParticle(-1, 1000805.0) }, { 0.0001d, new GammaParticle(1622600.0, 0.00076) }, { 0.0005d, new GammaParticle(1761900.0, 0.0007) } } },

        };
    }
}
    