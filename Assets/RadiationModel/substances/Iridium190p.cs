using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium190p : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium190p";
        public override double halfLife { get; } = 11113.2d;
        public override double atomicWeight { get; } = 189.96095d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.914d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium190() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.00074d, new GammaParticle(38900.0, 0.03187) }, { 0.6416d, new GammaParticle(186700.0, 0.00664) }, { 0.8674d, new GammaParticle(361200.0, 0.00343) }, { 0.8937999999999999d, new GammaParticle(502500.0, 0.00247) }, { 0.9012d, new GammaParticle(616500.0, 0.00201) }, { 0.519712461521176d, new GammaParticle(10393.0, 0.1193) }, { 0.2516525049670191d, new GammaParticle(61486.0, 0.02016) }, { 0.4336593227072533d, new GammaParticle(63000.0, 0.01968) }, { 0.14509336351541235d, new GammaParticle(71496.0, 0.01734) }, { 0.1857195052997278d, new GammaParticle(72338.0, 0.01714) }, { 0.04062614178431546d, new GammaParticle(73364.0, 0.0169) } } },
            { 0.086d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium190() }, { 2.57e-06d, new GammaParticle(22450.0, 0.05523) }, { 0.027200000000000002d, new GammaParticle(36184.0, 0.03426) }, { 0.0109d, new GammaParticle(56128.0, 0.02209) }, { 0.0298d, new GammaParticle(135348.0, 0.00916) }, { 0.000185d, new GammaParticle(148700.0, 0.00834) }, { 0.0134d, new GammaParticle(205206.0, 0.00604) }, { 0.0584786237024d, new GammaParticle(10728.0, 0.11557) }, { 0.009149928411006907d, new GammaParticle(63287.0, 0.01959) }, { 0.015702640142452217d, new GammaParticle(64896.0, 0.01911) }, { 0.00526882201601004d, new GammaParticle(73637.0, 0.01684) }, { 0.00675989864654088d, new GammaParticle(74510.0, 0.01664) }, { 0.0014910766305308411d, new GammaParticle(75576.0, 0.01641) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    