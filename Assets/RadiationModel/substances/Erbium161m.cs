using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium161m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium161m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 160.93043d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium161() }, { 0.001116d, new GammaParticle(27900.0, 0.04444) }, { 0.0025109999999999998d, new GammaParticle(29260.0, 0.04237) }, { 0.2139d, new GammaParticle(45540.0, 0.02723) }, { 0.03627d, new GammaParticle(46860.0, 0.02646) }, { 0.06602999999999999d, new GammaParticle(59000.0, 0.02101) }, { 0.0004185d, new GammaParticle(73400.0, 0.01689) }, { 0.02604d, new GammaParticle(78070.0, 0.01588) }, { 0.004557d, new GammaParticle(79350.0, 0.01562) }, { 0.14880000000000002d, new GammaParticle(85000.0, 0.01459) }, { 0.14880000000000002d, new GammaParticle(100000.0, 0.0124) }, { 0.13019999999999998d, new GammaParticle(106000.0, 0.0117) }, { 0.019530000000000002d, new GammaParticle(107220.0, 0.01156) }, { 0.14880000000000002d, new GammaParticle(131000.0, 0.00946) }, { 0.023250000000000003d, new GammaParticle(144000.0, 0.00861) }, { 0.2232d, new GammaParticle(147000.0, 0.00843) }, { 0.004836d, new GammaParticle(157800.0, 0.00786) }, { 0.037200000000000004d, new GammaParticle(191000.0, 0.00649) }, { 0.1116d, new GammaParticle(207120.0, 0.00599) }, { 0.06509999999999999d, new GammaParticle(253000.0, 0.0049) }, { 0.47d, new GammaParticle(7933.0, 0.15629) }, { 0.5d, new GammaParticle(48222.0, 0.02571) }, { 0.88d, new GammaParticle(49128.0, 0.02524) }, { 0.28600000000000003d, new GammaParticle(55779.0, 0.02223) }, { 0.36d, new GammaParticle(56399.0, 0.02198) }, { 0.07400000000000001d, new GammaParticle(57145.0, 0.0217) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    