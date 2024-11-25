using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium44";
        public override double halfLife { get; } = 14551.2d;
        public override double atomicWeight { get; } = 43.9594d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium44() }, { 1.0d, new BetaParticle(1, -1017250.0) }, { 0.9988670000000001d, new GammaParticle(1157022.0, 0.00107) }, { 0.00909d, new GammaParticle(1499449.0, 0.00083) }, { 3.7000000000000005e-05d, new GammaParticle(2144330.0, 0.00058) }, { 1.1000000000000001e-05d, new GammaParticle(2150840.0, 0.00058) }, { 0.001119d, new GammaParticle(2656480.0, 0.00047) }, { 1.4e-05d, new GammaParticle(3301350.0, 0.00038) }, { 1.8855600000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.0001956333992510649d, new GammaParticle(358.0, 3.46325) }, { 0.0025918228479536397d, new GammaParticle(3688.0, 0.33618) }, { 0.005121167452980913d, new GammaParticle(3692.0, 0.33582) }, { 0.000999603543001118d, new GammaParticle(4013.0, 0.30896) }, { 0.000999603543001118d, new GammaParticle(4013.0, 0.30896) } } },

        };
    }
}
    