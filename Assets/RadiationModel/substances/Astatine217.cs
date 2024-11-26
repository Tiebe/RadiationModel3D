using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine217 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine217";
        public override double halfLife { get; } = 0.0326d;
        public override double atomicWeight { get; } = 217.00472d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99993d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth213()), new(1.0d, new AlphaParticle(8224002.09)), new(2e-06d, new GammaParticle(165800.0, 0.00748)), new(0.000287d, new GammaParticle(257890.0, 0.00481)), new(6.2e-05d, new GammaParticle(335260.0, 0.0037)), new(2e-06d, new GammaParticle(501000.0, 0.00247)), new(0.000115d, new GammaParticle(593130.0, 0.00209)), new(4.9e-05d, new GammaParticle(758900.0, 0.00163)), new(5.128877985000001e-05d, new GammaParticle(12904.0, 0.09608)), new(3.638727184976842e-05d, new GammaParticle(74815.0, 0.01657)), new(6.087882190023159e-05d, new GammaParticle(77108.0, 0.01608)), new(2.0853373851454824e-05d, new GammaParticle(87388.0, 0.01419)), new(2.723450625e-05d, new GammaParticle(88458.0, 0.01402)), new(6.381132398545176e-06d, new GammaParticle(89784.0, 0.01381)) } },
            { 7.000000000000001e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon217()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    