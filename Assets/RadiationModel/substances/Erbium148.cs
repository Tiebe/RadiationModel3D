using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium148";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 147.94474d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium148() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.037200000000000004d, new GammaParticle(141600.0, 0.00876) }, { 0.062d, new GammaParticle(243800.0, 0.00509) }, { 0.0124d, new GammaParticle(268700.0, 0.00461) }, { 0.018600000000000002d, new GammaParticle(287500.0, 0.00431) }, { 0.06014d, new GammaParticle(315200.0, 0.00393) }, { 0.014879999999999999d, new GammaParticle(383000.0, 0.00324) }, { 0.05022d, new GammaParticle(609500.0, 0.00203) }, { 0.02046d, new GammaParticle(924900.0, 0.00134) }, { 0.01736d, new GammaParticle(1027300.0, 0.00121) }, { 0.07812000000000001d, new GammaParticle(1311800.0, 0.00095) }, { 0.00992d, new GammaParticle(2121800.0, 0.00058) } } },
            { 0.0015d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium147() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    