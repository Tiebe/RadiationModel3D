using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium170";
        public override double halfLife { get; } = 11111040.0d;
        public override double atomicWeight { get; } = 169.93581d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99869d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium170() }, { 1.0d, new BetaParticle(-1, 484314.49999) }, { 0.0248d, new GammaParticle(84254.74, 0.01472) }, { 0.0288747237744d, new GammaParticle(8502.0, 0.14583) }, { 0.009461826406548602d, new GammaParticle(51354.0, 0.02414) }, { 0.01667869981764252d, new GammaParticle(52389.0, 0.02367) }, { 0.005474792209206087d, new GammaParticle(59481.0, 0.02084) }, { 0.006903712975808876d, new GammaParticle(60151.0, 0.02061) }, { 0.0014289207666027886d, new GammaParticle(60961.0, 0.02034) } } },
            { 0.00131d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium170() }, { 3.5000000000000004e-05d, new GammaParticle(78700.0, 0.01575) }, { 0.00027650666044800004d, new GammaParticle(7933.0, 0.15629) }, { 0.00029075048271771654d, new GammaParticle(48222.0, 0.02571) }, { 0.0005160640445823865d, new GammaParticle(49128.0, 0.02524) }, { 0.0001677021624602357d, new GammaParticle(55779.0, 0.02223) }, { 0.00021130472469989698d, new GammaParticle(56399.0, 0.02198) }, { 4.360256223966128e-05d, new GammaParticle(57145.0, 0.0217) } } },

        };
    }
}
    