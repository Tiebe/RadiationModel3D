using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium238";
        public override double halfLife { get; } = 2767542407.97172d;
        public override double atomicWeight { get; } = 238.04956d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium234()), new(1.0d, new AlphaParticle(6615102.09)), new(0.000392d, new GammaParticle(43498.0, 0.0285)), new(1e-10d, new GammaParticle(62700.0, 0.01977)), new(7.29e-05d, new GammaParticle(99853.0, 0.01242)), new(2.0000000000000002e-11d, new GammaParticle(140150.0, 0.00885)), new(9.29e-06d, new GammaParticle(152720.0, 0.00812)), new(6.399999999999999e-12d, new GammaParticle(192910.0, 0.00643)), new(3.9e-08d, new GammaParticle(200970.0, 0.00617)), new(8.000000000000001e-11d, new GammaParticle(203120.0, 0.0061)), new(1e-10d, new GammaParticle(235900.0, 0.00526)), new(8.4e-10d, new GammaParticle(258300.0, 0.0048)), new(4.8e-10d, new GammaParticle(299200.0, 0.00414)), new(5.3e-10d, new GammaParticle(705900.0, 0.00176)), new(4.1e-09d, new GammaParticle(708420.0, 0.00175)), new(5.2e-08d, new GammaParticle(742810.0, 0.00167)), new(2.1999999999999998e-07d, new GammaParticle(766390.0, 0.00162)), new(2.4e-10d, new GammaParticle(783400.0, 0.00158)), new(3.2200000000000004e-08d, new GammaParticle(786300.0, 0.00158)), new(1.2e-09d, new GammaParticle(804400.0, 0.00154)), new(6e-10d, new GammaParticle(805600.0, 0.00154)), new(7.9e-09d, new GammaParticle(808250.0, 0.00153)), new(1.24e-08d, new GammaParticle(851700.0, 0.00146)), new(1.6e-09d, new GammaParticle(880500.0, 0.00141)), new(7.6e-09d, new GammaParticle(883230.0, 0.0014)), new(6.400000000000001e-10d, new GammaParticle(904300.0, 0.00137)), new(5.8e-09d, new GammaParticle(926720.0, 0.00134)), new(4.7e-09d, new GammaParticle(941900.0, 0.00132)), new(8.6e-10d, new GammaParticle(946000.0, 0.00131)), new(9.8e-09d, new GammaParticle(1001030.0, 0.00124)), new(2.2000000000000003e-09d, new GammaParticle(1041800.0, 0.00119)), new(9.1e-10d, new GammaParticle(1085400.0, 0.00114)), new(0.102d, new GammaParticle(16678.0, 0.07434)), new(5.9e-07d, new GammaParticle(94657.0, 0.0131)), new(9.399999999999999e-07d, new GammaParticle(98439.0, 0.0126)), new(3.4e-07d, new GammaParticle(111238.0, 0.01115)), new(4.6e-07d, new GammaParticle(112645.0, 0.01101)), new(1.16e-07d, new GammaParticle(114446.0, 0.01083)) } },
            { 1.9e-09d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    