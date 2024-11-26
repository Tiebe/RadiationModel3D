using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium249";
        public override double halfLife { get; } = 11076481017.08179d;
        public override double atomicWeight { get; } = 249.07485d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium245()), new(1.0d, new AlphaParticle(7315202.09)), new(0.000147d, new GammaParticle(37550.0, 0.03302)), new(0.00035999999999999997d, new GammaParticle(42870.0, 0.02892)), new(0.00038100000000000005d, new GammaParticle(54770.0, 0.02264)), new(0.00083d, new GammaParticle(54770.0, 0.02264)), new(7.7e-05d, new GammaParticle(65950.0, 0.0188)), new(7.7e-05d, new GammaParticle(65950.0, 0.0188)), new(0.00021999999999999998d, new GammaParticle(66800.0, 0.01856)), new(0.00308d, new GammaParticle(92510.0, 0.0134)), new(0.00042d, new GammaParticle(121600.0, 0.0102)), new(8.6e-05d, new GammaParticle(198100.0, 0.00626)), new(0.00053d, new GammaParticle(229200.0, 0.00541)), new(0.00213d, new GammaParticle(240900.0, 0.00515)), new(0.0255d, new GammaParticle(252820.0, 0.0049)), new(0.00032d, new GammaParticle(255470.0, 0.00485)), new(7.3e-05d, new GammaParticle(259000.0, 0.00479)), new(8.5e-05d, new GammaParticle(259150.0, 0.00478)), new(0.00707d, new GammaParticle(266630.0, 0.00465)), new(0.0013900000000000002d, new GammaParticle(295730.0, 0.00419)), new(2.8999999999999997e-05d, new GammaParticle(314000.0, 0.00395)), new(0.00065d, new GammaParticle(321250.0, 0.00386)), new(0.14800000000000002d, new GammaParticle(333370.0, 0.00372)), new(3.5000000000000004e-05d, new GammaParticle(347800.0, 0.00356)), new(0.00014000000000000001d, new GammaParticle(356000.0, 0.00348)), new(0.0001d, new GammaParticle(358800.0, 0.00346)), new(0.66d, new GammaParticle(388150.0, 0.00319)), new(0.000166d, new GammaParticle(390840.0, 0.00317)), new(4.7999999999999994e-05d, new GammaParticle(405930.0, 0.00305)), new(7.2999999999999996e-06d, new GammaParticle(421000.0, 0.00294)), new(1e-06d, new GammaParticle(483500.0, 0.00256)), new(1e-06d, new GammaParticle(483500.0, 0.00256)), new(1.7e-06d, new GammaParticle(580270.0, 0.00214)), new(5.3e-06d, new GammaParticle(588790.0, 0.00211)), new(8.6e-07d, new GammaParticle(596100.0, 0.00208)), new(7.1e-05d, new GammaParticle(643640.0, 0.00193)), new(1.58e-05d, new GammaParticle(647040.0, 0.00192)), new(2.2e-06d, new GammaParticle(650300.0, 0.00191)), new(2e-06d, new GammaParticle(652700.0, 0.0019)), new(1.2e-06d, new GammaParticle(663650.0, 0.00187)), new(1e-05d, new GammaParticle(670000.0, 0.00185)), new(7.000000000000001e-05d, new GammaParticle(680000.0, 0.00182)), new(9.9e-06d, new GammaParticle(701840.0, 0.00177)), new(2e-06d, new GammaParticle(708300.0, 0.00175)), new(3.1e-06d, new GammaParticle(717040.0, 0.00173)), new(0.000128d, new GammaParticle(718500.0, 0.00173)), new(5.8e-06d, new GammaParticle(718500.0, 0.00173)), new(6.6e-07d, new GammaParticle(731000.0, 0.0017)), new(0.0001d, new GammaParticle(740000.0, 0.00168)), new(0.0003d, new GammaParticle(760000.0, 0.00163)), new(0.0004d, new GammaParticle(770000.0, 0.00161)), new(1.3e-07d, new GammaParticle(798000.0, 0.00155)), new(7e-08d, new GammaParticle(841100.0, 0.00147)), new(1.2000000000000002e-07d, new GammaParticle(849900.0, 0.00146)), new(1.2000000000000002e-07d, new GammaParticle(849900.0, 0.00146)), new(2.3e-07d, new GammaParticle(890610.0, 0.00139)), new(7.3e-08d, new GammaParticle(906600.0, 0.00137)), new(2e-06d, new GammaParticle(916630.0, 0.00135)), new(1.1900000000000001e-05d, new GammaParticle(971380.0, 0.00128)), new(9e-06d, new GammaParticle(990000.0, 0.00125)), new(2e-08d, new GammaParticle(1054700.0, 0.00118)), new(3.3000000000000004e-08d, new GammaParticle(1102300.0, 0.00112)), new(0.137528822164012d, new GammaParticle(18579.0, 0.06673)), new(0.024769575937816216d, new GammaParticle(104606.0, 0.01185)), new(0.03878123679006766d, new GammaParticle(109286.0, 0.01134)), new(0.014524557050973462d, new GammaParticle(123280.0, 0.01006)), new(0.01963720113291612d, new GammaParticle(124855.0, 0.00993)), new(0.005112644081942658d, new GammaParticle(126917.0, 0.00977)) } },
            { 5e-09d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    