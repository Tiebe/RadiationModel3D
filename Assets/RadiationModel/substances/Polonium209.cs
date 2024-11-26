using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium209";
        public override double halfLife { get; } = 3913058820.84941d;
        public override double atomicWeight { get; } = 208.98243d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99546d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead205()), new(1.0d, new AlphaParticle(6001202.09)), new(0.00254d, new GammaParticle(260500.0, 0.00476)), new(0.0008500000000000001d, new GammaParticle(262800.0, 0.00472)), new(0.00063923444139d, new GammaParticle(12522.0, 0.09901)), new(0.0004817865154006977d, new GammaParticle(72805.0, 0.01703)), new(0.0008097252359675591d, new GammaParticle(74970.0, 0.01654)), new(0.00027675251815034073d, new GammaParticle(84986.0, 0.01459)), new(0.00036033177863174364d, new GammaParticle(86022.0, 0.01441)), new(8.357926048140291e-05d, new GammaParticle(87301.0, 0.0142)) } },
            { 0.00454d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead209()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00445d, new GammaParticle(896280.0, 0.00138)), new(0.001427627193604d, new GammaParticle(12904.0, 0.09608)), new(0.0009268022682629718d, new GammaParticle(74815.0, 0.01657)), new(0.0015506144692370282d, new GammaParticle(77108.0, 0.01608)), new(0.0005311460080398162d, new GammaParticle(87388.0, 0.01419)), new(0.0006936766865d, new GammaParticle(88458.0, 0.01402)), new(0.00016253067846018376d, new GammaParticle(89784.0, 0.01381)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    