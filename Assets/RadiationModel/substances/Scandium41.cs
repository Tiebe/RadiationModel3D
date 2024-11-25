using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium41 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium41";
        public override double halfLife { get; } = 0.5963d;
        public override double atomicWeight { get; } = 40.96925d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium41() }, { 1.0d, new BetaParticle(1, 3458594.5) }, { 0.00023d, new GammaParticle(2574800.0, 0.00048) }, { 0.000139d, new GammaParticle(2959300.0, 0.00042) }, { 1.998116d, new GammaParticle(511000.0, 0.00243) }, { 3.196876585388615e-06d, new GammaParticle(358.0, 3.46325) }, { 4.228292573664149e-05d, new GammaParticle(3688.0, 0.33618) }, { 8.354658315874627e-05d, new GammaParticle(3692.0, 0.33582) }, { 1.6307504352842257e-05d, new GammaParticle(4013.0, 0.30896) }, { 1.6307504352842257e-05d, new GammaParticle(4013.0, 0.30896) } } },

        };
    }
}
    