using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium242";
        public override double halfLife { get; } = 14072832.0d;
        public override double atomicWeight { get; } = 242.05883d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium238() }, { 1.0d, new AlphaParticle(7237602.09) }, { 0.0003345d, new GammaParticle(44080.0, 0.02813) }, { 2.5300000000000002e-05d, new GammaParticle(101930.0, 0.01216) }, { 1.42e-05d, new GammaParticle(157420.0, 0.00788) }, { 1.2000000000000002e-07d, new GammaParticle(210200.0, 0.0059) }, { 7e-09d, new GammaParticle(336380.0, 0.00369) }, { 4.5e-10d, new GammaParticle(357620.0, 0.00347) }, { 6e-10d, new GammaParticle(459800.0, 0.0027) }, { 4.5e-08d, new GammaParticle(515250.0, 0.00241) }, { 1.4999999999999998e-06d, new GammaParticle(561020.0, 0.00221) }, { 1e-06d, new GammaParticle(605040.0, 0.00205) }, { 7.9e-08d, new GammaParticle(617220.0, 0.00201) }, { 1.6e-09d, new GammaParticle(617220.0, 0.00201) }, { 1.9e-09d, new GammaParticle(837010.0, 0.00148) }, { 6.700000000000001e-10d, new GammaParticle(882630.0, 0.0014) }, { 2.1999999999999998e-07d, new GammaParticle(897330.0, 0.00138) }, { 5.4e-09d, new GammaParticle(918700.0, 0.00135) }, { 1.8e-09d, new GammaParticle(938910.0, 0.00132) }, { 5.3e-09d, new GammaParticle(962800.0, 0.00129) }, { 1.9999999999999997e-09d, new GammaParticle(974500.0, 0.00127) }, { 2.6e-09d, new GammaParticle(979800.0, 0.00127) }, { 5e-09d, new GammaParticle(983000.0, 0.00126) }, { 2e-08d, new GammaParticle(984500.0, 0.00126) }, { 1.5999999999999998e-08d, new GammaParticle(1028500.0, 0.00121) }, { 4.999999999999999e-10d, new GammaParticle(1081700.0, 0.00115) }, { 1.7e-09d, new GammaParticle(1118300.0, 0.00111) }, { 5e-09d, new GammaParticle(1184600.0, 0.00105) }, { 2.8000000000000003e-09d, new GammaParticle(1220200.0, 0.00102) }, { 0.09874846752290713d, new GammaParticle(17604.0, 0.07043) }, { 8.044444253718445e-07d, new GammaParticle(99533.0, 0.01246) }, { 1.2734595937499518e-06d, new GammaParticle(103741.0, 0.01195) }, { 4.67412708087531e-07d, new GammaParticle(117130.0, 0.01059) }, { 6.296049177939042e-07d, new GammaParticle(118619.0, 0.01045) }, { 1.6219220970637324e-07d, new GammaParticle(120544.0, 0.01029) } } },
            { 6.2e-08d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1e-16d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    