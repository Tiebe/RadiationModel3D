using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium46 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium46";
        public override double halfLife { get; } = 7239456.0d;
        public override double atomicWeight { get; } = 45.95517d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium46() }, { 1.0d, new BetaParticle(-1, 1183335.0) }, { 0.99984d, new GammaParticle(889277.0, 0.00139) }, { 0.9998699999999999d, new GammaParticle(1120545.0, 0.00111) }, { 1.3e-07d, new GammaParticle(2010000.0, 0.00062) }, { 1.22954322259998e-06d, new GammaParticle(477.0, 2.59925) }, { 1.5545485847293096e-05d, new GammaParticle(4505.0, 0.27521) }, { 3.06254646321771e-05d, new GammaParticle(4511.0, 0.27485) }, { 6.117650938529801e-06d, new GammaParticle(4947.0, 0.25063) }, { 6.117650938529801e-06d, new GammaParticle(4947.0, 0.25063) } } },

        };
    }
}
    