using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel76m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel76m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 75.95731d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel76() }, { 0.76d, new GammaParticle(142600.0, 0.00869) }, { 0.99d, new GammaParticle(355600.0, 0.00349) }, { 0.96d, new GammaParticle(930100.0, 0.00133) }, { 1.0d, new GammaParticle(990300.0, 0.00125) }, { 0.001250804352d, new GammaParticle(874.0, 1.41858) }, { 0.012480831119916687d, new GammaParticle(7461.0, 0.16618) }, { 0.02435759391084443d, new GammaParticle(7478.0, 0.1658) }, { 0.005076334969238882d, new GammaParticle(8296.0, 0.14945) }, { 0.005076334969238882d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    