using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium49";
        public override double halfLife { get; } = 1.26d;
        public override double atomicWeight { get; } = 48.96821d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium49() }, { 1.0d, new BetaParticle(-1, 5844250.0) }, { 0.004d, new GammaParticle(2023000.0, 0.00061) }, { 0.0154d, new GammaParticle(2249000.0, 0.00055) }, { 0.002d, new GammaParticle(3585000.0, 0.00035) }, { 0.002d, new GammaParticle(4072000.0, 0.0003) }, { 0.0176d, new GammaParticle(4272000.0, 0.00029) }, { 1.6305074401199999e-09d, new GammaParticle(358.0, 3.46325) }, { 2.1735114464398137e-08d, new GammaParticle(3688.0, 0.33618) }, { 4.294628426081434e-08d, new GammaParticle(3692.0, 0.33582) }, { 8.382709274787536e-09d, new GammaParticle(4013.0, 0.30896) }, { 8.382709274787536e-09d, new GammaParticle(4013.0, 0.30896) } } },
            { 0.86d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium49() }, { 1.0d, new BetaParticle(-1, 5844250.0) }, { 0.004d, new GammaParticle(2023000.0, 0.00061) }, { 0.0154d, new GammaParticle(2249000.0, 0.00055) }, { 0.002d, new GammaParticle(3585000.0, 0.00035) }, { 0.002d, new GammaParticle(4072000.0, 0.0003) }, { 0.0176d, new GammaParticle(4272000.0, 0.00029) }, { 1.6305074401199999e-09d, new GammaParticle(358.0, 3.46325) }, { 2.1735114464398137e-08d, new GammaParticle(3688.0, 0.33618) }, { 4.294628426081434e-08d, new GammaParticle(3692.0, 0.33582) }, { 8.382709274787536e-09d, new GammaParticle(4013.0, 0.30896) }, { 8.382709274787536e-09d, new GammaParticle(4013.0, 0.30896) } } },

        };
    }
}
    