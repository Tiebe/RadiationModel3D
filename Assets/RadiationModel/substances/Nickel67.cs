using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel67 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel67";
        public override double halfLife { get; } = 21.0d;
        public override double atomicWeight { get; } = 66.93157d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper67() }, { 1.0d, new BetaParticle(-1, 1788450.0) }, { 0.004699999999999999d, new GammaParticle(821600.0, 0.00151) }, { 0.004935d, new GammaParticle(1115300.0, 0.00111) }, { 0.006439d, new GammaParticle(1937100.0, 0.00064) }, { 0.002162d, new GammaParticle(2272000.0, 0.00055) }, { 0.0014099999999999998d, new GammaParticle(2623000.0, 0.00047) }, { 0.002303d, new GammaParticle(2680000.0, 0.00046) }, { 0.0026790000000000004d, new GammaParticle(2841000.0, 0.00044) } } },

        };
    }
}
    