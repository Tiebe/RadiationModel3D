using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium40 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium40";
        public override double halfLife { get; } = 0.0524d;
        public override double atomicWeight { get; } = 39.99035d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium40() }, { 1.0d, new BetaParticle(1, 12928201.0) }, { 2.0816d, new GammaParticle(511000.0, 0.00243) }, { 2.10310793288e-06d, new GammaParticle(422.0, 2.93801) }, { 2.698013427985955e-05d, new GammaParticle(4086.0, 0.30344) }, { 5.322575316602791e-05d, new GammaParticle(4091.0, 0.30307) }, { 1.0579156554112554e-05d, new GammaParticle(4474.0, 0.27712) }, { 1.0579156554112554e-05d, new GammaParticle(4474.0, 0.27712) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium39() }, { 1.0d, new ProtonParticle() }, { 0.09d, new GammaParticle(2467300.0, 0.0005) } } },

        };
    }
}
    