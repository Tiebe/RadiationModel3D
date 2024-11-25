using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese70 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese70";
        public override double halfLife { get; } = 0.0199d;
        public override double atomicWeight { get; } = 69.97805d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron70() }, { 1.0d, new BetaParticle(-1, 8220000.0) }, { 0.155d, new GammaParticle(483000.0, 0.00257) }, { 0.185d, new GammaParticle(855000.0, 0.00145) } } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron70() }, { 1.0d, new BetaParticle(-1, 8220000.0) }, { 0.155d, new GammaParticle(483000.0, 0.00257) }, { 0.185d, new GammaParticle(855000.0, 0.00145) } } },

        };
    }
}
    