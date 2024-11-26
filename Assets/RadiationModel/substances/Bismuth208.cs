using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth208 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth208";
        public override double halfLife { get; } = 11612948758649.855d;
        public override double atomicWeight { get; } = 207.97974d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium208()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.99785d, new GammaParticle(2614500.0, 0.00047)), new(0.28698432659535816d, new GammaParticle(12522.0, 0.09901)), new(0.1215355301896236d, new GammaParticle(72805.0, 0.01703)), new(0.20426139527667828d, new GammaParticle(74970.0, 0.01654)), new(0.06981362688563611d, new GammaParticle(84986.0, 0.01459)), new(0.09089734220509822d, new GammaParticle(86022.0, 0.01441)), new(0.021083715319462105d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    