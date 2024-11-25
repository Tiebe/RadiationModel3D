using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen19 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen19";
        public override double halfLife { get; } = 26.88d;
        public override double atomicWeight { get; } = 19.00358d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine19() }, { 1.0d, new BetaParticle(-1, 2410172.55) }, { 0.0254d, new GammaParticle(109894.0, 0.01128) }, { 0.9590000000000001d, new GammaParticle(197142.0, 0.00629) }, { 5e-06d, new GammaParticle(1149000.0, 0.00108) }, { 0.00017d, new GammaParticle(1236000.0, 0.001) }, { 0.504d, new GammaParticle(1356843.0, 0.00091) }, { 0.0264d, new GammaParticle(1444085.0, 0.00086) }, { 0.0139d, new GammaParticle(1553970.0, 0.0008) }, { 1.81e-05d, new GammaParticle(2353980.0, 0.00053) }, { 0.000189d, new GammaParticle(2582517.0, 0.00048) }, { 1.1000000000000001e-05d, new GammaParticle(3710640.0, 0.00033) }, { 1.33e-05d, new GammaParticle(3797870.0, 0.00033) }, { 3.84e-05d, new GammaParticle(3907740.0, 0.00032) }, { 0.0007920000000000001d, new GammaParticle(4180063.0, 0.0003) } } },

        };
    }
}
    