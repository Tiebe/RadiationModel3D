using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon122 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon122";
        public override double halfLife { get; } = 72360.0d;
        public override double atomicWeight { get; } = 121.90837d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine122()), new(0.0002886d, new GammaParticle(53080.0, 0.02336)), new(0.0009048000000000001d, new GammaParticle(58015.0, 0.02137)), new(0.0040716d, new GammaParticle(61626.0, 0.02012)), new(0.0002652d, new GammaParticle(66630.0, 0.01861)), new(0.0018564d, new GammaParticle(72470.0, 0.01711)), new(0.0056316d, new GammaParticle(90596.0, 0.01369)), new(0.0004914d, new GammaParticle(103857.0, 0.01194)), new(0.0004134d, new GammaParticle(109897.0, 0.01128)), new(0.0010140000000000001d, new GammaParticle(116355.0, 0.01066)), new(0.026208d, new GammaParticle(148612.0, 0.00834)), new(0.0013338d, new GammaParticle(163052.0, 0.0076)), new(0.0014352000000000002d, new GammaParticle(174450.0, 0.00711)), new(0.0026052d, new GammaParticle(175582.0, 0.00706)), new(0.0055769999999999995d, new GammaParticle(186978.0, 0.00663)), new(0.0011622d, new GammaParticle(201430.0, 0.00616)), new(0.0011856d, new GammaParticle(253690.0, 0.00489)), new(0.000546d, new GammaParticle(259400.0, 0.00478)), new(0.004056000000000001d, new GammaParticle(288420.0, 0.0043)), new(0.00039d, new GammaParticle(326300.0, 0.0038)), new(0.078d, new GammaParticle(350065.0, 0.00354)), new(0.002418d, new GammaParticle(355110.0, 0.00349)), new(0.01872d, new GammaParticle(416633.0, 0.00298)), new(0.086d, new GammaParticle(4335.0, 0.28601)), new(0.2216d, new GammaParticle(28318.0, 0.04378)), new(0.41100000000000003d, new GammaParticle(28613.0, 0.04333)), new(0.1186d, new GammaParticle(32395.0, 0.03827)), new(0.14529999999999998d, new GammaParticle(32680.0, 0.03794)), new(0.0268d, new GammaParticle(33040.0, 0.03753)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    