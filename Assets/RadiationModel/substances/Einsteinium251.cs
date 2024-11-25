using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium251";
        public override double halfLife { get; } = 118800.0d;
        public override double atomicWeight { get; } = 251.07999d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium251() }, { 8.955e-05d, new GammaParticle(71500.0, 0.01734) }, { 4.975e-05d, new GammaParticle(81200.0, 0.01527) }, { 0.0084d, new GammaParticle(129800.0, 0.00955) }, { 0.0053d, new GammaParticle(152800.0, 0.00811) }, { 0.0005600000000000001d, new GammaParticle(163800.0, 0.00757) }, { 0.0129d, new GammaParticle(177600.0, 0.00698) }, { 0.49818002191719996d, new GammaParticle(19579.0, 0.06333) }, { 0.19249166225379163d, new GammaParticle(109867.0, 0.01128) }, { 0.29788248569141385d, new GammaParticle(115063.0, 0.01078) }, { 0.11355271567462723d, new GammaParticle(129671.0, 0.00956) }, { 0.1539774824547945d, new GammaParticle(131332.0, 0.00944) }, { 0.040424766780167286d, new GammaParticle(133529.0, 0.00929) } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium247() }, { 1.0d, new AlphaParticle(7619002.09) } } },

        };
    }
}
    