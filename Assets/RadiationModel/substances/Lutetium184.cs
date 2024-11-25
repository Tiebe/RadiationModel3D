using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium184";
        public override double halfLife { get; } = 19.0d;
        public override double atomicWeight { get; } = 183.96103d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium184() }, { 1.0d, new BetaParticle(-1, 2600000.0) }, { 0.2695d, new GammaParticle(107100.0, 0.01158) }, { 0.1155d, new GammaParticle(242500.0, 0.00511) }, { 0.151720155587d, new GammaParticle(9114.0, 0.13604) }, { 0.06404713596833385d, new GammaParticle(54608.0, 0.0227) }, { 0.1120880923492017d, new GammaParticle(55786.0, 0.02222) }, { 0.036978666718598625d, new GammaParticle(63333.0, 0.01958) }, { 0.04685197073246445d, new GammaParticle(64057.0, 0.01936) }, { 0.009873304013865832d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    